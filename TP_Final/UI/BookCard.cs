using ImageProcessor;
using Newtonsoft.Json.Serialization;
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
using TP_Final.Exceptions;
using TP_Final.IO;
using TP_Final.Properties;

namespace TP_Final.UI
{
    public partial class BookCard : Form
    {
        private BookDTO iBook;
        private bool iAdmin, iCoverModified;
        private ComeFrom iComeFrom;       
        private string iTemp;
        private long iOriginalISBN;
        private byte[] iTempCover = null;
        
        
        
        
        public enum ComeFrom {AddBook,Catalogue}
        
        public BookCard(BookDTO pBook, bool pAdmin,ComeFrom pComeFrom)
        {
            InitializeComponent();
            this.iOriginalISBN = pBook.ISBN;
            this.iBook = pBook;
            this.iAdmin = pAdmin;
            this.iComeFrom = pComeFrom;
            AssignElements();
            if (pComeFrom == ComeFrom.AddBook)
            {
              DownloadHqCover();              
            }            
        }

        private async void DownloadHqCover()
        {
            try
            {
                await BookApiManager.CurrentApi.DownloadCover(iBook, BookApiManager.CoverImgSize.Large);
                if (iBook.Cover.Length > 900)
                {
                    MemoryStream ms = new MemoryStream(iBook.Cover);
                    Bitmap bmp = new Bitmap(ms);
                    ImageFactory imgFact = new ImageFactory();
                    imgFact.Load(bmp);
                    imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                    pictureBox1.Image = imgFact.Image;
                }
                else
                {
                    await BookApiManager.CurrentApi.DownloadCover(iBook, BookApiManager.CoverImgSize.Medium);
                    if (iBook.Cover.Length > 900)
                    {
                        MemoryStream ms = new MemoryStream(iBook.Cover);
                        Bitmap bmp = new Bitmap(ms);
                        ImageFactory imgFact = new ImageFactory();
                        imgFact.Load(bmp);
                        imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                        pictureBox1.Image = imgFact.Image;
                    }
                    else
                    {
                        await BookApiManager.CurrentApi.DownloadCover(iBook, BookApiManager.CoverImgSize.Small);
                        if (iBook.Cover.Length > 900)
                        {
                            MemoryStream ms = new MemoryStream(iBook.Cover);
                            Bitmap bmp = new Bitmap(ms);
                            ImageFactory imgFact = new ImageFactory();
                            imgFact.Load(bmp);
                            imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                            pictureBox1.Image = imgFact.Image;
                        }
                        else
                        {
                            pictureBox1.Image = Resources.CoverNotFoundImage;                            
                        }
                    }
                }
            }
            catch (ErrorDownloadingCoverException ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = Resources.CoverNotFoundImage;
            }
          
        }

        public void AssignElements()
        {
            if (iAdmin)
            {
                btnSelectNewCover.Visible = true;
                btnSaveChanges.Visible = true;
                if (iComeFrom == ComeFrom.AddBook)
                    btnSaveChanges.Text = "Agregar";
                else
                {
                    btnSaveChanges.Text = "Guardar Cambios";
                    btnAddLoan.Visible = true;
                    btnManageCopies.Visible = true;
                }
                btnEditTitle.Visible = true;

            }
            else
            {
                labelAuthor.Size = new Size(769, 39);
                labelAuthor.Multiline = true;
                labelGender.Size = new Size(769, 39);
                labelGender.Multiline = true;
                labelISBN.Size = new Size(769, 39);
                labelISBN.Multiline = true;
                labelLanguage.Size = new Size(769, 39);
                labelLanguage.Multiline = true;
                labelPages.Size = new Size(769, 39);
                labelPages.Multiline = true;
            }
            this.Text = "Ficha del libro: " +iBook.Title;
            labelTitle.Text = iBook.Title;            
            labelAuthor.Text = iBook.Author;
            labelGender.Text = iBook.Gender;
            labelLanguage.Text = iBook.Language;
            labelPages.Text = iBook.Pages.ToString();
            labelISBN.Text = iBook.ISBN.ToString();
            labelDescription.Text = iBook.Description;
            if (iBook.Cover != null)
            {
                MemoryStream ms = new MemoryStream(iBook.Cover);
                Bitmap bmp = new Bitmap(ms);
                ImageFactory imgFact = new ImageFactory();
                imgFact.Load(bmp);
                imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                pictureBox1.Image = imgFact.Image;
            }
            else
            {
                //Agregar imagen de error y solicitar recargar
            }
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            if (this.iComeFrom == ComeFrom.AddBook)
            {
                vMainWindow.labelChildTitle.Text = "Agegar un libro";
                
            }
            else
            {
                vMainWindow.labelChildTitle.Text = "Catálogo";
            }
            this.Close();
        }

