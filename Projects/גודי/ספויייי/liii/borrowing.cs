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
    public partial class borrowing : Form
    {
        public static string pass;
        public static string pass2;
        public static string pass3;
        public static string pass4;
        public borrowing()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.borrowDataTable kr;
        liDataSet.kartis_korehDataTable kr1;
        liDataSet.booksDataTable kr2;
        liDataSet.hazmanotDataTable kr3;
        liDataSet.trashDataTable kr4;



        private void borrowing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.trash' table. You can move, or remove it, as needed.
            this.trashTableAdapter.Fill(this.liDataSet.trash);
            // TODO: This line of code loads data into the 'liDataSet.hazmanot' table. You can move, or remove it, as needed.
            this.hazmanotTableAdapter.Fill(this.liDataSet.hazmanot);
            // TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);
            // TODO: This line of code loads data into the 'liDataSet.borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.liDataSet.borrow);
            textBox5.Text = books.pass;





        }
        private void books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////string sss = find.date(dateTimePicker1.Text);
            //MessageBox.Show(sss); 
            int x;
            kr2 = liDataSet.books;

            if (textBox5.Text == "")
            {
                MessageBox.Show("אי אפשר לבצע השאלה בלי הזנת שם הספר");
                textBox5.Focus();
            }
            else
            {
                x = find.yes(kr2, textBox5.Text);

                if (x == -1)
                {
                    MessageBox.Show("ספר זה לא קיים בספריה");
                    DialogResult aa = MessageBox.Show(" אנא הקש אישור אם ברצונכה לבדוק אפשרות הזמנת הספר    ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (aa == DialogResult.Yes)
                    {
                        pass3 = textBox5.Text;
                        pass4 = maskedTextBox1.Text;
                        bdikalhazmana fm8 = new bdikalhazmana();
                        fm8.Show();
                        pass3 = null;
                        //pass4 = null;
                        this.Close();

                    }
                    textBox5.Text = "";
                    textBox5.Focus();

                }
                else
                {
                    if (kr2[x]["amount"].ToString() == "0")
                    {
                        DialogResult aa = MessageBox.Show("  ספר זה לא זמין ,לחץ אישור להזמנת ספר זה   ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (aa == DialogResult.Yes)
                        {
                            pass = maskedTextBox1.Text;
                            pass2 = textBox5.Text;
                            hazmanot fm4 = new hazmanot();
                            fm4.Show();
                            pass = null;
                            pass2 = null;



                        }
                        else
                        {
                            textBox5.Text = "";
                            textBox5.Focus();

                        }

                    }
                    else
                    {
                        if (kr2[x]["msomn"].ToString() == "yes")
                        {
                            MessageBox.Show("ספר זה מסומן!! אי אפשר להשאיל אותו");
                            textBox5.Text = "";
                            textBox5.Focus();

                        }
                        else
                        {

                            bool b11;
                            b11 = find.TowTimes(kr, maskedTextBox1.Text);

                            if (b11 == true)
                            {
                                MessageBox.Show("אי אשפר לבצע השאלה!! לקוח זה יש לו שתי השאלות");
                                maskedTextBox1.Text = "";
                                maskedTextBox1.Focus();

                            }
                            else
                            {
                                DialogResult aa = MessageBox.Show("  האם אתה בטוח   ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                if (aa == DialogResult.Yes)
                                {

                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.CommandText = "INSERT into borrow ([id],[book name],[date of borowing]) VALUES ('" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
                                    con.Open();
                                    cmd.Connection = con;
                                    cmd.ExecuteNonQuery();
                                    int num;
                                    num = Convert.ToInt32(kr2[x]["amount"]);
                                    num = num - 1;
                                    string ss;
                                    ss = Convert.ToString(num);
                                    cmd.CommandText = "UPDATE [books] SET [amount]='" + ss + "'  where [name]='" + textBox5.Text + "'";
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    books_Load(sender, e);
                                    borrowing_Load(sender, e);



                                }

                            }
                        }
                    }
                }




            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            kr2 = liDataSet.books;
            kr = liDataSet.borrow;
            string s;
            s = dateTimePicker1.Text;
            int x;
            x = find.yes(kr2, textBox5.Text);
            int y = find.findborrow(kr, maskedTextBox1.Text);
            string s2 = kr[y]["book name"].ToString();
            int z = find.yes(kr2, s2);
            if (x == -1)
            {
                MessageBox.Show("ספר זה לא קיים");
                textBox5.Text = "";
                textBox5.Focus();

            }
            else if (kr2[x]["amount"].ToString() == "0")
            {
                MessageBox.Show("ספר זה לא זמין כעת");
            }

            else if (kr2[x]["msomn"].ToString() == "yes")
            {
                MessageBox.Show("ספר זה מסומן!! אי אפשר להשאיל אותו");
                textBox5.Text = "";
                textBox5.Focus();

            }
            else if (find.same(kr, maskedTextBox1.Text, textBox5.Text) == true)
            {
                MessageBox.Show("אין באפשרותך לשנות תאריך בגלל שלא שיניתה את הספר");
            }
            else
            {
                DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (aa == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE [borrow] SET [book name]='" + textBox5.Text + "',[date of borowing]='" + textBox1.Text + "' where [id]='" + maskedTextBox1.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int num;
                    num = Convert.ToInt32(kr2[x]["amount"]);
                    num = num - 1;
                    string ss;
                    ss = Convert.ToString(num);
                    cmd.CommandText = "UPDATE [books] SET  [amount]='" + ss + "'where[name]='" + textBox5.Text + "'";
                    cmd.ExecuteNonQuery();
                    int num2;
                    num2 = Convert.ToInt32(kr2[z]["amount"]);
                    num = num2 + 1;
                    ss = Convert.ToString(num);
                    cmd.CommandText = "UPDATE [books] SET  [amount]='" + ss + "'where[name]='" + s2 + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    books_Load(sender, e);
                    borrowing_Load(sender, e);
                    maskedTextBox1.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox1.Text = "";


                }
            }




        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            kr = liDataSet.borrow;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("book name");
            dz.Columns.Add("date of borowing");
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

            int x;
            kr2 = liDataSet.books;
            kr1 = liDataSet.kartis_koreh;
            x = find.yes(kr2, textBox5.Text);
            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            kr3 = liDataSet.hazmanot;
            if (aa == DialogResult.Yes)
            {
                string y = find.hazmanamokhana(kr3, textBox5.Text);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from borrow where [id]='" + maskedTextBox1.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

                int num;
                num = Convert.ToInt32(kr2[x]["amount"]);
                num = num + 1;
                string ss;
                ss = Convert.ToString(num);
                cmd.CommandText = "UPDATE [books] SET  [amount]='" + ss + "'where[name]='" + textBox5.Text + "'";
                cmd.ExecuteNonQuery();
                textBox5.Text = "";
                textBox7.Text = "";
                cmd.CommandText = "UPDATE [kartis koreh] SET [hayav]='" + "לא" + "' where [id]='" + maskedTextBox1.Text + "'";
                maskedTextBox1.Text = "";
                textBox1.Text = "";
                cmd.ExecuteNonQuery();
                
                if (y != ""||y==null)
                {
                    int z = find.IsFound(kr1, y);
                    string tellephone = kr1[z]["phone"].ToString();
                    MessageBox.Show(tellephone + "התקשר למספר ו תודיע לו שההזמנה מוכנה");
                }
                cmd.CommandText = "UPDATE [hazmanot] SET  [messagedate]='" + dateTimePicker1.Value.ToShortDateString() + "'where[id]='" + y + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                borrowing_Load(sender, e);
                books_Load(sender, e);
                card_Load(sender, e);
                hazmanot_Load(sender, e);




            }

        }
        private void hazmanot_Load(object sender, EventArgs e)
        {

        }
        private void card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Visible = true;
            label1.Visible = true;
            label8.Visible = false;
            textBox7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
            dateTimePicker1.Visible = false;
            maskedTextBox1.Visible = true;
            maskedTextBox1.Text = "";
            maskedTextBox1.Enabled = true;
            MessageBox.Show("הקש ת.ז קורא");
            maskedTextBox1.Focus();







        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox7.Visible = true;
            button9.Visible = true;
            textBox7.Text = "";
            maskedTextBox1.Visible = true;
            maskedTextBox1.Text = "";
            textBox5.Visible = true;
            textBox5.Text = "";
            dateTimePicker1.Visible = true;
            dateTimePicker1.Text = "";
            button1.Visible = false;
            button4.Visible = false;
            maskedTextBox1.Enabled = false;
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            kr1 = liDataSet.kartis_koreh;
            kr = liDataSet.borrow;
            if (maskedTextBox1.Text.Length != 9 || maskedTextBox1.Text.IndexOf(" ") > -1)
            {
                MessageBox.Show("נתון שהיזנתה אינו חוקי ");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
            else
            {

                int x = find.IsFound(kr1, maskedTextBox1.Text);
                if (x != -1)
                {
                    bool b;
                    b = find.TowTimes(kr, maskedTextBox1.Text);

                    if (b == true)
                    {
                        MessageBox.Show("אי אשפר לבצע השאלה!! לקוח זה יש לו השאלה קיימת ");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();

                    }
                    else
                    {


                        textBox1.Visible = false;
                        label5.Visible = true;
                        label6.Visible = false;
                        textBox5.Visible = true;
                        dateTimePicker1.Visible = true;
                        button1.Visible = true;
                        MessageBox.Show(x.ToString("הקש את שם הספר"));
                        textBox5.Focus();
                        button4.Visible = false;

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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
        //    textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
        //    dateTimePicker1.Text = dataGridView1[5, e.RowIndex].Value.ToString();

        //}

        private void label5_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x;
            kr2 = liDataSet.books;
            kr1 = liDataSet.kartis_koreh;
            kr4 = liDataSet.trash;
            x = find.yes(kr2, textBox5.Text);
            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            kr3 = liDataSet.hazmanot;
            if (aa == DialogResult.Yes)
            {

                string y = find.hazmanamokhana(kr3, textBox5.Text);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from borrow where [id] ='" + maskedTextBox1.Text + "' ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT into [trash] ([bitol],[id botal],[book],[dateb]) VALUES ('" + "h" + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "')";
                cmd.ExecuteNonQuery();
                int num;
                num = Convert.ToInt32(kr2[x]["amount"]);
                num = num + 1;
                string ss;
                ss = Convert.ToString(num);
                cmd.CommandText = "UPDATE [books] SET  [amount]='" + ss + "'where[name]='" + textBox5.Text + "'";
                cmd.ExecuteNonQuery();
                
                textBox5.Text = "";
                textBox7.Text = "";
                cmd.CommandText = "UPDATE [kartis koreh] SET [hayav]='" + "לא" + "' where [id]='" + maskedTextBox1.Text + "'";
                maskedTextBox1.Text = "";
                textBox1.Text = "";
                cmd.ExecuteNonQuery();
                if (y != "")
                {
                    int z = find.IsFound(kr1, y);
                    string tellephone = kr1[z]["phone"].ToString();
                    MessageBox.Show(tellephone + "התקשר למספר ו תודיע לו שההזמנה מוכנה");
                }
                cmd.CommandText = "UPDATE [hazmanot] SET  [messagedate]='" + dateTimePicker1.Value.ToShortDateString() + "'where[id]='" + y + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                borrowing_Load(sender, e);
                books_Load(sender, e);
                card_Load(sender, e);
                hazmanot_Load(sender, e);
                trash_Load( sender,  e);
            }
        }
        private void trash_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            kr2 = liDataSet.books;
            DataTable dd = new DataTable();
            dd.Columns.Add("name");
            for (int j = 0; j < kr2.Rows.Count; j++)
            {
                for (int k = 0; k < kr2.Columns.Count; k++)
                {
                    if (kr2.Rows[j][k].ToString().Contains(textBox5.Text))
                    {
                        dd.Rows.Add( kr2[j][1]);
                        k = kr2.Columns.Count;
                    }
                }

            }
            dataGridView2.DataSource = dd;
            if (textBox5.Text=="")
            {
                dataGridView2.Visible = false;
            }
        
    
        
                 
       
        



        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void borrowing_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox5.Text = dataGridView2[0, e.RowIndex].Value.ToString();
            }
        }
        }
    }
    

