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
    public partial class frmazkirot : Form
    {
        public frmazkirot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.mazkirotDataTable mz;
        private void frmazkirot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.mazkirot' table. You can move, or remove it, as needed.
            this.mazkirotTableAdapter.Fill(this.abedDataSet.mazkirot);
            
            // TODO: This line of code loads data into the 'abedDataSet.mazkirot' table. You can move, or remove it, as needed.
            this.mazkirotTableAdapter.Fill(this.abedDataSet.mazkirot);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text=textBox10.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string tSt =textBox1.Text;

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

        private void button3_Click(object sender, EventArgs e)
        {
            bool br = true;

            if (textBox1.Text == "" || textBox11.Text == "" || mstextBox4.Text == "   -" || textBox5.Text == "" || textBox2.Text == "" || textBox7.Text == "" || mstextBox3.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    br = false;
                }
            
            mz = abedDataSet.mazkirot;
            string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mz.Rows.Count) && bl; j++)
            {
                ss = mz.Rows[j]["tz"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("עובד זה קיים");
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
                    cmd.CommandText = "INSERT Into mazkirot ([tz],[shem mazkira],[shem meshpaha],gel,[num tele],ctovet,[cama shaot],mascoret,mail,code) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox11.Text + "','" + mstextBox3.Text + "','" + mstextBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmazkirot_Load(sender, e);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           bool bt=true;
                if (textBox10.Text == "" || textBox11.Text == "" || mstextBox4.Text == "" || textBox5.Text == "" || textBox2.Text == "" ||  textBox7.Text == "" || mstextBox3.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }
          if(bt)
          {
             OleDbCommand cmd = new OleDbCommand();
             cmd.CommandText = "UPDATE mazkirot set [shem mazkira]='" + textBox2.Text + "',[shem meshpaha]='" + textBox11.Text + "',gel='" + mstextBox3.Text + "',[num tele]='" + mstextBox4.Text + "',ctovet='" + textBox5.Text + "',[cama shaot]='" + textBox7.Text + "',mascoret='" + textBox8.Text + "',mail='" + textBox6.Text + "' where [tz ovd]='" + textBox1.Text + "' ";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            frmazkirot_Load(sender, e);
          }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (dr == DialogResult.Yes)
             {
                 OleDbCommand cmd = new OleDbCommand();
                 cmd.CommandText = "Delete from mazkirot where [tz] = '" + textBox1.Text + "' ";
                 cmd.Connection = con;
                 con.Open();
                 cmd.ExecuteNonQuery();
                 con.Close();
                 frmazkirot_Load(sender, e);
             }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.Text.Length > 0)
            //{
            //    string tSt = textBox3.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox3.Text = st;
            //        }
            //        else
            //            textBox3.Clear();
            //    }
            //}
        }

       

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 0)
            {
                string tSt = textBox7.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox7.Text = st;
                    }
                    else
                        textBox7.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        //if (textBox4.Text.Length > 0)
        //    {
        //        string tSt = textBox4.Text;

        //        int i = tSt.Length - 1;

        //        if (!char.IsNumber(tSt[i]))
        //        {

        //            MessageBox.Show("הקש רק מספר");
        //            if (tSt.Length > 1)
        //            {
        //                string st;
        //                st = tSt.Substring(0, tSt.Length - 1);
        //                textBox4.Text = st;
        //            }
        //            else
        //                textBox4.Clear();
        //        }
        //    }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 0)
            {
                string tString = textBox11.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox11.Text = st;
                    }
                    else
                        textBox11.Clear();

                }
            }
        

        }

        private void mstextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mstextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("tz");
            dz.Columns.Add("shem mazkira");
            dz.Columns.Add("shem meshpaha");
            dz.Columns.Add("gel");
            dz.Columns.Add("num tele");
            dz.Columns.Add("ctovet");
            dz.Columns.Add("cama shaot");
            dz.Columns.Add("mascoret");
            dz.Columns.Add("mail");
            abedDataSet.mazkirotDataTable mz;
            mz = abedDataSet.mazkirot;

            for (int j = 0; j < mz.Rows.Count; j++)
            {

                if (mz.Rows[j][0].ToString().Contains(textBox9.Text))
                {
                    dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                    j = mz.Columns.Count;
                }

            }

            dataGridView1.DataSource = dz;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmshot mzk = new frmshot();
            mzk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
