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
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class frm : Form
    {
        public static string pass5;
        public static int ps2=0;
       
       
        public frm()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
       
        
        private void frm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;

            button1.Focus();
            

            
          


     
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
            
                
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pass5 = textBox1.Text;
            if (frm.ps2 > 1)
                this.Close();

            frmMain ff = new frmMain();
            ff.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
