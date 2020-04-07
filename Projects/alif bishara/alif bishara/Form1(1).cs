using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alif_bishara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtxpass.Text = "";
            txtuser.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtxpass.Text == "0730" && txtuser.Text == "fadib")
            {
               FormNew fa = new FormNew();
                fa.Show();
                this.Hide();
            }
            else if(txtxpass.Text != "0730" && txtuser.Text != "fadib")
            {
               MessageBox.Show("השם משתמש והסיסמה שגויים אנא נסה שנית");
            }

            else if( txtxpass.Text != "0730" && txtuser.Text == "fadib")
                MessageBox.Show("הסיסמה שגויה נסה שנית");
            else MessageBox.Show("שם משתמש שגויי נסה שנית");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
