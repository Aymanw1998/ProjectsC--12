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

namespace liii
{
    public partial class hazmanotli : Form
    {
        public static string pass1;
        public hazmanotli()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.spakimDataTable kr;
        liDataSet.hazmanotlibraryDataTable kr1;
        

        private void hazmanotli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.liDataSet.spakim);
            // TODO: This line of code loads data into the 'liDataSet.hazmanotlibrary' table. You can move, or remove it, as needed.
            this.hazmanotlibraryTableAdapter.Fill(this.liDataSet.hazmanotlibrary);
            textBox1.Text = bdikalhazmana.pass;
            textBox5.Text = bdikalhazmana.pass1;
            if ( bdikalhazmana.pass3==true)
            {
                textBox3.Enabled = false;
            }
           

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("אי אפשר לבצע השאלה בלי הזנת שם הספר");
                textBox5.Focus();
            }
            else
            {
                if (textBox1.Text=="")
                {
                    MessageBox.Show("אי אפשר לבצע השאלה בלי הזנת שם הספר");
                    textBox1.Focus();
                }

                else
                {
                    if (textBox3.Text == "" && textBox3.Enabled==true)
                    {
                        MessageBox.Show("אי אפשר לבצע השאלה בלי הזנת שם הספר");
                        textBox3.Focus();

                    }
                    else
                        
                    {
                        bool x;
                        kr = liDataSet.spakim;
                        x = find.company(kr, textBox1.Text);
                        if (x == false)
                        {
                            MessageBox.Show("חברה זו לא קיימת תחילה יש להזין נתוני חברה זו");
                            textBox1.Focus();

                        }
                        else
                        {
                            int f = find.numsapak(kr, textBox1.Text);
                            string s = kr[f]["cophone"].ToString();
                            DialogResult aa = MessageBox.Show("התקשר לחברה ו אמת הזמנה  "+s, "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (aa == DialogResult.Yes)
                            {
                                string s1;
                                if (textBox3.Enabled==false)
                                {
                                     s1 = "1";
                                }
                                else 
                                     s1 = textBox3.Text;
                                

                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "INSERT into hazmanotlibrary ([bookname],[companyname],[date],[kamot]) VALUES ('" + textBox5.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" +s1 + "')";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "INSERT into hazmanot ([id],[book name],[date of hazmana]) VALUES ('" + bdikalhazmana.pass2 + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();
                                hazmanotli_Load(sender, e);
                                hazmanot_Load(sender, e);
                                textBox2.Text = "";
                                textBox3.Text = "";
                                

                            }
                        }

                    }
                }
            }
               

            
        }
         private void hazmanot_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                string s = textBox3.Text;
                int i = s.Length - 1;
                if (!char.IsNumber(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox3.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox3.Text = s1;


                    }
                    else
                        textBox3.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string s = textBox1.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox1.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox1.Text = s1;


                    }
                    else
                        textBox1.Clear();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            kr1 = liDataSet.hazmanotlibrary;
            DataTable dz = new DataTable();
            dz.Columns.Add("bookname");
            dz.Columns.Add("companyname");
            dz.Columns.Add("date");
            dz.Columns.Add("kamot");
            

            for (int j = 0; j < kr1.Rows.Count; j++)
            {
                for (int k = 0; k < kr1.Columns.Count; k++)
                {
                    if (kr1.Rows[j][k].ToString().Contains(textBox4.Text))
                    {
                        dz.Rows.Add(kr1[j][0], kr1[j][1], kr1[j][2], kr1[j][3]);
                        k = kr1.Columns.Count;
                    }
                }

            }

            dataGridView1.DataSource = dz;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void hazmanotli_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox5.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                
            }
        }
    }
}
