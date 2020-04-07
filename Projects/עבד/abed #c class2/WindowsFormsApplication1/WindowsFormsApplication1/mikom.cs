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
    public partial class mikom : Form
    {
        public mikom()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.mikomDataTable mk;
        private void mikom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.motzarim' table. You can move, or remove it, as needed.
            this.motzarimTableAdapter.Fill(this.abedDataSet.motzarim);
            // TODO: This line of code loads data into the 'abedDataSet.mikom' table. You can move, or remove it, as needed.
            this.mikomTableAdapter.Fill(this.abedDataSet.mikom);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

           
            //mk = abedDataSet.mikom;
            //string s = txt1.Text;
            //bool bl = true;
            //string ss;
            //for (int j = 0; (j < mk.Rows.Count) && bl; j++)
            //{
            //    ss = mk.Rows[j]["mikom"].ToString();
            //    if (s.Equals(ss))
            //    {
            //        MessageBox.Show("מוצר זה יש לו מקןם");
            //        bl = false;
            //        txt1.Clear();
            //    }
            //}

            

            //if (bl == true)
            //{
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into mikom (mikom,code,shrm,cmot) Values('" + txt1.Text + "','" + mstextBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    mikom_Load(sender, e);

                    txt1.Clear();
                    mstextBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            //}

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete from mikom where mikom = '" + txt1.Text + "' ";

                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                mikom_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button16.Visible = true;
            string s;
             mk = abedDataSet.mikom;
            bool bt = true;
            if (mstextBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || txt1.Text == ""  )
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }


            if (bt)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE  mikom  SET code='" + mstextBox2.Text + "',shrm='" + textBox3.Text + "',cmot='" + textBox4.Text + "' where mikom='" + txt1.Text + "' ";
                    
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    s = txt1.Text;

                    button16_Click(sender, e);

                    button15_Click(sender, e);
                    
                
                
                }
            mikom_Load(sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            DataTable dz = new DataTable();
            dz.Columns.Add("mikom");
            dz.Columns.Add("code");
            dz.Columns.Add("shrm");
            dz.Columns.Add("cmot");
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

        private void textBox7_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            //txt2.Visible = false;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //txt1.Text = txt2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                string tString = textBox3.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                         st = tString.Substring(0, tString.Length - 1);
                        textBox3.Text = st;
                    }
                    else
                        textBox3.Clear();
                       

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                string tSt= textBox4.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string s1;
                        s1 = tSt.Substring(0, tSt.Length - 1);
                        textBox4.Text = s1;
                    }
                    else
                        textBox4.Clear();

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mstextBox2.Text == "   -")
                  MessageBox.Show("ok");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            mikom_Load(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Visible = false;
           
            txt1.Enabled = true;
            mstextBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            txt1.Clear();
            mstextBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            button4.Visible = false;
            button7.Visible = false;
            button3.Visible = false;
            button8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;

            txt1.Enabled = true;
            mstextBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            

            button4.Visible = false;
            button7.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button2.Visible = true;

            txt1.Enabled = false;
            mstextBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            button4.Visible = true;
            button7.Visible = true;
            button3.Visible = true;
            button8.Visible = true;
            button16.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;

            txt1.Enabled = true;
            mstextBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;


            button2.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button8.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mikomBindingSource.MoveFirst();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mikomBindingSource.MoveNext();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mikomBindingSource.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mikomBindingSource.MoveLast();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("code");
            dz.Columns.Add("shem");
            dz.Columns.Add("cama alot");
            dz.Columns.Add("cama nmchar");
            dz.Columns.Add("mi hspak");
            dz.Columns.Add("mikom");
            dz.Columns.Add("kmot");
            dz.Columns.Add("kama nmhar");
            dz.Columns.Add("kama neshar");
            abedDataSet.motzarimDataTable mz;
            mz = abedDataSet.motzarim;
            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView2.DataSource = dz;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE  motzarim  SET mikom='" + txt1.Text +  "' where code='" + mstextBox2.Text + "'";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            mikom_Load(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; mk.Rows.Count > i; i++)
            {
                if ((mk.Rows[i]["code"].ToString()) == mstextBox2.Text && !(mk.Rows[i]["mikom"].Equals(txt1.Text)))
                {
                    
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE  mikom  SET code='" + null + "',shrm='" + null + "',cmot='" + null+ "' where mikom='" + mk.Rows[i]["mikom"].ToString() + "' ";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mikom_Load(sender, e);
                }
            }
            
        }






    }
}

