using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using Serilog;
using System.Drawing;
using static TP_Final.API.BookApiManager;
using System.Windows;

namespace TP_Final.API.OpenLibrary
{
    class OpenLibraryApi : IBookApi
    {
        
      


        public async Task DownloadCover(BookDTO pBook, CoverImgSize imgSize)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var uri = new Uri("https://covers.openlibrary.org/b/id/" + pBook.CoverDir + $"-{imgSize}.jpg");
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = await webClient.DownloadDataTaskAsync(uri);
                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        pBook.Cover = mem.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error("Error al obtener las imagenes de la API",ex.Message);
                MessageBox.Show(ex.Message);
                throw new Exception("Error al obtener las imagenes desde la API");
            }

        }



        public async Task<List<BookDTO>> SearchBook(string pBookTitle, SearchBy pSearchBy)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string mUrl = "";
            switch (pSearchBy)
            {
                case SearchBy.Author:
                    mUrl = "http://openlibrary.org/search.json?author=" + pBookTitle.Replace(" ", "+");
                    break;
                case SearchBy.Title:
                    mUrl = "http://openlibrary.org/search.json?title=" + pBookTitle.Replace(" ", "+");
                    break;
                case SearchBy.Gender:
                    mUrl = "http://openlibrary.org/search.json?subject=" + pBookTitle.Replace(" ", "+");
                    break;
                default:
                    break;
            }           
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);
            List<BookDTO> vBooksDTO = new List<BookDTO>();
            try
            {
                WebResponse mResponse =  mRequest.GetResponse();
                using (Stream responseStream = mResponse.GetResponseStream())
                {                    
                    dynamic mResponseJSON = await this.DeserializeAsync(responseStream);
                    int i = 0;
                    int cantidad = mResponseJSON.docs.Count;
                    while ((i <= cantidad - 1))
                    {
                        BookDTO vBookDTO = new BookDTO();
                        var bResponseItem = mResponseJSON.docs[i];
                        //Se agrega el titulo
                        if (bResponseItem.title != null)
                        {
                            vBookDTO.Title = WebUtility.HtmlDecode(bResponseItem.title.ToString());
                        }                       
                        //Se comprueban y agregan los autores
                        if (bResponseItem.author_name == null)
                        {
                            vBookDTO.Author = "Anónimo";
                        }
                        else
                        {
                            vBookDTO.Author = WebUtility.HtmlDecode(bResponseItem.author_name[0].ToString());
                        }
                        //Se agrega el ISBN
                        if (bResponseItem.isbn == null)
                        {                            
                            vBookDTO.ISBN = 0;
                        }
                        else
                        {
                            string vISBN = WebUtility.HtmlDecode(bResponseItem.isbn[0].ToString()).Replace("X", "");
                            vBookDTO.ISBN = Convert.ToInt64(vISBN);
                        }
                        //Se agrega la direccion del cover
                        if (bResponseItem.cover_i != null)
                        {
                            vBookDTO.CoverDir = WebUtility.HtmlDecode(bResponseItem.cover_i.ToString());
                        }
                        //Se agrega la cantidad de paginas
                        if (bResponseItem.number_of_pages_median != null)
                        {
                            vBookDTO.Pages = Convert.ToInt32(WebUtility.HtmlDecode(bResponseItem.number_of_pages_median.ToString()));
                        }
                        //Se agrega el lenguage
                        if (bResponseItem.language != null)
                        {
                            string vLanguage = "";
                            for (int j = 1; j <= Math.Min(bResponseItem.language.Count, 15); j++)
                            {
                                if (j == 1)
                                {
                                    vLanguage = (WebUtility.HtmlDecode(bResponseItem.language[j - 1].ToString()));
                                }
                                else
                                {
                                    vLanguage = vLanguage + ", " + (WebUtility.HtmlDecode(bResponseItem.language[j - 1].ToString()));
                                }
                            }
                            vBookDTO.Language = vLanguage;
                        }
                        //Se agregan los generos
                        if (bResponseItem.subject != null)
                        {
                            string vGender = "";
                            for (int j = 1; j <= Math.Min(bResponseItem.subject.Count,15); j++)
                            {
                                if (j == 1)
                                {
                                    vGender = (WebUtility.HtmlDecode(bResponseItem.subject[j - 1].ToString()));
                                }
                                else
                                {
                                    vGender = vGender + ", " + (WebUtility.HtmlDecode(bResponseItem.subject[j - 1].ToString()));
                                }
                            }
                            vBookDTO.Gender = vGender;
                        }
                        vBooksDTO.Add(vBookDTO);
                        i++;
                    }
                    return vBooksDTO;
                }
            }

            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();
                    Log.Error("Error: {0}", mErrorText);
                }
                return new List<BookDTO>();
            }
            catch (Exception ex)
            {
                Log.Error("Error: {0}", ex.Message);
                return new List<BookDTO>();
            }


        }
        private async Task<dynamic> DeserializeAsync(Stream pStream)
        {
            using (StreamReader reader = new StreamReader(pStream, Encoding.UTF8))
            {
                return JsonConvert.DeserializeObject(await reader.ReadToEndAsync());
            }
        }


    }
}
