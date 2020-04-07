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
    public partial class frmhazrot : Form
    {
        public frmhazrot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
        abedDataSet.sokhanimDataTable sk;
        abedDataSet.motzarimDataTable mz;
        abedDataSet.hazrotDataTable hz;
        
        
        private void frmhazrot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.motzarim' table. You can move, or remove it, as needed.
            this.motzarimTableAdapter.Fill(this.abedDataSet.motzarim);
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
            // TODO: This line of code loads data into the 'abedDataSet1.sokhanim' table. You can move, or remove it, as needed.
            
            this.hazrotTableAdapter.Fill(this.abedDataSet.hazrot);
            sk = abedDataSet.sokhanim;
            hz = abedDataSet.hazrot;
            mz = abedDataSet.motzarim;

            for (int i = 0; i < sk.Rows.Count; i++)
            {
                comboBox1.Items.Add(sk.Rows[i]["shem sokhen"].ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            bool bt = true;
            if(textBox2.Text==""||textBox4.Text==""||comboBox1.Text=="")
            {
                bt = false;
                MessageBox.Show("נא להקיש  נתונים ");
            }
            if (bt)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT Into hazrot ([brcode],[shem],[mikom],comt,[shem sokhen],[mhir tzarhan]) Values('" + textBox10.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedItem + "','" + textBox11.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    button1_Click(sender, e);

                    frmhazrot_Load(sender, e);

                    textBox4.Clear();
                    textBox1.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox2.Clear();
                }

            }

                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hazrotBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hazrotBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hazrotBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hazrotBindingSource.MoveLast();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("brcode");
            dz.Columns.Add("shem");
            dz.Columns.Add("mikom");
            dz.Columns.Add("comt");
            dz.Columns.Add("shem sokhen");
            dz.Columns.Add("mhir tzarhan");
            
            hz = abedDataSet.hazrot;

            for (int j = 0; j < hz.Rows.Count; j++)
            {
                for (int k = 0; k < hz.Columns.Count; k++)
                {
                    if (hz.Rows[j][k].ToString().Contains(textBox7.Text))
                    {
                        dz.Rows.Add(hz[j][0], hz[j][1], hz[j][2], hz[j][3], hz[j][4]);
                        k = hz.Columns.Count;
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;

            textBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;
            comboBox1.Enabled = true;
            textBox10.Enabled = true;

            textBox4.Clear();
            textBox1.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox2.Clear();
            textBox10.Clear();


            button10.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bt = true;
            if (textBox10.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                bt = false;
                MessageBox.Show("נא להקיש  נתונים ");
            }
            if (bt)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE   motzarim  set  [kama neshar]='" + textBox9.Text + "' where code='" + textBox8.Text + "'";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    frmhazrot_Load(sender, e);
                }
                button1.Visible = false;
                button2.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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


            if (!(textBox4.Text == ""))
            {
                int z;
                int x;
                int y;
                x = Convert.ToInt32(textBox4.Text);
                y = Convert.ToInt32(textBox3.Text);
                z = x + y;
                textBox9.Text = z.ToString();
            }
            if (!(textBox4.Text == ""))
            {
                int mhir;
                int mcolel;
                int cmot;
                cmot = Convert.ToInt32(textBox4.Text);
                mhir = Convert.ToInt32(textBox6.Text);
                mcolel = mhir * cmot;
                textBox11.Text = mcolel.ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sokhanimBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                        if (mz.Rows[j][k].ToString().Contains(textBox5.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                            k = mz.Columns.Count;
                        }
                    }
                }

                dataGridView2.DataSource = dz;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = true;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;

            textBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox8.Enabled = true;
            comboBox1.Enabled = true;
            textBox10.Enabled = true;

            



            button6.Visible = false;
            button2.Visible = false;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;
            textBox8.Enabled = false;
            comboBox1.Enabled = false;
            textBox10.Enabled = false;

            button10.Visible = true;
            button1.Visible = true;
            
            button2.Visible = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }

    }
}
