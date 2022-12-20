using ImageProcessor;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class SingUp : Form
    {
        private byte[] iAvatar;
        private ComeFrom iComefrom;
        public enum ComeFrom { LogIn, MainWindow }

        public SingUp(ComeFrom pComeFrom)
        {
            InitializeComponent();
            iComefrom = pComeFrom;  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainWindow vMainWindow = this.Owner as MainWindow;
            vMainWindow.labelChildTitle.Text = "Pantalla De Inicio";
            vMainWindow.OpenChildForm(new Login());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {            
            try
            {
                if (this.CheckFields())
                {
                    UserDTO vUserDTO = new UserDTO()
                    {
                        Name = NameTxtBox.Text,
                        LastName = LastNameTxtBox.Text,
                        DNI = Convert.ToInt32(DniTxtBox.Text),
                        Email = EmailTxtBox.Text,
                        Password = PassTxtBox.Text,
                        Avatar = iAvatar,
                        Active = true 
                    };
                    LibraryManager.AddUser(vUserDTO);
                    MainWindow vMainMenu = Owner as MainWindow;
                    if (iComefrom == ComeFrom.LogIn)
                    {
                        
                        vMainMenu.User = vUserDTO;
                        vMainMenu.UpdateUserData();
                        this.Close();
                        MessageBox.Show($"Usuario creado con éxito, bienvenido: {vUserDTO.Name}");
                    }
                    else
                    {
                        MessageBox.Show("Usuario creado con éxito!");
                        vMainMenu.OpenChildForm(new Home());
                    }                                       
                }
            }
            catch (AutoMapper.AutoMapperMappingException)
            {
                MessageBox.Show("El formato del email ingresado no es válido");
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);                
                MessageBox.Show(ex.ToString());         
            }
            
        }

        private bool CheckFields()
        {
            bool vCheck = true;
            if (NameTxtBox.Text.Trim() == "")
            {
                vCheck = false;
                MessageBox.Show("Debe Ingresar su nombre");
            }
            else if (LastNameTxtBox.Text.Trim() == "")
            {
                vCheck = false;
                MessageBox.Show("Debe Ingresar su Apellido");
            }
            else if (DniTxtBox.Text.Trim() == "")
            {
                vCheck = false;
                MessageBox.Show("Debe Ingresar su DNI");
            }
            else if (EmailTxtBox.Text.Trim() == "")
            {
                vCheck = false;
                MessageBox.Show("Debe Ingresar su Correo");
            }
            else if (PassTxtBox.Text.Trim() == "")
            {
                vCheck = false;
                MessageBox.Show("Debe Ingresar su Contraseña");
            }
            else if (PassRepeatTxtBox.Text != PassTxtBox.Text)
            {
                vCheck = false;
                MessageBox.Show("Las contraseñas no coinciden");
            }
            return vCheck;

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

        
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DniTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((DniTxtBox.Text.Length >= 9) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
