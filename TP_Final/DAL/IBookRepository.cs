using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    interface IBookRepository: IRepository<Book>
    {
        Book SearchByISBN(double pISBN);
    }
}
