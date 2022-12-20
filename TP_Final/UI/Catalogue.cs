using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class Catalogue : Form
    {
        private List<BookDTO> iBookList = new List<BookDTO>();
        private List<BookDTO> iCurrentList = new List<BookDTO>();
        private int i = 0;       
        private Form iActiveForm;
        private int currentPage = 1;
        
       
        public Catalogue()
        {
            InitializeComponent();
            this.OpenChildForm(new Home());
            LoadMainList();
            iCurrentList = iBookList;
            resultPagComboBox.SelectedIndex = 0;
            this.OpenChildForm(this.selectLayout());
            if (!(iBookList.Count() <= this.ResultsPerPage()))            
                rightBtn.Visible = true;            
        }

        /// <summary> Carga la lista de los libros que se encuentran en el catálogo de la biblioteca </summary>
        private void LoadMainList()
        {
            this.OpenChildForm(new ObteniendoDatosApi());
            var task =  LibraryManager.BookCatalogue();
            task.Start();
            iBookList =  task.Result;
        }

        /// <summary> Crea la pantalla, adapta el tamaño a donde tiene que ir y la muestra al usuario </summary>
        /// <param name="pChildForm"> Formulario a mostrar </param>
        public void OpenChildForm(Form pChildForm)
        {
            if (iActiveForm != null)
            {
                iActiveForm.Close();
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

        /// <summary> Muestra la página en la que se encuentra actualmente sobre la cantidad de páginas totales </summary>
        private void PageCounterUpdate()
        {
            pagesLabel.Text = $"Página {currentPage}/{Math.Ceiling(Convert.ToDouble(iCurrentList.Count) / this.ResultsPerPage())}";
            pagesLabel.Visible = true;
        }

        /// <summary> Cambia la disposición en la que se encuentra la pantalla, si muestra de a 4 o 16 libros </summary>
        private Form selectLayout()
        {
            if (resultPagComboBox.SelectedIndex == 0)
            {
                return new BookListLayout4(iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList());                    
            }
            else
            {
                return new BookListLayout16(iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList());
            }
        }

        /// <summary> Actualiza la pantalla dependiendo de la disposición que se necesite </summary>
        public void RefreshLayout()
        {
            BookListLayout4 layout16 = iActiveForm as BookListLayout4;
            if (layout16 != null)
            {

                layout16.BookList = iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList();
                layout16.AssignElements();
            }
            else
            {
                BookListLayout16 layout4 = iActiveForm as BookListLayout16;
                layout4.BookList = iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList();
                layout4.AssignElements();
            }
        }

        /// <summary> Muestra la cantidad de resultados por páginas, si el campo es distinto de nulo en el comboBox se
        /// muestran los resultados por página que se seleccionaron, sino se muestran 4</summary>
        private int ResultsPerPage()
        {
            if (resultPagComboBox.SelectedItem != null)
            {
                return Convert.ToInt32(resultPagComboBox.SelectedItem.ToString());
            }
            else
            {
                return 4;
            }
        }

        /// <summary> Evento que se encuentra esperando al cambio del valor del combo box para cambiar la distribucion 
        /// de la pagina</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void resultPagComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            i = 0;
            leftBtn.Visible = false;
            rightBtn.Visible = false;
            if (!(iCurrentList.Count() <= this.ResultsPerPage()))
            {
                rightBtn.Visible = true;
            }
            this.OpenChildForm(this.selectLayout());
            PageCounterUpdate();
        }

        /// <summary> Evento que espera un click sobre el botón para realizar una búsqueda de libro, controla si tiene filtro puesto, 
        /// sino notifica al usuario de esto</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir el filtro que desea utilizar");
            }
            else if (cbFiltro.SelectedItem.ToString()=="Autor")
            {
                iCurrentList = iBookList.FindAll(book => book.Author.ToUpper().Contains(searchTextBox.Text.Trim().ToUpper()));
                currentPage = 1;
                i = 0;                
                leftBtn.Visible = false;
                if ((iCurrentList.Count() <= this.ResultsPerPage()))
                {
                    rightBtn.Visible = false;
                }
                else rightBtn.Visible = true;
                this.PageCounterUpdate();
                this.OpenChildForm(this.selectLayout());
            }
            else if (cbFiltro.SelectedItem.ToString() == "ISBN")
            {
                iCurrentList = iBookList.FindAll(book => book.ISBN.ToString().Contains(searchTextBox.Text));
                currentPage = 1;
                i = 0;
                leftBtn.Visible = false;
                if ((iCurrentList.Count() <= this.ResultsPerPage()))
                {
                    rightBtn.Visible = false;
                }
                else rightBtn.Visible = true;
                this.PageCounterUpdate();
                this.OpenChildForm(this.selectLayout());
            }
            else if (cbFiltro.SelectedItem.ToString() == "Género")
            {
                iCurrentList = iBookList.FindAll(book => book.Gender.ToUpper().Contains(searchTextBox.Text.Trim().ToUpper()));
                currentPage = 1;
                i = 0;
                leftBtn.Visible = false;
                if ((iCurrentList.Count() <= this.ResultsPerPage()))
                {
                    rightBtn.Visible = false;
                }
                else rightBtn.Visible = true;
                this.PageCounterUpdate();
                this.OpenChildForm(this.selectLayout());
            }
            else if (cbFiltro.SelectedItem.ToString() == "Título")
            {
                iCurrentList = iBookList.FindAll(book => book.Title.ToUpper().Contains(searchTextBox.Text.Trim().ToUpper()));
                currentPage = 1;
                i = 0;
                leftBtn.Visible = false;
                if ((iCurrentList.Count() <= this.ResultsPerPage()))
                {
                    rightBtn.Visible = false;
                }
                else rightBtn.Visible = true;
                this.PageCounterUpdate();
                this.OpenChildForm(this.selectLayout());
            }
            
        }

        /// <summary> Evento que espera una tecla sobre el campo de texto para controlar si procesarla o no, y si es un enter
        /// lo toma como un click en el boton buscar</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltro.SelectedIndex != -1)
            {
                if (cbFiltro.SelectedItem.ToString() == "ISBN")
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                       (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.searchBtn_Click(sender, e);
            }


        }

        /// <summary> Evento que espera un click sobre el botón para realizar un cambio de los libros a mostrar en la pantalla </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void rightBtn_Click_1(object sender, EventArgs e)
        {
            if (!(i + this.ResultsPerPage() >= iBookList.Count()))
            {
                i = i + this.ResultsPerPage();
                this.RefreshLayout();
            }
            else
            {
                i = i + (iCurrentList.Count() - (i));
            }
            leftBtn.Visible = true;

            if (Math.Ceiling((i + 1.0) / this.ResultsPerPage()) == Math.Ceiling(Convert.ToDouble(iCurrentList.Count) / this.ResultsPerPage()))
            {
                rightBtn.Visible = false;
            }
            currentPage = currentPage + 1;
            this.PageCounterUpdate();

        }

        /// <summary> Evento que espera un click sobre el botón para realizar un cambio de los libros a mostrar en la pantalla </summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void leftBtn_Click_1(object sender, EventArgs e)
        {
            if (!(i - this.ResultsPerPage() < 0))
            {
                i = i - this.ResultsPerPage();
                this.RefreshLayout();
            }
            rightBtn.Visible = true;


            if (Math.Ceiling((i + 1.0) / this.ResultsPerPage()) == 1)
            {
                leftBtn.Visible = false;
            }
            currentPage--;
            this.PageCounterUpdate();
        }

    }
}
