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
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmerkazi.Controls.Clear();
            Form3 ss = new Form3();
            ss.TopLevel = false;
            ss.AutoScroll = true;
            panelmerkazi.Controls.Add(ss);
            ss.FormBorderStyle = FormBorderStyle.None;
            panelmerkazi.Size = panelmerkazi.Size;
            ss.Dock = DockStyle.Fill;
            ss.Show();
            panelmerkazi.Visible = true;

        }

        private void FormNew_Load(object sender, EventArgs e)
        {

        }

        private void panelmerkazi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
