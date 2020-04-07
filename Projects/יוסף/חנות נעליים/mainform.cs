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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void kopa_Click(object sender, EventArgs e)
        {
            shop sho = new shop();
            sho.Show();
            this.Hide();
        }

        private void oved_Click(object sender, EventArgs e)
        {
            mishmarot mish = new mishmarot();
            mish.Show();
        }

        private void hipos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            archives arch = new archives();
            arch.Show();
           

        }
    }
}
