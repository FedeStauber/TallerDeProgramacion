using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class BookDTO
    {
        
        public long ISBN { get; set; }       
        public string Title { get; set; }   
        public string Author { get; set; } 
        public string Language { get; set; }
        public int Pages { get; set; }
        public string Gender { get; set; }
        public byte[] Cover { get; set; }
        public bool Active { get; set; }
        public string CoverDir { get; set; }
        public string Description { get; set; }


    }
}
