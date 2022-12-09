using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_Final.DAL
{
    interface IUnitOfWork : IDisposable
    {
        void Complete();
        IBookRepository BookRepository { get; set; }
        ICopyRepository CopyRepository { get; set; }
        ILoanRepository LoanRepository { get; set; }
        IUserRepository UserRepository { get; set; }

    }
}
