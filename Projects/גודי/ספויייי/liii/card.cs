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
    public partial class card : Form
    {
        public card()
        {
            InitializeComponent();

        }
       
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.kartis_korehDataTable kr;
        liDataSet.trashDataTable kr1;

        private void button2_Click(object sender, EventArgs e)
        {

            
            string s4="";
            
            if (checkBox2.Checked)
            {
                s4 = dateTimePicker3.Value.AddMonths(6).ToShortDateString();
            }
            if (checkBox1.Checked)
            {
                s4 = dateTimePicker3.Value.AddYears(1).ToShortDateString();
            }
            if (maskedTextBox1.Text.Length != 9 || maskedTextBox1.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("נתון שהזנה שגוי !!יש לתקן אותו ");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();

            }
            else
            {
                kr = liDataSet.kartis_koreh;
                if (find.IsFound(kr, maskedTextBox1.Text) != -1)
                {
                    MessageBox.Show("לקוח קיים ");
                    maskedTextBox1.Text = "";
                }



                else
                {

                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("ישנם נתונים חסרים");
                        textBox2.Focus();

                    }
                    else
                    {

                        if (textBox3.Text == "")
                        {
                            MessageBox.Show("ישנם נתונים חסרים");
                            textBox3.Focus();

                        }

                        else
                        {
                             
                                if (find.tell(maskedTextBox2.Text))
                                {
                                    MessageBox.Show("נתון שהזנה שגוי !!יש לתקן אותו");
                                    maskedTextBox2.Text = "";
                                    maskedTextBox2.Focus();

                                }
                                else
                                {
                                    if (checkBox2.Checked == false && checkBox1.Checked == false)
                                    {
                                        MessageBox.Show("יש לבחור את תוקף המנוי");
                                    }


                                    else
                                    {
                                        DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                        if (aa == DialogResult.Yes)
                                        {
                                            OleDbCommand cmd = new OleDbCommand();
                                            cmd.CommandText = "INSERT into [kartis koreh] ([id],[name],[last name],[phone],[start day],[end day],[hayav],[tokef]) VALUES ('" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox2.Text + "','" + dateTimePicker3.Value + "','" + s4 + "','" + "לא" + "','"+"כו"+"')";
                                            cmd.Connection = con;
                                            con.Open();
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            card_Load(sender, e);


                                        }

                                    }
                                }

                            }

                        }
                    }
                }
            
        
            
            
              
           
            



             
            
        }

        private void card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.trash' table. You can move, or remove it, as needed.
            this.trashTableAdapter.Fill(this.liDataSet.trash);
            
            
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s4 = "";

            if (checkBox2.Checked)
            {
                s4 = dateTimePicker3.Value.AddYears(1).ToShortDateString();
            }
            if (checkBox1.Checked)
            {
                s4 = dateTimePicker3.Value.AddMonths(6).ToShortDateString();
            }
            

            if (maskedTextBox1.Text.Length != 9 || maskedTextBox1.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("נתון שהזנה שגוי !!יש לתקן אותו ");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();

            }
            else
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("ישנם נתונים חסרים");
                    textBox2.Focus();

                }
                else
                {

                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("ישנם נתונים חסרים");
                        textBox3.Focus();

                    }

                    else
                    {
                        //if (maskedTextBox2.Text.Length != 11)
                        //{
                        //    MessageBox.Show("נתון שהזנה שגוי !!יש לתקן אותו ");
                        //    maskedTextBox2.Text = "";
                        //    maskedTextBox2.Focus();

                        //}

                        //else
                        {
                            string s2 = maskedTextBox2.Text;
                            int count = 0;
                            // for (int i = 0; i < s.Length;i++ )
                            //{
                            //     if(s2[i]=='')
                            //    {
                            //        count++;

                            //    }
                            //}   
                            if (count > 1)
                            {
                                MessageBox.Show("נתון שהזנה שגוי !!יש לתקן אותו");
                                maskedTextBox2.Text = "";
                                maskedTextBox2.Focus();

                            }
                            else
                            {
                                DialogResult aa = MessageBox.Show("האם אתה בטוח  ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (aa == DialogResult.Yes)
                                {
                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.CommandText = "UPDATE [kartis koreh] SET [name]='" + textBox2.Text + "',[last name]='" + textBox3.Text + "',[phone]='" + maskedTextBox2.Text + "' where [id]='" + maskedTextBox1.Text + "'";
                                    cmd.Connection = con;
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    card_Load(sender, e);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            kr = liDataSet.kartis_koreh;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("name");
            dz.Columns.Add("last name");
            dz.Columns.Add("phone");
            dz.Columns.Add("start day");
            dz.Columns.Add("end day");

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

        private void button6_Click(object sender, EventArgs e)

        {

            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (aa == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT into [trash] ([bitol],[id botal],[book],[dateb]) VALUES ('" + "k" + "','" + maskedTextBox1.Text + "','" + "" + "','" + dateTimePicker3.Value + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from [kartis koreh] where [id]='" + maskedTextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                card_Load(sender, e);
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox4.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            maskedTextBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            maskedTextBox2.Visible = true;
            button4.Visible = true;
            
            textBox7.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            label7.Visible = true;
            checkBox2.Visible = false;
            checkBox1.Visible = false;
            label9.Visible = true;
            textBox5.Visible = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            maskedTextBox1.Visible = true;
            maskedTextBox1.Text = "";
            textBox2.Visible = true;
            textBox3.Visible = true;
            maskedTextBox2.Visible = true;
            button2.Visible = true;
            button6.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label7.Visible = false;
            textBox7.Visible = false;
            checkBox2.Visible = true;
            checkBox1.Visible = true;
            textBox5.Visible = false;
            label9.Visible = false;
            
           
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
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

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                maskedTextBox2.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox1.Text= dataGridView1[4, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            string s4 = "";


            if (checkBox2.Checked)
            {
                s4 = dateTimePicker3.Value.AddMonths(6).ToShortDateString();
            }
            if (checkBox1.Checked)
            {
                s4 = dateTimePicker3.Value.AddYears(1).ToShortDateString();
            }

            if (checkBox2.Checked == false && checkBox1.Checked == false)
            {
                MessageBox.Show("יש לבחור את תוקף המנוי");
            }
                
            else
            {
                DialogResult aa = MessageBox.Show("האם אתה בטוח  ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (aa == DialogResult.Yes)
                {
                    MessageBox.Show(s4);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE [kartis koreh] SET [start day]='" + dateTimePicker3.Value + "',[end day]='" + s4 + "' where [id]='" + maskedTextBox1.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    card_Load(sender, e);
                }
            }
            
               

          
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                maskedTextBox2.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                maskedTextBox2.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            }

        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void card_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                maskedTextBox2.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            }

        }
        
    }
}
