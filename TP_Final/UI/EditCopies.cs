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
            ImageFactory imgFact = new ImageFactory();
            imgFact.Load(Properties.Resources.viejo3I);
            imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(new Size(336, 473), ImageProcessor.Imaging.ResizeMode.Stretch));
            pictureBox1.Image = imgFact.Image;
           
        }

        /// <summary> Asigna las copias de ese libro que se busca por ISBN a la lista para mostrarle al usuario </summary>
        private void AssignElements()
        {
            try
            {
                this.iCopyList = LibraryManager.BookCopyList(iBook.ISBN);
                dataGridCopies.DataSource = iCopyList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener las copias del libro: " + ex.Message);
                Log.Error(ex, "Error al intentar obtener las copias del libro");
                this.Close();
            }           
        }

        /// <summary> Permite cambiar la celda de condicion de la copia, controlando que se pueda pasar de un estado a otro
        /// correctamente</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Datos para la tabla </param>
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
                    MessageBox.Show($"El estado de la copia con ID {dataGridCopies.Rows[e.RowIndex].Cells[0].Value.ToString()} ha cambiado a {dataGridCopies.Rows[e.RowIndex].Cells[1].Value.ToString()}");
                }
            }
            catch (Exception ex)
            {
                dataGridCopies.Rows[e.RowIndex].Cells[1].Value = iPreviousState;
                MessageBox.Show("Error al intentar editar una copia");
                Log.Error("Error al intentar editar una copia: "+ex);                     
            }  
        }

        private void dataGridCopies_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            iPreviousState = (CopyDTO.ConditionEnum)dataGridCopies.Rows[e.RowIndex].Cells[1].Value;
        }

        /// <summary> Abre una nueva ventana para que el usuario pueda ingresar la cantidad de copias que desea agregar de ese libro, 
        /// notificando al usuario si se realizó o dio error/summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Datos para la tabla </param>
        private void addBottom_Click(object sender, EventArgs e)
        {
            try
            {
                string amount = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de copias: ", "Cantidad de copias");
                if (amount != "")
                {
                    LibraryManager.AddCopy(iBook.ISBN, Int32.Parse(amount));
                    this.AssignElements();
                }
            }
            catch (Exception ex)
            {
                Log.Error("Error al intentar agregar una copia: ", ex);
                MessageBox.Show("Error al intentar agregar una copia");
            }
              
        }

        /// <summary> Permite cerrar y volver a la pantalla anterior</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Datos para la tabla </param>
        private void returnBottom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
