
namespace TP_Final.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lateralPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.submenuUsers = new System.Windows.Forms.Panel();
            this.btnUserList = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.panelLoans = new System.Windows.Forms.Panel();
            this.submenuLoans = new System.Windows.Forms.Panel();
            this.btnUserLoans = new FontAwesome.Sharp.IconButton();
            this.btnLoanReturn = new FontAwesome.Sharp.IconButton();
            this.btnLoans = new FontAwesome.Sharp.IconButton();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.submenuBooks = new System.Windows.Forms.Panel();
            this.btnCatalogue = new FontAwesome.Sharp.IconButton();
            this.btnAddBook = new FontAwesome.Sharp.IconButton();
            this.btnBooks = new FontAwesome.Sharp.IconButton();
            this.panelCurrentUser = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconScore = new FontAwesome.Sharp.IconButton();
            this.panelUserOptions = new System.Windows.Forms.Panel();
            this.btnModifyProfile = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.pbMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.pbClose = new FontAwesome.Sharp.IconPictureBox();
            this.labelChildTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lateralPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.submenuUsers.SuspendLayout();
            this.panelLoans.SuspendLayout();
            this.submenuLoans.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.submenuBooks.SuspendLayout();
            this.panelCurrentUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lateralPanel
            // 
            this.lateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.lateralPanel.Controls.Add(this.panel1);
            this.lateralPanel.Controls.Add(this.panelUsers);
            this.lateralPanel.Controls.Add(this.panelLoans);
            this.lateralPanel.Controls.Add(this.panelBooks);
            this.lateralPanel.Controls.Add(this.panelCurrentUser);
            this.lateralPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lateralPanel.Location = new System.Drawing.Point(0, 0);
            this.lateralPanel.Margin = new System.Windows.Forms.Padding(0);
            this.lateralPanel.Name = "lateralPanel";
            this.lateralPanel.Size = new System.Drawing.Size(220, 771);
            this.lateralPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 731);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 40);
            this.panel1.TabIndex = 4;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnHelp.IconColor = System.Drawing.Color.White;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 36;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHelp.Size = new System.Drawing.Size(220, 40);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // panelUsers
            // 
            this.panelUsers.AutoSize = true;
            this.panelUsers.Controls.Add(this.submenuUsers);
            this.panelUsers.Controls.Add(this.btnUsers);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsers.Location = new System.Drawing.Point(0, 460);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(220, 80);
            this.panelUsers.TabIndex = 3;
            // 
            // submenuUsers
            // 
            this.submenuUsers.AutoSize = true;
            this.submenuUsers.Controls.Add(this.btnUserList);
            this.submenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuUsers.Location = new System.Drawing.Point(0, 40);
            this.submenuUsers.Margin = new System.Windows.Forms.Padding(0);
            this.submenuUsers.Name = "submenuUsers";
            this.submenuUsers.Size = new System.Drawing.Size(220, 40);
            this.submenuUsers.TabIndex = 5;
            this.submenuUsers.Visible = false;
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserList.FlatAppearance.BorderSize = 0;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserList.IconColor = System.Drawing.Color.Black;
            this.btnUserList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserList.Location = new System.Drawing.Point(0, 0);
            this.btnUserList.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(220, 40);
            this.btnUserList.TabIndex = 12;
            this.btnUserList.Text = "Lista de usuarios";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 36;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUsers.Size = new System.Drawing.Size(220, 40);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelLoans
            // 
            this.panelLoans.AutoSize = true;
            this.panelLoans.Controls.Add(this.submenuLoans);
            this.panelLoans.Controls.Add(this.btnLoans);
            this.panelLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoans.Location = new System.Drawing.Point(0, 340);
            this.panelLoans.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoans.Name = "panelLoans";
            this.panelLoans.Size = new System.Drawing.Size(220, 120);
            this.panelLoans.TabIndex = 2;
            // 
            // submenuLoans
            // 
            this.submenuLoans.AutoSize = true;
            this.submenuLoans.Controls.Add(this.btnUserLoans);
            this.submenuLoans.Controls.Add(this.btnLoanReturn);
            this.submenuLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuLoans.Location = new System.Drawing.Point(0, 40);
            this.submenuLoans.Margin = new System.Windows.Forms.Padding(0);
            this.submenuLoans.Name = "submenuLoans";
            this.submenuLoans.Size = new System.Drawing.Size(220, 80);
            this.submenuLoans.TabIndex = 2;
            this.submenuLoans.Visible = false;
            // 
            // btnUserLoans
            // 
            this.btnUserLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnUserLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserLoans.FlatAppearance.BorderSize = 0;
            this.btnUserLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLoans.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLoans.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserLoans.IconColor = System.Drawing.Color.Black;
            this.btnUserLoans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserLoans.Location = new System.Drawing.Point(0, 40);
            this.btnUserLoans.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserLoans.Name = "btnUserLoans";
            this.btnUserLoans.Size = new System.Drawing.Size(220, 40);
            this.btnUserLoans.TabIndex = 13;
            this.btnUserLoans.Text = "Ver mis prestamos";
            this.btnUserLoans.UseVisualStyleBackColor = false;
            this.btnUserLoans.Click += new System.EventHandler(this.btnUserLoans_Click);
            // 
            // btnLoanReturn
            // 
            this.btnLoanReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnLoanReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoanReturn.FlatAppearance.BorderSize = 0;
            this.btnLoanReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanReturn.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanReturn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoanReturn.IconColor = System.Drawing.Color.Black;
            this.btnLoanReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoanReturn.Location = new System.Drawing.Point(0, 0);
            this.btnLoanReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoanReturn.Name = "btnLoanReturn";
            this.btnLoanReturn.Size = new System.Drawing.Size(220, 40);
            this.btnLoanReturn.TabIndex = 12;
            this.btnLoanReturn.Text = "Registrar devolución";
            this.btnLoanReturn.UseVisualStyleBackColor = false;
            this.btnLoanReturn.Click += new System.EventHandler(this.btnLoanReturn_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoans.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnLoans.IconColor = System.Drawing.Color.White;
            this.btnLoans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoans.Location = new System.Drawing.Point(0, 0);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLoans.Size = new System.Drawing.Size(220, 40);
            this.btnLoans.TabIndex = 1;
            this.btnLoans.Text = "Prestamos";
            this.btnLoans.UseVisualStyleBackColor = false;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // panelBooks
            // 
            this.panelBooks.AutoSize = true;
            this.panelBooks.Controls.Add(this.submenuBooks);
            this.panelBooks.Controls.Add(this.btnBooks);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooks.Location = new System.Drawing.Point(0, 220);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(0);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(220, 120);
            this.panelBooks.TabIndex = 1;
            // 
            // submenuBooks
            // 
            this.submenuBooks.AutoSize = true;
            this.submenuBooks.Controls.Add(this.btnCatalogue);
            this.submenuBooks.Controls.Add(this.btnAddBook);
            this.submenuBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuBooks.Location = new System.Drawing.Point(0, 40);
            this.submenuBooks.Margin = new System.Windows.Forms.Padding(0);
            this.submenuBooks.Name = "submenuBooks";
            this.submenuBooks.Size = new System.Drawing.Size(220, 80);
            this.submenuBooks.TabIndex = 1;
            this.submenuBooks.Visible = false;
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnCatalogue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogue.FlatAppearance.BorderSize = 0;
            this.btnCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogue.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogue.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCatalogue.IconColor = System.Drawing.Color.Black;
            this.btnCatalogue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalogue.Location = new System.Drawing.Point(0, 40);
            this.btnCatalogue.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(220, 40);
            this.btnCatalogue.TabIndex = 9;
            this.btnCatalogue.Text = "Catálogo";
            this.btnCatalogue.UseVisualStyleBackColor = false;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddBook.IconColor = System.Drawing.Color.Black;
            this.btnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(220, 40);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Alta Libro";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBooks.IconColor = System.Drawing.Color.White;
            this.btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBooks.IconSize = 36;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnBooks.Size = new System.Drawing.Size(220, 40);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Libros";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // panelCurrentUser
            // 
            this.panelCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.panelCurrentUser.Controls.Add(this.tableLayoutPanel1);
            this.panelCurrentUser.Controls.Add(this.userNameLabel);
            this.panelCurrentUser.Controls.Add(this.pictureBox1);
            this.panelCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelCurrentUser.Name = "panelCurrentUser";
            this.panelCurrentUser.Size = new System.Drawing.Size(220, 220);
            this.panelCurrentUser.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.iconScore, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelUserOptions, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // iconScore
            // 
            this.iconScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.iconScore.FlatAppearance.BorderSize = 0;
            this.iconScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconScore.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconScore.ForeColor = System.Drawing.Color.White;
            this.iconScore.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconScore.IconColor = System.Drawing.Color.White;
            this.iconScore.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconScore.IconSize = 25;
            this.iconScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconScore.Location = new System.Drawing.Point(220, 0);
            this.iconScore.Margin = new System.Windows.Forms.Padding(0);
            this.iconScore.Name = "iconScore";
            this.iconScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconScore.Size = new System.Drawing.Size(220, 50);
            this.iconScore.TabIndex = 1;
            this.iconScore.Text = "Puntaje";
            this.iconScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconScore.UseVisualStyleBackColor = false;
            // 
            // panelUserOptions
            // 
            this.panelUserOptions.Controls.Add(this.btnModifyProfile);
            this.panelUserOptions.Controls.Add(this.btnLogOut);
            this.panelUserOptions.Location = new System.Drawing.Point(0, 0);
            this.panelUserOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserOptions.Name = "panelUserOptions";
            this.panelUserOptions.Size = new System.Drawing.Size(220, 50);
            this.panelUserOptions.TabIndex = 0;
            this.panelUserOptions.Visible = false;
            // 
            // btnModifyProfile
            // 
            this.btnModifyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnModifyProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifyProfile.FlatAppearance.BorderSize = 0;
            this.btnModifyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyProfile.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModifyProfile.IconColor = System.Drawing.Color.Black;
            this.btnModifyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModifyProfile.Location = new System.Drawing.Point(0, 0);
            this.btnModifyProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnModifyProfile.Name = "btnModifyProfile";
            this.btnModifyProfile.Size = new System.Drawing.Size(220, 25);
            this.btnModifyProfile.TabIndex = 1;
            this.btnModifyProfile.Text = "Modificar Perfil";
            this.btnModifyProfile.UseVisualStyleBackColor = false;
            this.btnModifyProfile.Click += new System.EventHandler(this.btnModifyProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogOut.IconColor = System.Drawing.Color.Black;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.Location = new System.Drawing.Point(0, 25);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 25);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Cerrar sesion";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(50, 35);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(120, 15);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTop.Controls.Add(this.pbMinimize);
            this.panelTop.Controls.Add(this.pbMaximize);
            this.panelTop.Controls.Add(this.pbClose);
            this.panelTop.Controls.Add(this.labelChildTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 50);
            this.panelTop.TabIndex = 1;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pbMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.pbMinimize.IconColor = System.Drawing.Color.White;
            this.pbMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.pbMinimize.IconSize = 30;
            this.pbMinimize.Location = new System.Drawing.Point(1173, 8);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 32);
            this.pbMinimize.TabIndex = 2;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pbMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.pbMaximize.IconColor = System.Drawing.Color.White;
            this.pbMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbMaximize.IconSize = 30;
            this.pbMaximize.Location = new System.Drawing.Point(1209, 10);
            this.pbMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(32, 32);
            this.pbMaximize.TabIndex = 1;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pbClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.pbClose.IconColor = System.Drawing.Color.White;
            this.pbClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.pbClose.IconSize = 30;
            this.pbClose.Location = new System.Drawing.Point(1243, 10);
            this.pbClose.Margin = new System.Windows.Forms.Padding(0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // labelChildTitle
            // 
            this.labelChildTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChildTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.labelChildTitle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildTitle.ForeColor = System.Drawing.Color.White;
            this.labelChildTitle.Location = new System.Drawing.Point(0, 0);
            this.labelChildTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelChildTitle.Name = "labelChildTitle";
            this.labelChildTitle.Size = new System.Drawing.Size(1280, 50);
            this.labelChildTitle.TabIndex = 3;
            this.labelChildTitle.Text = "label1";
            this.labelChildTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChildTitle.Click += new System.EventHandler(this.labelChildTitle_Click);
            this.labelChildTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelChildTitle_MouseDown);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.ForeColor = System.Drawing.Color.Black;
            this.panelChildForm.Location = new System.Drawing.Point(220, 50);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1280, 721);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 771);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lateralPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1500, 771);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.lateralPanel.ResumeLayout(false);
            this.lateralPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.submenuUsers.ResumeLayout(false);
            this.panelLoans.ResumeLayout(false);
            this.panelLoans.PerformLayout();
            this.submenuLoans.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            this.submenuBooks.ResumeLayout(false);
            this.panelCurrentUser.ResumeLayout(false);
            this.panelCurrentUser.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lateralPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCurrentUser;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelLoans;
        private System.Windows.Forms.Panel panelBooks;
        private FontAwesome.Sharp.IconButton btnBooks;
        private FontAwesome.Sharp.IconButton btnLoans;
        private FontAwesome.Sharp.IconButton btnUsers;
        private System.Windows.Forms.Panel submenuBooks;
        private System.Windows.Forms.Panel submenuLoans;
        private FontAwesome.Sharp.IconButton btnCatalogue;
        private FontAwesome.Sharp.IconButton btnAddBook;
        private FontAwesome.Sharp.IconButton btnUserLoans;
        private FontAwesome.Sharp.IconButton btnLoanReturn;
        private System.Windows.Forms.Panel submenuUsers;
        private FontAwesome.Sharp.IconButton btnUserList;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelUserOptions;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnModifyProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private FontAwesome.Sharp.IconPictureBox pbClose;
        private FontAwesome.Sharp.IconPictureBox pbMinimize;
        private FontAwesome.Sharp.IconPictureBox pbMaximize;
        public System.Windows.Forms.Label labelChildTitle;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconScore;
    }
}