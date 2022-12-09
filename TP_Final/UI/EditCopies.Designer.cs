﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridCopies = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.conditionEnumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastModifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionEnumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridCopies, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(1176, 80);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // dataGridCopies
            // 
            this.dataGridCopies.AllowUserToAddRows = false;
            this.dataGridCopies.AllowUserToDeleteRows = false;
            this.dataGridCopies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.dataGridCopies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCopies.AutoGenerateColumns = false;
            this.dataGridCopies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCopies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCopies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCopies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCopies.ColumnHeadersHeight = 30;
            this.dataGridCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCopies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.conditionDataGridViewComboBoxColumn,
            this.lastModifyDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridCopies.DataSource = this.copyDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCopies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCopies.EnableHeadersVisualStyles = false;
            this.dataGridCopies.GridColor = System.Drawing.Color.White;
            this.dataGridCopies.Location = new System.Drawing.Point(76, 80);
            this.dataGridCopies.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridCopies.MultiSelect = false;
            this.dataGridCopies.Name = "dataGridCopies";
            this.dataGridCopies.RowHeadersVisible = false;
            this.dataGridCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCopies.Size = new System.Drawing.Size(1100, 591);
            this.dataGridCopies.TabIndex = 6;
            this.dataGridCopies.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridCopies_CellBeginEdit);
            this.dataGridCopies.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCopies_CellEndEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
           /* this.conditionDataGridViewComboBoxColumn.Items.AddRange(new object[] {
            TP_Final.IO.CopyDTO.ConditionEnum.Disponible,
            TP_Final.IO.CopyDTO.ConditionEnum.Prestado,
            TP_Final.IO.CopyDTO.ConditionEnum.Roto,
            TP_Final.IO.CopyDTO.ConditionEnum.Suspendido});*/
            this.conditionDataGridViewComboBoxColumn.MinimumWidth = 150;
            this.conditionDataGridViewComboBoxColumn.Name = "conditionDataGridViewComboBoxColumn";
            this.conditionDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.conditionDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.conditionDataGridViewComboBoxColumn.Width = 150;
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
            // lastModifyDataGridViewTextBoxColumn
            // 
            this.lastModifyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastModifyDataGridViewTextBoxColumn.DataPropertyName = "LastModify";
            this.lastModifyDataGridViewTextBoxColumn.HeaderText = "Ultima Modificación";
            this.lastModifyDataGridViewTextBoxColumn.Name = "lastModifyDataGridViewTextBoxColumn";
            this.lastModifyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Prestado Hasta";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // copyDTOBindingSource
            // 
            this.copyDTOBindingSource.DataSource = typeof(TP_Final.IO.CopyDTO);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 50;
            this.iconPictureBox2.Location = new System.Drawing.Point(1179, 27);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionEnumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource copyDTOBindingSource;
        private System.Windows.Forms.DataGridView dataGridCopies;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.BindingSource conditionEnumBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn conditionDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}