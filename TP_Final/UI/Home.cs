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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            pictureBox2.Image = UIResources.GetAmancio(UIResources.AmancioOrientarion.ToRight);
            lblPhrase.Text = UIResources.GetPhrase();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
