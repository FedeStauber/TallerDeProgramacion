using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Notificator
    {
        private INotificatorEstrategy iEstrategy;        
        public Notificator() 
        {
            this.iEstrategy = new EmailEstrategy();
        }         
       
        public void Notify(Loan pLoan)
        {
            iEstrategy.Notify(pLoan);
        }

        public void ChooseEstrategy(INotificatorEstrategy pNotificationEstrategy) 
        {
            this.iEstrategy = pNotificationEstrategy;
        }
    }
}
