using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenmnhlim_Click(object sender, EventArgs e)
        {
            frmMnhlim mn = new frmMnhlim();
            mn.Show();
        }

        private void btnOpenOvdeem_Click(object sender, EventArgs e)
        {
            ovdim ov = new ovdim();

            ov.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            spakim sp = new spakim();
            sp.Show();
        }

        private void btnOpenSokhen_Click(object sender, EventArgs e)
        {
            sokhnim sk = new sokhnim();
            sk.Show();

        }

        private void btnOpenLkohot_Click(object sender, EventArgs e)
        {
            lakokhot lk = new lakokhot();
            lk.Show();

        }

        private void btnOpenMotzarim_Click(object sender, EventArgs e)
        {
            motzarim mn = new motzarim();
            mn.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
