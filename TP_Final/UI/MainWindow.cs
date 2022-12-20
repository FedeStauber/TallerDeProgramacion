using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final.IO;

namespace TP_Final.UI
{
    public partial class MainWindow : Form
    {
        private Form iActiveForm = null;
        private Form iTempChild = null;
        private int lx, ly, sw, sh;
        public UserDTO User { get; set; }
        public BookDTO SelectedBook { get; set; }
        public new Form ActiveForm { get {return this.iActiveForm; } set {this.iActiveForm = value; } }
        public MainWindow()
        {
            InitializeComponent();
            this.ResetLayout();
            this.OpenChildForm(new Login());
        }
       

        private void ResetLayout()
        {
            
            this.HideSubMenu();
            lateralPanel.Visible = false;
            pbHome.Visible = false;
            panelCurrentUser.Visible = false; 
        }

        public void UpdateUserData()
        {
           
            this.userNameLabel.Text = User.Name;            
            try
            {
                MemoryStream ms = new MemoryStream(User.Avatar);
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
            this.pictureBox1.Visible = true;
            this.userNameLabel.Visible = true;
            this.iconScore.Text = this.User.Score.ToString();
            if (User.Admin)
                AdminLayout();
            else
                SimpleUserLayout();
        }

        #region Controles Menu
        private void HideSubMenu()
        {
            if (submenuBooks.Visible == true)
                submenuBooks.Visible = false;
            if (submenuLoans.Visible == true)
                submenuLoans.Visible = false;
            if (submenuUsers.Visible == true)
                submenuUsers.Visible = false;
            if (panelUserOptions.Visible == true)
                panelUserOptions.Visible = false;
            if (panelUserOptions.Visible == false)
                iconScore.Visible = true;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        public void OpenChildForm(Form pChildForm)
        {
            if (iActiveForm != null)
            {
                iActiveForm.Close();
            }
            if (iTempChild != null)
            {
                iTempChild.Close();
            }
            this.AddOwnedForm(pChildForm);
            this.labelChildTitle.Text = pChildForm.Text;
            iActiveForm = pChildForm;
            pChildForm.TopLevel = false;
            pChildForm.FormBorderStyle = FormBorderStyle.None;
            pChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(pChildForm);
            panelChildForm.Tag = pChildForm;
            pChildForm.BringToFront();
            pChildForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (panelUserOptions.Visible == false)
            {
                this.HideSubMenu();
                iconScore.Visible = false;
                panelUserOptions.Visible = true;
            }
            else
            {
                panelUserOptions.Visible = false;
                iconScore.Visible = true;
            }
        }
        private void SimpleUserLayout()
        {
            this.panelUsers.Visible = false;
            this.btnAddBook.Visible = false;            
            this.btnLoanReturn.Visible = false;
            this.lateralPanel.Visible = true;
            this.pbHome.Visible = true;
            this.panelCurrentUser.Visible = true;
        }
        private void AdminLayout()
        {
            this.panelUsers.Visible = true;
            this.btnAddBook.Visible = true;           
            this.btnLoanReturn.Visible = true;
            this.lateralPanel.Visible = true;
            this.pbHome.Visible = true;
            this.panelCurrentUser.Visible = true;
        }

        #endregion

        #region Botones Menu
        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(submenuBooks);
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(submenuLoans);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(submenuUsers);
        }

        #endregion

        #region Controles Ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelChildTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
             

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                this.Location = new Point(lx, ly);
                this.Size = new Size(sw, sh);
            }
            else
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sh = this.Size.Height;
                sw = this.Size.Width;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
        }

        

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        #endregion

        #region Eventos Botones
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.ResetLayout();
            this.OpenChildForm(new Login());
        }

        private void btnLoanReturn_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new LoanReturn());
        }

        private void btnUserLoans_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new UserLoans(this.User));
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new UserABM(this.User));
        }

        private void btnModifyProfile_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new ModifyProfile(this.User));
        }

       
        private void pbHome_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Home());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new AddBook());
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Catalogue());
        }

      
        #endregion

        public void OpenTempChild(Form pChildForm)
        {
            iTempChild = pChildForm;
            this.AddOwnedForm(pChildForm);
            this.labelChildTitle.Text = pChildForm.Text;            
            pChildForm.TopLevel = false;
            pChildForm.FormBorderStyle = FormBorderStyle.None;
            pChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(pChildForm);
            panelChildForm.Tag = pChildForm;
            pChildForm.BringToFront();
            pChildForm.Show();
        }
     
    }
}
