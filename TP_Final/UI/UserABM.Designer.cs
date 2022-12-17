
namespace TP_Final.UI
{
    partial class UserABM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelModifyBook = new System.Windows.Forms.Panel();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbScore = new TP_Final.UI.TextBoxPerso();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNI = new TP_Final.UI.TextBoxPerso();
            this.tbLastName = new TP_Final.UI.TextBoxPerso();
            this.tbEmail = new TP_Final.UI.TextBoxPerso();
            this.tbName = new TP_Final.UI.TextBoxPerso();
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.btnSaveChanges = new TP_Final.UI.ButtonPerso();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelModifyBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1707, 887);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridUsers, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1109, 887);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = "-";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridUsers.ColumnHeadersHeight = 30;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridUsers.DataSource = this.userDTOBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = "-";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.EnableHeadersVisualStyles = false;
            this.dataGridUsers.GridColor = System.Drawing.Color.White;
            this.dataGridUsers.Location = new System.Drawing.Point(27, 88);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(1082, 753);
            this.dataGridUsers.TabIndex = 1;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 461.9289F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.Width = 60;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.FillWeight = 39.67851F;
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 60;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 60;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.FillWeight = 39.67851F;
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.MinimumWidth = 60;
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.ReadOnly = true;
            this.adminDataGridViewCheckBoxColumn.Width = 60;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(TP_Final.IO.UserDTO);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.Controls.Add(this.panelModifyBook, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1109, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(598, 887);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // panelModifyBook
            // 
            this.panelModifyBook.Controls.Add(this.btnCancel);
            this.panelModifyBook.Controls.Add(this.btnSaveChanges);
            this.panelModifyBook.Controls.Add(this.cbAdmin);
            this.panelModifyBook.Controls.Add(this.cbActive);
            this.panelModifyBook.Controls.Add(this.label8);
            this.panelModifyBook.Controls.Add(this.label7);
            this.panelModifyBook.Controls.Add(this.label3);
            this.panelModifyBook.Controls.Add(this.tbScore);
            this.panelModifyBook.Controls.Add(this.label6);
            this.panelModifyBook.Controls.Add(this.label5);
            this.panelModifyBook.Controls.Add(this.label4);
            this.panelModifyBook.Controls.Add(this.label2);
            this.panelModifyBook.Controls.Add(this.label1);
            this.panelModifyBook.Controls.Add(this.tbDNI);
            this.panelModifyBook.Controls.Add(this.tbLastName);
            this.panelModifyBook.Controls.Add(this.tbEmail);
            this.panelModifyBook.Controls.Add(this.tbName);
            this.panelModifyBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModifyBook.Location = new System.Drawing.Point(13, 88);
            this.panelModifyBook.Margin = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.panelModifyBook.Name = "panelModifyBook";
            this.panelModifyBook.Size = new System.Drawing.Size(558, 753);
            this.panelModifyBook.TabIndex = 0;
            this.panelModifyBook.Visible = false;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.BackColor = System.Drawing.Color.White;
            this.cbAdmin.Location = new System.Drawing.Point(49, 583);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(18, 17);
            this.cbAdmin.TabIndex = 47;
            this.cbAdmin.UseVisualStyleBackColor = false;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.BackColor = System.Drawing.Color.White;
            this.cbActive.Location = new System.Drawing.Point(49, 511);
            this.cbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(18, 17);
            this.cbActive.TabIndex = 46;
            this.cbActive.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(44, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(44, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 38);
            this.label3.TabIndex = 43;
            this.label3.Text = "Modificar usuario";
            // 
            // tbScore
            // 
            this.tbScore.BackColor = System.Drawing.Color.DarkGray;
            this.tbScore.BorderColor = System.Drawing.Color.Gray;
            this.tbScore.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbScore.BorderRadius = 5;
            this.tbScore.BorderSize = 3;
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbScore.Location = new System.Drawing.Point(45, 404);
            this.tbScore.Margin = new System.Windows.Forms.Padding(4);
            this.tbScore.Multiline = false;
            this.tbScore.Name = "tbScore";
            this.tbScore.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbScore.PasswordChar = false;
            this.tbScore.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbScore.PlaceholderText = "";
            this.tbScore.Size = new System.Drawing.Size(467, 53);
            this.tbScore.TabIndex = 42;
            this.tbScore.UnderlinedStyle = false;
            this.tbScore._TextChanged += new System.EventHandler(this.tbScore__TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(40, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(40, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(40, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(40, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(40, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Puntaje";
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.DarkGray;
            this.tbDNI.BorderColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderRadius = 5;
            this.tbDNI.BorderSize = 3;
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbDNI.Location = new System.Drawing.Point(44, 245);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(4);
            this.tbDNI.Multiline = true;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbDNI.PasswordChar = false;
            this.tbDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDNI.PlaceholderText = "";
            this.tbDNI.Size = new System.Drawing.Size(467, 48);
            this.tbDNI.TabIndex = 35;
            this.tbDNI.UnderlinedStyle = false;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.DarkGray;
            this.tbLastName.BorderColor = System.Drawing.Color.Gray;
            this.tbLastName.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbLastName.BorderRadius = 5;
            this.tbLastName.BorderSize = 3;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbLastName.Location = new System.Drawing.Point(45, 166);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbLastName.PasswordChar = false;
            this.tbLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.Size = new System.Drawing.Size(467, 48);
            this.tbLastName.TabIndex = 34;
            this.tbLastName.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.DarkGray;
            this.tbEmail.BorderColor = System.Drawing.Color.Gray;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbEmail.BorderRadius = 5;
            this.tbEmail.BorderSize = 3;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbEmail.Location = new System.Drawing.Point(45, 325);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.Size = new System.Drawing.Size(467, 48);
            this.tbEmail.TabIndex = 36;
            this.tbEmail.UnderlinedStyle = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.DarkGray;
            this.tbName.BorderColor = System.Drawing.Color.Gray;
            this.tbName.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbName.BorderRadius = 5;
            this.tbName.BorderSize = 3;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(45, 90);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(467, 48);
            this.tbName.TabIndex = 33;
            this.tbName.UnderlinedStyle = false;
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
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(371, 698);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 40);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
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
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(186, 698);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(170, 40);
            this.btnSaveChanges.TabIndex = 55;
            this.btnSaveChanges.Text = "Guardar";
            this.btnSaveChanges.TextColor = System.Drawing.Color.Black;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click_1);
            // 
            // UserABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 887);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserABM";
            this.Text = "Lista de usuarios";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelModifyBook.ResumeLayout(false);
            this.panelModifyBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelModifyBook;
        private TextBoxPerso tbScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxPerso tbDNI;
        private TextBoxPerso tbLastName;
        private TextBoxPerso tbEmail;
        private TextBoxPerso tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.CheckBox cbActive;
        private ButtonPerso btnCancel;
        private ButtonPerso btnSaveChanges;
    }
}