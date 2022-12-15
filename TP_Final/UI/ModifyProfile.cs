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
    public partial class ModifyProfile : Form
    {

        private UserDTO iUser;
        private int iOriginalDni;
    
        public ModifyProfile(UserDTO user)
        {
            InitializeComponent();
            this.iUser = user;
            this.iOriginalDni = user.DNI;
            txtBoxName.Text = user.Name;
            txtBoxLastName.Text = user.LastName;
            txtBoxDni.Text = user.DNI.ToString();
            txtBoxEmail.Text = user.Email;
            }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                modifyAttributes();
                LibraryManager.ModifyUser(iOriginalDni, iUser);
                MessageBox.Show("Usuario modificado con éxito!!");
                MainWindow vMainWindow = Owner as MainWindow;
                vMainWindow.OpenChildForm(new Home());
            }
        }

        private void modifyAttributes()
        {
            this.iUser.Name = txtBoxName.Text;
            this.iUser.LastName = txtBoxLastName.Text;
            this.iUser.DNI = Convert.ToInt32(txtBoxDni.Text);
            this.iUser.Email = txtBoxEmail.Text;
            this.iUser.Password = txtBoxPass.Text;
        }
        private bool ComprobarCampos()
        {
            if (txtBoxName.Text == null)
            {
                MessageBox.Show("No ha ingresado el nombre."); 
                return false;
            }
            else
            {
                if (txtBoxLastName.Text == null)
                {
                    MessageBox.Show("No ha ingresado el apellido.");
                    return false;
                }
                else
                {
                    if (txtBoxDni.Text == null)
                    {
                        MessageBox.Show("No ha ingresado el DNI.");
                        return false;
                    }
                    else
                    {
                        if (txtBoxEmail.Text == null)
                        {
                            MessageBox.Show("No ha ingresado el email.");
                            return false;
                        }
                        else
                        {
                            if (txtBoxPass.Text == null)
                            {
                                MessageBox.Show("No ha ingresado la contraseña.");
                                return false;
                            }
                            else
                            {
                                if (txtBoxConfirmPass.Text != txtBoxPass.Text)
                                {
                                    MessageBox.Show("No ha ingresado la confirmación de la contraseña.");
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }

                        }
                    }
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
