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
    public partial class frmOvdim : Form
    {
        public frmOvdim()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.ovdimDataTable ov;
        private void frmOvdim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.ovdim' table. You can move, or remove it, as needed.
            this.ovdimTableAdapter.Fill(this.abedDataSet.ovdim);
            //// TODO: This line of code loads data into the 'abedDataSet.ovdim' table. You can move, or remove it, as needed.
            //this.ovdimTableAdapter.Fill(this.abedDataSet.ovdim);
           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tSt = txt1.Text;
            if (tSt.Length > 0)
            {          
                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        txt1.Text = st;
                    }
                    else
                        txt1.Clear();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           
            bool bt = true;
            if (txt1.Text == "" || textBox6.Text == "" || mstextBox4.Text == "(   )    -" || mstextBox5.Text == "" || textBox2.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox1.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("נא להקיש  נתונים ");
                    bt = false;
                }

            ov = abedDataSet.ovdim;
            string s = txt1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < ov.Rows.Count) && bl; j++)
            {
                ss = ov.Rows[j]["tz ovd"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("עובד זה קיים");
                    bl = false;
                    txt1.Clear();
                }
            }
            
            if (bl == true&&bt)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into ovdim ([tz ovd],[shem ovd],[shem meshpaha],taphkid,cod,gel,[num tele],ctovet,[cama shaot],[mascoret]) Values('" + txt1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + mstextBox5.Text + "','" + mstextBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox8.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmOvdim_Load(sender, e);

                    textBox1.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    txt2.Clear();
                    textBox9.Clear();
                    mstextBox4.Clear();
                    mstextBox5.Clear();
                    textBox4.Clear();
                    textBox8.Clear();
                    textBox7.Clear();
                    textBox6.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete from ovdim where [tz ovd] = '" + txt1.Text + "' ";

                cmd.Connection = con;
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                frmOvdim_Load(sender, e);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool bt1 = true;
            if (txt1.Text == "" || textBox6.Text == "" || mstextBox4.Text == "(   )    -" || mstextBox5.Text == "" || textBox2.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("נא להקיש  נתונים ");
                bt1 = false;
            }
                if (bt1)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE   ovdim set [shem ovd]='" + textBox7.Text + "',[shem meshpaha]='" + textBox6.Text + "',taphkid='" + textBox4.Text + "',cod='" + textBox1.Text + "',gel='" + mstextBox5.Text + "',[num tele]='" + mstextBox4.Text + "',ctovet='" + textBox3.Text + "',[cama shaot]='" + textBox2.Text + "' where [tz ovd]='" + txt1.Text + "' ";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmOvdim_Load(sender, e);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("tz ovd");
            dz.Columns.Add("shem ovd");
            dz.Columns.Add("shem meshpaha");
            dz.Columns.Add("gel");           
            dz.Columns.Add("num tele");
            dz.Columns.Add("ctovet");
            dz.Columns.Add("cama shaot");
            dz.Columns.Add("mascoret");
            abedDataSet.ovdimDataTable mz;
            mz = abedDataSet.ovdim;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox9.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text;
            
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txt2.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
      
            //if (textBox4.Text.Length > 0)
            //{
            //    string tSt = textBox4.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text.Length > 0)
            {
                string tSt = textBox2.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox2.Text = st;
                    }
                    else
                        textBox2.Clear();
                }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (textBox6.Text.Length > 0)
            {
                string tString = textBox6.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox6.Text = st;
                    }
                    else
                        textBox6.Clear();

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmshot mzk = new frmshot();
            mzk.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ovdimBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ovdimBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ovdimBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ovdimBindingSource.MoveLast();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

            button7.Visible = true;
            button10.Visible = true;
            button8.Visible = true;

            textBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            txt2.Enabled = false;
            textBox9.Enabled = false;
            mstextBox4.Enabled = false;
            mstextBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            textBox6.Enabled = false;

            btn3.Visible = true;
            button10.Visible = true;
            button1.Visible = true;
            button8.Visible = true;
            btn2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Visible = true;

            button7.Visible = false;

            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txt2.Clear();
            textBox9.Clear();
            mstextBox4.Clear();
            mstextBox5.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox2.Clear();

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            txt2.Enabled = true;
            textBox9.Enabled = true;
            mstextBox4.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;

            btn3.Visible = false;
            button10.Visible = false;
            button1.Visible = false;
            button8.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button9.Visible = true;
            button7.Visible = false;

            

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            txt2.Enabled = true;
            textBox9.Enabled = true;
            mstextBox4.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;

            btn2.Visible = false;
            button7.Visible = false;
            button1.Visible = false;
            button8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Visible = true;

            button8.Visible = false;

           

            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            txt2.Enabled = true;
            textBox9.Enabled = true;
            mstextBox4.Enabled = true;
            mstextBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Enabled = true;

            btn3.Visible = false;
            button10.Visible = false;
            btn2.Visible = false;
            button7.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        
    }
}
