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
            LoadMainList();
            iCurrentList = iBookList;
            comboBoxPerso1.SelectedIndex = 0;
            this.OpenChildForm(this.selectLayout());
            if (!(iBookList.Count() <= this.ResultsPerPage()))            
                rightBtn.Visible = true;            
        }

        private void LoadMainList()
        {
            this.OpenChildForm(new ObteniendoDatosApi());
            var task =  LibraryManager.BookCatalogue();
            task.Start();
            iBookList =  task.Result;
        }
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
        private void PageCounterUpdate()
        {
            pagesLabel.Text = $"Página {currentPage}/{Math.Ceiling(Convert.ToDouble(iCurrentList.Count) / this.ResultsPerPage())}";
            pagesLabel.Visible = true;
        }
       
          
        private Form selectLayout()
        {
            if (comboBoxPerso1.SelectedIndex == 0)
            {
                return new BookListLayout4(iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList());                    
            }
            else
            {
                return new BookListLayout16(iCurrentList.Skip(i).Take(this.ResultsPerPage()).ToList());
            }
        }
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
        private int ResultsPerPage()
        {
            if (comboBoxPerso1.SelectedItem != null)
            {
                return Convert.ToInt32(comboBoxPerso1.SelectedItem.ToString());
            }
            else
            {
                return 4;
            }
        }
        private void comboBoxPerso1_OnSelectedIndexChanged(object sender, EventArgs e)
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
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir el filtro que desea utilizar");
            }
            else if (cbFiltro.SelectedItem.ToString()=="Autor")
            {
                iCurrentList = iBookList.FindAll(book => book.Author.ToUpper().Contains(textBoxPerso1.Text.Trim().ToUpper()));
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
                iCurrentList = iBookList.FindAll(book => book.ISBN.ToString().Contains(textBoxPerso1.Text));
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
                iCurrentList = iBookList.FindAll(book => book.Gender.ToUpper().Contains(textBoxPerso1.Text.Trim().ToUpper()));
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
                iCurrentList = iBookList.FindAll(book => book.Title.ToUpper().Contains(textBoxPerso1.Text.Trim().ToUpper()));
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
        private void textBoxPerso1_KeyPress(object sender, KeyPressEventArgs e)
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
                this.iconPictureBox1_Click(sender, e);
            }


        }
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

        private void textBoxPerso1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
