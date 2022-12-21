
using System;
using System.Collections.Generic;

namespace TP_Final.UI
{
    partial class EditCopies
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
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }*/
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridCopies = new System.Windows.Forms.DataGridView();
            this.conditionEnumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copyDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBottom = new FontAwesome.Sharp.IconPictureBox();
            this.returnBottom = new FontAwesome.Sharp.IconPictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lastModifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionEnumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.411765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.58823F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridCopies, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.returnBottom, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridCopies
            // 
            this.dataGridCopies.AllowUserToAddRows = false;
            this.dataGridCopies.AllowUserToDeleteRows = false;
            this.dataGridCopies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.dataGridCopies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCopies.AutoGenerateColumns = false;
            this.dataGridCopies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCopies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCopies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCopies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCopies.ColumnHeadersHeight = 30;
            this.dataGridCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCopies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.conditionDataGridViewComboBoxColumn,
            this.lastModifyDataGridViewTextBoxColumn,
            this.LoanEndDate});
            this.dataGridCopies.DataSource = this.copyDTOBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCopies.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCopies.EnableHeadersVisualStyles = false;
            this.dataGridCopies.GridColor = System.Drawing.Color.White;
            this.dataGridCopies.Location = new System.Drawing.Point(44, 80);
            this.dataGridCopies.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridCopies.MultiSelect = false;
            this.dataGridCopies.Name = "dataGridCopies";
            this.dataGridCopies.RowHeadersVisible = false;
            this.dataGridCopies.RowHeadersWidth = 51;
            this.dataGridCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCopies.Size = new System.Drawing.Size(812, 561);
            this.dataGridCopies.TabIndex = 6;
            this.dataGridCopies.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridCopies_CellBeginEdit);
            this.dataGridCopies.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCopies_CellEndEdit);
            // 
            // conditionEnumBindingSource
            // 
            this.conditionEnumBindingSource.DataSource = new TP_Final.IO.CopyDTO.ConditionEnum[] {
        TP_Final.IO.CopyDTO.ConditionEnum.Disponible,
        TP_Final.IO.CopyDTO.ConditionEnum.Prestado,
        TP_Final.IO.CopyDTO.ConditionEnum.Roto,
        TP_Final.IO.CopyDTO.ConditionEnum.Suspendido};
            this.conditionEnumBindingSource.Position = 0;
            // 
            // copyDTOBindingSource
            // 
            this.copyDTOBindingSource.DataSource = typeof(TP_Final.IO.CopyDTO);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addBottom, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(856, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 561);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 10, 30, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // addBottom
            // 
            this.addBottom.BackColor = System.Drawing.Color.White;
            this.addBottom.ForeColor = System.Drawing.Color.LimeGreen;
            this.addBottom.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBottom.IconColor = System.Drawing.Color.LimeGreen;
            this.addBottom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBottom.Location = new System.Drawing.Point(0, 0);
            this.addBottom.Margin = new System.Windows.Forms.Padding(0);
            this.addBottom.Name = "addBottom";
            this.addBottom.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.addBottom.Size = new System.Drawing.Size(32, 32);
            this.addBottom.TabIndex = 7;
            this.addBottom.TabStop = false;
            this.addBottom.Click += new System.EventHandler(this.addBottom_Click);
            // 
            // returnBottom
            // 
            this.returnBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnBottom.BackColor = System.Drawing.Color.White;
            this.returnBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBottom.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.returnBottom.IconColor = System.Drawing.SystemColors.ControlText;
            this.returnBottom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.returnBottom.IconSize = 50;
            this.returnBottom.Location = new System.Drawing.Point(1200, 30);
            this.returnBottom.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.returnBottom.Name = "returnBottom";
            this.returnBottom.Size = new System.Drawing.Size(50, 50);
            this.returnBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnBottom.TabIndex = 8;
            this.returnBottom.TabStop = false;
            this.returnBottom.Click += new System.EventHandler(this.returnBottom_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionDataGridViewComboBoxColumn
            // 
            this.conditionDataGridViewComboBoxColumn.AutoComplete = false;
            this.conditionDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.conditionDataGridViewComboBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewComboBoxColumn.DataSource = this.conditionEnumBindingSource;
            this.conditionDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.conditionDataGridViewComboBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.conditionDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionDataGridViewComboBoxColumn.HeaderText = "Condición";
            this.conditionDataGridViewComboBoxColumn.MinimumWidth = 150;
            this.conditionDataGridViewComboBoxColumn.Name = "conditionDataGridViewComboBoxColumn";
            this.conditionDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.conditionDataGridViewComboBoxColumn.Width = 150;
            // 
            // lastModifyDataGridViewTextBoxColumn
            // 
            this.lastModifyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastModifyDataGridViewTextBoxColumn.DataPropertyName = "LastModify";
            this.lastModifyDataGridViewTextBoxColumn.HeaderText = "Ultima Modificación";
            this.lastModifyDataGridViewTextBoxColumn.MinimumWidth = 267;
            this.lastModifyDataGridViewTextBoxColumn.Name = "lastModifyDataGridViewTextBoxColumn";
            this.lastModifyDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastModifyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LoanEndDate
            // 
            this.LoanEndDate.DataPropertyName = "LoanEndDate";
            dataGridViewCellStyle3.NullValue = "-";
            this.LoanEndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoanEndDate.HeaderText = "Prestado Hasta";
            this.LoanEndDate.MinimumWidth = 267;
            this.LoanEndDate.Name = "LoanEndDate";
            this.LoanEndDate.ReadOnly = true;
            this.LoanEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LoanEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoanEndDate.Width = 267;
            // 
            // EditCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCopies";
            this.Text = "Editar Copias";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionEnumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource copyDTOBindingSource;
        private FontAwesome.Sharp.IconPictureBox addBottom;
        private System.Windows.Forms.BindingSource conditionEnumBindingSource;
        private FontAwesome.Sharp.IconPictureBox returnBottom;
        private System.Windows.Forms.DataGridView dataGridCopies;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn conditionDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanEndDate;
    }
}