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
    public partial class sokhnim : Form
    {
        public sokhnim()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.sokhanimDataTable sk;
        private void sokhnim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete from sokhanim where [shem sokhen]='" + textBox1.Text + "' ";
                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                sokhnim_Load(sender, e);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool bt = true;

            if (textBox1.Text == "" || textBox6.Text == "" || textBox4.Text == "" || mstextBox5.Text == "(   )    -" || textBox2.Text == "" || textBox8.Text == "" || textBox7.Text == "" )
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }
            
            sk = abedDataSet.sokhanim;
            string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < sk.Rows.Count) && bl; j++)
            {
                ss = sk.Rows[j]["shem sokhen"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("ספק זה קיים");
                    bl = false;
                    textBox1.Clear();
                }
                int z;
                int x;
                int y;

                if (!(textBox2.Text == ""))
                {
                    x = Convert.ToInt32(textBox3.Text);
                    y = Convert.ToInt32(textBox2.Text);

                    if (y <= x)
                    {
                        z = x - y;
                    }
                    else
                    {
                        z = x - y;
                        MessageBox.Show("no");
                        textBox2.Clear();
                    }


                }
                else
                {
                    x = Convert.ToInt32(textBox3.Text);
                    z = x + 0;
                }

                textBox9.Text = z.ToString();
            }
            if (bl == true&&bt)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into sokhanim ([shem sokhen],[tz sokhen],[shem meshpahe],ktoet,[misper tele],[maskoret],yaad,[kama machar],[kama nmchar]) Values('" + textBox1.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + mstextBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox9.Text + "')";

                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    sokhnim_Load(sender, e);

                    textBox9.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    mstextBox5.Clear();
                    mstextBox5.Clear();
                    textBox4.Clear();
                    textBox8.Clear();
                    textBox7.Clear();
                    textBox6.Clear();
                    textBox2.Clear();
                }
            }

        }            

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool bt = true;
            if (textBox11.Text == "" || textBox6.Text == "" || textBox4.Text == "" || mstextBox5.Text == "(   )    -" || textBox2.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                }
            int z;
            int x;
            int y;

            if (!(textBox2.Text == ""))
            {
                x = Convert.ToInt32(textBox3.Text);
                y = Convert.ToInt32(textBox2.Text);

                if (y <= x)
                {
                    z = x - y;
                }
                else
                {
                    z = x + 0;
                    MessageBox.Show("no");
                    textBox2.Clear();
                }


            }
            else
            {
                x = Convert.ToInt32(textBox3.Text);
                z = x + 0;
            }
            textBox9.Text = z.ToString();
                if (bt)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE  sokhanim set [tz sokhen]='" + textBox8.Text + "',[shem meshpahe]='" + textBox7.Text + "',ktoet='" + textBox6.Text + "',[misper tele]='" + mstextBox5.Text + "',maskoret='" + textBox4.Text + "',yaad='" + textBox3.Text + "',[kama machar]='" + textBox2.Text + "',[kama nmchar]='" + textBox9.Text + "' where [shem sokhen]='" + textBox1.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    sokhnim_Load(sender, e);
                }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("shem sokhen");
            dz.Columns.Add("tz sokhen");
            dz.Columns.Add("shem meshpahe");
            dz.Columns.Add("ktoet");
            dz.Columns.Add("misper tele");
            dz.Columns.Add("maskoret");
            dz.Columns.Add("yaad");
            dz.Columns.Add("kama machar");
            dz.Columns.Add("kama nmchar");
            abedDataSet.sokhanimDataTable mz;
            mz = abedDataSet.sokhanim;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox10.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Visible = false;

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox11.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 0)
            {
                string tSt = textBox8.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox8.Text = st;
                    }
                    else
                        textBox8.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if (textBox5.Text.Length > 0)
            //{
            //    string tSt = textBox5.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox5.Text = st;
            //        }
            //        else
            //            textBox5.Clear();
            //    }
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                string tSt = textBox4.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox4.Text = st;
                    }
                    else
                        textBox4.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                string tSt = textBox3.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox3.Text = st;
                    }
                    else
                        textBox3.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
                   
            


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text.Length > 0)
            {
                string tString = textBox7.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox7.Text = st;
                    }
                    else

                        textBox7.Clear();
                }
            }
        }


               

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                string tSt = textBox6.Text;

                int i = tSt.Length - 1;

                if (char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox6.Text = st;
                    }
                    else
                        textBox6.Clear();
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmkhirot sp = new frmkhirot();
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sokhanimBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sokhanimBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sokhanimBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sokhanimBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;

            button7.Visible = false;

            textBox9.Clear();
            textBox3.Clear();
            textBox4.Clear();      
            mstextBox5.Clear();
            mstextBox5.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox2.Clear();
            textBox11.Clear();

            textBox11.Enabled = true;
            textBox9.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;

           

            button10.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;

            button7.Visible = false;



            textBox11.Enabled = true;
            textBox9.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;



            btn1.Visible = false;
            button8.Visible = false;
            button2.Visible = false;
            button9.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

            

            textBox9.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            mstextBox5.Enabled = false;
            mstextBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;

            btn1.Visible = true;
            button10.Visible = true;
            button1.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;

            button9.Visible = false;
            button8.Visible = false;
            button1.Visible = false;
            button10.Visible = false;
            btn1.Visible = false;
        }
    }
}
