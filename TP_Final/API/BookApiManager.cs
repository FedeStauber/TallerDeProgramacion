using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.API
{
    public static class BookApiManager 
    {
        public enum CoverImgSize { Small, Medium, Large }

        public enum SearchBy
        {
            Author, Title, Gender
        }
        public static IBookApi CurrentApi { get; set; }
        public static void ChangeApi(IBookApi pBookApi)
        {
            CurrentApi = pBookApi;
        }

      
    }
}
