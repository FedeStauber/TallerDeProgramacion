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
    class CopyRepository : Repository<Copy, LibraryManagerDbContext>, ICopyRepository
    {
        private readonly DbContext iDbContext;
        public CopyRepository(LibraryManagerDbContext pDbContext) : base(pDbContext) 
        {
            this.iDbContext = pDbContext;
        }

        public Copy GetAvailableCopy(double pISBN)
        {
            Copy vCopy = this.iDbContext.Set<Copy>().Include(copy => copy.Book).FirstOrDefault(copy => copy.Book.ISBN == pISBN && copy.Condition == Copy.ConditionEnum.Avaible);           
            return vCopy;
        }

        public IEnumerable<Copy> GetBookCopies(long pISBN)
        {
            return this.iDbContext.Set<Copy>().Include(copy => copy.Book).Where(copy => copy.Book.ISBN == pISBN);
        }
    }   
    
}
