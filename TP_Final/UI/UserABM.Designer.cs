
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelModifyBook = new System.Windows.Forms.Panel();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFilter = new TP_Final.UI.TextBoxPerso();
            this.btnCancel = new TP_Final.UI.ButtonPerso();
            this.btnSaveChanges = new TP_Final.UI.ButtonPerso();
            this.tbScore = new TP_Final.UI.TextBoxPerso();
            this.tbDNI = new TP_Final.UI.TextBoxPerso();
            this.tbLastName = new TP_Final.UI.TextBoxPerso();
            this.tbEmail = new TP_Final.UI.TextBoxPerso();
            this.tbName = new TP_Final.UI.TextBoxPerso();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelModifyBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 721);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.NullValue = "-";
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
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
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.NullValue = "-";
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle30;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tlpFilter, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panelModifyBook, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(832, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 721);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 1;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Controls.Add(this.tableLayoutPanelFilters, 0, 0);
            this.tlpFilter.Controls.Add(this.pictureBox1, 0, 1);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(10, 641);
            this.tlpFilter.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(418, 80);
            this.tlpFilter.TabIndex = 4;
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.AutoSize = true;
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
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(418, 32);
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
            this.searchBtn.Location = new System.Drawing.Point(381, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 32);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 12;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(10, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.panelModifyBook.Location = new System.Drawing.Point(10, 80);
            this.panelModifyBook.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelModifyBook.Name = "panelModifyBook";
            this.panelModifyBook.Size = new System.Drawing.Size(418, 561);
            this.panelModifyBook.TabIndex = 0;
            this.panelModifyBook.Visible = false;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.BackColor = System.Drawing.Color.White;
            this.cbAdmin.Location = new System.Drawing.Point(116, 415);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbAdmin.TabIndex = 47;
            this.cbAdmin.UseVisualStyleBackColor = false;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.BackColor = System.Drawing.Color.White;
            this.cbActive.Location = new System.Drawing.Point(37, 415);
            this.cbActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 46;
            this.cbActive.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(112, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(33, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 33);
            this.label3.TabIndex = 43;
            this.label3.Text = "Modificar usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(30, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(30, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(30, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(30, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(30, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Puntaje";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 461.9289F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 140;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 140;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lastNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 39.67851F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dNIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dNIDataGridViewTextBoxColumn.Width = 120;
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
            this.scoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.textBoxFilter.BorderFocusColor = System.Drawing.Color.RosyBrown;
            this.textBoxFilter.BorderRadius = 0;
            this.textBoxFilter.BorderSize = 2;
            this.textBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFilter.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.Location = new System.Drawing.Point(3, 0);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.textBoxFilter.Multiline = false;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxFilter.PasswordChar = false;
            this.textBoxFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFilter.PlaceholderText = "Ingrese el DNI o Email del usuario a filtrar";
            this.textBoxFilter.Size = new System.Drawing.Size(378, 29);
            this.textBoxFilter.TabIndex = 11;
            this.textBoxFilter.UnderlinedStyle = true;
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
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
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(290, 521);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 40);
            this.btnCancel.TabIndex = 50;
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
            this.btnSaveChanges.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(158, 521);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(128, 40);
            this.btnSaveChanges.TabIndex = 49;
            this.btnSaveChanges.Text = "Guardar";
            this.btnSaveChanges.TextColor = System.Drawing.Color.Black;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click_1);
            // 
            // tbScore
            // 
            this.tbScore.BackColor = System.Drawing.Color.DarkGray;
            this.tbScore.BorderColor = System.Drawing.Color.Gray;
            this.tbScore.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbScore.BorderRadius = 5;
            this.tbScore.BorderSize = 3;
            this.tbScore.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.tbScore.Location = new System.Drawing.Point(34, 328);
            this.tbScore.Multiline = false;
            this.tbScore.Name = "tbScore";
            this.tbScore.Padding = new System.Windows.Forms.Padding(11);
            this.tbScore.PasswordChar = false;
            this.tbScore.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbScore.PlaceholderText = "";
            this.tbScore.Size = new System.Drawing.Size(350, 41);
            this.tbScore.TabIndex = 42;
            this.tbScore.UnderlinedStyle = false;
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.DarkGray;
            this.tbDNI.BorderColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderFocusColor = System.Drawing.Color.Gray;
            this.tbDNI.BorderRadius = 5;
            this.tbDNI.BorderSize = 3;
            this.tbDNI.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.tbDNI.Location = new System.Drawing.Point(33, 199);
            this.tbDNI.Multiline = true;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Padding = new System.Windows.Forms.Padding(11);
            this.tbDNI.PasswordChar = false;
            this.tbDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDNI.PlaceholderText = "";
            this.tbDNI.Size = new System.Drawing.Size(350, 39);
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
            this.tbLastName.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.tbLastName.Location = new System.Drawing.Point(34, 135);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(11);
            this.tbLastName.PasswordChar = false;
            this.tbLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.Size = new System.Drawing.Size(350, 39);
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
            this.tbEmail.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.tbEmail.Location = new System.Drawing.Point(34, 264);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(11);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.Size = new System.Drawing.Size(350, 39);
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
            this.tbName.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(34, 73);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(11);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(350, 39);
            this.tbName.TabIndex = 33;
            this.tbName.UnderlinedStyle = false;
            // 
            // UserABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserABM";
            this.Text = "Lista de usuarios";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            this.tableLayoutPanelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelModifyBook.ResumeLayout(false);
            this.panelModifyBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
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
        private ButtonPerso btnSaveChanges;
        private ButtonPerso btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilters;
        private FontAwesome.Sharp.IconPictureBox searchBtn;
        private TextBoxPerso textBoxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}