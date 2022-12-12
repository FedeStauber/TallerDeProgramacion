using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace TP_Final.UI
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class ComboBoxPerso : UserControl
    {
        private Color iBackColor = Color.White;
        private Color iIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
        private Color iListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
        private Color iListTextColor = Color.White;
        private Color iBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
        private int iBorderSize = 2;

        private ComboBox cbList;
        private Label labelText;
        private Button btnIcon;

        public new Color BackColor { get => iBackColor; set { iBackColor = value; labelText.BackColor = iBackColor; btnIcon.BackColor = iBackColor; } }
        public Color IconColor { get => iIconColor; set { iIconColor = value; btnIcon.Invalidate(); } }
        public Color ListBackColor { get => iListBackColor; set { iListBackColor = value; cbList.BackColor = iListBackColor; } }
        public Color ListTextColor { get => iListTextColor; set { iListTextColor = value; cbList.ForeColor = iListTextColor; } }
        public Color BorderColor { get => iBorderColor; set { iBorderColor = value; base.BackColor = iBackColor; } }
        public int BorderSize { get => iBorderSize; set { iBorderSize = value; this.Padding = new Padding(iBorderSize); AdjustComboboxDimensions(); } }
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; labelText.ForeColor = value; } }
        public override Font Font { get => base.Font; set { base.Font = value; cbList.Font = value; labelText.Font = value; } }
        public string Texts { get { return labelText.Text; } set { labelText.Text = value; } }
        public object SelectedItem { get { return cbList.SelectedItem; } set { cbList.SelectedItem = value; } }
        public int SelectedIndex { get { return cbList.SelectedIndex; } set { cbList.SelectedIndex = value; } }
        public ComboBoxStyle DropDownStyle
        {
            get { return cbList.DropDownStyle; }
            set { if(cbList.DropDownStyle != ComboBoxStyle.Simple) 
                cbList.DropDownStyle = value; }
        }
        //Events
        public event EventHandler OnSelectedIndexChanged;
        //Data
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]       
        public ComboBox.ObjectCollection Items { get => cbList.Items; }
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]       
        public object DataSource { get => cbList.DataSource; set => cbList.DataSource = value; }

        public ComboBoxPerso()
        {
            cbList = new ComboBox();
            labelText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();
            //Dropdwn List
            cbList.BackColor = iBackColor;
            cbList.Font = new Font(this.Font.Name, 10F);
            cbList.ForeColor = iListTextColor;            
            cbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cbList.TextChanged += new EventHandler(ComboBox_TextChanged);
            //Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = iBackColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);
            //Label
            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = iBackColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(8, 0, 0, 0);
            labelText.Font = new Font(this.Font.Name, 10F);
            labelText.Click += new EventHandler(Surface_Click);
            labelText.MouseEnter += new EventHandler(Surface_MouseEnter);
            labelText.MouseLeave += new EventHandler(Surface_MouseLeave);
            //User Control
            this.Controls.Add(labelText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(this.iBorderSize);
            base.BackColor = iBorderColor;
            this.ResumeLayout();
            AdjustComboboxDimensions();

        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void AdjustComboboxDimensions()
        {
            cbList.Width = labelText.Width;
            cbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cbList.Width,
                Y = labelText.Bottom - cbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            cbList.Select();
            if (cbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht)/2,(btnIcon.Height - iconHeight)/2, iconWidht,iconHeight);
            Graphics graph = e.Graphics;
            using(GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iIconColor,2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom,rectIcon.Right,rectIcon.Y);
                graph.DrawPath(pen, path);
            }
            

            
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cbList.Select();
            cbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text = cbList.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            labelText.Text = cbList.Text;

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboboxDimensions();
        }
    }
}
