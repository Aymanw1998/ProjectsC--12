using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liii
{
    public partial class Form2 : Form

    {
        public static bool pass;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Username";
            textBox1.Text = "Password";
            this.AcceptButton = button1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Password")
            {
                textBox1.UseSystemPasswordChar = true;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Visible = false;

            if (textBox2.Text=="adminadmin")
            {
                if (textBox1.Text=="jdlibrary2018")
                {
                    pass = true;
                    spakim fm13 = new spakim();
                    fm13.Show();
                    pass = false;
                    this.Close();
                }
                else
                {
                    label3.Visible = true;
                }
                
            }
            else if (textBox1.Text != "jdlibrary2018")
            {
                label2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                label2.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spakim fm13 = new spakim();
            fm13.Show();
            this.Close();
        }
       
    }
}
