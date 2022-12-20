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
    public partial class BookListLayout4 : Form
    {
        private List<BookDTO> iBookList;
        private Dictionary<int, Control[]> iBookPanel = new Dictionary<int, Control[]>();
        public List<BookDTO> BookList { get { return this.iBookList; } set { this.iBookList = value; } }
        public BookListLayout4(List<BookDTO> pBookList)
        {
            InitializeComponent();
            this.iBookList = pBookList;
            this.LoadDictionary();
            this.AssignElements();
        }

        /// <summary> Llama n veces al procedimiento de asignar para todos los elementos en la lista de libros</summary>
        public void AssignElements()
        {
            for (int i = 0; i < iBookList.Count(); i++)
            {
                if (i < 4)
                    this.AtomicAssign(i);
                else
                    break;
            }
        }

        /// <summary> Asigna todos los datos (titulo, autor isbn y portada) a ese libro en específico</summary>
        /// <param name="i"> Posición en el lista </param>
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
            if (iBookList.Count() < 4)
            {
                for (int j = iBookList.Count; j < 4; j++)
                {
                    iBookPanel[j][4].Visible = false;
                }
            }

        }

        /// <summary> Carga el diccionario para los 4 libros </summary>
        private void LoadDictionary()
        {
            iBookPanel.Add(0, new Control[5] { titleLabel0, authorLabel0, ISBNLabel0, pictureBox0, bookPanel0 });
            iBookPanel.Add(1, new Control[5] { titleLabel1, authorLabel1, ISBNLabel1, pictureBox1, bookPanel1 });
            iBookPanel.Add(2, new Control[5] { titleLabel2, authorLabel2, ISBNLabel2, pictureBox2, bookPanel2 });
            iBookPanel.Add(3, new Control[5] { titleLabel3, authorLabel3, ISBNLabel3, pictureBox3, bookPanel3 });
        }



        #region Cover Clicks
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
        #endregion


    }
}
