using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Loan
    {
        public int Id { get; set; }
        public virtual DateTime? StartDate { get; set; } = null;
        public virtual DateTime EndDate { get; set; } 
        public virtual DateTime? ReturnDate { get; set; } = null;
        public virtual User User { get; set; }
        public virtual bool Notificated { get; set; }
        public Copy Copy { get; set; }
        public int LoanScore { get; set; }
        public int DaysExtended { get; set; }

        public Loan() 
        {
            this.DaysExtended = 0;
        }


        //NO LO ENTIENDO
        /// <summary>
        /// Verifica si un préstamo 
        /// </summary>
        /// <returns>Verdadero o falso</returns>
        public bool Late()
        {
            if ((ReturnDate == null) && (EndDate < DateTime.Now))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Realiza la devolución de una copia, modifica la modificación de la condición y registra el score
        /// del usuario y del préstamo
        /// </summary>
        /// <param name="pUserId">Nueva condición para la copia</param>
        public void ReturnRegister(Copy.ConditionEnum pCondition)
        {
            if (pCondition == Copy.ConditionEnum.Available && this.Late())
            {              
                User.Score -= 2 * ((DateTime.Now - EndDate).Days + 1);
                LoanScore = 2 * ((DateTime.Now - EndDate).Days + 1);
            }
            else if (pCondition == Copy.ConditionEnum.Available)
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

        public void Extend(int pDaysToExtend)
        {
            if (ReturnDate != null)
            {
                throw new Exception("No se puede extender un préstamo finalizado");
            }
            else
            {
                if (pDaysToExtend + this.DaysExtended > 15)
                {
                    throw new Exception($"No se puede extender un prestamo más de 15 días, este préstamo ya se ha extendido {this.DaysExtended} días");
                }
                else
                {
                    if (this.User.Score < pDaysToExtend * 5)
                    {
                        throw new Exception("No dispone del puntaje suficiente para extender el préstamo");
                    }
                    else
                    {
                        if (this.EndDate < DateTime.Now)
                        {
                            throw new Exception("No es posible extender un préstamo atrasado");
                        }
                        else
                        {
                            this.EndDate = this.EndDate.AddDays(pDaysToExtend);
                            this.DaysExtended += pDaysToExtend;
                            User.Score -= pDaysToExtend * 5;
                        }
                    }
                }
            }  
        }
    }
}
