
namespace TP_Final.UI
{
    partial class AddBook
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftBtn = new FontAwesome.Sharp.IconPictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightBtn = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.pbLibraryLogo = new System.Windows.Forms.PictureBox();
            this.resultPagComboBox = new TP_Final.UI.ComboBoxPerso();
            this.cbFiltro = new TP_Final.UI.ComboBoxPerso();
            this.textBoxPerso1 = new TP_Final.UI.TextBoxPerso();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibraryLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cbFiltro);
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.textBoxPerso1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1264, 90);
            this.topPanel.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.Location = new System.Drawing.Point(898, 58);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(32, 32);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 90);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 622);
            this.leftPanel.TabIndex = 1;
            // 
            // leftBtn
            // 
            this.leftBtn.BackColor = System.Drawing.Color.White;
            this.leftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.leftBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.leftBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.leftBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leftBtn.IconSize = 40;
            this.leftBtn.Location = new System.Drawing.Point(55, 215);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(40, 40);
            this.leftBtn.TabIndex = 13;
            this.leftBtn.TabStop = false;
            this.leftBtn.Visible = false;
            this.leftBtn.Click += new System.EventHandler(this.LeftBtn_Click_1);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1164, 90);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(100, 622);
            this.rightPanel.TabIndex = 2;
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.White;
            this.rightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.rightBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.rightBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.rightBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rightBtn.IconSize = 40;
            this.rightBtn.Location = new System.Drawing.Point(5, 215);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(40, 40);
            this.rightBtn.TabIndex = 14;
            this.rightBtn.TabStop = false;
            this.rightBtn.Visible = false;
            this.rightBtn.Click += new System.EventHandler(this.RightBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultPagComboBox);
            this.panel1.Controls.Add(this.pagesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(100, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 80);
            this.panel1.TabIndex = 3;
            // 
            // pagesLabel
            // 
            this.pagesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pagesLabel.Font = new System.Drawing.Font("Roboto Cn", 10F);
            this.pagesLabel.Location = new System.Drawing.Point(0, 0);
            this.pagesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(1064, 80);
            this.pagesLabel.TabIndex = 0;
            this.pagesLabel.Text = "label1";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagesLabel.Visible = false;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Controls.Add(this.pbLibraryLogo);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.centerPanel.Location = new System.Drawing.Point(100, 90);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1064, 542);
            this.centerPanel.TabIndex = 4;
            // 
            // pbLibraryLogo
            // 
            this.pbLibraryLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLibraryLogo.Image = global::TP_Final.Properties.Resources._20221220_150315_0000;
            this.pbLibraryLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLibraryLogo.Name = "pbLibraryLogo";
            this.pbLibraryLogo.Size = new System.Drawing.Size(1064, 542);
            this.pbLibraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLibraryLogo.TabIndex = 0;
            this.pbLibraryLogo.TabStop = false;
            // 
            // resultPagComboBox
            // 
            this.resultPagComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultPagComboBox.BackColor = System.Drawing.Color.White;
            this.resultPagComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.resultPagComboBox.BorderSize = 2;
            this.resultPagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultPagComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.resultPagComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.resultPagComboBox.Items.AddRange(new object[] {
            "4",
            "16"});
            this.resultPagComboBox.ListBackColor = System.Drawing.Color.White;
            this.resultPagComboBox.ListTextColor = System.Drawing.Color.Black;
            this.resultPagComboBox.Location = new System.Drawing.Point(857, 26);
            this.resultPagComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.resultPagComboBox.Name = "resultPagComboBox";
            this.resultPagComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.resultPagComboBox.SelectedIndex = -1;
            this.resultPagComboBox.SelectedItem = null;
            this.resultPagComboBox.Size = new System.Drawing.Size(200, 30);
            this.resultPagComboBox.TabIndex = 1;
            this.resultPagComboBox.Texts = "Resultados Por Página";
            this.resultPagComboBox.OnSelectedIndexChanged += new System.EventHandler(this.resultPagComboBox_OnSelectedIndexChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFiltro.BackColor = System.Drawing.Color.White;
            this.cbFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.cbFiltro.BorderSize = 0;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltro.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.cbFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.cbFiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.cbFiltro.Items.AddRange(new object[] {
            "Autor",
            "Título",
            "Género"});
            this.cbFiltro.ListBackColor = System.Drawing.Color.White;
            this.cbFiltro.ListTextColor = System.Drawing.Color.Black;
            this.cbFiltro.Location = new System.Drawing.Point(320, 54);
            this.cbFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.Size = new System.Drawing.Size(200, 33);
            this.cbFiltro.TabIndex = 12;
            this.cbFiltro.Texts = "Buscar Por";
            this.cbFiltro.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltro_OnSelectedIndexChanged);
            // 
            // textBoxPerso1
            // 
            this.textBoxPerso1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPerso1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPerso1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.textBoxPerso1.BorderFocusColor = System.Drawing.Color.RosyBrown;
            this.textBoxPerso1.BorderRadius = 0;
            this.textBoxPerso1.BorderSize = 2;
            this.textBoxPerso1.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.textBoxPerso1.Location = new System.Drawing.Point(526, 54);
            this.textBoxPerso1.Multiline = false;
            this.textBoxPerso1.Name = "textBoxPerso1";
            this.textBoxPerso1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPerso1.PasswordChar = false;
            this.textBoxPerso1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPerso1.PlaceholderText = "Ingrese el texto a buscar";
            this.textBoxPerso1.Size = new System.Drawing.Size(366, 33);
            this.textBoxPerso1.TabIndex = 10;
            this.textBoxPerso1.UnderlinedStyle = true;
            this.textBoxPerso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBoxKeyPress);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.Text = "Agregar un libro";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLibraryLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Panel centerPanel;
        private ComboBoxPerso resultPagComboBox;
        private FontAwesome.Sharp.IconPictureBox leftBtn;
        private FontAwesome.Sharp.IconPictureBox rightBtn;
        private ComboBoxPerso cbFiltro;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private TextBoxPerso textBoxPerso1;
        private System.Windows.Forms.PictureBox pbLibraryLogo;
    }
}