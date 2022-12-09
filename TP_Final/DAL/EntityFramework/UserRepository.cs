using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;
using Microsoft.EntityFrameworkCore;
using TP_Final.Exceptions;

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
            User vUser =  iDbContext.Set<User>().FirstOrDefault(user => user.Email == pEmail);
            if (vUser == null)
            {
                throw new UserNotFoundException("No se encontro ningun usuario para el Email ingresado");
            }
            return vUser;
        }

        public bool EmailExists(string pEmail)
        {
            User vUser = iDbContext.Set<User>().FirstOrDefault(user => user.Email == pEmail);
            if (vUser == null)
            {
                return false;
            }
            return true;
        }
        public bool DNIExists(long pDNI)
        {
            User vUser = iDbContext.Set<User>().FirstOrDefault(user => user.DNI == pDNI);
            if (vUser == null)
            {
                return false;
            }
            return true;
        }

   
    }
    
    
}
