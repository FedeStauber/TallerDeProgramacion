using ImageProcessor;
using Microsoft.Win32;
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
            //MessageBox.Show(iUser.Active.ToString());
            try
            {
                if (ComprobarCampos())
                {
                    modifyAttributes();
                    if (txtBoxNewPass.Text != "")
                    {
                        iUser.Password = "";                    
                    }
                    LibraryManager.ModifyUser(iOriginalDni, iUser);                    
                    MessageBox.Show("Usuario modificado con éxito!!");
                    MainWindow vMainWindow = Owner as MainWindow;
                    vMainWindow.OpenChildForm(new Home());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex, ex.Message);
            }
        }

        private void modifyAttributes()
        {
            this.iUser.Name = txtBoxName.Text;
            this.iUser.LastName = txtBoxLastName.Text;
            this.iUser.DNI = Convert.ToInt32(txtBoxDni.Text);
            this.iUser.Email = txtBoxEmail.Text;
            this.iUser.Password = txtBoxNewPass.Text;
            if (iAvatar != null)
            {
                this.iUser.Avatar = iAvatar;
            }           
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
            this.Close();
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
        private void btnUploadAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
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
