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
    public partial class frmMnhlim : Form
    {
        public frmMnhlim()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.mnahelDataTable mn;

        private void frmMnhlim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.mnahel' table. You can move, or remove it, as needed.
            this.mnahelTableAdapter.Fill(this.abedDataSet.mnahel);
            // TODO: This line of code loads data into the 'abedDataSet.mnahel' table. You can move, or remove it, as needed.
            this.mnahelTableAdapter.Fill(this.abedDataSet.mnahel);
            
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }           

        private void button2_Click(object sender, EventArgs e)
        {
            bool bt = true;

            if (textBox1.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "" || mstextBox2.Text == "(   )    -" || mstextBox10.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }
            
             mn =abedDataSet.mnahel;
             string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mn.Rows.Count) && bl; j++)
            {
                ss = mn.Rows[j]["tz mnehel"].ToString();
                if (ss.Equals(s))
                {
                    MessageBox.Show("מנהל זה קיים");
                    bl = false;
                    textBox1.Clear();
                }
            }


            if (bl == true&&bt==true)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into mnahel ([tz mnehel],[shem mnehel],[shem mashpaha],ctovet,[nam tele],gel,mascoret,code) Values('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + mstextBox2.Text + "','" + mstextBox10.Text + "','" + textBox9.Text + "','" + textBox2.Text + "')";

                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmMnhlim_Load(sender, e);
                }

            }

            



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Delete from mnahel where [tz mnehel] = '" + textBox1.Text + "' ";

            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            frmMnhlim_Load(sender, e);



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool bt = true;
            if (textBox1.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "" || mstextBox10.Text == "" || mstextBox2.Text == "(   )    -" || textBox9.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }
                if (bt)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE mnahel set [shem mnehel]='" + textBox5.Text + "',[shem mashpaha]='" + textBox4.Text + "',ctovet='" + textBox3.Text + "',[nam tele]='" + mstextBox2.Text + "',gel='" + mstextBox10.Text + "',MASCORET='" + textBox9.Text + "' code='" + textBox2.Text + "'where [tz mnehel]='" + textBox1.Text + "'";

                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmMnhlim_Load(sender, e);
                }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("tz mnehel");
            dz.Columns.Add("shem mnehel");
            dz.Columns.Add("shem mashpaha");
            dz.Columns.Add("ctovet");
            dz.Columns.Add("nam tele");
            dz.Columns.Add("gel");
            dz.Columns.Add("MASCORET");
            abedDataSet.mnahelDataTable mz;
            mz = abedDataSet.mnahel;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox6.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            //textBox7.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = textBox7.Text;
           

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                string tString = textBox5.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox5.Text = st;
                    }
                    else
                        textBox5.Clear();

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text.Length > 0)
            //{
            //    string tSt = textBox2.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox2.Text = st;
            //        }
            //        else
            //            textBox2.Clear();

            //    }
            //}
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //if (textBox10.Text.Length > 0)
            //{
            //    string tSt = textBox10.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox10.Text = st;
            //        }
            //        else
            //            textBox10.Clear();

            //    }
            //}
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 0)
            {
                string tSt = textBox9.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox9.Text = st;
                    }
                    else
                        textBox9.Clear();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmshot mzk = new frmshot();
            mzk.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mnahelBindingSource.MoveFirst();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            mnahelBindingSource.MoveNext();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            mnahelBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mnahelBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;

            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox9.Clear();
            mstextBox10.Clear();
            mstextBox2.Clear();

            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox9.Enabled = true;
            mstextBox10.Enabled = true;
            mstextBox2.Enabled = true;
            textBox7.Enabled = true;

            btn3.Visible = false;
            button8.Visible = false;
            button1.Visible = false;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn3.Visible = true;
            button8.Visible = true;
            button1.Visible = true;
            button9.Visible = true;
            button7.Visible = true;
            btn2.Visible = true;

            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox9.Enabled = false;
            mstextBox10.Enabled = false;
            mstextBox2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn3.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            btn2.Visible = false;

            
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox9.Enabled = true;
            mstextBox10.Enabled = true;
            mstextBox2.Enabled = true;

            btn3.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            btn2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            button1.Visible = false;
            button7.Visible = false;
            btn2.Visible = false; 
            button8.Visible = false;
            button9.Visible = false;
            btn2.Visible = false;

             textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox9.Enabled = true;
            mstextBox10.Enabled = true;
            mstextBox2.Enabled = true;
        }

        private void textBox7_Click_1(object sender, EventArgs e)
        {
            textBox7.Visible = false;
        }
    }
}
