
namespace TP_Final.UI
{
    partial class Catalogue
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
            this.searchTextBox = new TP_Final.UI.TextBoxPerso();
            this.cbFiltro = new TP_Final.UI.ComboBoxPerso();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftBtn = new FontAwesome.Sharp.IconPictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightBtn = new FontAwesome.Sharp.IconPictureBox();
            this.botPanel = new System.Windows.Forms.Panel();
            this.resultPagComboBox = new TP_Final.UI.ComboBoxPerso();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).BeginInit();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.searchBtn);
            this.topPanel.Controls.Add(this.searchTextBox);
            this.topPanel.Controls.Add(this.cbFiltro);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1685, 111);
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
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(32, 32);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchTextBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.searchTextBox.BorderRadius = 0;
            this.searchTextBox.BorderSize = 2;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(526, 54);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(9);
            this.searchTextBox.PasswordChar = false;
            this.searchTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTextBox.PlaceholderText = "Ingrese el texto a buscar";
            this.searchTextBox.Size = new System.Drawing.Size(463, 37);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.UnderlinedStyle = false;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFiltro.BackColor = System.Drawing.Color.White;
            this.cbFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.cbFiltro.BorderSize = 2;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.cbFiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.cbFiltro.Items.AddRange(new object[] {
            "Autor",
            "Título",
            "ISBN",
            "Género"});
            this.cbFiltro.ListBackColor = System.Drawing.Color.White;
            this.cbFiltro.ListTextColor = System.Drawing.Color.Black;
            this.cbFiltro.Location = new System.Drawing.Point(320, 54);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.Size = new System.Drawing.Size(200, 33);
            this.cbFiltro.TabIndex = 3;
            this.cbFiltro.Texts = "Buscar Por";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.leftBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 111);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(133, 765);
            this.leftPanel.TabIndex = 1;
            // 
            // leftBtn
            // 
            this.leftBtn.BackColor = System.Drawing.Color.White;
            this.leftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.leftBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.leftBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.leftBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leftBtn.IconSize = 49;
            this.leftBtn.Location = new System.Drawing.Point(73, 265);
            this.leftBtn.Margin = new System.Windows.Forms.Padding(4);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(53, 49);
            this.leftBtn.TabIndex = 12;
            this.leftBtn.TabStop = false;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click_1);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.rightBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1552, 111);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(133, 765);
            this.rightPanel.TabIndex = 2;
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.White;
            this.rightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.rightBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.rightBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.rightBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rightBtn.IconSize = 49;
            this.rightBtn.Location = new System.Drawing.Point(7, 265);
            this.rightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(53, 49);
            this.rightBtn.TabIndex = 13;
            this.rightBtn.TabStop = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click_1);
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.Color.White;
            this.botPanel.Controls.Add(this.resultPagComboBox);
            this.botPanel.Controls.Add(this.pagesLabel);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(133, 778);
            this.botPanel.Margin = new System.Windows.Forms.Padding(4);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(1419, 98);
            this.botPanel.TabIndex = 3;
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
            this.resultPagComboBox.Location = new System.Drawing.Point(858, 24);
            this.resultPagComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.resultPagComboBox.Name = "resultPagComboBox";
            this.resultPagComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.resultPagComboBox.SelectedIndex = -1;
            this.resultPagComboBox.SelectedItem = null;
            this.resultPagComboBox.Size = new System.Drawing.Size(200, 30);
            this.resultPagComboBox.TabIndex = 2;
            this.resultPagComboBox.Texts = "Resultados Por Página";
            this.resultPagComboBox.OnSelectedIndexChanged += new System.EventHandler(this.resultPagComboBox_OnSelectedIndexChanged);
            // 
            // pagesLabel
            // 
            this.pagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pagesLabel.Location = new System.Drawing.Point(0, 0);
            this.pagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(1419, 98);
            this.pagesLabel.TabIndex = 0;
            this.pagesLabel.Text = "label1";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(133, 111);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1419, 667);
            this.centerPanel.TabIndex = 4;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 876);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Catalogue";
            this.Text = "Catálogo";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftBtn)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightBtn)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label pagesLabel;
        private ComboBoxPerso resultPagComboBox;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private TextBoxPerso searchTextBox;
        private ComboBoxPerso cbFiltro;
        private FontAwesome.Sharp.IconPictureBox leftBtn;
        private FontAwesome.Sharp.IconPictureBox rightBtn;
    }
}