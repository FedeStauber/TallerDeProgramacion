
namespace TP_Final
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPass = new TP_Final.UI.TextBoxPerso();
            this.txtBoxEmail = new TP_Final.UI.TextBoxPerso();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegister = new TP_Final.UI.ButtonPerso();
            this.btnAccept = new TP_Final.UI.ButtonPerso();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(0, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(0, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxPass.BorderColor = System.Drawing.Color.Gray;
            this.txtBoxPass.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtBoxPass.BorderRadius = 5;
            this.txtBoxPass.BorderSize = 3;
            this.txtBoxPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(0, 286);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.txtBoxPass.Multiline = false;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Padding = new System.Windows.Forms.Padding(16);
            this.txtBoxPass.PasswordChar = true;
            this.txtBoxPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxPass.PlaceholderText = "";
            this.txtBoxPass.Size = new System.Drawing.Size(581, 57);
            this.txtBoxPass.TabIndex = 8;
            this.txtBoxPass.UnderlinedStyle = false;
            this.txtBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPass_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxEmail.BorderColor = System.Drawing.Color.Gray;
            this.txtBoxEmail.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtBoxEmail.BorderRadius = 5;
            this.txtBoxEmail.BorderSize = 3;
            this.txtBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(0, 196);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Padding = new System.Windows.Forms.Padding(16);
            this.txtBoxEmail.PasswordChar = false;
            this.txtBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxEmail.PlaceholderText = "";
            this.txtBoxEmail.Size = new System.Drawing.Size(581, 57);
            this.txtBoxEmail.TabIndex = 7;
            this.txtBoxEmail.UnderlinedStyle = false;
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEmail_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.040817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1500, 751);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRegister, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnAccept, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxPass, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxEmail, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(764, 75);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 600);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Silver;
            this.btnRegister.BackgroundColor = System.Drawing.Color.Silver;
            this.btnRegister.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(0, 430);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(581, 53);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Silver;
            this.btnAccept.BackgroundColor = System.Drawing.Color.Silver;
            this.btnAccept.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderRadius = 5;
            this.btnAccept.BorderSize = 0;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(0, 369);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(581, 53);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::TP_Final.Properties.Resources.viejo1D;
            this.pictureBox2.Location = new System.Drawing.Point(153, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1500, 751);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI.TextBoxPerso txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UI.TextBoxPerso txtBoxPass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UI.ButtonPerso btnRegister;
        private UI.ButtonPerso btnAccept;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

