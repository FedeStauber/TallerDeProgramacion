using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public interface INotificatorEstrategy
    {
        void Notify(Loan pLoan);
    }
}
