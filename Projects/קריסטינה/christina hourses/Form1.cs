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
namespace christina_hourses
{
    public partial class Form1 : Form
    {
        public static string pass;
        public static string pass2;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);
            this.AcceptButton = button1;
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            textbox_password.Focus(); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)
                textbox_password.UseSystemPasswordChar = true;
            else
                textbox_password.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass=textbox_password.Text;

            
            if(textbox_password.Text =="")
                MessageBox.Show("אנא הזן סיסמה");

            else
               {
                     Form_main frm = new Form_main();
                     frm.Show();
                     this.Hide();
       
               }
        



            
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass2 = textbox_password.Text;

            Form_main frm = new Form_main();
            frm.Show();
            this.Hide();
        }


    }
}
