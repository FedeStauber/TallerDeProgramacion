using ImageProcessor;
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
    public partial class BookListLayout16 : Form
    {
        private List<BookDTO> iBookList;
        private Dictionary<int, Control[]> iBookPanel = new Dictionary<int, Control[]>();

        public List<BookDTO> BookList { get {return this.iBookList; } set { this.iBookList = value; }}
        public BookListLayout16(List<BookDTO> pBookList)
        {           
            InitializeComponent();
            this.iBookList = pBookList;
            this.LoadDictionary();
            this.AssignElements();                       
        }


        public void AssignElements()
        {           
            for (int i = 0; i < iBookList.Count(); i++)
            {
                this.AtomicAssign(i);
            }
        }

     
        public void AtomicAssign(int i)
        {
            iBookPanel[i][0].Text = iBookList[i].Title;
            iBookPanel[i][1].Text = iBookList[i].Author;
            iBookPanel[i][2].Text = iBookList[i].ISBN.ToString();
            PictureBox pb = iBookPanel[i][3] as PictureBox;
            if (!(iBookList[i].Cover == null))
            {
                MemoryStream ms = new MemoryStream(iBookList[i].Cover);
                Bitmap bmp = new Bitmap(ms);
                ImageFactory imgFact = new ImageFactory();
                imgFact.Load(bmp);
                imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pb.Size, ImageProcessor.Imaging.ResizeMode.Stretch));                
                pb.Image = imgFact.Image;
            }
            else
            {
                pb.Image = Properties.Resources.loading;
            }
            iBookPanel[i][4].Visible = true;
            if (iBookList.Count() < 16)
            {
                for (int j = iBookList.Count; j < 16; j++)
                {
                    iBookPanel[j][4].Visible = false;
                }
            }
        }
        private void LoadDictionary()
        {
            iBookPanel.Add(0, new Control[5] { titleLabel0, authorLabel0, ISBNLabel0, pictureBox0, bookPanel0});
            iBookPanel.Add(1, new Control[5] { titleLabel1, authorLabel1, ISBNLabel1, pictureBox1, bookPanel1});
            iBookPanel.Add(2, new Control[5] { titleLabel2, authorLabel2, ISBNLabel2, pictureBox2, bookPanel2});
            iBookPanel.Add(3, new Control[5] { titleLabel3, authorLabel3, ISBNLabel3, pictureBox3, bookPanel3});
            iBookPanel.Add(4, new Control[5] { titleLabel4, authorLabel4, ISBNLabel4, pictureBox4, bookPanel4});
            iBookPanel.Add(5, new Control[5] { titleLabel5, authorLabel5, ISBNLabel5, pictureBox5, bookPanel5});
            iBookPanel.Add(6, new Control[5] { titleLabel6, authorLabel6, ISBNLabel6, pictureBox6, bookPanel6});
            iBookPanel.Add(7, new Control[5] { titleLabel7, authorLabel7, ISBNLabel7, pictureBox7, bookPanel7});
            iBookPanel.Add(8, new Control[5] { titleLabel8, authorLabel8, ISBNLabel8, pictureBox8, bookPanel8});
            iBookPanel.Add(9, new Control[5] { titleLabel9, authorLabel9, ISBNLabel9, pictureBox9, bookPanel9});
            iBookPanel.Add(10, new Control[5] { titleLabel10, authorLabel10, ISBNLabel10, pictureBox10, bookPanel10});
            iBookPanel.Add(11, new Control[5] { titleLabel11, authorLabel11, ISBNLabel11, pictureBox11, bookPanel11});
            iBookPanel.Add(12, new Control[5] { titleLabel12, authorLabel12, ISBNLabel12, pictureBox12, bookPanel12});
            iBookPanel.Add(13, new Control[5] { titleLabel13, authorLabel13, ISBNLabel13, pictureBox13, bookPanel13});
            iBookPanel.Add(14, new Control[5] { titleLabel14, authorLabel14, ISBNLabel14, pictureBox14, bookPanel14});
            iBookPanel.Add(15, new Control[5] { titleLabel15, authorLabel15, ISBNLabel15, pictureBox15, bookPanel15});  
        }

        #region Cover clicks
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[0], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[0], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[1], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[1], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[2], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[2], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[3], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[3], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[4], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[4], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[5], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[5], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[6], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[6], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[7], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[7], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[8], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[8], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[9], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[9], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[10], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[10], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[11], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[11], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[12], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[12], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[13], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[13], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[14], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[14], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            AddBook vAddBook = Owner as AddBook;
            if (!(vAddBook == null))
            {
                MainWindow vMainWindow = vAddBook.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[15], vMainWindow.User.Admin, BookCard.ComeFrom.AddBook));
            }
            else
            {
                Catalogue vCatalogue = Owner as Catalogue;
                MainWindow vMainWindow = vCatalogue.Owner as MainWindow;
                vMainWindow.OpenTempChild(new BookCard(iBookList[15], vMainWindow.User.Admin, BookCard.ComeFrom.Catalogue));
            }
        }
        #endregion


    }
}
