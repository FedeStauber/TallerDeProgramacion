using TP_Final.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TP_Final.API.BookApiManager;

namespace TP_Final.API

{
    public interface IBookApi
    {
        Task<List<BookDTO>> SearchBook(string pBookTitle, SearchBy pSearchBy);

        Task DownloadCover(BookDTO pBook, CoverImgSize imgSize);
    }
}