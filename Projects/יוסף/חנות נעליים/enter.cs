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
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
              
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            if (tb2.Text == "" && tb1.Text == "")
            {
                menahel men = new menahel();
                men.Show();
                
            }
            else if (tb2.Text == "" && tb1.Text == "")
            {
                MessageBox.Show("please enter username and password");

            }
            else
            {
                MessageBox.Show("the password or the username not corect");
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
           
            //if (check1.Checked)
            //{
            //    tb2.UseSystemPasswordChar = false;

            //}
            //else
            //{
            //    tb2.UseSystemPasswordChar = true;
            //}
        }

        private void enter_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            tb2.UseSystemPasswordChar = true;
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            tb2.UseSystemPasswordChar = false;
            show.Visible = false;
            dontshow.Visible = true;

        }

        private void dontshow_Click(object sender, EventArgs e)
        {
            tb2.UseSystemPasswordChar = true;
            show.Visible = true;
            dontshow.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

  

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void kopa_Click(object sender, EventArgs e)
        {
            shop sho = new shop();
            sho.Show();
        }
    }
}
