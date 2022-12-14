
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxPerso1 = new TP_Final.UI.TextBoxPerso();
            this.cbFiltro = new TP_Final.UI.ComboBoxPerso();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftBtn = new FontAwesome.Sharp.IconPictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightBtn = new FontAwesome.Sharp.IconPictureBox();
            this.botPanel = new System.Windows.Forms.Panel();
            this.comboBoxPerso1 = new TP_Final.UI.ComboBoxPerso();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            this.topPanel.Controls.Add(this.iconPictureBox1);
            this.topPanel.Controls.Add(this.textBoxPerso1);
            this.topPanel.Controls.Add(this.cbFiltro);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1264, 90);
            this.topPanel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(729, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // textBoxPerso1
            // 
            this.textBoxPerso1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPerso1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.textBoxPerso1.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.textBoxPerso1.BorderRadius = 0;
            this.textBoxPerso1.BorderSize = 2;
            this.textBoxPerso1.Font = new System.Drawing.Font("Roboto Condensed"., 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerso1.Location = new System.Drawing.Point(376, 31);
            this.textBoxPerso1.Multiline = false;
            this.textBoxPerso1.Name = "textBoxPerso1";
            this.textBoxPerso1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPerso1.PasswordChar = false;
            this.textBoxPerso1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPerso1.PlaceholderText = "Ingrese el texto a buscar";
            this.textBoxPerso1.Size = new System.Drawing.Size(347, 30);
            this.textBoxPerso1.TabIndex = 4;
            this.textBoxPerso1.UnderlinedStyle = false;
            this.textBoxPerso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPerso1_KeyPress);
            // 
            // cbFiltro
            // 
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
            this.cbFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.cbFiltro.ListTextColor = System.Drawing.Color.White;
            this.cbFiltro.Location = new System.Drawing.Point(170, 31);
            this.cbFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.cbFiltro.SelectedIndex = -1;
            this.cbFiltro.SelectedItem = null;
            this.cbFiltro.Size = new System.Drawing.Size(200, 30);
            this.cbFiltro.TabIndex = 3;
            this.cbFiltro.Texts = "Buscar Por";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.leftBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 90);
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
            this.leftBtn.TabIndex = 12;
            this.leftBtn.TabStop = false;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click_1);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.rightBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1164, 90);
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
            this.rightBtn.TabIndex = 13;
            this.rightBtn.TabStop = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click_1);
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.Color.White;
            this.botPanel.Controls.Add(this.comboBoxPerso1);
            this.botPanel.Controls.Add(this.pagesLabel);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(100, 632);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(1064, 80);
            this.botPanel.TabIndex = 3;
            // 
            // comboBoxPerso1
            // 
            this.comboBoxPerso1.BackColor = System.Drawing.Color.White;
            this.comboBoxPerso1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.comboBoxPerso1.BorderSize = 2;
            this.comboBoxPerso1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerso1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPerso1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.comboBoxPerso1.Items.AddRange(new object[] {
            "4",
            "16"});
            this.comboBoxPerso1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.comboBoxPerso1.ListTextColor = System.Drawing.Color.White;
            this.comboBoxPerso1.Location = new System.Drawing.Point(858, 24);
            this.comboBoxPerso1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPerso1.Name = "comboBoxPerso1";
            this.comboBoxPerso1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPerso1.SelectedIndex = -1;
            this.comboBoxPerso1.SelectedItem = null;
            this.comboBoxPerso1.Size = new System.Drawing.Size(200, 30);
            this.comboBoxPerso1.TabIndex = 2;
            this.comboBoxPerso1.Texts = "Resultados Por Página";
            this.comboBoxPerso1.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxPerso1_OnSelectedIndexChanged);
            // 
            // pagesLabel
            // 
            this.pagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesLabel.Font = new System.Drawing.Font("Roboto Condensed"., 10F);
            this.pagesLabel.Location = new System.Drawing.Point(0, 0);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(1064, 80);
            this.pagesLabel.TabIndex = 0;
            this.pagesLabel.Text = "label1";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(100, 90);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1064, 542);
            this.centerPanel.TabIndex = 4;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogue";
            this.Text = "Catálogo";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
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
        private ComboBoxPerso comboBoxPerso1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBoxPerso textBoxPerso1;
        private ComboBoxPerso cbFiltro;
        private FontAwesome.Sharp.IconPictureBox leftBtn;
        private FontAwesome.Sharp.IconPictureBox rightBtn;
    }
}