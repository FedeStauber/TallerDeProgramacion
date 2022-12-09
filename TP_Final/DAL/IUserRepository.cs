using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    interface IUserRepository : IRepository<User>
    {
        User SearchByEmail(string pEmail);
        User SearchByDNI(long pDni);
        bool EmailExists(string pEmail);
        bool DNIExists(long pDNI);

     
    }
}
