
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
            this.btnAccept = new TP_Final.UI.ButtonPerso();
            this.txtBoxPass = new TP_Final.UI.TextBoxPerso();
            this.txtBoxEmail = new TP_Final.UI.TextBoxPerso();
            this.btnRegister = new TP_Final.UI.ButtonPerso();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.White;
            this.btnAccept.BackgroundColor = System.Drawing.Color.White;
            this.btnAccept.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAccept.BorderRadius = 20;
            this.btnAccept.BorderSize = 2;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(602, 330);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(306, 40);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.White;
            this.txtBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.txtBoxPass.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.txtBoxPass.BorderRadius = 0;
            this.txtBoxPass.BorderSize = 3;
            this.txtBoxPass.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.Location = new System.Drawing.Point(602, 277);
            this.txtBoxPass.Multiline = false;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxPass.PasswordChar = true;
            this.txtBoxPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxPass.PlaceholderText = "Ingrese su contraseña";
            this.txtBoxPass.Size = new System.Drawing.Size(306, 30);
            this.txtBoxPass.TabIndex = 8;
            this.txtBoxPass.UnderlinedStyle = true;
            this.txtBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPass_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.White;
            this.txtBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.txtBoxEmail.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.txtBoxEmail.BorderRadius = 0;
            this.txtBoxEmail.BorderSize = 3;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(602, 231);
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxEmail.PasswordChar = false;
            this.txtBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxEmail.PlaceholderText = "Ingrese su correo";
            this.txtBoxEmail.Size = new System.Drawing.Size(306, 30);
            this.txtBoxEmail.TabIndex = 7;
            this.txtBoxEmail.UnderlinedStyle = true;
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEmail_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundColor = System.Drawing.Color.White;
            this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 2;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(602, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(306, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1500, 751);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);

        }

        #endregion
        private UI.ButtonPerso btnRegister;
        private UI.TextBoxPerso txtBoxEmail;
        private UI.TextBoxPerso txtBoxPass;
        private UI.ButtonPerso btnAccept;
    }
}

