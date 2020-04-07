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
    public partial class hazmanot : Form
    {
        public hazmanot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.hazmanotDataTable kr;
        liDataSet.kartis_korehDataTable kr2;
        liDataSet.booksDataTable kr3;
        liDataSet.trashDataTable kr4;

        private void hazmanot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.trash' table. You can move, or remove it, as needed.
            this.trashTableAdapter.Fill(this.liDataSet.trash);
            // TODO: This line of code loads data into the 'liDataSet1.hazmanot' table. You can move, or remove it, as needed.
            this.hazmanotTableAdapter.Fill(this.liDataSet1.hazmanot);
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);
            // TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);
            // TODO: This line of code loads data into the 'liDataSet.hazmanot' table. You can move, or remove it, as needed.
            this.hazmanotTableAdapter.Fill(this.liDataSet.hazmanot);
            if (borrowing.pass != null & borrowing.pass2 != null)
            {
                maskedTextBox1.Text = borrowing.pass;
                textBox5.Text = borrowing.pass2;
                maskedTextBox1.Visible = true;
                textBox5.Visible = true;
                button1.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                dateTimePicker1.Visible = true; 
            }
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x;
            kr3 = liDataSet.books;
            
            if (textBox5.Text == "")
            {
                MessageBox.Show("אי אפשר לבצע השאלה בלי הזנת שם הספר");
                textBox5.Focus();
            }
            else
            {
                x = find.yes(kr3, textBox5.Text);

                if (x == -1)
                {
                    MessageBox.Show("ספר זה לא קיים");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else
                {
                    if (kr3[x]["msomn"].ToString() == "yes")
                    {
                        MessageBox.Show("ספר זה מסומן!! אי אפשר להזמין אותו");
                        textBox5.Text = "";
                        textBox5.Focus();

                    }
                    else
                    {
                        DialogResult aa = MessageBox.Show(" האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (aa == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "INSERT into hazmanot ([id],[book name],[date of hazmana]) VALUES ('" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            hazmanot_Load(sender, e);
                            textBox5.Text = "";
                            textBox1.Text = "";
                            maskedTextBox1.Text = "";
                            button1.Visible = false;
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

          

                int x;
                x = find.yes(kr3, textBox5.Text);

                if (x == -1)
                {
                    MessageBox.Show("ספר זה לא קיים");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else
                {
                    if (kr3[x]["msomn"].ToString() == "yes")
                    {
                        MessageBox.Show("ספר זה מסומן!! אי אפשר להזמין אותו");
                        textBox5.Text = "";
                        textBox5.Focus();

                    }
                    else
                    {
                        if (kr3[x]["amount"].ToString() == "0")
                        {
                            MessageBox.Show("ספר זה לא קיים כעת");
                        }
                        else
                        {

                            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (aa == DialogResult.Yes)
                            {
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "UPDATE [hazmanot] SET [book name]='" + textBox5.Text + "',[date of hazmana]='" + dateTimePicker1.Value.ToShortDateString() + "' where [id]='" + maskedTextBox1.Text + "'";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                hazmanot_Load(sender, e);
                                textBox1.Text = "";
                                maskedTextBox1.Text = "";
                                textBox5.Text = "";
                            }
                        }
                    }
                }
            
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            kr = liDataSet.hazmanot;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("book name");
            dz.Columns.Add("date of hazmana");

            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    if (kr.Rows[j][k].ToString().Contains(textBox7.Text))
                    {
                        dz.Rows.Add(kr[j][0], kr[j][1], kr[j][2]);
                        k = kr.Columns.Count;
                    }
                }

            }

            dataGridView1.DataSource = dz;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (aa == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT into [trash] ([bitol],[id botal],[book],[dateb]) VALUES ('" + "hz" + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from hazmanot where [id]='" + maskedTextBox1.Text+ "'";
                cmd.ExecuteNonQuery();
                con.Close();
                hazmanot_Load(sender, e);
                textBox5.Text = "";
                maskedTextBox1.Text = "";
                textBox1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            label3.Visible = true;
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox5.Visible = false;
            dateTimePicker1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox7.Visible = false;
            button1.Visible = false;
            maskedTextBox1.Visible = true;
            textBox1.Visible = false;
            maskedTextBox1.Text = "";
            MessageBox.Show("הקש ת.ז קורא");
            maskedTextBox1.Focus();
            maskedTextBox1.Enabled = true;
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox1.Text = "";
            textBox5.Visible = true;
            textBox5.Text = "";
            dateTimePicker1.Visible = true;
            dateTimePicker1.Text = "";
            button2.Visible = true;
            button3.Visible = true;
            textBox7.Visible = true;
            textBox7.Text = "";
            button6.Visible = false;
            button1.Visible = false;
            maskedTextBox1.Enabled = false;
            button7.Visible = true;
            
            
            
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kr2 = liDataSet.kartis_koreh;
            kr3 = liDataSet.books;
            kr = liDataSet.hazmanot;
            if (maskedTextBox1.Text.Length != 9 || maskedTextBox1.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("נתון שהיזנתה אינו חוקי ");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
            else
            {

                int x = find.IsFound(kr2, maskedTextBox1.Text);
                if (x != -1)
                {
                    bool b;
                    b = find.tow(kr, maskedTextBox1.Text);
                    if (b == true)
                    {
                        MessageBox.Show("אי אשפר לבצע השאלה!! לקוח זה יש לו שתי השאלות");
                    }
                    else
                    {


                        
                        label3.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        textBox1.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        textBox5.Visible = true;
                        dateTimePicker1.Visible = true;
                        button1.Visible = true;
                        MessageBox.Show(x.ToString("הקש את שם הספר"));
                        textBox5.Focus();
                        button6.Visible = false;
                        
                        
                    }

                }

                else
                {
                    MessageBox.Show("לקוח זה לא קיים");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();
                }
            }
            
         

               
            
                   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
        //    textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
        //    dateTimePicker1 .Text= dataGridView1[5, e.RowIndex].Value.ToString();

        //}

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            }

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int z;
            kr3 = liDataSet.books;
            z= find.yes(kr3, textBox5.Text);
           
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from hazmanot where [id]='" + maskedTextBox1.Text + "'";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT into borrow ([id],[book name],[date of borowing]) VALUES ('" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            int num;
            num = Convert.ToInt32(kr3[z]["amount"]);
            num = num -1;
            string ss;
            ss = Convert.ToString(num);
            cmd.CommandText = "UPDATE [books] SET  [amount]='" + ss + "'where[name]='" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();


            con.Close();
            hazmanot_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox1.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;

        }

        private void hazmanot_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }  

    }
}
