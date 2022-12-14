
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new TP_Final.UI.ButtonPerso();
            this.txtBoxPass = new TP_Final.UI.TextBoxPerso();
            this.btnAccept = new TP_Final.UI.ButtonPerso();
            this.txtBoxEmail = new TP_Final.UI.TextBoxPerso();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(526, 516);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1067, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(857, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(857, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Silver;
            this.btnRegister.BackgroundColor = System.Drawing.Color.Silver;
            this.btnRegister.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(862, 498);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(478, 50);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.Gray;
            this.txtBoxPass.BorderColor = System.Drawing.Color.Gray;
            this.txtBoxPass.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtBoxPass.BorderRadius = 5;
            this.txtBoxPass.BorderSize = 3;
            this.txtBoxPass.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(862, 346);
            this.txtBoxPass.Multiline = false;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Padding = new System.Windows.Forms.Padding(16);
            this.txtBoxPass.PasswordChar = true;
            this.txtBoxPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxPass.PlaceholderText = "";
            this.txtBoxPass.Size = new System.Drawing.Size(478, 50);
            this.txtBoxPass.TabIndex = 8;
            this.txtBoxPass.UnderlinedStyle = true;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Silver;
            this.btnAccept.BackgroundColor = System.Drawing.Color.Silver;
            this.btnAccept.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderRadius = 5;
            this.btnAccept.BorderSize = 0;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(862, 429);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(478, 50);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.Gray;
            this.txtBoxEmail.BorderColor = System.Drawing.Color.Gray;
            this.txtBoxEmail.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtBoxEmail.BorderRadius = 5;
            this.txtBoxEmail.BorderSize = 3;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(862, 252);
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Padding = new System.Windows.Forms.Padding(16);
            this.txtBoxEmail.PasswordChar = false;
            this.txtBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxEmail.PlaceholderText = "";
            this.txtBoxEmail.Size = new System.Drawing.Size(478, 50);
            this.txtBoxEmail.TabIndex = 7;
            this.txtBoxEmail.UnderlinedStyle = true;
            this.txtBoxEmail._TextChanged += new System.EventHandler(this.txtBoxEmail__TextChanged);
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEmail_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1500, 751);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI.TextBoxPerso txtBoxEmail;
        private UI.ButtonPerso btnAccept;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UI.TextBoxPerso txtBoxPass;
        private UI.ButtonPerso btnRegister;
    }
}

