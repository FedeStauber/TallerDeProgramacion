
namespace TP_Final.UI
{
    partial class BookCard
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
            this.btnEditTitle = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new TP_Final.UI.TextBoxPerso();
            this.label6 = new System.Windows.Forms.Label();
            this.labelISBN = new TP_Final.UI.TextBoxPerso();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPages = new TP_Final.UI.TextBoxPerso();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGender = new TP_Final.UI.TextBoxPerso();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLanguage = new TP_Final.UI.TextBoxPerso();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAcceptEdit = new FontAwesome.Sharp.IconPictureBox();
            this.btnDiscardEdit = new FontAwesome.Sharp.IconPictureBox();
            this.panelEditBox = new System.Windows.Forms.Panel();
            this.btnAddLoan = new TP_Final.UI.ButtonPerso();
            this.btnSaveChanges = new TP_Final.UI.ButtonPerso();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new TP_Final.UI.TextBoxPerso();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAuthor = new TP_Final.UI.TextBoxPerso();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageCopies = new TP_Final.UI.ButtonPerso();
            this.btnSelectNewCover = new TP_Final.UI.ButtonPerso();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscardEdit)).BeginInit();
            this.panelEditBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditTitle);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnEditTitle
            // 
            this.btnEditTitle.BackColor = System.Drawing.Color.White;
            this.btnEditTitle.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnEditTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTitle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditTitle.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTitle.IconSize = 43;
            this.btnEditTitle.Location = new System.Drawing.Point(32, 31);
            this.btnEditTitle.Name = "btnEditTitle";
            this.btnEditTitle.Size = new System.Drawing.Size(43, 43);
            this.btnEditTitle.TabIndex = 2;
            this.btnEditTitle.TabStop = false;
            this.btnEditTitle.Visible = false;
            this.btnEditTitle.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
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
            this.iconPictureBox2.Location = new System.Drawing.Point(1202, 31);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1280, 100);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 621);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.00972F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.99028F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.Controls.Add(this.labelDescription, 2, 12);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 11);
            this.tableLayoutPanel3.Controls.Add(this.labelISBN, 2, 10);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.labelPages, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.labelGender, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelLanguage, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 3, 14);
            this.tableLayoutPanel3.Controls.Add(this.panelEditBox, 2, 14);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAuthor, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(391, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 15;
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(889, 621);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.DarkGray;
            this.labelDescription.BorderColor = System.Drawing.Color.Gray;
            this.labelDescription.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelDescription.BorderRadius = 5;
            this.labelDescription.BorderSize = 3;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDescription.Location = new System.Drawing.Point(58, 359);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelDescription.Multiline = true;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(11);
            this.labelDescription.PasswordChar = false;
            this.labelDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelDescription.PlaceholderText = "";
            this.labelDescription.Size = new System.Drawing.Size(759, 80);
            this.labelDescription.TabIndex = 59;
            this.labelDescription.TabStop = false;
            this.labelDescription.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(58, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Descripción:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelISBN
            // 
            this.labelISBN.BackColor = System.Drawing.Color.DarkGray;
            this.labelISBN.BorderColor = System.Drawing.Color.Gray;
            this.labelISBN.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelISBN.BorderRadius = 5;
            this.labelISBN.BorderSize = 3;
            this.labelISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelISBN.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelISBN.Location = new System.Drawing.Point(58, 292);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelISBN.Multiline = true;
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Padding = new System.Windows.Forms.Padding(11);
            this.labelISBN.PasswordChar = false;
            this.labelISBN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelISBN.PlaceholderText = "";
            this.labelISBN.Size = new System.Drawing.Size(759, 39);
            this.labelISBN.TabIndex = 56;
            this.labelISBN.TabStop = false;
            this.labelISBN.UnderlinedStyle = false;
            this.labelISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelISBN_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(58, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "ISBN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPages
            // 
            this.labelPages.BackColor = System.Drawing.Color.DarkGray;
            this.labelPages.BorderColor = System.Drawing.Color.Gray;
            this.labelPages.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelPages.BorderRadius = 5;
            this.labelPages.BorderSize = 3;
            this.labelPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPages.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPages.Location = new System.Drawing.Point(58, 225);
            this.labelPages.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelPages.Multiline = true;
            this.labelPages.Name = "labelPages";
            this.labelPages.Padding = new System.Windows.Forms.Padding(11);
            this.labelPages.PasswordChar = false;
            this.labelPages.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelPages.PlaceholderText = "";
            this.labelPages.Size = new System.Drawing.Size(759, 39);
            this.labelPages.TabIndex = 52;
            this.labelPages.TabStop = false;
            this.labelPages.UnderlinedStyle = false;
            this.labelPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelISBN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(58, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Páginas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.DarkGray;
            this.labelGender.BorderColor = System.Drawing.Color.Gray;
            this.labelGender.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelGender.BorderRadius = 5;
            this.labelGender.BorderSize = 3;
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGender.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGender.Location = new System.Drawing.Point(58, 158);
            this.labelGender.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelGender.Multiline = true;
            this.labelGender.Name = "labelGender";
            this.labelGender.Padding = new System.Windows.Forms.Padding(11);
            this.labelGender.PasswordChar = false;
            this.labelGender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelGender.PlaceholderText = "";
            this.labelGender.Size = new System.Drawing.Size(759, 39);
            this.labelGender.TabIndex = 49;
            this.labelGender.TabStop = false;
            this.labelGender.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(58, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Genero(s):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelLanguage
            // 
            this.labelLanguage.BackColor = System.Drawing.Color.DarkGray;
            this.labelLanguage.BorderColor = System.Drawing.Color.Gray;
            this.labelLanguage.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelLanguage.BorderRadius = 5;
            this.labelLanguage.BorderSize = 3;
            this.labelLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLanguage.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLanguage.Location = new System.Drawing.Point(58, 91);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelLanguage.Multiline = true;
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Padding = new System.Windows.Forms.Padding(11);
            this.labelLanguage.PasswordChar = false;
            this.labelLanguage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelLanguage.PlaceholderText = "";
            this.labelLanguage.Size = new System.Drawing.Size(759, 39);
            this.labelLanguage.TabIndex = 46;
            this.labelLanguage.TabStop = false;
            this.labelLanguage.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(58, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Idioma(s):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAcceptEdit, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDiscardEdit, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(820, 445);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.65116F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.34884F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(66, 173);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.BackColor = System.Drawing.Color.White;
            this.btnAcceptEdit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAcceptEdit.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAcceptEdit.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAcceptEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcceptEdit.IconSize = 25;
            this.btnAcceptEdit.Location = new System.Drawing.Point(3, 20);
            this.btnAcceptEdit.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(25, 25);
            this.btnAcceptEdit.TabIndex = 0;
            this.btnAcceptEdit.TabStop = false;
            this.btnAcceptEdit.Visible = false;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click_1);
            // 
            // btnDiscardEdit
            // 
            this.btnDiscardEdit.BackColor = System.Drawing.Color.White;
            this.btnDiscardEdit.ForeColor = System.Drawing.Color.Red;
            this.btnDiscardEdit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnDiscardEdit.IconColor = System.Drawing.Color.Red;
            this.btnDiscardEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscardEdit.IconSize = 25;
            this.btnDiscardEdit.Location = new System.Drawing.Point(3, 56);
            this.btnDiscardEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnDiscardEdit.Name = "btnDiscardEdit";
            this.btnDiscardEdit.Size = new System.Drawing.Size(25, 25);
            this.btnDiscardEdit.TabIndex = 1;
            this.btnDiscardEdit.TabStop = false;
            this.btnDiscardEdit.Visible = false;
            this.btnDiscardEdit.Click += new System.EventHandler(this.btnDiscardEdit_Click_1);
            // 
            // panelEditBox
            // 
            this.panelEditBox.Controls.Add(this.btnAddLoan);
            this.panelEditBox.Controls.Add(this.btnSaveChanges);
            this.panelEditBox.Controls.Add(this.tableLayoutPanel5);
            this.panelEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditBox.Location = new System.Drawing.Point(58, 442);
            this.panelEditBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditBox.Name = "panelEditBox";
            this.panelEditBox.Size = new System.Drawing.Size(759, 179);
            this.panelEditBox.TabIndex = 24;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.BackColor = System.Drawing.Color.Silver;
            this.btnAddLoan.BackgroundColor = System.Drawing.Color.Silver;
            this.btnAddLoan.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddLoan.BorderRadius = 5;
            this.btnAddLoan.BorderSize = 0;
            this.btnAddLoan.FlatAppearance.BorderSize = 0;
            this.btnAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoan.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.ForeColor = System.Drawing.Color.Black;
            this.btnAddLoan.Location = new System.Drawing.Point(373, 125);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddLoan.Size = new System.Drawing.Size(190, 38);
            this.btnAddLoan.TabIndex = 27;
            this.btnAddLoan.Text = "Realizar Préstamo";
            this.btnAddLoan.TextColor = System.Drawing.Color.Black;
            this.btnAddLoan.UseVisualStyleBackColor = false;
            this.btnAddLoan.Visible = false;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Silver;
            this.btnSaveChanges.BackgroundColor = System.Drawing.Color.Silver;
            this.btnSaveChanges.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveChanges.BorderRadius = 5;
            this.btnSaveChanges.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(569, 125);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveChanges.Size = new System.Drawing.Size(190, 38);
            this.btnSaveChanges.TabIndex = 26;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.TextColor = System.Drawing.Color.Black;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(759, 179);
            this.tableLayoutPanel5.TabIndex = 28;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.richTextBox1.BorderFocusColor = System.Drawing.Color.Gray;
            this.richTextBox1.BorderRadius = 5;
            this.richTextBox1.BorderSize = 3;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 10);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Padding = new System.Windows.Forms.Padding(11);
            this.richTextBox1.PasswordChar = false;
            this.richTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.PlaceholderText = "";
            this.richTextBox1.Size = new System.Drawing.Size(759, 144);
            this.richTextBox1.TabIndex = 60;
            this.richTextBox1.UnderlinedStyle = false;
            this.richTextBox1.Visible = false;
            this.richTextBox1._TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(58, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Autor(es):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAuthor
            // 
            this.labelAuthor.BackColor = System.Drawing.Color.DarkGray;
            this.labelAuthor.BorderColor = System.Drawing.Color.Gray;
            this.labelAuthor.BorderFocusColor = System.Drawing.Color.Gray;
            this.labelAuthor.BorderRadius = 5;
            this.labelAuthor.BorderSize = 3;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAuthor.Location = new System.Drawing.Point(58, 24);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelAuthor.Multiline = true;
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Padding = new System.Windows.Forms.Padding(11);
            this.labelAuthor.PasswordChar = false;
            this.labelAuthor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.labelAuthor.PlaceholderText = "";
            this.labelAuthor.Size = new System.Drawing.Size(759, 39);
            this.labelAuthor.TabIndex = 43;
            this.labelAuthor.TabStop = false;
            this.labelAuthor.UnderlinedStyle = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnManageCopies, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectNewCover, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 621);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnManageCopies
            // 
            this.btnManageCopies.BackColor = System.Drawing.Color.Silver;
            this.btnManageCopies.BackgroundColor = System.Drawing.Color.Silver;
            this.btnManageCopies.BorderColor = System.Drawing.Color.Transparent;
            this.btnManageCopies.BorderRadius = 5;
            this.btnManageCopies.BorderSize = 0;
            this.btnManageCopies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnManageCopies.FlatAppearance.BorderSize = 0;
            this.btnManageCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCopies.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCopies.ForeColor = System.Drawing.Color.Black;
            this.btnManageCopies.Location = new System.Drawing.Point(25, 571);
            this.btnManageCopies.Margin = new System.Windows.Forms.Padding(25, 0, 0, 3);
            this.btnManageCopies.Name = "btnManageCopies";
            this.btnManageCopies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnManageCopies.Size = new System.Drawing.Size(366, 37);
            this.btnManageCopies.TabIndex = 28;
            this.btnManageCopies.Text = "Administrar copias";
            this.btnManageCopies.TextColor = System.Drawing.Color.Black;
            this.btnManageCopies.UseVisualStyleBackColor = false;
            this.btnManageCopies.Click += new System.EventHandler(this.btnManageCopies_Click);
            // 
            // btnSelectNewCover
            // 
            this.btnSelectNewCover.BackColor = System.Drawing.Color.Silver;
            this.btnSelectNewCover.BackgroundColor = System.Drawing.Color.Silver;
            this.btnSelectNewCover.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelectNewCover.BorderRadius = 5;
            this.btnSelectNewCover.BorderSize = 0;
            this.btnSelectNewCover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectNewCover.FlatAppearance.BorderSize = 0;
            this.btnSelectNewCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectNewCover.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectNewCover.ForeColor = System.Drawing.Color.Black;
            this.btnSelectNewCover.Location = new System.Drawing.Point(25, 531);
            this.btnSelectNewCover.Margin = new System.Windows.Forms.Padding(25, 0, 0, 3);
            this.btnSelectNewCover.Name = "btnSelectNewCover";
            this.btnSelectNewCover.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSelectNewCover.Size = new System.Drawing.Size(366, 37);
            this.btnSelectNewCover.TabIndex = 27;
            this.btnSelectNewCover.Text = "Subir nuevo cover";
            this.btnSelectNewCover.TextColor = System.Drawing.Color.Black;
            this.btnSelectNewCover.UseVisualStyleBackColor = false;
            this.btnSelectNewCover.Click += new System.EventHandler(this.btnSelectNewCover_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(25, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(25, 0, 0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookCard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscardEdit)).EndInit();
            this.panelEditBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox btnEditTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconPictureBox btnAcceptEdit;
        private FontAwesome.Sharp.IconPictureBox btnDiscardEdit;
        private System.Windows.Forms.Panel panelEditBox;
        private System.Windows.Forms.Label label1;
        private TextBoxPerso labelGender;
        private System.Windows.Forms.Label label3;
        private TextBoxPerso labelLanguage;
        private System.Windows.Forms.Label label2;
        private TextBoxPerso labelAuthor;
        private TextBoxPerso labelPages;
        private System.Windows.Forms.Label label4;
        private TextBoxPerso labelISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TextBoxPerso labelDescription;
        private ButtonPerso btnAddLoan;
        private ButtonPerso btnSaveChanges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ButtonPerso btnSelectNewCover;
        private ButtonPerso btnManageCopies;
        private TextBoxPerso richTextBox1;
    }
}