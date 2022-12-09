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
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.password2Label);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.mailLabel);
            this.panel1.Controls.Add(this.dniLabel);
            this.panel1.Controls.Add(this.lastnameLabel);
            this.panel1.Controls.Add(this.nameLabel);
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
            this.panel1.Location = new System.Drawing.Point(308, 135);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(832, 463);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(654, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnAccept.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(474, 420);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(175, 40);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // PassRepeatTxtBox
            // 
            this.PassRepeatTxtBox.BackColor = System.Drawing.Color.White;
            this.PassRepeatTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.PassRepeatTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.PassRepeatTxtBox.BorderRadius = 0;
            this.PassRepeatTxtBox.BorderSize = 3;
            this.PassRepeatTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassRepeatTxtBox.Location = new System.Drawing.Point(423, 269);
            this.PassRepeatTxtBox.Multiline = false;
            this.PassRepeatTxtBox.Name = "PassRepeatTxtBox";
            this.PassRepeatTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.PassRepeatTxtBox.PasswordChar = true;
            this.PassRepeatTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PassRepeatTxtBox.PlaceholderText = "Repita su contraseña";
            this.PassRepeatTxtBox.Size = new System.Drawing.Size(306, 30);
            this.PassRepeatTxtBox.TabIndex = 6;
            this.PassRepeatTxtBox.UnderlinedStyle = true;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.BackColor = System.Drawing.Color.White;
            this.PassTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.PassTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.PassTxtBox.BorderRadius = 0;
            this.PassTxtBox.BorderSize = 3;
            this.PassTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxtBox.Location = new System.Drawing.Point(423, 233);
            this.PassTxtBox.Multiline = false;
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.PassTxtBox.PasswordChar = true;
            this.PassTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PassTxtBox.PlaceholderText = "Ingrese su contraseña";
            this.PassTxtBox.Size = new System.Drawing.Size(306, 30);
            this.PassTxtBox.TabIndex = 5;
            this.PassTxtBox.UnderlinedStyle = true;
            // 
            // btnUploadAvatar
            // 
            this.btnUploadAvatar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUploadAvatar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUploadAvatar.BorderColor = System.Drawing.Color.Indigo;
            this.btnUploadAvatar.BorderRadius = 0;
            this.btnUploadAvatar.BorderSize = 0;
            this.btnUploadAvatar.FlatAppearance.BorderSize = 0;
            this.btnUploadAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAvatar.ForeColor = System.Drawing.Color.White;
            this.btnUploadAvatar.Location = new System.Drawing.Point(113, 305);
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
            this.DniTxtBox.BackColor = System.Drawing.Color.White;
            this.DniTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.DniTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.DniTxtBox.BorderRadius = 0;
            this.DniTxtBox.BorderSize = 3;
            this.DniTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniTxtBox.Location = new System.Drawing.Point(423, 161);
            this.DniTxtBox.Multiline = false;
            this.DniTxtBox.Name = "DniTxtBox";
            this.DniTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.DniTxtBox.PasswordChar = false;
            this.DniTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DniTxtBox.PlaceholderText = "Ingrese su DNI";
            this.DniTxtBox.Size = new System.Drawing.Size(306, 30);
            this.DniTxtBox.TabIndex = 3;
            this.DniTxtBox.UnderlinedStyle = true;
            this.DniTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxtBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(113, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 203);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.White;
            this.LastNameTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.LastNameTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.LastNameTxtBox.BorderRadius = 0;
            this.LastNameTxtBox.BorderSize = 3;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.Location = new System.Drawing.Point(423, 125);
            this.LastNameTxtBox.Multiline = false;
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.LastNameTxtBox.PasswordChar = false;
            this.LastNameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LastNameTxtBox.PlaceholderText = "Ingrese su apellido";
            this.LastNameTxtBox.Size = new System.Drawing.Size(306, 30);
            this.LastNameTxtBox.TabIndex = 2;
            this.LastNameTxtBox.UnderlinedStyle = true;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BackColor = System.Drawing.Color.White;
            this.EmailTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.EmailTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.EmailTxtBox.BorderRadius = 0;
            this.EmailTxtBox.BorderSize = 3;
            this.EmailTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.Location = new System.Drawing.Point(423, 197);
            this.EmailTxtBox.Multiline = false;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.EmailTxtBox.PasswordChar = false;
            this.EmailTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailTxtBox.PlaceholderText = "Ingrese su correo";
            this.EmailTxtBox.Size = new System.Drawing.Size(306, 30);
            this.EmailTxtBox.TabIndex = 4;
            this.EmailTxtBox.UnderlinedStyle = true;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.Color.White;
            this.NameTxtBox.BorderColor = System.Drawing.Color.Indigo;
            this.NameTxtBox.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.NameTxtBox.BorderRadius = 0;
            this.NameTxtBox.BorderSize = 3;
            this.NameTxtBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.Location = new System.Drawing.Point(423, 89);
            this.NameTxtBox.Multiline = false;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Padding = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.NameTxtBox.PasswordChar = false;
            this.NameTxtBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameTxtBox.PlaceholderText = "Ingrese su nombre";
            this.NameTxtBox.Size = new System.Drawing.Size(306, 30);
            this.NameTxtBox.TabIndex = 1;
            this.NameTxtBox.UnderlinedStyle = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(363, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.nameLabel.Size = new System.Drawing.Size(56, 17);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Nombre:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(363, 138);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lastnameLabel.Size = new System.Drawing.Size(55, 17);
            this.lastnameLabel.TabIndex = 21;
            this.lastnameLabel.Text = "Apellido:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(381, 174);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.dniLabel.Size = new System.Drawing.Size(32, 17);
            this.dniLabel.TabIndex = 22;
            this.dniLabel.Text = "DNI:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLabel.Location = new System.Drawing.Point(366, 210);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mailLabel.Size = new System.Drawing.Size(51, 17);
            this.mailLabel.TabIndex = 23;
            this.mailLabel.Text = "Correo: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(346, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.passwordLabel.Size = new System.Drawing.Size(72, 17);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Contraseña:";
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Label.Location = new System.Drawing.Point(345, 282);
            this.password2Label.Name = "password2Label";
            this.password2Label.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.password2Label.Size = new System.Drawing.Size(72, 17);
            this.password2Label.TabIndex = 25;
            this.password2Label.Text = "Contraseña:";
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
        private System.Windows.Forms.Label password2Label;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}