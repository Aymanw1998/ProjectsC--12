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

namespace חנות_נעליים
{
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }
       
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        shoe_shopDataSet.shoesDataTable ss;
        int selectedRow;
        
        

        private void shop_Load(object sender, EventArgs e)
        {
            this.shoesTableAdapter.Fill(this.shoe_shopDataSet.shoes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ss = shoe_shopDataSet.shoes;
            DataTable dz = new DataTable();
            dz.Columns.Add("degem");
            dz.Columns.Add("firma");
            dz.Columns.Add("mehir");
            dz.Columns.Add("mida");
            dz.Columns.Add("color");
            dz.Columns.Add("kamot");
            dz.Columns.Add("mhlaka");
            dz.Columns.Add("spak");
            for (int j = 0; j < ss.Rows.Count; j++)
            {
                for (int k = 0; k < ss.Columns.Count; k++)
                {
                    if (ss.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(ss[j][0], ss[j][1], ss[j][2], ss[j][3], ss[j][4], ss[j][5], ss[j][6], ss[j][7]);
                        k = ss.Columns.Count;
                    }
                }
            }
            dataGridView1.DataSource = dz;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            string str1 = row.Cells[5].Value.ToString();

            
            int x = Convert.ToInt32(str1);
            if (x != 0)
            {
                degem_Tb.Text = row.Cells[0].Value.ToString();
                mehir_tb.Text = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("נעל חסרה בממלאי");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss = shoe_shopDataSet.shoes;
            DialogResult dr = MessageBox.Show("הוסף נעל לחשבון", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int x = 0;
                for (int j = 0; j <= ss.Rows.Count - 1; j++)
                {
                    if (degem_Tb.Text == ss.Rows[j]["degem"].ToString())
                    {
                        string str = ss.Rows[j]["kamot"].ToString();
                        x = Convert.ToInt32(str);
                    }
                }
                int count = 1;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    if (degem_Tb.Text == dataGridView2.Rows[i].Cells[0].Value.ToString())
                    {
                        count++;
                    }
                }
                if (x > count)
                {
                    dataGridView2.Rows.Add(degem_Tb.Text, mehir_tb.Text);
                    shop_Load(sender, e);
                    dataGridView1.Refresh();
                }
                else if (x == count)
                {
                    dataGridView2.Rows.Add(degem_Tb.Text, mehir_tb.Text);
                    shop_Load(sender, e);

                    MessageBox.Show("אחרונה במלאי");
                }
                else
                {
                    MessageBox.Show("נגמר במלאי");
                }
            }
            textBox1.Text = "";
        }
    
            
            
       
    

      
      

        private void button2_Click(object sender, EventArgs e)
        {         
                        
            int x = 0;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            ss = shoe_shopDataSet.shoes;
            for (int j = 0; j < ss.Rows.Count; j++)
            {
                if (degem_Tb.Text == ss.Rows[j]["degem"].ToString())
                {
                    string str = ss.Rows[j]["kamot"].ToString();
                    x = Convert.ToInt32(str);
                }
            }
            
            if (x != 0)
            {


                DialogResult dr = MessageBox.Show("לתשלום", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string str = "";
                    string y = "";
                    int sum = 0;

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        str = dataGridView2.Rows[i].Cells[1].Value.ToString();
                        y = str[0].ToString() + str[1] + str[2];
                        sum = Convert.ToInt32(y) + sum;
                    }
                    MessageBox.Show("  שקל לתשלום  " + sum.ToString());

                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        string degem_shoes = dataGridView2.Rows[i].Cells["degem"].Value.ToString();

                        for (int j = 0; j < ss.Rows.Count; j++)
                        {
                            if ((string)ss.Rows[j]["degem"] == degem_shoes)
                            {
                                string kamot_shoes = ss.Rows[j]["kamot"].ToString();
                                int kamot_int = Convert.ToInt32(kamot_shoes);
                                kamot_int--;
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "Update shoes SET kamot='" + kamot_int + "'where [degem]='" + degem_shoes + "'";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                shop_Load(sender, e);
                                textBox1.Text = "";  
                            }
                        }
                       
                    }
                    dataGridView2.Rows.Clear();
                }
            }
        }


 
                    
                



          

        private void oved_Click(object sender, EventArgs e)
        {
            mishmarot mish = new mishmarot();
            mish.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enter ent = new enter();
            ent.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

        }
   

  }
}

