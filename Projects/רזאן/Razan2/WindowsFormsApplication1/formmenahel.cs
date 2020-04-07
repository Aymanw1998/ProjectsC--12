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
    public partial class formmenahel : Form
    {
        public formmenahel()
        {
            InitializeComponent();
        }

        private void btnbkab_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnsap_Click(object sender, EventArgs e)
        {
            formsapakim sapak = new formsapakim();
            sapak.Show();
            this.Close();

        }

        private void btnmas_Click(object sender, EventArgs e)
        {
           

        }

       

        private void formmenahel_Load(object sender, EventArgs e)
        {

        }

        private void ovdeem_Click(object sender, EventArgs e)
        {
            formovdeem oved = new formovdeem();
           oved.Show();
            this.Close();
        }

        private void meamnim_Click(object sender, EventArgs e)
        {
            formmeamnim meamen = new formmeamnim();
            meamen.Show();
            this.Close();
        }
    }
}
