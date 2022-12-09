namespace TP_Final.UI
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPerso1 = new TP_Final.UI.ComboBoxPerso();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPerso1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.20805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.79195F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxPerso1
            // 
            this.comboBoxPerso1.BackColor = System.Drawing.Color.White;
            this.comboBoxPerso1.BorderColor = System.Drawing.Color.Indigo;
            this.comboBoxPerso1.BorderSize = 2;
            this.comboBoxPerso1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPerso1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPerso1.IconColor = System.Drawing.Color.Indigo;
            this.comboBoxPerso1.ListBackColor = System.Drawing.Color.Indigo;
            this.comboBoxPerso1.ListTextColor = System.Drawing.Color.White;
            this.comboBoxPerso1.Location = new System.Drawing.Point(429, 3);
            this.comboBoxPerso1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPerso1.Name = "comboBoxPerso1";
            this.comboBoxPerso1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPerso1.SelectedIndex = -1;
            this.comboBoxPerso1.SelectedItem = null;
            this.comboBoxPerso1.Size = new System.Drawing.Size(440, 180);
            this.comboBoxPerso1.TabIndex = 0;
            this.comboBoxPerso1.Texts = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComboBoxPerso comboBoxPerso1;
    }
}