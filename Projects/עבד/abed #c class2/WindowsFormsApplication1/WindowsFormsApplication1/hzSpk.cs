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
    public partial class hzSpk : Form
    {
        public static string pass6;
        public hzSpk()
        {
            InitializeComponent();
        }


        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\abed #c class2\WindowsFormsApplication1\abed.mdb");
       
        abedDataSet.hzSpDataTable hz;
        abedDataSet.motzarimDataTable mz;
        abedDataSet.doh_spDataTable spu;

        private void hzSpk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.doh_sp' table. You can move, or remove it, as needed.
            this.doh_spTableAdapter.Fill(this.abedDataSet.doh_sp);
            // TODO: This line of code loads data into the 'abedDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.abedDataSet.spakim);
            // TODO: This line of code loads data into the 'abedDataSet.hzSp' table. You can move, or remove it, as needed.
            this.hzSpTableAdapter.Fill(this.abedDataSet.hzSp);
            // TODO: This line of code loads data into the 'abedDataSet.motzarim' table. You can move, or remove it, as needed.
            this.motzarimTableAdapter.Fill(this.abedDataSet.motzarim);

           

            comboBox1.Text = frmhz1.pass;
            maskedTextBox1.Text= DateTime.Now.ToString();

            spu = abedDataSet.doh_sp;

            int c = spu.Rows.Count + 1;

            textBox7.Text = c.ToString();

            
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox5.Text == ""))
            {
                button7.Visible = true;
                button4.Visible = true;
                button8.Visible = true;
                button10.Visible = true;


                button8_Click(sender, e);
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    con.Open();

                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {



                        cmd.CommandText = "INSERT Into hzSp ([mis heshbonit],shem,[code motzar],[shem motzar],mhir,cmot) Values('" + textBox7.Text + "', '" + dataGridView3.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView3.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView3.Rows[i].Cells[3].Value.ToString() + "', '" + dataGridView3.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView3.Rows[i].Cells[5].Value.ToString() + "')";

                        cmd.ExecuteNonQuery();



                    }



                    con.Close();

                    button4_Click(sender, e);
                }


                hzSpk_Load(sender, e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
                    if (mz.Rows[j][k].ToString().Contains(textBox6.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8]);
                        k = mz.Columns.Count;
                    }
                }
            }

            dataGridView2.DataSource = dz;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string scode;

            string sn="";
            string sd="";
            string h="";

            int sum1=0;
            int sum=0;

            int y = 0;
            int r = 0;
            int t = 0;

            mz = abedDataSet.motzarim;
            


            


                 OleDbCommand cmd = new OleDbCommand();
                 cmd.Connection = con;
                 con.Open();
                for (int i = 0; i < mz.Rows.Count - 1; i++)
                {
                    sum1 = 0;
                    sum = 0;
                    y = 0;
                    r = 0;
                    t = 0;

                    scode = mz.Rows[i]["code"].ToString();
                    

                    for (int j = 0; j < dataGridView3.Rows.Count-1; j++)
                    {
                        sd = dataGridView3.Rows[j].Cells[2].Value.ToString();
                        if (sd.Equals(scode))
                        {
                             r = Convert.ToInt32(mz.Rows[i]["kama neshar"].ToString());
                             t = Convert.ToInt32(dataGridView3.Rows[j].Cells[5].Value.ToString());
                             y = Convert.ToInt32(mz.Rows[i]["kmot"].ToString());
                             
                            sum = r + t;
                            sum1 = sum + y;
                            j = dataGridView3.Rows.Count + 9;
                            
                            sn = sum.ToString();
                            h = sum1.ToString();


                            cmd.CommandText = "UPDATE   motzarim  set kmot='" + h + "', [kama neshar]='" + sn + "' where code='" + scode + "'";

                            cmd.ExecuteNonQuery();



                        }
                      
                    }
                    
                    


                    h = "";
                    sn = "";
                    scode = "";

                    
                }

                 con.Close();
                 button7_Click(sender, e);
             
             hzSpk_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmmotzarim mzn = new frmmotzarim();
            mzn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool bl = false;
            if (!(textBox5.Text == "") && !(textBox2.Text == ""))
            {

                string s = textBox2.Text;
                 bl = true;
                string ss;

                for (int j = 0; (dataGridView3.Rows.Count - 1) > j && bl; j++)
                {


                    ss = dataGridView3.Rows[j].Cells[2].Value.ToString();
                    if (s.Equals(ss))
                    {
                        MessageBox.Show("מוצר זה נוסף");
                        bl = false;

                    }
                }
            }
            if (bl)
            {
                DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dataGridView3.Rows.Add(textBox7.Text, comboBox1.Text, textBox2.Text, textBox3.Text, textBox12.Text, textBox5.Text);
                }
                textBox5.Text = "";
            }
            button13.Visible = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT Into [doh sp](misparh,[shem spak],price, tarick) Values('" + textBox7.Text + "','" + comboBox1.Text+ "','" + textBox8.Text + "','" + maskedTextBox1.Text + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                hzSpk_Load(sender, e);

            
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



            if (!(textBox5.Text == ""))
            {
                int z;
                int x;
                int y;
                x = Convert.ToInt32(textBox5.Text);
                y = Convert.ToInt32(textBox10.Text);
                z = x + y;
                textBox9.Text = z.ToString();
            }
            if ((textBox5.Text == ""))
                textBox9.Text = "";

            if (!(textBox5.Text == ""))
            {
                int mhir;
                int mcolel;
                int cmot;
                cmot = Convert.ToInt32(textBox5.Text);
                mhir = Convert.ToInt32(textBox4.Text);
                mcolel =  mhir *cmot;
                textBox12.Text = mcolel.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for (int y = 0; y < dataGridView3.Rows.Count; y++)
            {
                double r = Convert.ToDouble(dataGridView3.Rows[y].Cells[4].Value);


                sum = sum + r;

            }

            textBox8.Text = sum.ToString();

            double sumw = 0;

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                double t = Convert.ToDouble(dataGridView3.Rows[i].Cells[5].Value);


                sumw = sumw + t;

            }

            textBox11.Text = sumw.ToString();


          
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox8.Enabled = true;
            

            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string st="";
            string s1="";
            mz=abedDataSet.motzarim;
            for (int j = 0; j < mz.Rows.Count - 1; j++)
            {
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    int t = Convert.ToInt32(dataGridView3.Rows[i].Cells[5].Value.ToString());

                    int y = Convert.ToInt32(mz.Rows[j]["kmot"].ToString());
                    int r = Convert.ToInt32(mz.Rows[j]["kama neshar"].ToString());
                    st = (t + r).ToString();
                    s1 = (t + r + y).ToString();
                    MessageBox.Show(st.ToString());
                    MessageBox.Show(s1.ToString());
                }
               

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button13.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox8.Enabled = false;
            textBox12.Enabled = false;


            button1.Visible = false;
            button8.Visible = false;
            button4.Visible = false;
            button7.Visible = false;
            

            button13.Visible = true;

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
