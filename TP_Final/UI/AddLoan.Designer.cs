
namespace TP_Final.UI
{
    partial class AddLoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelActiveLoans = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelEditBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.tbScore = new TP_Final.UI.TextBoxPerso();
            this.textBoxFilter = new TP_Final.UI.TextBoxPerso();
            this.tbActiveLoans = new TP_Final.UI.TextBoxPerso();
            this.tbDNI = new TP_Final.UI.TextBoxPerso();
            this.tbName = new TP_Final.UI.TextBoxPerso();
            this.btnAddLoan = new TP_Final.UI.ButtonPerso();
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelEditBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 80);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 50;
            this.iconPictureBox2.Location = new System.Drawing.Point(1210, 31);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1280, 80);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54688F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.45313F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 641);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.00972F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.99028F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tbScore, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelFilters, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelScore, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.tbActiveLoans, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.labelActiveLoans, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.tbDNI, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.labelDNI, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbName, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelName, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.panelEditBox, 1, 14);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(391, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(889, 641);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelScore.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelScore.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelScore.Location = new System.Drawing.Point(32, 238);
            this.labelScore.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(58, 19);
            this.labelScore.TabIndex = 57;
            this.labelScore.Text = "Puntaje";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelActiveLoans
            // 
            this.labelActiveLoans.AutoSize = true;
            this.labelActiveLoans.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelActiveLoans.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelActiveLoans.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelActiveLoans.Location = new System.Drawing.Point(32, 171);
            this.labelActiveLoans.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelActiveLoans.Name = "labelActiveLoans";
            this.labelActiveLoans.Size = new System.Drawing.Size(56, 19);
            this.labelActiveLoans.TabIndex = 55;
            this.labelActiveLoans.Text = "Activos";
            this.labelActiveLoans.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDNI.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelDNI.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDNI.Location = new System.Drawing.Point(32, 104);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(32, 19);
            this.labelDNI.TabIndex = 48;
            this.labelDNI.Text = "DNI";
            this.labelDNI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(32, 37);
            this.labelName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 19);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Nombre";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelEditBox
            // 
            this.panelEditBox.Controls.Add(this.btnAddLoan);
            this.panelEditBox.Controls.Add(this.btnCancel);
            this.panelEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditBox.Location = new System.Drawing.Point(32, 442);
            this.panelEditBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditBox.Name = "panelEditBox";
            this.panelEditBox.Size = new System.Drawing.Size(779, 139);
            this.panelEditBox.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 641);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(25, 0, 0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 2;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelFilters.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.textBoxFilter, 0, 0);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(32, 0);
            this.tableLayoutPanelFilters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 1;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(779, 37);
            this.tableLayoutPanelFilters.TabIndex = 60;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 37;
            this.searchBtn.Location = new System.Drawing.Point(742, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 37);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 12;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tbScore
            // 
            this.tbScore.BackColor = System.Drawing.Color.DarkGray;
            this.tbScore.BorderColor = System.Drawing.Color.Gray;
            this.tbScore.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbScore.BorderRadius = 5;
            this.tbScore.BorderSize = 3;
            this.tbScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScore.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbScore.Location = new System.Drawing.Point(32, 262);
            this.tbScore.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tbScore.Multiline = true;
            this.tbScore.Name = "tbScore";
            this.tbScore.Padding = new System.Windows.Forms.Padding(11);
            this.tbScore.PasswordChar = false;
            this.tbScore.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbScore.PlaceholderText = "";
            this.tbScore.Size = new System.Drawing.Size(779, 39);
            this.tbScore.TabIndex = 61;
            this.tbScore.TabStop = false;
            this.tbScore.UnderlinedStyle = false;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.textBoxFilter.BorderFocusColor = System.Drawing.Color.RosyBrown;
            this.textBoxFilter.BorderRadius = 0;
            this.textBoxFilter.BorderSize = 2;
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFilter.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.Location = new System.Drawing.Point(3, 0);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxFilter.Multiline = false;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFilter.PasswordChar = false;
            this.textBoxFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFilter.PlaceholderText = "Ingrese el DNI o Email del usuario a filtrar";
            this.textBoxFilter.Size = new System.Drawing.Size(739, 29);
            this.textBoxFilter.TabIndex = 11;
            this.textBoxFilter.UnderlinedStyle = true;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerso8_KeyPress);
            // 
            // tbActiveLoans
            // 
            this.tbActiveLoans.BackColor = System.Drawing.Color.DarkGray;
            this.tbActiveLoans.BorderColor = System.Drawing.Color.Gray;
            this.tbActiveLoans.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbActiveLoans.BorderRadius = 5;
            this.tbActiveLoans.BorderSize = 3;
            this.tbActiveLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActiveLoans.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActiveLoans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbActiveLoans.Location = new System.Drawing.Point(32, 195);
            this.tbActiveLoans.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tbActiveLoans.Multiline = true;
            this.tbActiveLoans.Name = "tbActiveLoans";
            this.tbActiveLoans.Padding = new System.Windows.Forms.Padding(11);
            this.tbActiveLoans.PasswordChar = false;
            this.tbActiveLoans.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbActiveLoans.PlaceholderText = "";
            this.tbActiveLoans.Size = new System.Drawing.Size(779, 39);
            this.tbActiveLoans.TabIndex = 56;
            this.tbActiveLoans.TabStop = false;
            this.tbActiveLoans.UnderlinedStyle = false;
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.DarkGray;
            this.tbDNI.BorderColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderRadius = 5;
            this.tbDNI.BorderSize = 3;
            this.tbDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDNI.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDNI.Location = new System.Drawing.Point(32, 128);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tbDNI.Multiline = true;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Padding = new System.Windows.Forms.Padding(11);
            this.tbDNI.PasswordChar = false;
            this.tbDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDNI.PlaceholderText = "";
            this.tbDNI.Size = new System.Drawing.Size(779, 39);
            this.tbDNI.TabIndex = 49;
            this.tbDNI.TabStop = false;
            this.tbDNI.UnderlinedStyle = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.DarkGray;
            this.tbName.BorderColor = System.Drawing.Color.Gray;
            this.tbName.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbName.BorderRadius = 5;
            this.tbName.BorderSize = 3;
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbName.Location = new System.Drawing.Point(32, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(11);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(779, 39);
            this.tbName.TabIndex = 46;
            this.tbName.TabStop = false;
            this.tbName.UnderlinedStyle = false;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLoan.BackColor = System.Drawing.Color.Silver;
            this.btnAddLoan.BackgroundColor = System.Drawing.Color.Silver;
            this.btnAddLoan.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddLoan.BorderRadius = 5;
            this.btnAddLoan.BorderSize = 0;
            this.btnAddLoan.FlatAppearance.BorderSize = 0;
            this.btnAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoan.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.ForeColor = System.Drawing.Color.Black;
            this.btnAddLoan.Location = new System.Drawing.Point(394, 98);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddLoan.Size = new System.Drawing.Size(190, 38);
            this.btnAddLoan.TabIndex = 27;
            this.btnAddLoan.Text = "Realizar Préstamo";
            this.btnAddLoan.TextColor = System.Drawing.Color.Black;
            this.btnAddLoan.UseVisualStyleBackColor = false;
            this.btnAddLoan.Visible = false;
            this.btnAddLoan.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(590, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(190, 38);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLoan";
            this.Text = "Agregar Prestamo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelEditBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelScore;
        private TextBoxPerso tbActiveLoans;
        private System.Windows.Forms.Label labelActiveLoans;
        private TextBoxPerso tbDNI;
        private System.Windows.Forms.Label labelDNI;
        private TextBoxPerso tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelEditBox;
        private ButtonPerso btnAddLoan;
        private ButtonPerso btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilters;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private TextBoxPerso textBoxFilter;
        private TextBoxPerso tbScore;
    }
}