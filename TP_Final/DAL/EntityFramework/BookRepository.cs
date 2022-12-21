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
    class BookRepository : Repository<Book,LibraryManagerDbContext>,IBookRepository
    {
        private readonly DbContext iDbContext;
        public BookRepository(LibraryManagerDbContext pDbContext) : base (pDbContext)
        {
            this.iDbContext = pDbContext;
        }

        public Book SearchByISBN(double pISBN)
        {
            Book vBook = this.iDbContext.Set<Book>().FirstOrDefault(book => book.ISBN == pISBN);           
            return vBook;
        }
    }
}
