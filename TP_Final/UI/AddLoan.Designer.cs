
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
            this.tbScore = new TP_Final.UI.TextBoxPerso();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxFilter = new TP_Final.UI.TextBoxPerso();
            this.labelScore = new System.Windows.Forms.Label();
            this.tbActiveLoans = new TP_Final.UI.TextBoxPerso();
            this.labelActiveLoans = new System.Windows.Forms.Label();
            this.tbDNI = new TP_Final.UI.TextBoxPerso();
            this.labelDNI = new System.Windows.Forms.Label();
            this.tbName = new TP_Final.UI.TextBoxPerso();
            this.labelName = new System.Windows.Forms.Label();
            this.panelEditBox = new System.Windows.Forms.Panel();
            this.btnAddLoan = new TP_Final.UI.ButtonPerso();
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.panelEditBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1707, 113);
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
            this.iconPictureBox2.IconSize = 62;
            this.iconPictureBox2.Location = new System.Drawing.Point(1613, 38);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(67, 62);
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
            this.labelTitle.Size = new System.Drawing.Size(1707, 113);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 774);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.00972F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.99028F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(521, 0);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1186, 774);
            this.tableLayoutPanel3.TabIndex = 4;
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
            this.tbScore.Location = new System.Drawing.Point(43, 329);
            this.tbScore.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tbScore.Multiline = true;
            this.tbScore.Name = "tbScore";
            this.tbScore.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbScore.PasswordChar = false;
            this.tbScore.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbScore.PlaceholderText = "";
            this.tbScore.Size = new System.Drawing.Size(1035, 48);
            this.tbScore.TabIndex = 61;
            this.tbScore.TabStop = false;
            this.tbScore.UnderlinedStyle = false;
            this.tbScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 2;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanelFilters.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.textBoxFilter, 0, 0);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(43, 0);
            this.tableLayoutPanelFilters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 1;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(1035, 46);
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
            this.searchBtn.IconSize = 46;
            this.searchBtn.Location = new System.Drawing.Point(986, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(49, 46);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 12;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.btnSearchUser_Click);
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
            this.textBoxFilter.Location = new System.Drawing.Point(4, 0);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.textBoxFilter.Multiline = false;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.textBoxFilter.PasswordChar = false;
            this.textBoxFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFilter.PlaceholderText = "Ingrese el DNI o Email del usuario a filtrar";
            this.textBoxFilter.Size = new System.Drawing.Size(982, 37);
            this.textBoxFilter.TabIndex = 11;
            this.textBoxFilter.UnderlinedStyle = true;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerso8_KeyPress);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelScore.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelScore.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelScore.Location = new System.Drawing.Point(43, 298);
            this.labelScore.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(78, 25);
            this.labelScore.TabIndex = 57;
            this.labelScore.Text = "Puntaje";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tbActiveLoans.Location = new System.Drawing.Point(43, 245);
            this.tbActiveLoans.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tbActiveLoans.Multiline = true;
            this.tbActiveLoans.Name = "tbActiveLoans";
            this.tbActiveLoans.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbActiveLoans.PasswordChar = false;
            this.tbActiveLoans.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbActiveLoans.PlaceholderText = "";
            this.tbActiveLoans.Size = new System.Drawing.Size(1035, 48);
            this.tbActiveLoans.TabIndex = 56;
            this.tbActiveLoans.TabStop = false;
            this.tbActiveLoans.UnderlinedStyle = false;
            this.tbActiveLoans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // labelActiveLoans
            // 
            this.labelActiveLoans.AutoSize = true;
            this.labelActiveLoans.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelActiveLoans.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelActiveLoans.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelActiveLoans.Location = new System.Drawing.Point(43, 214);
            this.labelActiveLoans.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelActiveLoans.Name = "labelActiveLoans";
            this.labelActiveLoans.Size = new System.Drawing.Size(76, 25);
            this.labelActiveLoans.TabIndex = 55;
            this.labelActiveLoans.Text = "Activos";
            this.labelActiveLoans.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tbDNI.Location = new System.Drawing.Point(43, 161);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tbDNI.Multiline = true;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbDNI.PasswordChar = false;
            this.tbDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDNI.PlaceholderText = "";
            this.tbDNI.Size = new System.Drawing.Size(1035, 48);
            this.tbDNI.TabIndex = 49;
            this.tbDNI.TabStop = false;
            this.tbDNI.UnderlinedStyle = false;
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDNI.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelDNI.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDNI.Location = new System.Drawing.Point(43, 130);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(45, 25);
            this.labelDNI.TabIndex = 48;
            this.labelDNI.Text = "DNI";
            this.labelDNI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tbName.Location = new System.Drawing.Point(43, 77);
            this.tbName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(1035, 48);
            this.tbName.TabIndex = 46;
            this.tbName.TabStop = false;
            this.tbName.UnderlinedStyle = false;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.labelName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelName.Location = new System.Drawing.Point(43, 46);
            this.labelName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 25);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Nombre";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelEditBox
            // 
            this.panelEditBox.Controls.Add(this.btnAddLoan);
            this.panelEditBox.Controls.Add(this.btnCancel);
            this.panelEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditBox.Location = new System.Drawing.Point(43, 529);
            this.panelEditBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditBox.Name = "panelEditBox";
            this.panelEditBox.Size = new System.Drawing.Size(1035, 171);
            this.panelEditBox.TabIndex = 24;
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
            this.btnAddLoan.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.ForeColor = System.Drawing.Color.Black;
            this.btnAddLoan.Location = new System.Drawing.Point(522, 121);
            this.btnAddLoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddLoan.Size = new System.Drawing.Size(253, 47);
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
            this.btnCancel.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(783, 121);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(253, 47);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 774);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(33, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(33, 0, 0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1707, 887);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLoan";
            this.Text = "Realizar un nuevo préstamo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.panelEditBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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