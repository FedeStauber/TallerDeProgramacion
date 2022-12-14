namespace TP_Final.UI
{
    partial class LoanReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backTLP = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLoanReturnData = new System.Windows.Forms.Panel();
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.btnSaveChanges = new TP_Final.UI.ButtonPerso();
            this.comboBoxPerso1 = new TP_Final.UI.ComboBoxPerso();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new TP_Final.UI.TextBoxPerso();
            this.ExpiresLabel = new TP_Final.UI.TextBoxPerso();
            this.dniLabel = new TP_Final.UI.TextBoxPerso();
            this.bookLabel = new TP_Final.UI.TextBoxPerso();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxFilter = new TP_Final.UI.TextBoxPerso();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backTLP.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelLoanReturnData.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backTLP
            // 
            this.backTLP.ColumnCount = 2;
            this.backTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.backTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.backTLP.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.backTLP.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.backTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backTLP.Location = new System.Drawing.Point(0, 0);
            this.backTLP.Margin = new System.Windows.Forms.Padding(0);
            this.backTLP.Name = "backTLP";
            this.backTLP.RowCount = 1;
            this.backTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backTLP.Size = new System.Drawing.Size(1280, 721);
            this.backTLP.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelLoanReturnData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tlpFilter, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(832, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 721);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panelLoanReturnData
            // 
            this.panelLoanReturnData.Controls.Add(this.btnCancel);
            this.panelLoanReturnData.Controls.Add(this.btnSaveChanges);
            this.panelLoanReturnData.Controls.Add(this.comboBoxPerso1);
            this.panelLoanReturnData.Controls.Add(this.label3);
            this.panelLoanReturnData.Controls.Add(this.label6);
            this.panelLoanReturnData.Controls.Add(this.label5);
            this.panelLoanReturnData.Controls.Add(this.label4);
            this.panelLoanReturnData.Controls.Add(this.label2);
            this.panelLoanReturnData.Controls.Add(this.label1);
            this.panelLoanReturnData.Controls.Add(this.userLabel);
            this.panelLoanReturnData.Controls.Add(this.ExpiresLabel);
            this.panelLoanReturnData.Controls.Add(this.dniLabel);
            this.panelLoanReturnData.Controls.Add(this.bookLabel);
            this.panelLoanReturnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoanReturnData.Location = new System.Drawing.Point(10, 77);
            this.panelLoanReturnData.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLoanReturnData.Name = "panelLoanReturnData";
            this.panelLoanReturnData.Size = new System.Drawing.Size(418, 564);
            this.panelLoanReturnData.TabIndex = 0;
            this.panelLoanReturnData.Visible = false;
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
            this.btnCancel.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(290, 521);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSaveChanges.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(158, 521);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(128, 40);
            this.btnSaveChanges.TabIndex = 53;
            this.btnSaveChanges.Text = "Guardar";
            this.btnSaveChanges.TextColor = System.Drawing.Color.Black;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // comboBoxPerso1
            // 
            this.comboBoxPerso1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxPerso1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.comboBoxPerso1.BorderSize = 0;
            this.comboBoxPerso1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPerso1.Font = new System.Drawing.Font("Roboto Cn", 9.25F);
            this.comboBoxPerso1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPerso1.IconColor = System.Drawing.Color.Black;
            this.comboBoxPerso1.Items.AddRange(new object[] {
            "Disponible",
            "Roto"});
            this.comboBoxPerso1.ListBackColor = System.Drawing.Color.DarkGray;
            this.comboBoxPerso1.ListTextColor = System.Drawing.Color.Black;
            this.comboBoxPerso1.Location = new System.Drawing.Point(32, 360);
            this.comboBoxPerso1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPerso1.MinimumSize = new System.Drawing.Size(150, 24);
            this.comboBoxPerso1.Name = "comboBoxPerso1";
            this.comboBoxPerso1.SelectedIndex = -1;
            this.comboBoxPerso1.SelectedItem = null;
            this.comboBoxPerso1.Size = new System.Drawing.Size(348, 34);
            this.comboBoxPerso1.TabIndex = 52;
            this.comboBoxPerso1.Texts = "Seleccione el estado de la copia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 33);
            this.label3.TabIndex = 51;
            this.label3.Text = "Registrar devolución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(28, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(28, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(26, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(28, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(28, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Estado copia";
            // 
            // userLabel
            // 
            this.userLabel.BackColor = System.Drawing.Color.DarkGray;
            this.userLabel.BorderColor = System.Drawing.Color.Gray;
            this.userLabel.BorderFocusColor = System.Drawing.Color.Gray;
            this.userLabel.BorderRadius = 5;
            this.userLabel.BorderSize = 3;
            this.userLabel.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userLabel.Location = new System.Drawing.Point(30, 223);
            this.userLabel.Multiline = true;
            this.userLabel.Name = "userLabel";
            this.userLabel.Padding = new System.Windows.Forms.Padding(11);
            this.userLabel.PasswordChar = false;
            this.userLabel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userLabel.PlaceholderText = "";
            this.userLabel.Size = new System.Drawing.Size(350, 39);
            this.userLabel.TabIndex = 44;
            this.userLabel.UnderlinedStyle = false;
            this.userLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // ExpiresLabel
            // 
            this.ExpiresLabel.BackColor = System.Drawing.Color.DarkGray;
            this.ExpiresLabel.BorderColor = System.Drawing.Color.Gray;
            this.ExpiresLabel.BorderFocusColor = System.Drawing.Color.Gray;
            this.ExpiresLabel.BorderRadius = 5;
            this.ExpiresLabel.BorderSize = 3;
            this.ExpiresLabel.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.ExpiresLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExpiresLabel.Location = new System.Drawing.Point(32, 158);
            this.ExpiresLabel.Multiline = true;
            this.ExpiresLabel.Name = "ExpiresLabel";
            this.ExpiresLabel.Padding = new System.Windows.Forms.Padding(11);
            this.ExpiresLabel.PasswordChar = false;
            this.ExpiresLabel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ExpiresLabel.PlaceholderText = "";
            this.ExpiresLabel.Size = new System.Drawing.Size(350, 39);
            this.ExpiresLabel.TabIndex = 43;
            this.ExpiresLabel.UnderlinedStyle = false;
            this.ExpiresLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // dniLabel
            // 
            this.dniLabel.BackColor = System.Drawing.Color.DarkGray;
            this.dniLabel.BorderColor = System.Drawing.Color.Gray;
            this.dniLabel.BorderFocusColor = System.Drawing.Color.Gray;
            this.dniLabel.BorderRadius = 5;
            this.dniLabel.BorderSize = 3;
            this.dniLabel.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.dniLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dniLabel.Location = new System.Drawing.Point(32, 289);
            this.dniLabel.Multiline = true;
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Padding = new System.Windows.Forms.Padding(11);
            this.dniLabel.PasswordChar = false;
            this.dniLabel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.dniLabel.PlaceholderText = "";
            this.dniLabel.Size = new System.Drawing.Size(350, 39);
            this.dniLabel.TabIndex = 45;
            this.dniLabel.UnderlinedStyle = false;
            this.dniLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // bookLabel
            // 
            this.bookLabel.BackColor = System.Drawing.Color.DarkGray;
            this.bookLabel.BorderColor = System.Drawing.Color.Gray;
            this.bookLabel.BorderFocusColor = System.Drawing.Color.Gray;
            this.bookLabel.BorderRadius = 5;
            this.bookLabel.BorderSize = 3;
            this.bookLabel.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.bookLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bookLabel.Location = new System.Drawing.Point(32, 92);
            this.bookLabel.Multiline = true;
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Padding = new System.Windows.Forms.Padding(11);
            this.bookLabel.PasswordChar = false;
            this.bookLabel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.bookLabel.PlaceholderText = "";
            this.bookLabel.Size = new System.Drawing.Size(350, 39);
            this.bookLabel.TabIndex = 42;
            this.bookLabel.UnderlinedStyle = false;
            this.bookLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 1;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Controls.Add(this.tableLayoutPanelFilters, 0, 0);
            this.tlpFilter.Controls.Add(this.pictureBox1, 0, 1);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(10, 0);
            this.tlpFilter.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(418, 77);
            this.tlpFilter.TabIndex = 3;
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 2;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelFilters.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.textBoxFilter, 0, 0);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFilters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 1;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(418, 37);
            this.tableLayoutPanelFilters.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 37;
            this.searchBtn.Location = new System.Drawing.Point(381, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 37);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 12;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.textBoxFilter.BorderFocusColor = System.Drawing.Color.RosyBrown;
            this.textBoxFilter.BorderRadius = 0;
            this.textBoxFilter.BorderSize = 2;
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFilter.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.textBoxFilter.Location = new System.Drawing.Point(3, 0);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxFilter.Multiline = false;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFilter.PasswordChar = false;
            this.textBoxFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFilter.PlaceholderText = "Ingrese el DNI o Email del usuario a filtrar";
            this.textBoxFilter.Size = new System.Drawing.Size(378, 33);
            this.textBoxFilter.TabIndex = 11;
            this.textBoxFilter.UnderlinedStyle = true;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(10, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridUsers, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 721);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = "-";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridUsers.ColumnHeadersHeight = 30;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.userEmailDataGridViewTextBoxColumn,
            this.userDNIDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookISBNDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn});
            this.dataGridUsers.DataSource = this.loanDTOBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.NullValue = "-";
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.EnableHeadersVisualStyles = false;
            this.dataGridUsers.GridColor = System.Drawing.Color.White;
            this.dataGridUsers.Location = new System.Drawing.Point(20, 80);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersVisible = false;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(812, 561);
            this.dataGridUsers.TabIndex = 1;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.Id.DefaultCellStyle = dataGridViewCellStyle12;
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 50;
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.userEmailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.userEmailDataGridViewTextBoxColumn.FillWeight = 150F;
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.userEmailDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.userEmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // userDNIDataGridViewTextBoxColumn
            // 
            this.userDNIDataGridViewTextBoxColumn.DataPropertyName = "UserDNI";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.userDNIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.userDNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.userDNIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.userDNIDataGridViewTextBoxColumn.Name = "userDNIDataGridViewTextBoxColumn";
            this.userDNIDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDNIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userDNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.bookTitleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookTitleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bookISBNDataGridViewTextBoxColumn
            // 
            this.bookISBNDataGridViewTextBoxColumn.DataPropertyName = "BookISBN";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.bookISBNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.bookISBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.bookISBNDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.bookISBNDataGridViewTextBoxColumn.Name = "bookISBNDataGridViewTextBoxColumn";
            this.bookISBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookISBNDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bookISBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto Cn", 9F);
            this.startDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.startDateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.startDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // loanDTOBindingSource
            // 
            this.loanDTOBindingSource.DataSource = typeof(TP_Final.IO.LoanDTO);
            // 
            // LoanReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.backTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanReturn";
            this.Text = "Registrar Devolución";
            this.backTLP.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelLoanReturnData.ResumeLayout(false);
            this.panelLoanReturnData.PerformLayout();
            this.tlpFilter.ResumeLayout(false);
            this.tableLayoutPanelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backTLP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelLoanReturnData;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilters;
        private TextBoxPerso textBoxFilter;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource loanDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxPerso userLabel;
        private TextBoxPerso ExpiresLabel;
        private TextBoxPerso dniLabel;
        private TextBoxPerso bookLabel;
        private System.Windows.Forms.Label label3;
        private ComboBoxPerso comboBoxPerso1;
        private ButtonPerso btnCancel;
        private ButtonPerso btnSaveChanges;
    }
}