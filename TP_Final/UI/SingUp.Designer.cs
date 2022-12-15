namespace TP_Final.UI
{
    partial class SingUp
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
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.btnAccept = new TP_Final.UI.ButtonPerso();
            this.PassRepeatTxtBox = new TP_Final.UI.TextBoxPerso();
            this.PassTxtBox = new TP_Final.UI.TextBoxPerso();
            this.btnUploadAvatar = new TP_Final.UI.ButtonPerso();
            this.DniTxtBox = new TP_Final.UI.TextBoxPerso();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastNameTxtBox = new TP_Final.UI.TextBoxPerso();
            this.EmailTxtBox = new TP_Final.UI.TextBoxPerso();
            this.NameTxtBox = new TP_Final.UI.TextBoxPerso();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.PassRepeatTxtBox);
            this.panel1.Controls.Add(this.PassTxtBox);
            this.panel1.Controls.Add(this.btnUploadAvatar);
            this.panel1.Controls.Add(this.DniTxtBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LastNameTxtBox);
            this.panel1.Controls.Add(this.EmailTxtBox);
            this.panel1.Controls.Add(this.NameTxtBox);
            this.panel1.Location = new System.Drawing.Point(67, 38);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1356, 701);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Cn", 15.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(538, 611);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(478, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnAccept.Font = new System.Drawing.Font("Roboto Cn", 15.75F);
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(538, 555);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(478, 50);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // PassRepeatTxtBox
            // 
            this.PassRepeatTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.PassRepeatTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.PassRepeatTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.PassRepeatTxtBox.BorderRadius = 5;
            this.PassRepeatTxtBox.BorderSize = 3;
            this.PassRepeatTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.PassRepeatTxtBox.Location = new System.Drawing.Point(538, 475);
            this.PassRepeatTxtBox.Multiline = false;
            this.PassRepeatTxtBox.Name = "PassRepeatTxtBox";
            this.PassRepeatTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.PassRepeatTxtBox.PasswordChar = true;
            this.PassRepeatTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PassRepeatTxtBox.PlaceholderText = "";
            this.PassRepeatTxtBox.Size = new System.Drawing.Size(478, 51);
            this.PassRepeatTxtBox.TabIndex = 6;
            this.PassRepeatTxtBox.UnderlinedStyle = false;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.PassTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.PassTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.PassTxtBox.BorderRadius = 5;
            this.PassTxtBox.BorderSize = 3;
            this.PassTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.PassTxtBox.Location = new System.Drawing.Point(538, 393);
            this.PassTxtBox.Multiline = false;
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.PassTxtBox.PasswordChar = true;
            this.PassTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PassTxtBox.PlaceholderText = "";
            this.PassTxtBox.Size = new System.Drawing.Size(478, 51);
            this.PassTxtBox.TabIndex = 5;
            this.PassTxtBox.UnderlinedStyle = false;
            // 
            // btnUploadAvatar
            // 
            this.btnUploadAvatar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUploadAvatar.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnUploadAvatar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.btnUploadAvatar.BorderRadius = 0;
            this.btnUploadAvatar.BorderSize = 0;
            this.btnUploadAvatar.FlatAppearance.BorderSize = 0;
            this.btnUploadAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAvatar.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadAvatar.ForeColor = System.Drawing.Color.White;
            this.btnUploadAvatar.Location = new System.Drawing.Point(290, 284);
            this.btnUploadAvatar.Name = "btnUploadAvatar";
            this.btnUploadAvatar.Size = new System.Drawing.Size(208, 40);
            this.btnUploadAvatar.TabIndex = 7;
            this.btnUploadAvatar.Text = "Subir nuevo avatar";
            this.btnUploadAvatar.TextColor = System.Drawing.Color.White;
            this.btnUploadAvatar.UseVisualStyleBackColor = false;
            this.btnUploadAvatar.Click += new System.EventHandler(this.btnUploadAvatar_Click);
            // 
            // DniTxtBox
            // 
            this.DniTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.DniTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.DniTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.DniTxtBox.BorderRadius = 5;
            this.DniTxtBox.BorderSize = 3;
            this.DniTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.DniTxtBox.Location = new System.Drawing.Point(538, 228);
            this.DniTxtBox.Multiline = false;
            this.DniTxtBox.Name = "DniTxtBox";
            this.DniTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.DniTxtBox.PasswordChar = false;
            this.DniTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DniTxtBox.PlaceholderText = "";
            this.DniTxtBox.Size = new System.Drawing.Size(478, 51);
            this.DniTxtBox.TabIndex = 3;
            this.DniTxtBox.UnderlinedStyle = false;
            this.DniTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxtBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(290, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 203);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.LastNameTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.LastNameTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.LastNameTxtBox.BorderRadius = 5;
            this.LastNameTxtBox.BorderSize = 3;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.LastNameTxtBox.Location = new System.Drawing.Point(538, 146);
            this.LastNameTxtBox.Multiline = false;
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.LastNameTxtBox.PasswordChar = false;
            this.LastNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LastNameTxtBox.PlaceholderText = "";
            this.LastNameTxtBox.Size = new System.Drawing.Size(478, 51);
            this.LastNameTxtBox.TabIndex = 2;
            this.LastNameTxtBox.UnderlinedStyle = false;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.EmailTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.EmailTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.EmailTxtBox.BorderRadius = 5;
            this.EmailTxtBox.BorderSize = 3;
            this.EmailTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.EmailTxtBox.Location = new System.Drawing.Point(538, 310);
            this.EmailTxtBox.Multiline = false;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.EmailTxtBox.PasswordChar = false;
            this.EmailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailTxtBox.PlaceholderText = "";
            this.EmailTxtBox.Size = new System.Drawing.Size(478, 51);
            this.EmailTxtBox.TabIndex = 4;
            this.EmailTxtBox.UnderlinedStyle = false;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.NameTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.NameTxtBox.BorderFocusColor = System.Drawing.Color.Gray;
            this.NameTxtBox.BorderRadius = 5;
            this.NameTxtBox.BorderSize = 3;
            this.NameTxtBox.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.NameTxtBox.Location = new System.Drawing.Point(538, 64);
            this.NameTxtBox.Multiline = true;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Padding = new System.Windows.Forms.Padding(16);
            this.NameTxtBox.PasswordChar = false;
            this.NameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameTxtBox.PlaceholderText = "";
            this.NameTxtBox.Size = new System.Drawing.Size(478, 51);
            this.NameTxtBox.TabIndex = 1;
            this.NameTxtBox.UnderlinedStyle = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(533, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(533, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(533, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(533, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(533, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(533, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nombre";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 751);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingUp";
            this.Text = "Registrarse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxPerso LastNameTxtBox;
        private TextBoxPerso DniTxtBox;
        private TextBoxPerso EmailTxtBox;
        private TextBoxPerso NameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonPerso btnUploadAvatar;
        private System.Windows.Forms.Panel panel1;
        private TextBoxPerso PassRepeatTxtBox;
        private TextBoxPerso PassTxtBox;
        private ButtonPerso btnCancel;
        private ButtonPerso btnAccept;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}