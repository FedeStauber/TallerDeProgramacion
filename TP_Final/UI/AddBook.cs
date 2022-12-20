using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.API;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class AddBook : Form
    {
        private List<BookDTO> iBookList = new List<BookDTO>();
        private int iPageIndex;
        private int iDownloadedTo;
        private Form iActiveForm;
        private double iCurrentPage;
        private bool iCanDownload = true;
        private int iResultsPerPage = 4;
        private int iSearchFilterIndex = -1;

       
        public AddBook()
        {
            InitializeComponent();
            resultPagComboBox.Visible = false;
        }

        /// <summary> Crea la pantalla, adapta el tamaño a donde tiene que ir y la muestra al usuario </summary>
        /// <param name="pChildForm"> Formulario a mostrar </param>
        public void OpenChildForm(Form pChildForm)
        {
            if (iActiveForm != null)
            {
                iActiveForm.Dispose();
            }
            this.AddOwnedForm(pChildForm);
            iActiveForm = pChildForm;
            pChildForm.TopLevel = false;
            pChildForm.FormBorderStyle = FormBorderStyle.None;
            pChildForm.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(pChildForm);
            centerPanel.Tag = pChildForm;
            pChildForm.BringToFront();
            pChildForm.Show();
        }

        /// <summary> Descarga las portadas de forma asincrónica a medida que se van necesitando para mostrar, y las que no
        /// se necesitan se van cargando en el array</summary>

        private async void DownloadCovers()
        {
            if (iDownloadedTo < iBookList.Count && iCanDownload)
            {
                if (iBookList[iDownloadedTo].CoverDir == null)
                {
                    using (var stream = new MemoryStream())
                    {
                        Properties.Resources.CoverNotFoundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        iBookList[iDownloadedTo].Cover = stream.ToArray();
                    }
                }
                else
                {
                    await BookApiManager.CurrentApi.DownloadCover(iBookList[iDownloadedTo], BookApiManager.CoverImgSize.M);
                }
                iDownloadedTo++;
                if (iCurrentPage * iResultsPerPage >= iDownloadedTo && ((iCurrentPage - 1) * iResultsPerPage) <= iDownloadedTo && iCanDownload)
                {
                    this.RefreshLayout();
                }
                this.DownloadCovers();
            }
        }

        /// <summary> Muestra la página en la que se encuentra actualmente sobre la cantidad de páginas totales </summary>
        private void PageCounterUpdate()
        {
            pagesLabel.Text = $"Página {iCurrentPage}/{Math.Ceiling(Convert.ToDouble(iBookList.Count) / this.iResultsPerPage)}";
            pagesLabel.Visible = true;
        }

        /// <summary> Cambia la disposición en la que se encuentra la pantalla, si muestra de a 4 o 16 libros </summary>
        private Form SelectLayout()
        {
            if (this.iResultsPerPage == 4)
            {

                return new BookListLayout4(iBookList.Skip(iPageIndex).Take(this.iResultsPerPage).ToList());
            }
            else
            {
                return new BookListLayout16(iBookList.Skip(iPageIndex).Take(this.iResultsPerPage).ToList());
            }
        }

        /// <summary> Actualiza la pantalla dependiendo de la disposición que se necesite </summary>
        private void RefreshLayout()
        {
            BookListLayout4 layout16 = iActiveForm as BookListLayout4;
            if (layout16 != null)
            {

                layout16.BookList = iBookList.Skip(iPageIndex).Take(this.iResultsPerPage).ToList();
                layout16.AssignElements();
            }
            else
            {
                BookListLayout16 layout4 = iActiveForm as BookListLayout16;
                layout4.BookList = iBookList.Skip(iPageIndex).Take(this.iResultsPerPage).ToList();
                layout4.AssignElements();
            }
        }

        /// <summary> Evento que se encuentra esperando al cambio del valor del combo box para cambiar la distribucion 
        /// de la pagina</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void resultPagComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            iPageIndex = 0;
            this.iResultsPerPage = Convert.ToInt32(resultPagComboBox.SelectedItem.ToString());
            this.ResetLayout();
            this.OpenChildForm(this.SelectLayout());
            this.PageCounterUpdate();
        }

        /// <summary> Evento que espera un click sobre el botón para realizar una búsqueda de libro, controla si tiene filtro puesto, 
        /// sino notifica al usuario de esto</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private async void searchBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.rightBtn.Visible = false;
                this.leftBtn.Visible = false; 
                if (iSearchFilterIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el filtro a utilizar");
                }
                else if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el texto a buscar");
                }
                else
                {
                    this.iCanDownload = false;
                    this.OpenChildForm(new ObteniendoDatosApi());
                    iPageIndex = 0;
                    this.iDownloadedTo = 0;
                    await this.DownloadList();
                    this.ResetLayout();
                    this.OpenChildForm(this.SelectLayout());
                    this.iCanDownload = true;
                    this.DownloadCovers();
                    this.PageCounterUpdate();
                    resultPagComboBox.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
                //Abrir ventana logo
            }
        }

        /// <summary> Evento que espera un click sobre el botón para realizar un cambio de los libros a mostrar en la pantalla </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void LeftBtn_Click_1(object sender, EventArgs e)
        {
            if (!(iPageIndex - this.iResultsPerPage < 0))
            {
                iPageIndex = iPageIndex - this.iResultsPerPage;
                this.RefreshLayout();
            }
            rightBtn.Visible = true;
            if (Math.Ceiling((iPageIndex + 1.0) / this.iResultsPerPage) == 1)
            {
                leftBtn.Visible = false;
            }
            iCurrentPage--;
            this.PageCounterUpdate();
        }

        /// <summary> Evento que espera un click sobre el botón para realizar un cambio de los libros a mostrar en la pantalla </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void RightBtn_Click_1(object sender, EventArgs e)
        {
            if (!(iPageIndex + this.iResultsPerPage >= iBookList.Count()))
            {
                iPageIndex = iPageIndex + this.iResultsPerPage;
                this.RefreshLayout();
            }
            else
            {
                iPageIndex = iPageIndex + (iBookList.Count() - (iPageIndex));
            }
            leftBtn.Visible = true;
            if (Math.Ceiling((iPageIndex + 1.0) / this.iResultsPerPage) == Math.Ceiling(Convert.ToDouble(iBookList.Count) / this.iResultsPerPage))
            {
                rightBtn.Visible = false;
            }
            iCurrentPage = iCurrentPage + 1;
            this.PageCounterUpdate();
        }

        /// <summary> Reinicia la distribución </summary>

        private void ResetLayout()
        {
            this.iCurrentPage = 1;
            this.leftBtn.Visible = false;
            this.rightBtn.Visible = false;
            if (!(iBookList.Count() <= this.iResultsPerPage))
            {
                rightBtn.Visible = true;
            }
        }

        /// <summary> Realiza llamado a la API para poder crear una lista de libros dependiendo el filtro que se seleccione </summary>
        private async Task DownloadList()
        {
            if (iSearchFilterIndex == 0) //Autor
            {
                this.iBookList = await BookApiManager.CurrentApi.SearchBook(textBox1.Text.Trim(), BookApiManager.SearchBy.Author);
            }
            else if (iSearchFilterIndex == 1) //Titulo
            {
                this.iBookList = await BookApiManager.CurrentApi.SearchBook(textBox1.Text.Trim(), BookApiManager.SearchBy.Title);

            }
            else if (iSearchFilterIndex == 2) //Género
            {
                this.iBookList = await BookApiManager.CurrentApi.SearchBook(textBox1.Text.Trim(), BookApiManager.SearchBy.Gender);
            }
        }

        /// <summary> Asigna el valor del filtro que se selecciona </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void cbFiltro_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.iSearchFilterIndex = cbFiltro.SelectedIndex;
            
        }

        /// <summary> Evento que espera de un Enter para poder realizar la misma función que un click sobre el boton buscar </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void SearchTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.searchBtn_Click_1(sender, e);
            }
        }

    }
}
