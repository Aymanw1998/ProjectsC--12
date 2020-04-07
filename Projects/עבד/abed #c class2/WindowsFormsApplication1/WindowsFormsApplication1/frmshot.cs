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
    public partial class frmshot : Form
    {
        public frmshot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmshot_Load(object sender, EventArgs e)
        {
            //////// TODO: This line of code loads data into the 'abedDataSet.ovdim' table. You can move, or remove it, as needed.
            //////this.ovdimTableAdapter.Fill(this.abedDataSet.ovdim);
             //TODO: This line of code loads data into the 'abedDataSet.shaot' table. You can move, or remove it, as needed.
            this.shaotTableAdapter.Fill(this.abedDataSet.shaot);
            textBox9.Text=System.DateTime.Now.ToShortDateString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    bool bt = true;

        //    if (textBox3.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox6.Text == "" || maskedTextBox1.Text == "  /  /" || textBox2.Text == "")
        //    {
        //        MessageBox.Show("נא להקיש  נתונים ");
        //        bt = false;
        //    }
        //    if (bt)
        //    {
        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.CommandText = "UPDATE shaot set [shem ovd]='" + textBox2.Text + "',date='" + maskedTextBox1.Text + "',[shaot cnise]='" + textBox3.Text + "',yetsea='" + textBox4.Text + "',[sah shaot]='" + textBox5.Text + "'where [cod]='" + textBox6.Text + "'";

        //        cmd.Connection = con;
        //        con.Open();

        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        frmshot_Load(sender, e);
        //    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmshot_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool bt = true;

            //if (textBox3.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox6.Text == "" || maskedTextBox1.Text == "  /  /" || textBox2.Text == "")
            //{
            //    MessageBox.Show("נא להקיש  נתונים ");
            //    bt = false;
            //}

            //sh = abedDataSet.shaot; 
            //bool bl = true;       
            //if (bl == true && bt == true)
            //{
            //    DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (dr == DialogResult.Yes)
            //    {
            //        OleDbCommand cmd = new OleDbCommand();
            //        cmd.CommandText = "INSERT Into shaot(cod,[shem ovd],date,[shaot cnise],yetsea,[sah shaot]) Values('" + textBox6.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";

            //        cmd.Connection = con;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        frmshot_Load(sender, e);
            //    }

            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //private void comboBox3_Click(object sender, EventArgs e)
        //{
           
        //}

        private void button3_Click(object sender, EventArgs e)
        {

            ////OleDbCommand cmd = new OleDbCommand();
            ////cmd.CommandText = "Delete from shaot where [cod] = '" + textBox6.Text + "' ";

            ////cmd.Connection = con;
            ////con.Open();

            ////cmd.ExecuteNonQuery();
            ////con.Close();
            ////frmshot_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("code");
            dz.Columns.Add("shem ovd");
            dz.Columns.Add("date");
            dz.Columns.Add("shaot cnise");
            dz.Columns.Add("yetsea");
            dz.Columns.Add("sah shaot");
            abedDataSet.mikomDataTable mz;
            mz = abedDataSet.mikom;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox5.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox7.Text;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string tSt = textBox1.Text;

                int i = tSt.Length - 1;

                if (!char.IsLetter(tSt[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox1.Text = st;
                    }
                    else
                        textBox1.Clear();

                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string tSt = textBox1.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox1.Text = st;
                    }
                    else
                        textBox1.Clear();

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
