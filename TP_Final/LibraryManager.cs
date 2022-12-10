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

namespace TP_Final
{
    public static class LibraryManager
    {
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
            }  
        }
        public static void AddUser(UserDTO form)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {                
                var vUser = UsefulMapper.Mapper.Map<UserDTO, User>(form);
                vUser.Active = true;
                vUser.Password = Encrypter.Encrypt(form.Password);
                if (unit.UserRepository.EmailExists(vUser.Email))
                {
                    throw new Exception("El Correo que ingreso ya está siendo utilizado");
                }
                if (unit.UserRepository.DNIExists(vUser.DNI))
                {
                    throw new Exception("El DNI ingresado ya está siendo utilizado");
                }
                unit.UserRepository.Add(vUser);  
                unit.Complete();  
            }           
        }


        public static void ModifyUser(int pDni, UserDTO form)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByDNI(pDni);
                vUser.Active = form.Active;
                vUser.Admin = form.Admin;
                vUser.DNI = form.DNI;
                vUser.Email = form.Email;
                vUser.Avatar = form.Avatar;
                vUser.LastName = form.LastName;
                vUser.Name = form.Name;
                vUser.Score = form.Score;
                vUser.Password = Encrypter.Encrypt(form.Password);                
                unit.Complete();
            }
        }

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
            }
        }

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
            }
        }

        public static void CreateLoan(LoanDTO form)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByEmail(form.UserEmail);                               
                Copy vCopy = unit.CopyRepository.GetAvailableCopy(form.BookISBN);
                if (vCopy == null)
                {
                    throw new NoAvailableCopyException("No existen copias disponibles para el libro seleccionado");
                }
                vCopy.Condition = Copy.ConditionEnum.Borrowed;
                vCopy.LastModify = DateTime.Now;
                Loan vLoan = new Loan() { Copy = vCopy, StartDate = DateTime.Now, Notificated = false, User = vUser, EndDate = DateTime.Now.AddDays(Convert.ToDouble(ConfigurationManager.AppSettings.Get("DIAS_PRESTAMO")))};               
                unit.LoanRepository.Add(vLoan);
                unit.Complete();
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static void LoanReturnRegister(int pLoanId, int pCondition)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {           
                Loan vLoan = unit.LoanRepository.Get(pLoanId);
                if(vLoan == null)
                {
                    throw new Exception("No se pudo encontrar el prestamo solicitado");
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
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static LoginDTO LogIn(string pUserEmail, string pPassword)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {               
                string vEncrpyptedPassword = Encrypter.Encrypt(pPassword);
                var vUser =  unit.UserRepository.SearchByEmail(pUserEmail);                  
                if (vUser.Password == vEncrpyptedPassword && vUser.Active)
                {                   
                    var vUserDTO = UsefulMapper.Mapper.Map<User,UserDTO>(vUser);
                    vUserDTO.Avatar = vUser.Avatar;        
                    LoginDTO loginDTO = new LoginDTO() { IsValid = true, User = vUserDTO };
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
                    return vBooksDTO;
                }
            });
        }
        // Este procedimiento está correcto, falta documentar V
        public static void AddBook(BookDTO pBookDTO)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                if (unit.BookRepository.SearchByISBN(pBookDTO.ISBN) == null)
                {
                    var vBook = UsefulMapper.Mapper.Map<BookDTO, Book>(pBookDTO);                 
                    unit.BookRepository.Add(vBook);
                    unit.Complete();
                }
                else
                {
                    throw new Exception("El ISBN que desea ingresar ya está siendo utilizado");
                }
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static List<LoanDTO> UserLoansHistory(UserDTO pUserDTO)
        {
            User vUser = UsefulMapper.Mapper.Map<UserDTO, User>(pUserDTO);
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {               
                var vLoans = unit.LoanRepository.GetUserLoansHistory(vUser.Id).ToList();
                List<LoanDTO> vLoanDTOs = new List<LoanDTO>();
                foreach (var vLoan in vLoans)
                {
                  LoanDTO vLoanDTO = UsefulMapper.Mapper.Map<Loan,LoanDTO>(vLoan);                 
                  vLoanDTO.BookISBN = vLoan.Copy.Book.ISBN;
                  vLoanDTO.BookTitle = vLoan.Copy.Book.Title;
                  vLoanDTOs.Add(vLoanDTO);
                }
                return vLoanDTOs;
            }
        }
        /// <summary>
        /// Realiza una consulta al repositorio para obtener los prestamos activos asociados a el usuario indicado
        /// </summary>
        /// <param name="pUserId">Id del usuario para el que se desea realizar la consulta</param>
        /// <returns>Una lista de objetos LoanDTO que contiene los prestamos activos del usuario</returns>
        public static List<LoanDTO> UserActiveLoans(int pUserId)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vLoanDTOs = UsefulMapper.Mapper.Map<List<Loan>, List<LoanDTO>>(unit.LoanRepository.GetUserActiveLoans(pUserId).ToList());
                return vLoanDTOs;
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static UserDTO SearchUserByDNI(long pDni)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                User vUser = unit.UserRepository.SearchByDNI(pDni);                
                UserDTO vUserDTO = UsefulMapper.Mapper.Map<User, UserDTO>(vUser);                
                return vUserDTO;
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static List<UserDTO> UsersList()
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {
                var vListUserDTO = UsefulMapper.Mapper.Map<List<User>, List<UserDTO>>(unit.UserRepository.GetAll().ToList());   
                return vListUserDTO;
            }
        }
        // Este procedimiento está correcto, falta documentar V
        public static List<CopyDTO> BookCopyList(long pBookISBN)
        {
            using (UnitOfWork unit = new UnitOfWork(new LibraryManagerDbContext()))
            {             
                var vListCopy = unit.CopyRepository.GetBookCopies(pBookISBN).ToList();               
                var vListCopyDTO = UsefulMapper.Mapper.Map<List<Copy>, List<CopyDTO>>(vListCopy);
                foreach (var copyDTO in vListCopyDTO)
                {
                    if (copyDTO.Condition == CopyDTO.ConditionEnum.Prestado)
                    {
                       copyDTO.EndDate = unit.LoanRepository.GetByCopyID(copyDTO.Id).EndDate;                       
                    }                   
                }
                return vListCopyDTO;
            }
        }
        // Este procedimiento está correcto, falta documentar V
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
                }
            }
        }

        // Este procedimiento está correcto, falta documentar V
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
                return vLoanDTOs;
            }            
        }

    }
}
