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
        private UserDTO iUserToEdit = new UserDTO();
        private UserDTO iUser;

        public UserABM(UserDTO pUser)
        {            
            InitializeComponent();
            this.iUser = pUser;
            this.AssignElements();
            pictureBox1.Image = UIResources.GetAmancio(UIResources.AmancioOrientarion.ToLeft);
        }

        private void AssignElements()
        {
            try
            {
                this.iUserList = LibraryManager.UsersList();
                dataGridUsers.DataSource = iUserList;
                this.OpenTlpFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener la lista de usuarios: " + ex.Message);
                Log.Error(ex, "Error al intentar obtener la lista de usuarios");
            }
       
        }


        private void UpdatePanelModifiy()
        {
            tbDNI.Text = iUserToEdit.DNI.ToString();
            tbEmail.Text = iUserToEdit.Email;
            tbLastName.Text = iUserToEdit.LastName;
            tbName.Text = iUserToEdit.Name;
            tbScore.Text = iUserToEdit.Score.ToString();
            cbActive.Checked = iUserToEdit.Active;
            cbAdmin.Checked = iUserToEdit.Admin;
            panelModifyBook.Visible = true;
           
        }


        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                iUserToEdit = iUserList.Find(userDto => userDto.DNI == Convert.ToInt32(dataGridUsers.Rows[e.RowIndex].Cells[3].Value.ToString()));
                this.UpdatePanelModifiy();
                this.OPenDataPanel();
            }
            
        }


        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.CheckFields()) 
                { 
                int vDni = Convert.ToInt32(dataGridUsers.SelectedRows[0].Cells[3].Value.ToString());
                iUserToEdit.Active = cbActive.Checked;
                iUserToEdit.Admin = cbAdmin.Checked;
                iUserToEdit.Name = tbName.Text;
                iUserToEdit.LastName = tbLastName.Text;
                iUserToEdit.Email = tbEmail.Text;
                iUserToEdit.DNI = Convert.ToInt32(tbDNI.Text);
                iUserToEdit.Score = Convert.ToInt32(tbScore.Text);
                iUserToEdit.Password = "";
                LibraryManager.ModifyUser(vDni, iUserToEdit);
                if (iUser.DNI == vDni)
                {
                    MainWindow vMainWindow = Owner as MainWindow;
                    vMainWindow.User = iUserToEdit;
                    vMainWindow.UpdateUserData();
                    vMainWindow.OpenChildForm(new Home());
                }
                this.AssignElements();
                panelModifyBook.Visible = false;
                MessageBox.Show("Usuario modificado con exito!!");
                }
                else
                {
                    MessageBox.Show("No puede dejar campos vacíos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar realizar el alta del usuario: "+ex);
                Log.Error("Error al intentar realizar el alta del usuario");
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

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
              e.Handled = true;                              
            }
            if ((tbDNI.Text.Length >= 9) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((tbScore.Text.Length >= 9) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OPenDataPanel()
        {
            tlpFilter.Visible = false;
            tableLayoutPanel3.SetCellPosition(tlpFilter, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel3.SetCellPosition(panelModifyBook, new TableLayoutPanelCellPosition(0, 1));
            panelModifyBook.Visible = true;
        }

        private bool CheckFields()
        {
            if (tbName.Text.Trim() == "")
                return false;
            if (tbLastName.Text.Trim() == "")
                return false;
            if (tbEmail.Text.Trim() == "")
                return false;
            if (tbDNI.Text.Trim() == "")
                return false;
            if (tbScore.Text.Trim() == "")
                return false;
            return true;            
        }
    }
}
