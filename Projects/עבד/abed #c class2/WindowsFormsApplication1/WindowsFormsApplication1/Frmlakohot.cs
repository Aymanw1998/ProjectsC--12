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
    public partial class Frmlakohot : Form
    {
        public Frmlakohot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.LAKOHOTDataTable lk;
        abedDataSet.sokhanimDataTable sk;

        private void Frmlakohot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
            // TODO: This line of code loads data into the 'abedDataSet.LAKOHOT' table. You can move, or remove it, as needed.
            this.lAKOHOTTableAdapter.Fill(this.abedDataSet.LAKOHOT);

            sk = abedDataSet.sokhanim;
            for (int i = 0; i < sk.Rows.Count; i++)
            {
                comboBox1.Items.Add(sk.Rows[i]["shem sokhen"].ToString());
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool by=true;
            if (textBox1.Text == "" || mstextBox5.Text == "(   )    -" || mstextBox4.Text == "" || comboBox1.Text=="" || textBox2.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    by = false;
                }
           
            lk = abedDataSet.LAKOHOT;
            string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < lk.Rows.Count) && bl; j++)
            {
                ss = lk.Rows[j]["shem lakoah"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("לקוח זה קיים");
                    bl = false;
                    textBox1.Clear();
                }
            }

            if (bl == true&&by==true)
            {

                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into LAKOHOT ([shem lakoah],[mspar tele],tz,[shem sokhen],azor) Values('" + textBox1.Text + "','" + mstextBox5.Text + "','" + mstextBox4.Text + "','" + comboBox1.SelectedItem + "','" + textBox2.Text + "')";
                    cmd.Connection = con;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Frmlakohot_Load(sender, e);

                    textBox7.Clear();
                    mstextBox5.Clear();
                    mstextBox4.Clear();

                    textBox2.Clear();
                }
            }

            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool bt = true;
            if (textBox7.Text == "" || mstextBox5.Text == "(   )    -" || mstextBox4.Text == "" || comboBox1.SelectedItem == "" || textBox2.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }
          if(bt)
            {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE   LAKOHOT set [mspar tele]='" + mstextBox5.Text + "',tz='" + mstextBox4.Text + "',[shem sokhen]='" + comboBox1.SelectedItem + "',azor='" + textBox2.Text + "' where [shem lakoah]='" + textBox1.Text + "'";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Frmlakohot_Load(sender, e);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Delete from LAKOHOT where [shem lakoah] = '" + textBox1.Text + "' ";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Frmlakohot_Load(sender, e); 
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Text.Length > 0)
            //{
            //    string tSt = textBox4.Text;

            //    int i = tSt.Length - 1;

            //    if (char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox4.Text = st;
            //        }
            //        else
            //            textBox4.Clear();
            //    }
            //}
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if (textBox5.Text.Length > 0)
            //{
            //    string tSt = textBox5.Text;

            //    int i = tSt.Length - 1;

            //    if (char.IsNumber(tSt[i]))
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("shem lakoah");
            dz.Columns.Add("mspar tele");
            dz.Columns.Add("tz");
            dz.Columns.Add("shem sokhen");
            dz.Columns.Add("azor");
            abedDataSet.LAKOHOTDataTable mz;
            mz = abedDataSet.LAKOHOT;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox6.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Visible = false;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox7.Text;
            
        }

        private void mstextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mstextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lAKOHOTBindingSource.MoveFirst();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lAKOHOTBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lAKOHOTBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lAKOHOTBindingSource.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;

            textBox7.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox4.Enabled = true;
            comboBox1.Enabled = true;
            textBox2.Enabled = true;

            textBox7.Clear();
            mstextBox5.Clear();
            mstextBox4.Clear();
            
            textBox2.Clear();

           


            button3.Visible = false;
            button8.Visible = false;
            button4.Visible = false;
            button9.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;

            textBox7.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox4.Enabled = true;
            comboBox1.Enabled = true;
            textBox2.Enabled = true;

            




            btn2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

            textBox7.Enabled = true;
            mstextBox5.Enabled = true;
            mstextBox4.Enabled = true;
            comboBox1.Enabled = true;
            textBox2.Enabled = true;

           




            button3.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            btn2.Visible = false;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button7.Visible = true;

            textBox7.Enabled = false;
            mstextBox5.Enabled = false;
            mstextBox4.Enabled = false;
            comboBox1.Enabled = false;
            textBox2.Enabled = false;

           




            button3.Visible = true;
            button8.Visible = true;
            button4.Visible = true;
            button9.Visible = true;
            btn2.Visible=true;

        }
    }
}
