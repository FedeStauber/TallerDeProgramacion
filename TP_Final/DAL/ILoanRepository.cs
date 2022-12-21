using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    interface ILoanRepository : IRepository<Loan>
    {
       
        List<Loan> GetUserLoansHistory(int pUserId);
        int GetUserActiveLoansCount(int pUserId);
        List<Loan> GetActiveLoans();
        List<Loan> GetNextToExpire();
      

    }
}
