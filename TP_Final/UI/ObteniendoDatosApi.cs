using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final.UI
{
    public partial class ObteniendoDatosApi : Form
    {
        public ObteniendoDatosApi()
        {
            InitializeComponent();
            this.TopLevel = true;            
            pictureBox1.Image = Properties.Resources.loading;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
