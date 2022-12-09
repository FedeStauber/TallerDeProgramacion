using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    interface ICopyRepository : IRepository<Copy>
    {
        Copy GetAvailableCopy(double pISBN);

        IEnumerable<Copy> GetBookCopies(long pISBN);
    }
}
