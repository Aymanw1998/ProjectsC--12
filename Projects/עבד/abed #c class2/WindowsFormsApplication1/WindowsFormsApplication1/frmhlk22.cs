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
    public partial class frmhlk22 : Form
    {
        public frmhlk22()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.sokhanimDataTable sk;

        abedDataSet.dhmDataTable t;
        abedDataSet.motzarimDataTable mz;
        
        
      
        private void button1_Click(object sender, EventArgs e)
        {

            //int x = t.Rows.Count + 1;
            //string str = x.ToString();
            //textBox2.Text = str.ToString();

            string s = textBox3.Text;
            bool bl = true;
            string ss;
           
                for (int j = 0; (j < (dataGridView1.Rows.Count-1)) && bl; j++)
                {
                    ss = dataGridView1.Rows[j].Cells[1].Value.ToString();
                    if (s.Equals(ss))
                    {
                        MessageBox.Show("מוצר זה נוסף");
                        bl = false;
                        textBox3.Clear();
                    }
                }

                if (bl && !(textBox6.Text == "") && !(textBox3.Text == ""))
                {
                    DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, textBox9.Text, textBox13.Text, textBox5.Text, textBox6.Text, comboBox1.Text, textBox11.Text, textBox7.Text, maskedTextBox1.Text);
                    }
                    textBox6.Text = "";
                    button5.Visible = true;
                    
                }
                else
                    MessageBox.Show("הקש נתונים");


           

        }

        private void frmhlk22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet4.hazmnt_lak' table. You can move, or remove it, as needed.
            this.hazmnt_lakTableAdapter.Fill(this.abedDataSet4.hazmnt_lak);
            // TODO: This line of code loads data into the 'abedDataSet.hazmnt_lak' table. You can move, or remove it, as needed.
            this.hazmnt_lakTableAdapter.Fill(this.abedDataSet.hazmnt_lak);
            // TODO: This line of code loads data into the 'abedDataSet.motzarim' table. You can move, or remove it, as needed.
            this.motzarimTableAdapter.Fill(this.abedDataSet.motzarim);
           
         
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
            // TODO: This line of code loads data into the 'abedDataSet.dhm' table. You can move, or remove it, as needed.
            this.dhmTableAdapter.Fill(this.abedDataSet.dhm);

            
            t = abedDataSet.dhm;
            sk = abedDataSet.sokhanim;

            int x = t.Rows.Count + 1;
            string str = x.ToString();
            textBox2.Text = str.ToString();

            for (int i = 0; i < sk.Rows.Count; i++)
            {
                comboBox1.Items.Add(sk.Rows[i]["shem sokhen"].ToString());
            }
            textBox2.Text = frmkhirot.pass;
            textBox7.Text = frmkhirot.pass2;
            comboBox1.Text = frmkhirot.pass3;
            textBox11.Text = frmkhirot.pass5;
            maskedTextBox1.Text = frmkhirot.pass4;
            textBox15.Text = frmkhirot.pass6;
            textBox17.Text = frmkhirot.pass7;




           


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                button11.Visible = true;
                button9_Click_1(sender, e);
                button13_Click(sender, e);


                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {



                    cmd.CommandText = "INSERT Into [hazmnt lak] ([mispar heshbonit],code,[tz lak],[shem mot],[cama nmchar],mikom,cmot,[shem sokhen],ell,tarikh) Values('" + textBox2.Text + "', '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[7].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "','" + textBox7.Text + "','" + maskedTextBox1.Text + "')";

                    cmd.ExecuteNonQuery();



                }


                con.Close();

                button11_Click(sender, e);

                frmhlk22_Load(sender, e);
                button10.Visible = false;
                button11.Visible = false;
                button6.Visible = true;
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            t = abedDataSet.dhm;
            int i = t.Rows.Count + 1;

            textBox2.Text = i.ToString();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            frmhlk22_Load(sender, e);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            dataGridView3.DataSource = dz;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
           
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string st;
            int x;
            int z;
           

            x = Convert.ToInt32(textBox15.Text);
            z= Convert.ToInt32(textBox10.Text);
            st = z.ToString();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE  sokhanim set yaad='" + textBox15.Text + "',[kama machar]='" + z + "' where [shem sokhen]='" + comboBox1.Text + "'";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            button10.Visible = true;
            button10_Click_1(sender, e);
            frmhlk22_Load(sender, e);
            //button13.Visible = false;
            //button7.Visible = false;
          
        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
            double sum = 0;

            for (int y = 0; y < dataGridView1.Rows.Count; y++)
            {
                double r = Convert.ToDouble(dataGridView1.Rows[y].Cells[3].Value);

                
                sum = sum + r;

            }

            textBox10.Text = sum.ToString();

           
            double sumw = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                double x = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);

                sumw = sumw + x;

                

            }
            textBox12.Text = sumw.ToString();
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT Into dhm ([mispar heshbonit],ell,[tz lak],[sah aiska],tarikh,[shem soken],[sah cmot]) Values('" + textBox2.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "','" + maskedTextBox1.Text+"','" + comboBox1.Text + "','" + textBox12.Text + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                frmhlk22_Load(sender, e);
                
            }
            button4.Visible = true;
            button10.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                string tSt = textBox6.Text;

                int i = tSt.Length - 1;

                if (!char.IsNumber(tSt[i]))
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

            string tString = textBox6.Text;
            int z;
            int x;
            int y;
            if (!(textBox6.Text == ""))
            {

                x = Convert.ToInt32(textBox6.Text);
                y = Convert.ToInt32(textBox8.Text);
                if (x <= y)
                {
                    z = y - x;
                    textBox14.Text = z.ToString();
                    
                }
                else
                {
                    MessageBox.Show("no");
                    string st;
                    st = tString.Substring(0, tString.Length - 1);
                    textBox6.Text = st;
                }
            }
            if ((textBox6.Text == ""))
                textBox14.Text = "";


            if (!(textBox6.Text == ""))
            {
                int mhir;
                int mcolel;
                int cmot;
                cmot = Convert.ToInt32(textBox6.Text);
                mhir = Convert.ToInt32(textBox4.Text);
                mcolel = mhir * cmot;
                textBox13.Text = mcolel.ToString();
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE   motzarim  set  [kama neshar]='" + textBox14.Text + "' where code='" + textBox3.Text + "'";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            button13_Click(sender, e);
            button7_Click(sender, e);
            frmhlk22_Load(sender, e);

            button13.Visible = true;
            button7.Visible = true;
            //button11.Visible = false;

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            int x;
            int z;
            int we;
            int y;
           
            we = Convert.ToInt32(textBox15.Text);
            y = Convert.ToInt32(textBox10.Text);
            x = Convert.ToInt32(textBox17.Text);
            z = we - y - x;
            if(z>0) 
            {
                textBox16.Text = z.ToString();
            }
            else
                z=0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            button14.Visible = false;
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible=false;
            textBox6.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Visible = false;
            button4.Visible = false;
        }
        
    }
}
