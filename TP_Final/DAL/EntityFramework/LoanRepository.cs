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
            return this.iDbContext.Set<Loan>().Include(loan => loan.User)
                .Include(loan => loan.Copy).ThenInclude(copy => copy.Book)
                .Where(loan => ((loan.EndDate <= DateTime.Now.AddDays(2)) && !loan.Notificated)).ToList();            
        }

        public List<Loan> GetUserLoansHistory(int pUserId)
        {
            return this.iDbContext.Set<Loan>().Include(loan => loan.Copy).ThenInclude(copy => copy.Book).Where(loan => loan.User.Id == pUserId).ToList();       
        }

       
        public int GetUserActiveLoansCount(int pUserId)
        {
            return this.iDbContext.Set<Loan>().Where(loan => loan.User.Id == pUserId && loan.ReturnDate == null).Count();
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
