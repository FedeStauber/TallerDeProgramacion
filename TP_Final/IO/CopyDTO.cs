using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.IO
{
    public class CopyDTO
    {
        public enum ConditionEnum
        {
            Disponible, Prestado, Roto, Suspendido
        }
        public int Id { get; set; }
        public long BookISBN{ get; set; }
        public DateTime LastModify { get; set; }
        public DateTime? LoanEndDate { get; set; }
        public ConditionEnum Condition { get; set; }
       

    }
}
