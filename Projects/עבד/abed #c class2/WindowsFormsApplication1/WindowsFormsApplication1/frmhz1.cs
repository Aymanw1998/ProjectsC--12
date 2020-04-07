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

namespace WindowsFormsApplication1
{
    public partial class frmhz1 : Form
    {
        public static string pass;
        public frmhz1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.doh_spDataTable dh;
        abedDataSet.spakimDataTable sp;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmhz1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.doh_sp' table. You can move, or remove it, as needed.
            this.doh_spTableAdapter.Fill(this.abedDataSet.doh_sp);
            // TODO: This line of code loads data into the 'abedDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.abedDataSet.spakim);
            // TODO: This line of code loads data into the 'abedDataSet.doh_sp' table. You can move, or remove it, as needed.
            this.doh_spTableAdapter.Fill(this.abedDataSet.doh_sp);
            sp = abedDataSet.spakim;
            for (int i = 0; i < sp.Rows.Count; i++)
            {
                comboBox1.Items.Add(sp.Rows[i]["shem spak"].ToString());
            }
            ms2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dh = abedDataSet.doh_sp;

            pass = comboBox1.Text;
            if (textBox1.Text == "")
            {
                hzSpk fm = new hzSpk();
                fm.Show();

                pass = null;
            }
            else
                MessageBox.Show("הקש שם ספק");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE   [doh sp]  set [shem spak]='" + comboBox1.SelectedItem + "',price='" + textBox4.Text + "',tarick='" + ms2.Text + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            frmhz1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = true;

            comboBox1.Enabled = false;
            ms2.Enabled = false;
            textBox4.Enabled = false;



            button2.Visible = true;
            button1.Visible = true;
            button4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;

            comboBox1.Enabled = true;
            ms2.Enabled = true;
            
            

           
            
          
            textBox4.Clear();

            button2.Visible = false;
            button5.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;

            comboBox1.Enabled = true;
            ms2.Enabled = true;
            textBox4.Enabled = true;


            

            button1.Visible = false;
            button4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
