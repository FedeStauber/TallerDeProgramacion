using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class LoanReturn : Form
    {
        private List<LoanDTO> iLoanList, iFilteredList;

        private LoanDTO iLoan;
        public LoanReturn()
        {
            iLoanList = LibraryManager.ActiveLoans();
            iFilteredList = iLoanList;
            InitializeComponent();
            dataGridUsers.DataSource = iFilteredList;
            pictureBox1.Image = Properties.Resources.leyendo_a_izquierda; 
            OpenTlpFilter();               
        }

        private void OpenDataPanel()
        {
            tlpFilter.Visible = false;
            tableLayoutPanel3.SetCellPosition(tlpFilter, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel3.SetCellPosition(panelLoanReturnData, new TableLayoutPanelCellPosition(0, 1));
            panelLoanReturnData.Visible = true;
        }

        private void UpdateDataPanel()
        {
            bookLabel.Text = iLoan.BookTitle;
            dniLabel.Text = iLoan.UserDNI.ToString();
            ExpiresLabel.Text = iLoan.EndDate.ToString();
            userLabel.Text = iLoan.UserEmail;
        }
        private void OpenTlpFilter()
        {
            panelLoanReturnData.Visible = false;
            tableLayoutPanel3.SetCellPosition(tlpFilter, new TableLayoutPanelCellPosition(0, 1));
            tableLayoutPanel3.SetCellPosition(panelLoanReturnData, new TableLayoutPanelCellPosition(0, 0));
            tlpFilter.Visible = true;            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {            
            OpenTlpFilter();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Trim() == "")
            {
                iFilteredList = iLoanList;
            }
            else
            {
                try
                {
                    iFilteredList = iLoanList.FindAll(loan => loan.UserDNI == Convert.ToInt64(textBoxFilter.Text.Trim()) || loan.UserEmail == textBoxFilter.Text.Trim());
                }
                catch (Exception)
                {
                    iFilteredList = iLoanList.FindAll(loan => loan.UserEmail == textBoxFilter.Text.Trim());
                }                              
            }
            dataGridUsers.DataSource = iFilteredList;
        }

        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchBtn_Click(sender, e);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPerso1.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el estado del libro");
                }
                else
                {
                    LibraryManager.LoanReturnRegister(iLoan.Id, comboBoxPerso1.SelectedIndex);
                    List<LoanDTO> auxListToRemove = new List<LoanDTO>();
                    auxListToRemove.Add(iLoan);
                    iFilteredList = iLoanList.Except(auxListToRemove).ToList();
                    dataGridUsers.DataSource = iFilteredList;
                }
                OpenTlpFilter();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }          
          
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iLoan = iLoanList.Find(loanDTO => loanDTO.Id == Convert.ToInt32(dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.UpdateDataPanel();
                this.OpenDataPanel();
            }
        }
    }
}
