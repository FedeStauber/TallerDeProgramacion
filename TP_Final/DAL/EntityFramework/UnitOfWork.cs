using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.DAL.EntityFramework
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryManagerDbContext iDbContext;
        private bool iDisposed = false;

        public IBookRepository BookRepository { get; set; }
        public ICopyRepository CopyRepository { get; set; }
        public ILoanRepository LoanRepository { get; set; }
        public IUserRepository UserRepository { get; set; }     

        public UnitOfWork(LibraryManagerDbContext pDbContext)
        {
            this.iDbContext = pDbContext;
            this.CopyRepository = new CopyRepository(pDbContext);
            this.BookRepository = new BookRepository(pDbContext);
            this.LoanRepository = new LoanRepository(pDbContext);
            this.UserRepository = new UserRepository(pDbContext);
        }

        public void Complete()
        {
            iDbContext.SaveChanges();
        }

        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposed)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposed = true;
            }
        }

        public void Dispose()
        {
            iDbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
