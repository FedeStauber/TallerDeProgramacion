using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Copy
    {

        public Copy() 
        {
            this.LastModify = DateTime.Now;
        }       

        public int Id { get; set; }

        public virtual Book Book { get; set; }

        public ConditionEnum Condition { get; set; }

        public DateTime LastModify { get; set; }

        public enum ConditionEnum
        {
            Avaible, Borrowed, Broken, Unavailale
        }

        public void ChangeCondition(ConditionEnum pCondition)
        {
            if (this.Condition != ConditionEnum.Borrowed)
            {
                this.Condition = pCondition;
                this.LastModify = DateTime.Today;
            }
            else
                throw new Exception("Debe esperar a que acabe un préstamo para modificar el estado del libro");
        }

        public void ReturnRegister(ConditionEnum pCondition)
        {
            this.Condition = pCondition;
            this.LastModify = DateTime.Today;         
        }

    }
}
