using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;
using Microsoft.EntityFrameworkCore;
using TP_Final.IO;

namespace TP_Final.DAL.EntityFramework
{
    class LoanRepository : Repository<Loan, LibraryManagerDbContext>, ILoanRepository
    {
        private readonly DbContext iDbContext;
        public LoanRepository(LibraryManagerDbContext pDbContext) : base(pDbContext) 
        {
            this.iDbContext = pDbContext;
        }
        public List<Loan> GetNextToExpire()
        {
            List<Loan> nextToExpire = new List<Loan>();
            foreach (var loan in this.GetAll())
            {
                if ((loan.EndDate <= (DateTime.Now.Add(new TimeSpan(2, 0, 0, 0)))) && (loan.Notificated == false))
                {
                    nextToExpire.Add(loan);
                }
            }
            return nextToExpire;
        }

        public List<Loan> GetUserLoansHistory(int pUserId)
        {
            return this.iDbContext.Set<Loan>().Include(loan => loan.Copy).ThenInclude(copy => copy.Book).Where(loan => loan.User.Id == pUserId).ToList();       
        }

        public Loan GetByCopyID(int pCopyID)
        {
            return this.iDbContext.Set<Loan>().Include(loan => loan.Copy).ThenInclude(copy => copy.Book).FirstOrDefault(loan => loan.Copy.Id == pCopyID);
        }

        public List<Loan> GetUserActiveLoans(int pUserId)
        {
            return this.iDbContext.Set<Loan>().Include(loan => loan.Copy).ThenInclude(copy => copy.Book).Where(loan => loan.User.Id == pUserId && loan.ReturnDate == null).ToList();
        }

        public List<Loan> GetActiveLoans()
        {
            return this.iDbContext.Set<Loan>().Include(user => user.User).Include(loan => loan.Copy).ThenInclude(copy => copy.Book).Where(loan => loan.ReturnDate == null).ToList();
        }

        new public Loan Get(int pLoanId)
        {
            return this.iDbContext.Set<Loan>().Include(user => user.User).Include(loan => loan.Copy).ThenInclude(copy => copy.Book).FirstOrDefault(loan => loan.Id == pLoanId);
        }
      
    }   
    
}
