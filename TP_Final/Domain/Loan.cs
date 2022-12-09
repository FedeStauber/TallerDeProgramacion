using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Loan
    {
        public Loan() { }
        public int Id { get; set; }
        public virtual DateTime? StartDate { get; set; } = null;
        public virtual DateTime? EndDate { get; set; } = null;
        public virtual DateTime? ReturnDate { get; set; } = null;
        public virtual User User { get; set; }
        public virtual bool Notificated { get; set; }
        public Copy Copy { get; set; }
        public int LoanScore { get; set; }




        public bool Late()
        {
            if ((ReturnDate == null) && (EndDate < DateTime.Now))
            {
                return true;
            }
            return false;
        }

        public void ReturnRegister(Copy.ConditionEnum pCondition)
        {
            if (pCondition == Copy.ConditionEnum.Avaible && this.Late())
            {              
                User.Score -= 2 * ((DateTime.Now - EndDate).Value.Days + 1);
                LoanScore = 2 * ((DateTime.Now - EndDate).Value.Days + 1);
            }
            else if (pCondition == Copy.ConditionEnum.Avaible)
            {                
                User.Score += 5;
                LoanScore = 5;
            }
            else if (pCondition == Copy.ConditionEnum.Broken)
            {               
                User.Score -= 10;
                LoanScore = -10;
            }           
            ReturnDate = DateTime.Now;
            Copy.ReturnRegister(pCondition);
        }
    }
}
