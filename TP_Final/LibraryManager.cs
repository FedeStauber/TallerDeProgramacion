using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;
using TP_Final.IO;
using TP_Final.API.OpenLibrary;
using TP_Final.API;
using TP_Final.Exceptions;
using System.Configuration;
using System.Windows;
using System.Runtime.CompilerServices;
using Serilog;

namespace TP_Final
{
    public static class LibraryManager
    {

        /// <summary> Notifica a todos los usuarios que tienen préstamos que están a dos días de expirar </summary>
        public static void Notificate()
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                Notificator notifier = new Notificator();
                List<Loan> loans = unit.LoanRepository.GetNextToExpire();                
                foreach (var loan in loans)
                {
                    notifier.Notify(loan);
                    loan.Notificated = true;                    
                }
                unit.Complete();
                Log.Information("Se notificó correctamente a los usuarios que poseen préstamos atrasados.");
            }  
        }

        /// <summary> Guarda un usuario en el repositorio </summary>
        /// <param name="pUserDTO"> Nuevo usuario </param>
        public static void AddUser(UserDTO pUserDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vUser = UsefulMapper.Mapper.Map<UserDTO, User>(pUserDTO);
                vUser.Active = true;
                unit.UserRepository.Add(vUser);  
                unit.Complete();
                Log.Information("Se agregó el usuario correctamente.");
            }           
        }

        /// <summary> Busca el usuario por el DNI y le cambia los valores</summary>
        /// <param int="pDni"> DNI del usuario a modificar </param>
        /// <param UserDTO="pUserDTO"> Nuevo usuario </param>
        public static void ModifyUser(int pDni, UserDTO pUserDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByDNI(pDni);
                vUser.Active = pUserDTO.Active;
                vUser.Admin = pUserDTO.Admin;
                vUser.DNI = pUserDTO.DNI;
                vUser.Email = pUserDTO.Email;
                vUser.Avatar = pUserDTO.Avatar;
                vUser.LastName = pUserDTO.LastName;
                vUser.Name = pUserDTO.Name;
                vUser.Score = pUserDTO.Score;
                if (pUserDTO.Password != "")
                {
                    vUser.Password = pUserDTO.Password;
                }                               
                unit.Complete();
                Log.Information("Se modificó el usuario con éxito");
            }
        }

        /// <summary> Busca el libro por ISBN y le agrega la cantidad de copias ingresadas </summary>
        /// <param long="pISBN"> ISBN del libro que se quiere agregar las copias </param>
        /// <param int="amount"> Cantidad de copias que se quiere agregar de ese libro </param>
        public static void AddCopy(long pISBN, int amount)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {                             
                Book vBook = unit.BookRepository.SearchByISBN(pISBN);
                if (vBook != null)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        Copy copy = new Copy() { Book = vBook, Condition = Copy.ConditionEnum.Available };
                        unit.CopyRepository.Add(copy);
                    }
                }
                else
                {
                    throw new Exception("El ISBN ingresado no es correcto");
                }
                unit.Complete();
                Log.Information("Se agregó una copia con éxito.");
            }
        }

        /// <summary> Cambia la condición de la copia </summary>
        /// <param CopyDTO="pCopyDTO"> Copia a modificar </param>
        public static void ModifyCopy(CopyDTO pCopyDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                Copy.ConditionEnum conditionEnum = Copy.ConditionEnum.Available;
                if (pCopyDTO.Condition == CopyDTO.ConditionEnum.Prestado)
                {
                    conditionEnum = Copy.ConditionEnum.Borrowed;
                }
                else if (pCopyDTO.Condition == CopyDTO.ConditionEnum.Roto)
                {
                    conditionEnum = Copy.ConditionEnum.Broken;
                }
                else if (pCopyDTO.Condition == CopyDTO.ConditionEnum.Suspendido)
                {
                    conditionEnum = Copy.ConditionEnum.Unavailable;
                }               
                Copy copy = unit.CopyRepository.Get(pCopyDTO.Id);
                copy.ChangeCondition(conditionEnum);
                unit.Complete();
                Log.Information("Se modificó una copia con éxito.");
            }
        }

        /// <summary> Busca el usuario por el mail, busca una copia disponible, cambia la condicion de la copia y la ultima fecha de
        /// modificacion, crea el préstamo y lo agrega al repositorio, si no encuentra una copia disponible lo notifica al usuario</summary>
        /// <param LoanDTO="pLoanDTO"> Préstamo a crear  </param>
        public static void CreateLoan(LoanDTO pLoanDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByEmail(pLoanDTO.UserEmail);                               
                Copy vCopy = unit.CopyRepository.GetAvailableCopy(pLoanDTO.BookISBN);
                if (vCopy == null)
                {
                    throw new NoAvailableCopyException("No existen copias disponibles para el libro seleccionado.");
                }
                vCopy.Condition = Copy.ConditionEnum.Borrowed;
                vCopy.LastModify = DateTime.Now;               
                Loan vLoan = new Loan() { Copy = vCopy, StartDate = DateTime.Now, Notificated = false, User = vUser, EndDate = DateTime.Now.AddDays(Convert.ToDouble(ConfigurationManager.AppSettings.Get("DIAS_PRESTAMO")))};
                vCopy.LoanEndDate=vLoan.EndDate;
                unit.LoanRepository.Add(vLoan);
                unit.Complete();
                Log.Information("Se creó un préstamo con éxito.");
            }
        }
        /// <summary> Busca el préstamo por el id ingresado y cambia la condicion por la ingresada, si no encuentra el préstamo notifica al 
        /// usuario </summary>
        /// <param int="pLoanId"> Id del préstamo </param>
        /// <param int="pCondition"> Entero que representa la posición en la lista de condiciones </param>
        public static void LoanReturnRegister(int pLoanId, int pCondition)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {           
                Loan vLoan = unit.LoanRepository.Get(pLoanId);
                if(vLoan == null)
                {
                    throw new Exception("No se pudo encontrar el prestamo solicitado.");
                }
                if (pCondition == 0)
                {
                    vLoan.ReturnRegister(Copy.ConditionEnum.Available);
                }
                else
                {
                    vLoan.ReturnRegister(Copy.ConditionEnum.Broken);
                }                
                unit.Complete();
                Log.Information("Se creó una devolución de un préstamo con éxito.");
            }
        }
        /// <summary> Busca el mail ingresado en el repositorio de usuario, compara las contraseñas de ese usuario con la ingresada y
        /// verifica que el usuario esté activo, si la contraseña no coincide o el usuario no está activo, se notifica al usuario</summary>
        /// <param string="pUserEmail"> Email ingresada</param>
        /// <param string="pPassword"> Contraseña ingresada </param>
        public static LoginDTO LogIn(string pUserEmail, string pPassword)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {                              
                var vUser =  unit.UserRepository.SearchByEmail(pUserEmail);                
                if (vUser.PasswordMatch(pPassword) && vUser.Active)
                {                   
                    var vUserDTO = UsefulMapper.Mapper.Map<User,UserDTO>(vUser);
                    vUserDTO.Avatar = vUser.Avatar;                      
                    LoginDTO loginDTO = new LoginDTO() { IsValid = true, User = vUserDTO };
                    Log.Information("Se inició sesión con éxito.");
                    return loginDTO;
                    
                }
                else if (!vUser.Active)
                {
                    throw new Exception("El usuario seleccionado está inhabilitado contacte al administrador");
                }
                else
                {
                    throw new Exception("Usuario y contraseña no coinciden");
                }
            }
        }
        /// <summary>
        /// Realiza una consulta al repositorio para obtener todos los libros registrados 
        /// y los mapea con sus correspondiente dto para enviar a la capa de presentación
        /// </summary>
        /// <returns>Una lista de objetos BookDTO correspondiente a TODOS los libros del repositorio</returns>
        public static Task<List<BookDTO>> BookCatalogue()
        {
            return new Task<List<BookDTO>>(() =>
            {
                using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
                {
                    List<Book> vBooks = unit.BookRepository.GetAll().ToList();                   
                    var vBooksDTO = UsefulMapper.Mapper.Map<List<Book>, List<BookDTO>>(vBooks);
                    Log.Information("Se devuelve el catálogo actual de la biblioteca con éxito.");
                    return vBooksDTO;
                    
                }
            });
        }

        /// <summary> Busca si el libro ya existe en el catálogo, si existe lo notifica al usuario de esto, sino mapea y agrega
        /// el libro al repositorio</summary>
        /// <param BookDTO="pBookDTO"> Libro a agregar </param>
        public static void AddBook(BookDTO pBookDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                if (unit.BookRepository.SearchByISBN(pBookDTO.ISBN) == null)
                {
                    var vBook = UsefulMapper.Mapper.Map<BookDTO, Book>(pBookDTO);                 
                    unit.BookRepository.Add(vBook);
                    unit.Complete();
                    Log.Information("Se agregó un nuevo libro con éxito.");
                }
                else
                {
                    throw new Exception("El ISBN que desea ingresar ya está siendo utilizado");
                }
            }
        }


        /// <summary> Realiza una consulta al repositorio para obtener todos los prestamos asociados a el usuario indicado </summary>
        /// <param UserDTO="pUserDTO"> Usuario a utilizar </param>
        /// <returns>Una lista de objetos LoanDTO que contiene todos los prestamos del usuario</returns>
        public static List<LoanDTO> UserLoansHistory(UserDTO pUserDTO)
        {
            User vUser = UsefulMapper.Mapper.Map<UserDTO, User>(pUserDTO);
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {               
                var vLoans = unit.LoanRepository.GetUserLoansHistory(vUser.Id);
                List<LoanDTO> vLoanDTOs = new List<LoanDTO>();
                foreach (var vLoan in vLoans)
                {
                  LoanDTO vLoanDTO = UsefulMapper.Mapper.Map<Loan,LoanDTO>(vLoan);                 
                  vLoanDTO.BookISBN = vLoan.Copy.Book.ISBN;
                  vLoanDTO.BookTitle = vLoan.Copy.Book.Title;
                  vLoanDTOs.Add(vLoanDTO);
                }
                Log.Information("Se devuelve el historial de préstamos con éxito.");
                return vLoanDTOs;                
            }
        }

        /// <summary>
        /// Realiza una consulta al repositorio para obtener los prestamos activos asociados a el usuario indicado
        /// </summary>
        /// <param name="pUserId">Id del usuario para el que se desea realizar la consulta</param>
        /// <returns>Una numero entero que representa la cantidad de prestamos activos del usuario</returns>
        public static int CountUserActiveLoans(int pUserId)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                Log.Information("Se devolvió la cantidad de préstamos activos de un usuario con éxito.");
                return unit.LoanRepository.GetUserActiveLoans(pUserId);              
            }
        }

        /// <summary> Realiza una búsqueda de un Usuario en el repositorio mediante el DNI </summary>
        /// <param name="pDni">Dni ingresado</param>
        public static UserDTO SearchUserByDNI(long pDni)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByDNI(pDni);                
                UserDTO vUserDTO = UsefulMapper.Mapper.Map<User, UserDTO>(vUser);
                Log.Information("Búsqueda por DNI realizada con éxito.");
                return vUserDTO;
               
            }
        }

        /// <summary> Mapea una lista de todos los usuarios </summary>
        /// <returns> Una lista de objetos UserDTO que contiene todos los usuarios</returns>
        public static List<UserDTO> UsersList()
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vListUserDTO = UsefulMapper.Mapper.Map<List<User>, List<UserDTO>>(unit.UserRepository.GetAll().ToList());
                Log.Information("Se devolvió la lista de usuarios con éxito.");
                return vListUserDTO;
               
            }
        }
        /// <summary> Crea una lista de copias DTO </summary>
        /// <param name="pBookISBN">ISBN del libro</param>
        /// <returns> Una lista de objetos CopyDTO que contiene todas las copias de un libro</returns>
        public static List<CopyDTO> BookCopyList(long pBookISBN)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {             
                var vListCopy = unit.CopyRepository.GetBookCopies(pBookISBN).ToList();               
                var vListCopyDTO = UsefulMapper.Mapper.Map<List<Copy>, List<CopyDTO>>(vListCopy);
                Log.Information("Se devolvió la lista de copias de un libro con éxito");
                return vListCopyDTO;                
            }
        }

        /// <summary> Busca el libro en el repositorio por ISBN y cambia los campos de este </summary>
        /// <param name="pISBN">ISBN del libro</param>
        /// <param name="pBookDTO">Libro DTO</param>

        public static void ModifyBook(long pISBN, BookDTO pBookDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                Book vBook = unit.BookRepository.SearchByISBN(pISBN);
                if (vBook != null)
                {
                    vBook.Author = pBookDTO.Author;
                    vBook.Description = pBookDTO.Description;   
                    vBook.Pages = pBookDTO.Pages;
                    vBook.ISBN = pBookDTO.ISBN; 
                    vBook.Cover = pBookDTO.Cover;
                    vBook.Gender = pBookDTO.Gender;
                    vBook.Language = pBookDTO.Language;
                    vBook.Title = pBookDTO.Title;
                    unit.Complete();
                    Log.Information("Se modificó un libro con éxito.");
                }
            }
        }

        /// <summary> Crea una lista de préstamos DTO </summary>
        /// <returns> Una lista de objetos LoanDTO que contiene todas los préstamos activos</returns>

        public static List<LoanDTO> ActiveLoans()
        {      
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vLoans = unit.LoanRepository.GetActiveLoans();
                List<LoanDTO> vLoanDTOs = new List<LoanDTO>();
                foreach (var vLoan in vLoans)
                {
                    LoanDTO vLoanDTO = UsefulMapper.Mapper.Map<Loan, LoanDTO>(vLoan);
                    vLoanDTO.BookISBN = vLoan.Copy.Book.ISBN;
                    vLoanDTO.BookTitle = vLoan.Copy.Book.Title;
                    vLoanDTOs.Add(vLoanDTO);
                }
                Log.Information("Se devolvió la lista de préstamos activos con éxito");
                return vLoanDTOs;               
            }            
        }

        /// <summary> Extiende la cantidad de días de un préstamo, buscando a este por su ID </summary>
        /// <param name="pLoan">Préstamo</param>
        /// <param name="pDaysToExtend">Cantidad de días a extender</param>
        public static void LoanExtend(LoanDTO pLoan, int pDaysToExtend)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vLoan = unit.LoanRepository.Get(pLoan.Id);
                vLoan.Extend(pDaysToExtend);
                unit.Complete();
                Log.Information("Se extendió un préstamo con éxito");
            }
        }
    }
}
