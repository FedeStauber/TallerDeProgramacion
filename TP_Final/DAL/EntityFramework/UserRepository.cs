using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;
using Microsoft.EntityFrameworkCore;
using TP_Final.Exceptions;
using TP_Final.UI;

namespace TP_Final.DAL.EntityFramework
{
    class UserRepository : Repository<User, LibraryManagerDbContext>, IUserRepository
    {
        private readonly DbContext iDbContext;
        public UserRepository(LibraryManagerDbContext pDbContext) : base(pDbContext) 
        {
            this.iDbContext = pDbContext;
        }

        public User SearchByDNI(long pDNI)
        {
            User vUser = iDbContext.Set<User>().FirstOrDefault(user => user.DNI == pDNI);
            if (vUser == null)
            {
                throw new UserNotFoundException("No se encontro ningun usuario para el DNI ingresado");
            }        
            return vUser;

        }                

        public User SearchByEmail(string pEmail)
        {
            User vUser =  iDbContext.Set<User>().FirstOrDefault(user => user.Email.ToLower() == pEmail.ToLower());
            if (vUser == null)
            {
                throw new UserNotFoundException("No se encontro ningun usuario para el Email ingresado");
            }            
            return vUser;
        }

     
        public new void Add(User vUser)
        {
            if (vUser == null)
            {
                throw new ArgumentNullException(nameof(vUser));
            }
            if (iDbContext.Set<User>().FirstOrDefault(user => user.DNI == vUser.DNI) != null)
            {
                throw new Exception("El DNI ingresado ya está en uso");
            }
            else if (iDbContext.Set<User>().FirstOrDefault(user => user.Email == vUser.Email) != null)
            {
                throw new Exception("El email ingresado ya está en uso");
            }
            iDbContext.Set<User>().Add(vUser);
        }

   
    }
    
    
}
