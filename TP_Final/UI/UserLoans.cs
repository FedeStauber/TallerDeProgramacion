using ImageProcessor;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.Domain;
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
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Extender" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cellBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Extender"] as DataGridViewButtonCell;
                cellBoton.FlatStyle = FlatStyle.Flat;
                cellBoton.UseColumnTextForButtonValue = false;                
                Icon icoAtomico = Properties.Resources.calendario32x32;
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 19, e.CellBounds.Top + 3);
                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 6;
                this.dataGridView1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
               
                    if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Extender")
                    {
                        string amount = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad días: ", "Cantidad días");
                        if (amount != "")
                        {
                            LibraryManager.LoanExtend(iLoanList[e.RowIndex], Int32.Parse(amount));                            
                            dataGridView1[e.ColumnIndex-3,e.RowIndex].Value = iLoanList[e.RowIndex].EndDate.AddDays(Int32.Parse(amount));                            
                            MessageBox.Show("Préstamo extendido con éxito!!");
                        }

                    }
                
              
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show(ex.Message);
            }          
        }

    }
}
