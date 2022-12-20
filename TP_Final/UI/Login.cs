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
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {         
            try
            {
                LoginDTO vLoginDTO = LibraryManager.LogIn(txtBoxEmail.Text, txtBoxPass.Text);
                if (vLoginDTO.IsValid)
                {
                    MainWindow vMainWindow = Owner as MainWindow;
                    vMainWindow.User = vLoginDTO.User;
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
                MessageBox.Show(ex.Message);
                Log.Error(ex, ex.Message);
            }
        }

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
