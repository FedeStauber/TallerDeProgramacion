using ImageProcessor;
using Microsoft.Win32;
using Quartz.Util;
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
    public partial class ModifyProfile : Form
    {

        private UserDTO iUser;
        private int iOriginalDni;
        private byte[] iAvatar = null;
    
        public ModifyProfile(UserDTO user)
        {
            InitializeComponent();
            this.iUser = user;
            this.iOriginalDni = user.DNI;
            txtBoxName.Text = user.Name;
            txtBoxLastName.Text = user.LastName;
            txtBoxDni.Text = user.DNI.ToString();
            txtBoxEmail.Text = user.Email;
            this.LoadImage(); 
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields())
                {
                    modifyAttributes();
                    LibraryManager.ModifyUser(iOriginalDni, iUser);                    
                    MessageBox.Show("Usuario modificado con éxito!!");
                    MainWindow vMainWindow = Owner as MainWindow;
                    vMainWindow.UpdateUserData();
                    vMainWindow.OpenChildForm(new Home());                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar el perfil :" +ex);
                Log.Error("Error al intentar modificar el perfil");
            }
        }

        private void modifyAttributes()
        {
            this.iUser.Name = txtBoxName.Text;
            this.iUser.LastName = txtBoxLastName.Text;
            this.iUser.DNI = Convert.ToInt32(txtBoxDni.Text);
            this.iUser.Email = txtBoxEmail.Text;
            if (!(txtBoxNewPass.Text.Trim() == null))
            {
                this.iUser.Password = txtBoxNewPass.Text;
            }            
            if (iAvatar != null)
            {
                this.iUser.Avatar = iAvatar;
            }           
        }
        private bool CheckFields()
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
                            if (txtBoxConfirmPass.Text != txtBoxNewPass.Text)
                            {
                                MessageBox.Show("Las contraseñas no coinciden.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = Owner as MainWindow;
            vMainWindow.OpenChildForm(new Home());
        }
        private void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream(iUser.Avatar);
                Bitmap bmp = new Bitmap(ms);
                ImageFactory imgFact = new ImageFactory();
                imgFact.Load(bmp);
                imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                pictureBox1.Image = imgFact.Image;
            }
            catch (Exception)
            {
                pictureBox1.Image = Properties.Resources.defAvatar;

            }
        }

        private void DniTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((txtBoxDni.Text.Length >= 9) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUploadAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] file = null;
                Stream vStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    vStream.CopyTo(ms);
                    file = ms.ToArray();
                    iAvatar = file;
                    Bitmap bmp = new Bitmap(ms);
                    ImageFactory imgFact = new ImageFactory();
                    imgFact.Load(bmp);
                    imgFact.Resize(new ImageProcessor.Imaging.ResizeLayer(pictureBox1.Size, ImageProcessor.Imaging.ResizeMode.Stretch));
                    pictureBox1.Image = imgFact.Image;
                }
            }
        }
    }
}
