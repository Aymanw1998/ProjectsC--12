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
    public partial class spakim : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        public spakim()
        {
            InitializeComponent();
        }

        
        abedDataSet.spakimDataTable ml;
        private void spakim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.abedDataSet.spakim);
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool br = true;

            if (textBox1.Text == "" || textBox8.Text == "" || textBox2.Text == "" || mstextBox7.Text == "(   )    -" && textBox6.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    br = false;

                }

            
            ml = abedDataSet.spakim;
            string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < ml.Rows.Count) && bl; j++)
            {
                ss = ml.Rows[j]["shem spak"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("ספק זה קיים");
                    bl = false;
                    textBox1.Clear();
                }
            }
   

                if (bl == true&&br)
                {
                    DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();

                        cmd.CommandText = "INSERT Into spakim ([shem spak],[shem meshpaha],tele,ktovet,[shem hebra]) Values('" + textBox1.Text + "','" + textBox8.Text + "','" + mstextBox7.Text + "','" + textBox6.Text + "','" + textBox2.Text + "')";
                        cmd.Connection = con;
                        con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        spakim_Load(sender, e);

                        textBox1.Clear();
                        textBox4.Clear();
                        mstextBox7.Clear();
                        textBox6.Clear();
                        textBox8.Clear();
                        textBox2.Clear();
                    }
                }


                textBox4.Visible = true;
            
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete from spakim where [shem spak]='" + textBox1.Text + "' ";
                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string tString = textBox1.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox1.Text = st;
                    }
                    else
                        textBox1.Clear();


                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 0)
            {
                string tString = textBox8.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox8.Text = st;
                    }
                    else
                        textBox8.Clear();


                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //if (textBox7.Text.Length > 0)
            //{
            //    string tSt = textBox7.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string s1;
            //            s1 = tSt.Substring(0, tSt.Length - 1);
            //            textBox7.Text = s1;
            //        }
            //        else
            //            textBox7.Clear();

            //    }
            //}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string tString = textBox2.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox2.Text = st;
                    }
                    else
                        textBox2.Clear();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool br = true;
            if (textBox1.Text == "" || textBox8.Text == "" || textBox2.Text == "" || mstextBox7.Text == "(   )    -" && textBox6.Text == "")
            {
                MessageBox.Show("נא להקיש  נתונים ");
                br = false;

            }
            if (br)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE spakim set [shem meshpaha]='" + textBox8.Text + "',tele='" + mstextBox7.Text + "',ktovet='" + textBox6.Text + "',[shem hebra]='" + textBox2.Text + "' where [shem spak]='" + textBox1.Text + "'";
                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("shem spak");
            dz.Columns.Add("shem meshpaha");
            dz.Columns.Add("tele");
            dz.Columns.Add("ktovet");
            dz.Columns.Add("shem hebra");
            abedDataSet.spakimDataTable mz;
            mz = abedDataSet.spakim;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox3.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text;
            if (textBox4.Text.Length > 0)
            {
                string tString = textBox4.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox4.Text = st;
                    }
                    else
                        textBox4.Clear();


                }
            }
        }

        private void spakim_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = false;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            spakimBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spakimBindingSource.MoveNext();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            spakimBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spakimBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hzSpk spk = new hzSpk();
            spk.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;

            textBox4.Enabled = true;
            mstextBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;


            textBox4.Clear();
            mstextBox7.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox2.Clear();
            

            button10.Visible = false;
            button2.Visible = false;
            button9.Visible = false;
            button1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;

            textBox4.Enabled = true;
            mstextBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;


            


            btn2.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

            textBox4.Enabled = true;
            mstextBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;


           


            button2.Visible = false;
            button10.Visible = false;
            button8.Visible = false;
            btn2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button9.Visible = true;
            btn2.Visible = true;
            button8.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            button1.Visible = true;

            textBox4.Enabled = false;
            mstextBox7.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;
            textBox8.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      }
    
}
