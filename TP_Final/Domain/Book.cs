using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Book
    {       
        public Book() { }
        public int Id { get; set; }
        [Required]
        public double ISBN { get; set; }
        [Required]
        public string Title { get; set; }        
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string Gender { get; set; }
        public byte[] Cover { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }




    }
}
