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
    public partial class add_book : Form
    {
        public add_book()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
         liDataSet.spakimDataTable kr;
        liDataSet.booksDataTable kr3;
        
         private void button1_Click(object sender, EventArgs e)
        {
             if (maskedTextBox1.Text.Length != 6 || maskedTextBox1.Text.IndexOf(" ") > -1)
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
                         if (textBox4.Text == "")
                         {
                             MessageBox.Show("ישנם נתונים חסרים");
                             textBox4.Focus();

                         }
                         else
                         {
                             int num = Convert.ToInt32(textBox4.Text);
                             if (num > 2018 || num<1800)
                             {
                                 MessageBox.Show("נתון שגוי ");
                                 textBox4.Focus();
                                 textBox4.Text = "";

                             }

                             else
                             {
                                 if (comboBox1.Text == "")
                                 {
                                     MessageBox.Show("ישנם נתונים חסרים");
                                     comboBox1.Focus();

                                 }
                                 else
                                 {

                                     if (comboBox1.Text != "ערבית" && comboBox1.Text != "עברית" && comboBox1.Text != "אנגלית")
                                     {
                                         MessageBox.Show("הספריה מכילה ספרים רק בשפה האנגלית העברית ו הערבית ");
                                         comboBox1.Text = "";
                                         comboBox1.Focus();

                                     }
                                     else
                                     {
                                         if (textBox6.Text=="")
                                         {
                                             MessageBox.Show("ישנם נתונים חסרים");
                                             textBox6.Focus();
                                         }
                                         else
                                         { 
                                            int num1 = Convert.ToInt32(textBox6.Text);
                                            if (num1 > 50)
                                             {
                                             MessageBox.Show("הספריה לא מכילה יותר מ-50 ספר מאותו סוג ");
                                             textBox6.Text = "";
                                             textBox6.Focus();
                                             }
                                            else
                                             {



                                             if (comboBox2.Text == "")
                                             {
                                                 MessageBox.Show("ישנם נתונים חסרים");
                                                 comboBox2.Focus();

                                             }
                                             else
                                             {

                                                 if (comboBox2.Text != "כתבי עת" && comboBox2.Text != "סיפורים" && comboBox2.Text != "אגדות" && comboBox2.Text != "ספרי לימוד")
                                                 {
                                                     MessageBox.Show("הספריה מכילה כתבי עת,סיפורים,אגדות,ספרי לימוד ו אי אפשר להוסיף סוגי ספרים אחרים");
                                                     comboBox2.Text = "";
                                                     comboBox2.Focus();
                                                 }
                                                 else
                                                 {
                                                     if (comboBox3.Text == "")
                                                     {
                                                         MessageBox.Show("ישנם נתונים חסרים");
                                                         comboBox3.Focus();

                                                     }
                                                     else
                                                     {

                                                         if (comboBox3.Text != "0-3" && comboBox3.Text != "3-6" && comboBox3.Text != "6-10" && comboBox3.Text != "11-14" && comboBox3.Text != "15-18" && comboBox3.Text != "18 ו מעלה ")
                                                         {


                                                             MessageBox.Show(" נתון שגוי!! יש לבחור אחת מאפשריות הקיימות");
                                                             comboBox3.Text = "";
                                                             comboBox3.Focus();
                                                         }
                                                         else
                                                         {
                                                             if (comboBox4.Text == "")
                                                             {
                                                                 MessageBox.Show("ישנם נתונים חסרים");
                                                                 comboBox4.Focus();

                                                             }
                                                             else
                                                             {

                                                                 if (find.msomn(comboBox4.Text) == false)
                                                                 {
                                                                     MessageBox.Show("נתון שגוי");
                                                                     comboBox4.Text = "";
                                                                     comboBox4.Focus();

                                                                 }
                                                                 else
                                                                 {
                                                                     if (comboBox5.Text == "")
                                                                     {
                                                                         MessageBox.Show("ישנם נתונים חסרים");
                                                                         comboBox5.Focus();
                                                                     }
                                                                     else
                                                                     {
                                                                         if (find.letterr(comboBox5.Text) == false)
                                                                         {
                                                                             MessageBox.Show("נתון שגוי!! יש לבחור מהאפשריות הקיימות");
                                                                             comboBox5.Text = "";
                                                                             comboBox5.Focus();
                                                                         }
                                                                         else
                                                                         {
                                                                             
                                                                             bool x;
                                                                             kr = liDataSet.spakim;
                                                                             x = find.company(kr, textBox11.Text);
                                                                             if (x == false)
                                                                             {
                                                                                 MessageBox.Show("חברה זו לא קיימת תחילה יש להזין נתוני חברה זו");
                                                                                 textBox11.Focus();

                                                                             }

                                                                             else
                                                                             {
                                                                                 kr3 = liDataSet.books;
                                                                                 int a = find.kayam(kr3, maskedTextBox1.Text);
                                                                                 
                                                                                 if (a != -1)
                                                                                 {
                                                                                    
                                                                                     int num3;
                                                                                     num3 = Convert.ToInt32(kr3[a]["amount"]);
                                                                                     int num2 = Convert.ToInt32(textBox6.Text);
                                                                                     num3 = num3 + num2;
                                                                                     string ss;
                                                                                     ss = Convert.ToString(num3);
                                                                                     int num4;
                                                                                     num4 = Convert.ToInt32(kr3[a]["otakim"]);
                                                                                     num4 = num4 + num2;
                                                                                     string ss2 = Convert.ToString(num4);
                                                                                     OleDbCommand cmd = new OleDbCommand();
                                                                                     cmd.CommandText = "UPDATE [books] SET [amount]='" + ss + "',[otakim]='" + ss2 + "'  where [code]='" + maskedTextBox1.Text + "'";
                                                                                     cmd.Connection = con;
                                                                                     con.Open();
                                                                                     cmd.ExecuteNonQuery();
                                                                                     con.Close();
                                                                                     add_book_Load(sender, e);
                                                                                     if (textBox5.Text=="z")
                                                                                         this.Close();

                                                                                 }
                                                                                 else
                                                                                 {
                                                                                     DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                                                                     if (aa == DialogResult.Yes)
                                                                                     {
                                                                                         string ww = comboBox5.Text.ToUpper();
                                                                                         OleDbCommand cmd = new OleDbCommand();
                                                                                         cmd.CommandText = "INSERT into books ([code],[name],[writername],[year],[language],[amount],[type],[age],[msomn],[raw],[company],[otakim]) VALUES ('" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + ww + "','" + textBox11.Text + "','" + textBox6.Text + "')";
                                                                                         cmd.Connection = con;
                                                                                         con.Open();
                                                                                         cmd.ExecuteNonQuery();
                                                                                         con.Close();
                                                                                         add_book_Load(sender, e);
                                                                                        if (textBox5.Text=="z")
                                                                                        {
                                                                                            
                                                                                            this.Close();
                                                                                        }


                                                                                         


                                                                                     }
                                                                                 }
                                                                             }
                                                                         }
                                                                     }
                                                                 }
                                                             }
                                                         }
                                                     }
                                             }
                                         }
                                            }
                                         }
                                     }
                                 }
                             }
                         }
                     }
                 }
             }
         }
         
        
      
        

        private void add_book_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'liDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.liDataSet.spakim);
            //TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);
            textBox2.Text = Form1.pass;
            textBox6.Text = Form1.pass3;
            textBox11.Text = Form1.pass2;
            textBox5.Text = Form1.pass4;
            
            

        }

        private void button2_Click(object sender, EventArgs e)
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
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("ישנם נתונים חסרים");
                        textBox4.Focus();

                    }
                    else
                    {
                        int num = Convert.ToInt32(textBox4.Text);
                        if (num > 2018 || num < 1800)
                        {
                            MessageBox.Show("נתון שגוי ");
                            textBox4.Focus();
                            textBox4.Text = "";

                        }

                        else
                        {
                            if (comboBox1.Text == "")
                            {
                                MessageBox.Show("ישנם נתונים חסרים");
                                comboBox1.Focus();

                            }
                            else
                            {

                                if (comboBox1.Text != "ערבית" && comboBox1.Text != "עברית" && comboBox1.Text != "אנגלית")
                                {
                                    MessageBox.Show("הספריה מכילה ספרים רק בשפה האנגלית העברית ו הערבית ");
                                    comboBox1.Text = "";
                                    comboBox1.Focus();

                                }
                                else
                                {
                                    if (textBox6.Text == "")
                                    {
                                        MessageBox.Show("ישנם נתונים חסרים");
                                        textBox6.Focus();
                                    }
                                    else
                                    {
                                        int num1 = Convert.ToInt32(textBox6.Text);
                                        if (num1 > 50)
                                        {
                                            MessageBox.Show("הספריה לא מכילה יותר מ-50 ספר מאותו סוג ");
                                            textBox6.Text = "";
                                            textBox6.Focus();
                                        }
                                        else
                                        {



                                            if (comboBox2.Text == "")
                                            {
                                                MessageBox.Show("ישנם נתונים חסרים");
                                                comboBox2.Focus();

                                            }
                                            else
                                            {

                                                if (comboBox2.Text != "כתבי עת" && comboBox2.Text != "סיפורים" && comboBox2.Text != "אגדות" && comboBox2.Text != "ספרי לימוד")
                                                {
                                                    MessageBox.Show("הספריה מכילה כתבי עת,סיפורים,אגדות,ספרי לימוד ו אי אפשר להוסיף סוגי ספרים אחרים");
                                                    comboBox2.Text = "";
                                                    comboBox2.Focus();
                                                }
                                                else
                                                {
                                                    if (comboBox3.Text == "")
                                                    {
                                                        MessageBox.Show("ישנם נתונים חסרים");
                                                        comboBox3.Focus();

                                                    }
                                                    else
                                                    {

                                                        if (comboBox3.Text != "0-3" && comboBox3.Text != "3-6" && comboBox3.Text != "6-10" && comboBox3.Text != "11-14" && comboBox3.Text != "15-18" && comboBox3.Text != "18 ו מעלה ")
                                                        {


                                                            MessageBox.Show(" נתון שגוי!! יש לבחור אחת מאפשריות הקיימות");
                                                            comboBox3.Text = "";
                                                            comboBox3.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (comboBox4.Text == "")
                                                            {
                                                                MessageBox.Show("ישנם נתונים חסרים");
                                                                comboBox4.Focus();

                                                            }
                                                            else
                                                            {

                                                                if (find.msomn(comboBox4.Text) == false)
                                                                {
                                                                    MessageBox.Show("נתון שגוי");
                                                                    comboBox4.Text = "";
                                                                    comboBox4.Focus();

                                                                }
                                                                else
                                                                {
                                                                    if (comboBox5.Text == "")
                                                                    {
                                                                        MessageBox.Show("ישנם נתונים חסרים");
                                                                        comboBox5.Focus();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (find.letterr(comboBox5.Text) == false)
                                                                        {
                                                                            MessageBox.Show("נתון שגוי!! יש לבחור מהאפשריות הקיימות");
                                                                            comboBox5.Text = "";
                                                                            comboBox5.Focus();
                                                                        }
                                                                        else
                                                                        {
                                                                            bool x;
                                                                            kr = liDataSet.spakim;
                                                                            x = find.company(kr, textBox11.Text);
                                                                            if (x == false)
                                                                            {
                                                                                MessageBox.Show("חברה זו לא קיימת תחילה יש להזין נתוני חברה זו");
                                                                                textBox11.Focus();

                                                                            }

                                                                            DialogResult aa = MessageBox.Show("האם אתה בטוח ", "exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                                                            if (aa == DialogResult.Yes)
                                                                            {
                                                                                OleDbCommand cmd = new OleDbCommand();
                                                                                cmd.CommandText = "UPDATE [books] SET [name]='" + textBox2.Text + "',[writername]='" + textBox3.Text + "',[year]='" + textBox4.Text + "',[language]='" + comboBox1.Text + "',[amount]='" + textBox6.Text + "',[type]='" + comboBox2.Text + "',[age]='" + comboBox3.Text + "',[msomn]='" + comboBox4.Text + "',[raw]='" + comboBox5.Text + "',[company]='" + textBox11.Text + "',[otakim]='" + textBox6.Text + "' where [code]='" + maskedTextBox1.Text + "'";
                                                                                cmd.Connection = con;
                                                                                con.Open();
                                                                                cmd.ExecuteNonQuery();
                                                                                con.Close();
                                                                                add_book_Load(sender, e);
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0)
            {
                string s = textBox6.Text;
                int i = s.Length - 1;
                if (!char.IsNumber(s[i]))
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 0)
            {
                string s = textBox11.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    textBox11.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        textBox11.Text = s1;


                    }
                    else
                        textBox11.Clear();
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (comboBox5.Text.Length > 0)
            {
                string s = comboBox5.Text;
                int i = s.Length - 1;
                if (!char.IsLetter(s[i]))
                {
                    MessageBox.Show("היקשתה נתון לא מתאים");
                    comboBox5.Focus();
                    if (s.Length > 1)
                    {
                        string s1;
                        s1 = s.Substring(0, s.Length - 1);
                        comboBox5.Text = s1;


                    }
                    
                        
                }
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int x = find.kayam(kr1)
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox11.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                comboBox1.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                comboBox2.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                comboBox3.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                comboBox4.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                comboBox5.Text = dataGridView1[9, e.RowIndex].Value.ToString();
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kr3 = liDataSet.books;
            DataTable dz = new DataTable();
            dz.Columns.Add("code");
            dz.Columns.Add("name");
            dz.Columns.Add("writername");
            dz.Columns.Add("year");
            dz.Columns.Add("language");
            dz.Columns.Add("amount");
            dz.Columns.Add("type");
            dz.Columns.Add("age");
            dz.Columns.Add("msomn");
            dz.Columns.Add("raw");
            dz.Columns.Add("company");
            dz.Columns.Add("otakim");

            for (int j = 0; j < kr3.Rows.Count; j++)
            {
                for (int k = 0; k < kr3.Columns.Count; k++)
                {
                    if (kr3.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(kr3[j][0], kr3[j][1], kr3[j][2], kr3[j][3], kr3[j][4], kr3[j][5], kr3[j][6], kr3[j][7], kr3[j][8], kr3[j][9], kr3[j][10],kr3[j][11]);
                        k = kr3.Columns.Count;
                    }
                }

            }

            dataGridView1.DataSource = dz;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                maskedTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox11.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                comboBox1.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                comboBox2.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                comboBox3.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                comboBox4.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                comboBox5.Text = dataGridView1[9, e.RowIndex].Value.ToString();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void add_book_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        
    }
}
