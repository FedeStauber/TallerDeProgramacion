using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class UserLoans : Form
    {       
        private List<LoanDTO> iLoanList; 
        public UserLoans(UserDTO pUser)
        {
            InitializeComponent();        
            this.iLoanList = LibraryManager.UserLoansHistory(pUser);
            this.AssignElements();
        }

        private void AssignElements()
        {           
            dataGridView1.DataSource = iLoanList;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = Properties.Resources.calendario;/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Extender")
          {
                MessageBox.Show("Hola");
          }
            
        }
    }
}
