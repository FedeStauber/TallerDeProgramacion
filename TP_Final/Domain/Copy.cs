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

        public DateTime? LoanEndDate { get; set; }

        public enum ConditionEnum
        {
            Available, Borrowed, Broken, Unavailable
        }

        /// <summary>
        /// Realiza la modificación de la condición de la copia del libro. 
        /// </summary>
        /// <param name="pCondition">Nueva condición para la copia</param>
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

        /// <summary>
        /// Realiza la modificación de la condición de la copia del libro solo si el libro se encuentra prestado  
        /// </summary>
        /// <param name="pCondition">Nueva condición para la copia</param>
        public void ReturnRegister(ConditionEnum pCondition)
        {
            if (this.Condition == ConditionEnum.Borrowed)
            {
                this.Condition = pCondition;
                this.LastModify = DateTime.Today;
                this.LoanEndDate = null;
            }
            else
            {
                throw new Exception("El libro no se encuentra prestado.");
            }
                    
        }
        
    }
}
