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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
            pass.MaxLength = 4;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(pass.Text=="")
            {
                MessageBox.Show("הקש סיסמה");
            }

            else if (pass.Text=="1234")
            {
                formmenahel frmmen = new formmenahel();
                frmmen.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("סיסמה שגויה, נסה שנית");
                pass.Clear();

            }
        }
    }
}
