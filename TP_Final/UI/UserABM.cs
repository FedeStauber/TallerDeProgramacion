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
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class UserABM : Form
    {
        private List<UserDTO> iUserList,iFilteredList;
        private UserDTO iUser = new UserDTO();
        
        public UserABM()
        {
            InitializeComponent();
            this.AssignElements();
            pictureBox1.Image = Properties.Resources.leyendo_a_izquierda;
        }

        private void AssignElements()
        {
            this.iUserList = LibraryManager.UsersList();
            dataGridUsers.DataSource = iUserList;
            this.OpenTlpFilter();
        }


        private void UpdatePanelModifiy()
        {
            tbDNI.Text = iUser.DNI.ToString();
            tbEmail.Text = iUser.Email;
            tbLastName.Text = iUser.LastName;
            tbName.Text = iUser.Name;
            tbScore.Text = iUser.Score.ToString();
            cbActive.Checked = iUser.Active;
            cbAdmin.Checked = iUser.Admin;
            panelModifyBook.Visible = true;
           
        }


        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                iUser = iUserList.Find(userDto => userDto.DNI == Convert.ToInt32(dataGridUsers.Rows[e.RowIndex].Cells[3].Value.ToString()));
                this.UpdatePanelModifiy();
                this.OPenDataPanel();
            }
            
        }


        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            try
            {
                int vDni = Convert.ToInt32(dataGridUsers.SelectedRows[0].Cells[3].Value.ToString());
                iUser.Active = cbActive.Checked;
                iUser.Admin = cbAdmin.Checked;
                iUser.Name = tbName.Text;
                iUser.LastName = tbLastName.Text;
                iUser.Email = tbEmail.Text;
                iUser.DNI = Convert.ToInt32(tbDNI.Text);
                iUser.Score = Convert.ToInt32(tbScore.Text);
                iUser.Password = "";
                LibraryManager.ModifyUser(vDni, iUser);
                this.AssignElements();
                panelModifyBook.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex, ex.Message);
                panelModifyBook.Visible = false;
                this.AssignElements();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {           
            OpenTlpFilter();
        }

        private void OpenTlpFilter()
        {
            panelModifyBook.Visible = false;
            tableLayoutPanel3.SetCellPosition(tlpFilter, new TableLayoutPanelCellPosition(0, 1));
            tableLayoutPanel3.SetCellPosition(panelModifyBook, new TableLayoutPanelCellPosition(0, 0));
            tlpFilter.Visible = true;
        }

        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchBtn_Click(sender, e);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        { 
            if (textBoxFilter.Text.Trim() == "")
            {
                    iFilteredList = iUserList;
            }
            else
            {
                try
                {
                    iFilteredList = iUserList.FindAll(user => user.DNI == Convert.ToInt64(textBoxFilter.Text.Trim()) || user.Email == textBoxFilter.Text.Trim());
                }
                catch (Exception)
                {
                    iFilteredList = iUserList.FindAll(user => user.Email == textBoxFilter.Text.Trim());
                }
                }
                dataGridUsers.DataSource = iFilteredList;
        }

        private void OPenDataPanel()
        {
            tlpFilter.Visible = false;
            tableLayoutPanel3.SetCellPosition(tlpFilter, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel3.SetCellPosition(panelModifyBook, new TableLayoutPanelCellPosition(0, 1));
            panelModifyBook.Visible = true;
        }
    }
}
