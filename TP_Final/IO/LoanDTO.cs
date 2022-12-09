using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class LoanDTO
    {
        public string UserEmail { get; set; }
        public double BookISBN { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Returned { get { return ReturnDate != null; } set{; } }
        public int LoanScore { get; set; }
        public string BookTitle { get; set; }
        public int UserDNI { get; set; }
        public int Id { get; set; }

    }
}
