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
    public partial class frmkhirot : Form
    {
        public static string pass;
        public static string pass2;
        public static string pass3;
        public static string pass4;
        public static string pass5;
        public static string pass6;
        public static string pass7;

        public frmkhirot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.dhmDataTable dh;
        abedDataSet.sokhanimDataTable sk;
        abedDataSet.LAKOHOTDataTable lk;
        private void frmkhirot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.dhm' table. You can move, or remove it, as needed.
            this.dhmTableAdapter.Fill(this.abedDataSet.dhm);
            // TODO: This line of code loads data into the 'abedDataSet.LAKOHOT' table. You can move, or remove it, as needed.
            this.lAKOHOTTableAdapter.Fill(this.abedDataSet.LAKOHOT);
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
            // TODO: This line of code loads data into the 'abedDataSet.dhm' table. You can move, or remove it, as needed.
            this.dhmTableAdapter.Fill(this.abedDataSet.dhm);
           
            // TODO: This line of code loads data into the 'abedDataSet.dhm' table. You can move, or remove it, as needed.
            this.dhmTableAdapter.Fill(this.abedDataSet.dhm);
            sk = abedDataSet.sokhanim;
            for (int i = 0; i < sk.Rows.Count; i++)
            {
                comboBox8.Items.Add(sk.Rows[i]["shem sokhen"].ToString());
            }

            lk = abedDataSet.LAKOHOT;
            for (int i = 0; i < lk.Rows.Count; i++)
            {
                comboBox2.Items.Add(lk.Rows[i]["tz"].ToString());
            }
            
            ms2.Text = DateTime.Now.ToString();
            comboBox8.Text = "";
            comboBox2.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void דוח_Click(object sender, EventArgs e)
        {

        }

        private void doh_mhirotDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

            dh = abedDataSet.dhm;
            pass = textBox3.Text;
            pass2 = textBox1.Text;
            pass3 = comboBox8.Text;
            pass4 = ms2.Text;
            pass5 = comboBox2.Text;
            pass6 = textBox5.Text;
            pass7 = textBox8.Text;

            bool bt = true;
            if ( comboBox8.Text == "" || comboBox2.Text == "" || textBox1.Text == ""  )
            {
                MessageBox.Show("נא להקיש  נתונים ");
                bt = false;
            }
            if (bt)
            {
                frmhlk22 fm = new frmhlk22();
                fm.Show();

                pass2 = null;
                pass = null;
                pass3 = null;
                pass4 = null;
                pass5 = null;
                pass6 = null;
                pass7 = null;
            }



            
        


            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("mispar heshbonit");
            dz.Columns.Add("shem sokhen");
            dz.Columns.Add("date");
            dz.Columns.Add("to");
            dz.Columns.Add("code motzar");
            dz.Columns.Add("shem motzar");
            dz.Columns.Add("cmot");
            dz.Columns.Add("mikom");
            abedDataSet.dhmDataTable mz;
            mz = abedDataSet.dhm;

            for (int j = 0; j < mz.Rows.Count; j++)
            {
               
                    if (mz.Rows[j][0].ToString().Contains(textBox4.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4],mz[j][5],mz[j][6],mz[j][7]);
                        j = mz.Columns.Count;
                    }
                
            }

            dataGridView1.DataSource = dz;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("האם רוצה למחוק", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dr == DialogResult.Yes)
            //{
            //    OleDbCommand cmd = new OleDbCommand();
            //    cmd.CommandText = "Delete from dhm where [mispar heshbonit]='" + textBox2.Text + "' ";
            //    cmd.Connection = con;
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    frmkhirot_Load(sender, e);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bt = true;

            if (textBox2.Text == "" || textBox9.Text == "" || ms2.Text == "  /  /" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("נא להקיש  נתונים ");
                bt = false;
            }
            if (bt)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE  dhm set to='" + textBox4.Text + "',[tz lak]='" + textBox5.Text + "'date='" + ms2.Text + "',[shem soken]='" + comboBox8.Text + "' where [mispar heshbonit]='" + textBox2.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                frmkhirot_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 0)
            {
                string tString = textBox9.Text;

                int i = tString.Length - 1;

                if (!char.IsLetter(tString[i]))
                {

                    MessageBox.Show("הקש רק אותיות");
                    if (tString.Length > 1)
                    {
                        string st;
                        st = tString.Substring(0, tString.Length - 1);
                        textBox9.Text = st;
                    }
                    else
                        textBox9.Clear();

                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmhlk22 mk = new frmhlk22();
            mk.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            sk = abedDataSet.sokhanim;
            textBox5.Text = sk.Rows[comboBox8.SelectedIndex]["yaad"].ToString();
            textBox8.Text = sk.Rows[comboBox8.SelectedIndex]["kama machar"].ToString();
        }

        private void ms2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;

            textBox9.Enabled = true;
            ms2.Enabled = true;
            textBox6.Enabled = true;
            textBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox8.Enabled = true;


           



            
            button7.Visible = false;
            button1.Visible = false;
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lk = abedDataSet.LAKOHOT;
            textBox1.Text = lk.Rows[comboBox2.SelectedIndex]["shem lakoah"].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;

            textBox9.Enabled = true;
            
            textBox6.Enabled = true;
            textBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox8.Enabled = true;


            textBox9.Clear();
            
            textBox6.Clear();
            


            button3.Visible = false;
            button6.Visible = false;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button7.Visible = true;

            textBox9.Enabled = false;
            ms2.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox8.Enabled = false;





            button1.Visible = true;
            button3.Visible = true;
            button6.Visible =true;
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
