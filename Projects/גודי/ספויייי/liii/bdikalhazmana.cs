using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace liii
{
    public partial class bdikalhazmana : Form
    {
        public static string pass;
        public static string pass1;
        public static string pass2;
        public static bool pass3;
        public bdikalhazmana()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.spakimDataTable kr;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdikalhazmana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.liDataSet.spakim);
            textBox1.Text = borrowing.pass3;
            this.AcceptButton = button1;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool x;
            kr = liDataSet.spakim;
            x = find.company(kr, textBox5.Text);
            if (x == false)
            {
                MessageBox.Show("חברה זו לא קיימת תחילה יש להזין נתוני חברה זו");
                textBox5.Focus();

            }

            else
            {
                MessageBox.Show("יש אפשרות להזמין את הספר");
                pass = textBox5.Text;
                pass1 = textBox1.Text;
                pass2 = borrowing.pass4;
                pass3 = true;
                hazmanotli fm10 = new hazmanotli();
                fm10.Show();
                pass = null;
                pass1 = null;
                

                

            }

            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void bdikalhazmana_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
