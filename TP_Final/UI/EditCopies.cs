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
    public partial class EditCopies : Form
    {
        private List<CopyDTO> iCopyList;
        private BookDTO iBook;
        private CopyDTO.ConditionEnum iPreviousState;
        public EditCopies(BookDTO pBook)
        {
            InitializeComponent();
            
            this.iBook = pBook;
            this.AssignElements();
        }

        private void AssignElements()
        {
            this.iCopyList = LibraryManager.BookCopyList(iBook.ISBN);
            dataGridCopies.DataSource = iCopyList;
        }    

        private void dataGridCopies_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CopyDTO vCopy = iCopyList.Find(copy => copy.Id == Convert.ToInt32(dataGridCopies.Rows[e.RowIndex].Cells[0].Value.ToString()));
                if (vCopy.Condition != iPreviousState)
                {
                    if (vCopy.Condition == CopyDTO.ConditionEnum.Prestado)
                    {
                        throw new Exception("El estado prestado solo puede ser adquirido a partir de la realización de un préstamo");
                    }
                    LibraryManager.ModifyCopy(vCopy);
                    MessageBox.Show($"El estado del libro con ID {dataGridCopies.Rows[e.RowIndex].Cells[0].Value.ToString()} ha cambiado a {dataGridCopies.Rows[e.RowIndex].Cells[1].Value.ToString()}");
                }
            }
            catch (Exception ex)
            {
                dataGridCopies.Rows[e.RowIndex].Cells[1].Value = iPreviousState;
                MessageBox.Show(ex.Message);
                Log.Error(ex, ex.Message);                     
            }  
        }

        private void dataGridCopies_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            iPreviousState = (CopyDTO.ConditionEnum)dataGridCopies.Rows[e.RowIndex].Cells[1].Value;
        }

        private void IconPictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string amount = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de copias: ", "Cantidad de copias");
                if (amount != "")
                {
                    int amount2 = Int32.Parse(amount);
                    LibraryManager.AddCopy(iBook.ISBN, amount2);
                    this.AssignElements();
                }
            }
            catch (Exception ex)
            {
                Log.Error("Error al intentar agregar una copia: ", ex.Message);
                MessageBox.Show(ex.Message);
            }
              
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.OpenChildForm(new BookCard(this.iBook,true,BookCard.ComeFrom.Catalogue));
        }
    }
}
