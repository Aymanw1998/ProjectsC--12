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
    public partial class frmmotzarim : Form
    {
        public frmmotzarim()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.motzarimDataTable mz;
        abedDataSet.spakimDataTable sp;
        abedDataSet.mikomDataTable mk;
        

        private void frmmotzarim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.mikom' table. You can move, or remove it, as needed.
            this.mikomTableAdapter.Fill(this.abedDataSet.mikom);
            // TODO: This line of code loads data into the 'abedDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.abedDataSet.spakim);
            // TODO: This line of code loads data into the 'abedDataSet.motzarim' table. You can move, or remove it, as needed.
            this.motzarimTableAdapter.Fill(this.abedDataSet.motzarim);
            sp = abedDataSet.spakim;
            mk = abedDataSet.mikom;
            for (int i = 0; i < sp.Rows.Count; i++)
            {
                comboBox1.Items.Add(sp.Rows[i]["shem spak"].ToString());
            }

            for (int i = 0; i < mk.Rows.Count; i++)
            {
                comboBox2.Items.Add(mk.Rows[i]["mikom"].ToString());
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool bt = true;
            if (textBox1.Text == "" || textBox6.Text == ""  || textBox5.Text == "" || textBox2.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("נא להקיש  נתונים ");
                bt = false;
            }
            
            mz = abedDataSet.motzarim;
            string s = textBox1.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mz.Rows.Count) && bl; j++)
            {
                ss =mz.Rows[j]["code"].ToString();
                if (s.Equals(ss))
                {
                    MessageBox.Show("מוצר זה קיים");
                    bl = false;
                    textBox1.Clear();
                }
            }

            int z;
            int x;
            int y;

            if (!(textBox9.Text == ""))
            {
                x = Convert.ToInt32(textBox10.Text);
                y = Convert.ToInt32(textBox9.Text);

                if (y <= x)
                {
                    z = x - y;
                }
                else
                {
                    z = x + 0;
                    MessageBox.Show("no");
                    textBox9.Clear();
                }


            }
            else
            {
                x = Convert.ToInt32(textBox10.Text);
                z = x + 0;
            }
            textBox8.Text = z.ToString();
              if (bl == true&&bt)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into motzarim (code,shem,[cama alot],[cama nmchar],[mi hspak],mikom,kmot,[kama nmhar],[kama neshar]) Values('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem + "','" + comboBox2.SelectedItem + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    button13_Click(sender, e);

                    frmmotzarim_Load(sender, e);

                    textBox1.Clear();

                    textBox11.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox8.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox2.Clear();
                }
              }

            

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length > 0)
            //{
            //    string tSt = textBox1.Text;

            //    int i = tSt.Length - 1;

            //    if (!char.IsNumber(tSt[i]))
            //    {

            //        MessageBox.Show("הקש רק מספר");
            //        if (tSt.Length > 1)
            //        {
            //            string st;
            //            st = tSt.Substring(0, tSt.Length - 1);
            //            textBox1.Text = st;
            //        }
            //        else
            //            textBox1.Clear();
            //    }
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Delete from motzarim where code = '" + textBox11.Text + "' ";

            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();


            frmmotzarim_Load(sender, e);

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             if (textBox5.Text.Length > 0)
            {
                string tSt = textBox5.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
                {

                    MessageBox.Show("הקש רק מספר");
                    if (tSt.Length > 1)
                    {
                        string st;
                        st = tSt.Substring(0, tSt.Length - 1);
                        textBox5.Text = st;
                    }
                    else
                        textBox5.Clear();
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int z;
            int x;
            int y;

            if (!(textBox9.Text == ""))
            {
                x = Convert.ToInt32(textBox10.Text);
                y = Convert.ToInt32(textBox9.Text);

                if (y <= x)
                {
                    z = x - y;
                }
                else
                {
                    z = x + 0;
                    MessageBox.Show("no");
                    textBox9.Clear();
                }


            }
            else
            {
                x = Convert.ToInt32(textBox10.Text);
                z = x + 0;
            }
            textBox8.Text = z.ToString();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE   motzarim  set shem='" + textBox6.Text + "',[cama alot]='" + textBox2.Text + "',[cama nmchar]='" + textBox5.Text + "',[mi hspak]='" + comboBox1.SelectedItem + "',mikom='" + comboBox2.SelectedItem + "',kmot='" + textBox10.Text + "',[kama nmhar]='" + textBox9.Text + "',[kama neshar]='" + textBox8.Text + "' where code='" + textBox1.Text + "'";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    button13_Click_1(sender, e);
                    frmmotzarim_Load(sender, e);
                   

                
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
            mz =abedDataSet.motzarim;
            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox7.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = textBox11.Text;
            
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            //textBox11.Visible = false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.Text.Length > 0)
            //{
            //    string tString = textBox4.Text;

            //    int i = tString.Length - 1;

            //    if (!char.IsLetter(tString[i]))
            //    {

            //        MessageBox.Show("הקש רק אותיות");
            //        if (tString.Length > 1)
            //        {
            //            string st;
            //            st = tString.Substring(0, tString.Length - 1);
            //            textBox4.Text = st;
            //        }
            //        else
            //            textBox4.Clear();

            //    }
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

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

        private void mstextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //mstextBox1.Text = mstextBox11.Text;
        }

        private void mstextBox11_Click(object sender, EventArgs e)
        {
            //mstextBox11.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            motzarimBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            motzarimBindingSource.MoveNext();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            motzarimBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            motzarimBindingSource.MoveLast();
        }

        private void motzarimBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_Click_1(object sender, EventArgs e)
        {
            textBox11.Visible = false;

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
             
        }

        private void frmmotzarim_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

           

            textBox1.Clear();
            
            textBox11.Clear();
            textBox9.Clear();      
            textBox10.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Clear();

            textBox11.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox8.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;

            
      
            button10.Visible = false;
            button1.Visible = false;
            button11.Visible = false;
            button4.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;



            

            textBox11.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox8.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;


            button10.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button9.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button9.Visible = true;



            

            textBox11.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox8.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;


            button5.Visible = true;
            button10.Visible = true;
            button1.Visible = true;
            button11.Visible = true;
            button4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox11.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox8.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;


            button10.Visible = false;
            button1.Visible = false;
            button11.Visible = false;
            button9.Visible = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE  mikom  SET code='" + textBox1.Text + "' where mikom='" + comboBox2.SelectedItem + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            frmmotzarim_Load(sender, e);
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
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
                    if (mz.Rows[j][k].ToString().Contains(textBox3.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView1.DataSource = dz;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE  mikom  SET code='" + textBox1.Text + "',shrm='" + textBox6.Text + "',cmot='" + textBox8.Text + "' where mikom='" + comboBox2.SelectedItem + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            frmmotzarim_Load(sender, e);
        }
    }
}
