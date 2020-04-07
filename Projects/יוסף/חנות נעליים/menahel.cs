using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace חנות_נעליים
{
    public partial class menahel : Form
    {
        public menahel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spakim spa = new spakim();
            spa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mahlakot mah = new mahlakot();
            mah.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovdeem ovd = new ovdeem();
            ovd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shoes sho = new shoes();
            sho.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            archives arch = new archives();
            arch.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shop sho = new shop();
            sho.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
