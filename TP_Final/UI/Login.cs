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
using TP_Final.UI;


namespace TP_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox2.Image = UIResources.GetAmancio(UIResources.AmancioOrientarion.ToRight);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        /// <summary> Evento que espera un click sobre el botón aceptar, que verifica que las credenciales ingresadas se encuentren
        /// en la base de datos, sino, notifica al usuario</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void btnAccept_Click(object sender, EventArgs e)
        {         
            try
            {
                if (LibraryManager.LogIn(txtBoxEmail.Text, txtBoxPass.Text))
                {
                    MainWindow vMainWindow = Owner as MainWindow;
                    vMainWindow.User = LibraryManager.SearchUserByEmail(txtBoxEmail.Text);
                    vMainWindow.UpdateUserData();
                    vMainWindow.OpenChildForm(new Home());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario y contraseña no coinciden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: "+ex.Message);
                Log.Error(ex,"Error al intentar iniciar sesión:");
            }
        }

        /// <summary> Evento que espera una tecla en el campo de mail, si es un enter actua como si fuese un click sobre
        /// el boton aceptar</summary>
        /// <param name="sender"> Objeto que inicia el evento </param>
        /// <param name="e"> Dato de evento </param>
        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnAccept_Click(sender, e);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            MainWindow vMainMenu = Owner as MainWindow;
            vMainMenu.OpenChildForm(new SingUp(SingUp.ComeFrom.LogIn));    
        }

        private void txtBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.btnAccept_Click(sender, e);
            }
        }

    }
}
