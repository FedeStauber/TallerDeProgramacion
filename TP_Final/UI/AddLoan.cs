using ImageProcessor;
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
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class AddLoan : Form
    {
        private BookDTO iBook;
        private UserDTO iUser;
        public AddLoan(BookDTO pBook)
        {
            InitializeComponent();
            this.iBook = pBook;
            this.AssignElements();
        }

        private void AssignElements()
        {
            this.labelTitle.Text = iBook.Title;
            if (iBook.Cover != null)
            {
                MemoryStream ms = new MemoryStream(iBook.Cover);
                Bitmap bmp = new Bitmap(ms);
                ImageFactory imgFact = new ImageFactory();
                imgFact.Load(bmp);
                imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                pictureBox1.Image = imgFact.Image;
            }
        }



        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFilter.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un DNI para corroborar los datos del usuario");
                }
                iUser = LibraryManager.SearchUserByDNI(Convert.ToInt64(textBoxFilter.Text));
                if (iUser != null)
                {
                    tbName.Text = iUser.LastName + " " + iUser.Name;
                    tbScore.Text = iUser.Score.ToString();
                    tbDNI.Text = iUser.DNI.ToString();
                    tbActiveLoans.Text = LibraryManager.CountUserActiveLoans(iUser.Id).ToString();
                    btnAddLoan.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningun usuario para el DNI ingresado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex, ex.Message);
            }

        }

        private void textBoxPerso8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnSearchUser_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.labelChildTitle.Text = $"Ficha del libro: {iBook.Title}";
            this.Close();      
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                LoanDTO vLoanDTO = new LoanDTO()
                {
                    UserEmail = iUser.Email,
                    BookISBN = iBook.ISBN,
                    BookTitle = iBook.Title
                };
                LibraryManager.CreateLoan(vLoanDTO);
                MessageBox.Show("Préstamo registrado con éxito");
                MainWindow vMainWindow = Owner as MainWindow;
                vMainWindow.OpenChildForm(new Home()); 
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
