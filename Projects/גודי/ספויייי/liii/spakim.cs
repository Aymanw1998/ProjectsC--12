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
    public partial class spakim : Form
    {
        public spakim()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.spakimDataTable kr;

        private void spakim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.liDataSet.spakim);
            if(Form2.pass==true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox3.Text == "")
                    {
                        MessageBox.Show("חסר נתונים");
                        textBox3.Focus();

                    }
           
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("חסר נתונים");
                    textBox2.Focus();

                }
                else
                {
                    if (textBox1.Text.Length != 10)
                    {
                        MessageBox.Show("נתון שגוי");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                   
                    else
                    {
                        if (textBox4.Text.Length != 10)
                        {
                            MessageBox.Show("נתון שגוי");
                            textBox4.Text = "";
                            textBox4.Focus();
                        }
                        else
                        {
                            if (find.IsValidEmail(textBox5.Text) == false)
                            {
                                MessageBox.Show("נתון שגוי");
                                textBox5.Text = "";
                                textBox5.Focus();

                            }
                            else
                            {
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("חסר נתונים");
                                    textBox6.Focus();

                                }
                                else
                                {

                                    DialogResult aa = MessageBox.Show(" האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                    if (aa == DialogResult.Yes)
                                    {
                                        OleDbCommand cmd = new OleDbCommand();
                                        cmd.CommandText = "INSERT into spakim ([coname],[maname],[cophone],[manphone],[mail],[adress]) VALUES ('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                                        cmd.Connection = con;
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        spakim_Load(sender, e);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (aa == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE [spakim] SET [maname]='" + textBox2.Text + "',[cophone]='" + textBox1.Text + "',[manphone]='" + textBox4.Text + "',[mail]='" + textBox5.Text + "',[adress]='" + textBox6.Text + "' where [coname]='" + textBox3.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (aa == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from spakim where [coname]='" + textBox3.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            kr = liDataSet.spakim;
            DataTable dz = new DataTable();
            dz.Columns.Add("coname");
            dz.Columns.Add("maname");
            dz.Columns.Add("cophone");
            dz.Columns.Add("manphone");
            dz.Columns.Add("mail");
            dz.Columns.Add("adress");

            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    if (kr.Rows[j][k].ToString().Contains(textBox7.Text))
                    {
                        dz.Rows.Add(kr[j][0], kr[j][1], kr[j][2], kr[j][3], kr[j][4], kr[j][5]);
                        k = kr.Columns.Count;
                    }
                }

            }

            dataGridView1.DataSource = dz;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string s = textBox1.Text;
                int i = s.Length - 1;
                if (!char.IsNumber(s[i]))
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string s = textBox2.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox2.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox2.Text = s1;


                    }
                    else
                        textBox2.Clear();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                string s = textBox3.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                string s = textBox4.Text;
                int i = s.Length - 1;
                if (!char.IsNumber(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox4.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox4.Text = s1;


                    }
                    else
                        textBox4.Clear();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                string s = textBox6.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox6.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox6.Text = s1;


                    }
                    else
                        textBox6.Clear();
                }
            }
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    i
        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox3.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            }
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void spakim_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
    }
}
