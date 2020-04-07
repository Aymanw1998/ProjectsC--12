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
    public partial class Form1 : Form
    {
        public static string pass;
        public static string pass2;
        public static string pass3;
        public static string pass4;
        public static Stack<int> pass5;
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.borrowDataTable kr;
        liDataSet.kartis_korehDataTable kr2;
        liDataSet.hazmanotDataTable kr3;
        //liDataSet.booksDataTable kr4;
        liDataSet.hazmanotlibraryDataTable kr5;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dohot fm = new dohot();
            //fm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            borrowing fm1 = new borrowing();
            fm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pass4 = "l";
            add_book fm2 = new add_book();
            fm2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            card fm3 = new card();
            fm3.Show();
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //  hazmanot fm4=new hazmanot
        //  fm4 .Show();

        
        private void חדשעלהמדףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void נוערToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void השאלהמהספריהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowing fm6 = new borrowing();
            fm6.Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void הכלToolStripMenuItem_Click(object sender, EventArgs e)
        {
            legends fm23 = new legends();
            fm23.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hazmanot fm4 = new hazmanot();
            fm4.Show();

        }

        private void צעיריםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הכלToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            books fm5 = new books();
            fm5.Show();
        }

        private void לקוחותשחייביםלשלםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dohot fm6 = new dohot();
            //fm6.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tkanon fm9 = new tkanon();
            fm9.Show();

        }

        private void דוחספריםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ספריםקייToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avialbe_books fm10 = new avialbe_books();
            fm10.Show();
        }

        private void ספריםלאזמיניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            not_availbe_books fm11 = new not_availbe_books();
            fm11.Show();

        }

        private void חייביםלשלםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hiaveem fm12 = new hiaveem();
            fm12.Show();
        }

        private void לאהחזירוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            no_reback fm12 = new no_reback();
            fm12.Show();

        

        }

        private void button6_Click(object sender, EventArgs e)
        {
           


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form2 fm1 = new Form2();
            fm1.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'liDataSet.hazmanotlibrary' table. You can move, or remove it, as needed.
            this.hazmanotlibraryTableAdapter.Fill(this.liDataSet.hazmanotlibrary);
            // TODO: This line of code loads data into the 'liDataSet.hazmanot' table. You can move, or remove it, as needed.
            this.hazmanotTableAdapter.Fill(this.liDataSet.hazmanot);

            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);
            // TODO: This line of code loads data into the 'liDataSet.borrow' table. You can move, or remove it, as needed.

            this.borrowTableAdapter.Fill(this.liDataSet.borrow);
            
            
            

        }
             private void hazmanot_Load(object sender, EventArgs e)
             {

             }
                
                
    
    




            

             
            

      


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hazmanotli fm17 = new hazmanotli();
            fm17.Show();
        }

        private void ספריםזמיניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avialbe_books fm18 = new avialbe_books();
            fm18.Show();
        }

        private void ספריםלאזמיניםToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            not_availbe_books fm20 =  new not_availbe_books();
            fm20.Show();


        }
        
        private void ילדיםונוערToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edubooks fm21 = new edubooks();
            fm21.Show();
        }

        private void מבוגריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stories fm22 = new stories();
            fm22.Show();
        }

        private void השאלותקיימותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hazmanot_kayamot fm24 = new hazmanot_kayamot();
            fm24.Show();
        }

        private void הזמנותקיימותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ashalot_kayamot fm25 = new ashalot_kayamot();
            fm25.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            kr2 = liDataSet.kartis_koreh;
            kr = liDataSet.borrow;
            kr5 = liDataSet.hazmanotlibrary;
            kr3=liDataSet.hazmanot;

            string ehor = dateTimePicker1.Value.AddDays(-3).ToShortDateString().ToString();
            
            for (int l = 0; l < kr3.Rows.Count; l++)
            {
                
                if (kr3[l]["messagedate"].ToString() == ehor)
                {
                    string tz = kr3[l]["id"].ToString();
                    MessageBox.Show(tz);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "delete from hazmanot where [id]='" + tz + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    hazmanot_Load(sender, e);
                }
            }

            string s = dateTimePicker1.Value.AddMonths(-1).ToShortDateString().ToString();
            string s2 = dateTimePicker1.Value.AddMonths(-1).AddDays(-3).ToShortDateString().ToString();
            kr3 = liDataSet.hazmanot;

            Stack<string> sm = new Stack<string>();
            Stack<string> sm2 = new Stack<string>();
            Stack<string> sm3 = new Stack<string>();
            Stack<string> sm4 = new Stack<string>();

            for (int i = 0; i < kr2.Rows.Count; i++)
            {
                string phone;
                if (kr2[i]["end day"].ToString()==dateTimePicker1.Value.ToShortDateString().ToString())
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE [kartis koreh] SET[tokef]='" + "לא"+ "' where [id]='" + kr2[i]["id"].ToString() + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    card_Load(sender, e);
                    phone = kr2[i]["phone"].ToString();
                    MessageBox.Show("תתקשר ללקוח ו תודיע לו שהמנוי שלו הסתיים");
                }

            }


            

            for (int i = 0; i < kr.Rows.Count; i++)
            {
                if (s == kr[i]["date of borowing"].ToString())
                {

                    if (kr[i]["id"].ToString() != null)
                    {
                        sm.Push(kr[i]["id"].ToString());
                        sm3.Push(kr[i]["id"].ToString());
                    }


                }

                if (s2 == kr[i]["date of borowing"].ToString())
                {
                    if (kr[i]["id"].ToString() != null)
                    {
                        sm2.Push(kr[i]["id"].ToString());
                        sm4.Push(kr[i]["id"].ToString());
                    }
                }


            }


            while (sm.Count != 0)
            {
                int i = find.IsFound(kr2, sm.Pop());
                string sss = kr2[i]["phone"].ToString();
                if (kr2[i]["hayav"].ToString() == "לא")
                {
                    MessageBox.Show( sss+" תזכורת ללקוח שזמן הההשאלה הסתיים אנא התקששר למספר   " );

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE [kartis koreh] SET [hayav]='" + "**" + "' where [id]='" + kr2[i]["id"].ToString() + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();




                }


            }
            card_Load(sender, e);


            if (sm2.Count != 0)
            {
                MessageBox.Show("לקוחות שיופיעו קיבלו הודעה ו לא החזירו את הספרים");
                while (sm2.Count != 0)
                {
                    int i = find.IsFound(kr2, sm2.Pop());
                    string sss2 = kr2[i]["phone"].ToString();

                    MessageBox.Show(" אנא הודיע ללקוח שקיבל כנס    " + sss2);

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE [kartis koreh] SET [hayav]='" + "200 ש''ח" + "' where [id]='" + kr2[i]["id"].ToString() + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    card_Load(sender, e);






                }

            }



            //if (sm3.Count == 0 && sm4.Count == 0)
            //{
            //    MessageBox.Show("ok");
            //}

           
            Stack<int> index123 = new Stack<int>();
            Stack<int> index456 = new Stack<int>();
            string book;
            string kbala = dateTimePicker1.Value.AddDays(0).ToShortDateString().ToString();
            for (int j = 0; j < kr5.Rows.Count; j++)
            {
                if (kbala == kr5[j]["date"].ToString())
                {
                    book = kr5[j]["bookname"].ToString();
                    DialogResult aa = MessageBox.Show( book+" האם ההזמנה הגיעה" , "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (aa == DialogResult.Yes)
                    {
                        index123.Push(j);
                        index456.Push(j);
                    }
                    else
                        MessageBox.Show(" התקשר למנהל, ההזמנה לא הגיעה");

                }
            }
            int x = -1;
            string y;
            while (index456.Count != 0)
            {
                x = index456.Peek();
                y = find.hazmanamokhana(kr3, kr5[x]["bookname"].ToString());
                if (y != "")
                {
                    int z = find.IsFound(kr2, y);
                    string tellephone = kr2[z]["phone"].ToString();
                    MessageBox.Show(tellephone + "  " + "התקשר למספר ו תודיע לו שההזמנה מוכנה");
                    x = index456.Pop();
                }
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "UPDATE [hazmanot] SET  [messagedate]='" + dateTimePicker1.Value.ToShortDateString() + "'where[id]='" + y + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                hazmanot_Load(sender, e);

            }





            if (index123.Count != 0)
            {

                x = index123.Pop();
                pass = kr5[x]["bookname"].ToString();
                pass2 = kr5[x]["companyname"].ToString();
                pass3 = kr5[x]["kamot"].ToString();
                pass4 = "z";
                pass5 = index456;
                add_book fm18 = new add_book();
                fm18.Show();
                pass = null;
                pass2 = null;
                pass3 = null;

                while (index123.Count != 0)
                {


                    pass = kr5[x]["bookname"].ToString();
                    pass2 = kr5[x]["companyname"].ToString();
                    pass3 = kr5[x]["kamot"].ToString();
                    pass4 = "z";
                    pass5 = index456;
                    add_book fm17 = new add_book();
                    fm17.Show();
                    pass = null;
                    pass2 = null;
                    pass3 = null;
                    x = index123.Pop();


                }

            }
            MessageBox.Show("ok");
            menuStrip1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Visible = false;


            
               
            
                
          



            

            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            trash fm30 = new trash();
            fm30.Show();
        }

        private void השאלותשבוטלוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowcan fm0 = new borrowcan();
            fm0.Show();
        }

        private void הזמנותהסתיימוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hazmanotcan fm00 = new hazmanotcan();
            fm00.Show();
        }

        private void כרטיסיםלאבתוקףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lobtokef fmm = new lobtokef();
            fmm.Show();
        }

        private void כרטיסיםבתוקףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btokef lm = new btokef();
            lm.Show();
        }

        private void אודותספקיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_in n = new new_in();
            n.Show();
        }
    }
}