        #region Editar Libro
        private void EndEdit()
        {
            btnDiscardEdit.Visible = false;
            btnAcceptEdit.Visible = false;
            richTextBox1.Visible = false;
            btnSaveChanges.Visible = true;
            btnAddLoan.Visible = true;
        }
        private void BeginEdit()
        {
            this.iTemp = labelTitle.Text;
            richTextBox1.Text = labelTitle.Text;
            richTextBox1.Visible = true;
            btnDiscardEdit.Visible = true;
            btnAcceptEdit.Visible = true;
            btnSaveChanges.Visible = false;
            btnAddLoan.Visible = false;
        }
       
       
        private void btnAcceptEdit_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = richTextBox1.Text;
            this.EndEdit();            
        }
        private void btnDiscardEdit_Click_1(object sender, EventArgs e)
        {
            labelTitle.Text = iTemp;
            this.EndEdit();
        }
        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
            this.BeginEdit();
        }
      
        private void labelISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!iAdmin)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }    
        }
        private void btnSelectNewCover_Click_1(object sender, EventArgs e)
        {
            iCoverModified = false;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                iCoverModified = true;
                byte[] file = null;
                Stream vStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    vStream.CopyTo(ms);
                    file = ms.ToArray();
                    iTempCover = file;
                    Bitmap bmp = new Bitmap(ms);
                    ImageFactory imgFact = new ImageFactory();
                    imgFact.Load(bmp);
                    imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                    pictureBox1.Image = imgFact.Image;
                }
            }
        }
        #endregion
        
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (iComeFrom == ComeFrom.AddBook)
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro que desea agregar {iBook.Title} a la biblioteca?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        iBook.Title = labelTitle.Text;
                        iBook.Gender = labelGender.Text;
                        iBook.Description = labelDescription.Text;
                        iBook.Author = labelAuthor.Text;
                        iBook.ISBN = Convert.ToInt64(labelISBN.Text);
                        iBook.Pages = Convert.ToInt32(labelPages.Text);
                        iBook.Language = labelLanguage.Text;
                        using (var stream = new MemoryStream())
                        {
                            pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            iBook.Cover = stream.ToArray();
                        }
                        try
                        {
                            LibraryManager.AddBook(iBook);
                            MessageBox.Show("Libro agregado con éxito");
                            MainWindow vMainWindow = Owner as MainWindow;
                            vMainWindow.labelChildTitle.Text = "Agregar Libro";                            
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al intentar agregar un libro: " + ex.Message);
                            Log.Error(ex,"Error al intentar agregar un libro");
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro que desea agregar guardar los cambios?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        iBook.Title = labelTitle.Text;
                        iBook.Gender = labelGender.Text;
                        iBook.Description = labelDescription.Text;
                        iBook.Author = labelAuthor.Text;
                        iBook.ISBN = Convert.ToInt64(labelISBN.Text);
                        iBook.Pages = Convert.ToInt32(labelPages.Text);
                        iBook.Language = labelLanguage.Text;
                        if (iCoverModified)
                        {
                            iBook.Cover = iTempCover;
                        }                        
                        LibraryManager.ModifyBook(iOriginalISBN, iBook);
                        iOriginalISBN = iBook.ISBN;
                        MainWindow vOwner = Owner as MainWindow;
                        Catalogue vCatalogue = vOwner.ActiveForm as Catalogue;
                        vCatalogue.RefreshLayout();
                        MessageBox.Show("Cambios guardados con éxito!");
                        this.ReturnButton_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex,"Error al agregar un libro" );
                MessageBox.Show("Error al agregar un libro: "+ex.Message);
            }
            
        }
       

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.OpenTempChild(new AddLoan(iBook));
        }

        private void btnManageCopies_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.OpenTempChild(new EditCopies(iBook));
        }

        private void labelAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!iAdmin)
            {
                e.Handled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            labelTitle.Text = richTextBox1.Text;
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.labelChildTitle.Text = labelTitle.Text;
        }
    }
}
