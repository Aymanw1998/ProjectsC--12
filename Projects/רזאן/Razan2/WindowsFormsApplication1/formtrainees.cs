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
    public partial class formtrainees : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

   
        public formtrainees()
        {
            InitializeComponent();
        }

        razan22DataSet1.mitamneem2DataTable mm;
        razan22DataSet1.hugeem2DataTable mw;

        razan22DataSet1.hugeem2DataTable mn;
       
        private void formtrainees_Load(object sender, EventArgs e)
        {
         

            // TODO: This line of code loads data into the 'razan22DataSet1.hugeem2' table. You can move, or remove it, as needed.
            this.hugeem2TableAdapter.Fill(this.razan22DataSet1.hugeem2);
            // TODO: This line of code loads data into the 'razan22DataSet1.mitamneem2' table. You can move, or remove it, as needed.
            this.mitamneem2TableAdapter.Fill(this.razan22DataSet1.mitamneem2);

            hugmitamen.Items.Clear();
            mw = razan22DataSet1.hugeem2;
            for (int i = 0; i < mw.Rows.Count; i++)
            {
                hugmitamen.Items.Add(mw.Rows[i]["shem"].ToString());
            }


        
        }

        private void btnbktrainees_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmtaho_Click(object sender, EventArgs e)
        {
            

            bool bl2 = true;
            bool bl3 = true;
            bool bl11 = true;
            string st2 = tzmitamen.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }

            
            if (tzmitamen.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (shemmitamen.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishmitamen.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (telmitamen.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (ktovetmitamen.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (gilmitamen.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (minmitamen.Text == "")
            {
                bl2 = false;
                label7.Visible = true;

            }
            else

                label7.Visible = false;

            if (bdaymitamen.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (yeshuv.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (hiovmitamen.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (hugmitamen.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (tokefmitamen.Text == "")
            {
                bl2 = false;
                label12.Visible = true;

            }
            else

                label12.Visible = false;


            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            bool bl99 = true;
            bool bl9 = true;
            bool bl88 = true;
            bool bl8 = true;
            bool bl7 = true;
            bool bl6 = true;
            bool bl5 = true;
            bool bl77 = true;
            bool bl777 = true;
            bool bl4 = true;
            bool bl100 = true;
            bool bl111 = true;
            bool bl25 = true;
            bool bl20 = true;
            bool bl57 = true;

            if (bl2 == true)
            {

                if (tzmitamen.Text.Length != 9)
                {
                    bl3 = false;
                    MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
                }



               
                if (bdaymitamen.Text.Length != 10)
                {
                    bl4 = false;
                    MessageBox.Show("הזן תאריך חוקי");
                    bl20 = false;
                }

                
                if (bl20 == true)
                {
                    string s28 = bdaymitamen.Text;
                    string s29 = s28.Substring(6, 4);

                    string s24 = bdaymitamen.Text;
                    string s25 = s24.Substring(0, 2);


                    string s26 = bdaymitamen.Text;
                    string s27 = s26.Substring(3, 2);

                    if (double.Parse(s27) == 01 || double.Parse(s27) == 03 || double.Parse(s27) == 05 || double.Parse(s27) == 10 || double.Parse(s27) == 12 || double.Parse(s27) == 07 || double.Parse(s27) == 08)
                    {
                        if (double.Parse(s25) > 31 || double.Parse(s25) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }

                    }

                    else if (double.Parse(s27) == 04 || double.Parse(s27) == 06 || double.Parse(s27) == 09 || double.Parse(s27) == 11)
                    {
                        if (double.Parse(s25) > 30 || double.Parse(s25) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }
                    }

                    else
                    {
                        if (double.Parse(s25) > 28 || double.Parse(s25) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }
                    }


                    if (double.Parse(s27) > 12 || double.Parse(s27) < 1)
                    {
                        bl8 = false;
                        MessageBox.Show("הזן חודש קיים");
                    }

                    if (double.Parse(s29) < 1948 || double.Parse(s29) > 2004)
                    {
                        bl9 = false;
                        MessageBox.Show("הזן שנה בטווח 1948-2004");
                    }

                }
                if (bl20 == true)
                {
                    string s30 = bdaymitamen.Text;
                    string s31 = s30.Substring(6, 4);

                    int z1 = Convert.ToInt32(gilmitamen.Text);
                    string currentyear = DateTime.Now.Year.ToString();
                    int cc = Convert.ToInt32(currentyear);
                    int cc2 = cc - z1;
                    int z22 = Convert.ToInt32(s31);
                    if (z22 != cc2)
                        MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");
                }

               
                if (tokefmitamen.Text.Length != 10)
                {
                    bl4 = false;
                    MessageBox.Show("הזן תוקף חוקי");
                    bl25 = false;
                }

                DateTime d5 = DateTime.Today;
                DateTime d6 = d5.AddYears(1);
               
                DateTime d7 = Convert.ToDateTime(tokefmitamen.Text);
                int res1 = DateTime.Compare(d7, d6);
                if (res1 != 0)
                {
                    MessageBox.Show("הזן תאריך אשר תוקפו מסתיים בעוד שנה בדיוק");
                    bl57 = false;
                }


               
                if (bl25 == true)
                {
                    string s288 = bdaymitamen.Text;
                    string s299 = s288.Substring(6, 4);

                    string s244 = bdaymitamen.Text;
                    string s255 = s244.Substring(0, 2);


                    string s266 = bdaymitamen.Text;
                    string s277 = s266.Substring(3, 2);

                    if (double.Parse(s277) == 01 || double.Parse(s277) == 03 || double.Parse(s277) == 05 || double.Parse(s277) == 10 || double.Parse(s277) == 12 || double.Parse(s277) == 07 || double.Parse(s277) == 08)
                    {
                        if (double.Parse(s255) > 31 || double.Parse(s255) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }

                    }

                    else if (double.Parse(s277) == 04 || double.Parse(s277) == 06 || double.Parse(s277) == 09 || double.Parse(s277) == 11)
                    {
                        if (double.Parse(s255) > 30 || double.Parse(s255) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }
                    }

                    else
                    {
                        if (double.Parse(s255) > 28 || double.Parse(s255) < 1)
                        {
                            bl7 = false;
                            MessageBox.Show("הזן יום קיים בחודש זה");
                        }
                    }
                    if (double.Parse(s277) > 12 || double.Parse(s277) < 1)
                    {
                        bl88 = false;
                        MessageBox.Show("הזן חודש קיים");
                    }

                    if (double.Parse(s299) < 1948 || double.Parse(s299) > 2004)
                    {
                        bl9 = false;
                        MessageBox.Show("הזן שנה בטווח 1948-2004");
                    }
                }
               
                string sv = telmitamen.Text;
                if (sv[0] != '0' || sv[1] != '5')
                {
                    MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                    bl100 = false;
                }

               
                if (telmitamen.Text.Length != 11)
                {
                    bl6 = false;
                    MessageBox.Show("הזן מספר טלפון תקין");
                }

                
                string st77 = gilmitamen.Text;
                if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
                {
                    bl777 = false;
                    MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
                }


                
                string st22 = telmitamen.Text;
                int xx = st22.IndexOf(' ');
                if (xx != -1)
                {
                    MessageBox.Show("הזן מספר פלאפון ללא רווח");
                    bl111 = false;
                }
            }
            if (bl2 == true && bl57==true && bl100==true&& bl777==true && bl11==true && bl3==true && bl4==true && bl5==true && bl6==true && bl7==true && bl77==true &&bl8==true && bl88==true && bl9==true && bl99==true && bl111==true)
            {

                mm = razan22DataSet1.mitamneem2;


                string s = tzmitamen.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["tz"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("מתאמן זה קיים");
                        bl = false;
                        


                    }

                }




                if (bl == true)
                {

                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    int r = Convert.ToInt32(hugmitamen.SelectedIndex);
                    if (dr == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into mitamneem2 (tz,shem,mishpaha,tel,ktovet,gil,[min],tarikh,yeshuv,hiov,hug,tokef) VALUES('" + tzmitamen.Text + "' , '" + shemmitamen.Text + "' , '" + mishmitamen.Text + "' , '" + telmitamen.Text + "' , '" + ktovetmitamen.Text + "' , '" + gilmitamen.Text + "' , '" + minmitamen.Text + "' , '" + bdaymitamen.Text + "' , '" + yeshuv.Text + "' , '" + hiovmitamen.Text + "' , '" + hugmitamen.Text + "','" + tokefmitamen.Text + "' )";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formtrainees_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                        mn = razan22DataSet1.hugeem2;
                        if (Convert.ToInt32(r) > -1)
                        {
                            int ss24 = Convert.ToInt32(mn.Rows[r]["mispar"].ToString());
                            int ss244 = ss24 + 1;
                            OleDbCommand cmd2 = new OleDbCommand();
                            cmd2.CommandText = "Update hugeem2 SET mispar =  '" + ss244 + "'  where shem='" + mn.Rows[r]["shem"].ToString() + "' ";
                            cmd2.Connection = con;
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }


                        button6.Visible = true;
                        tzmitamen.Enabled = false;
                        tzmitamen2.Enabled = false;
                        shemmitamen.Enabled = false;
                        mishmitamen.Enabled = false;
                        telmitamen.Enabled = false;
                        ktovetmitamen.Enabled = false;
                        gilmitamen.Enabled =false;
                        minmitamen.Enabled = false;
                        bdaymitamen.Enabled = false;
                        yeshuv.Enabled = false;
                        hiovmitamen.Enabled = false;
                        hugmitamen.Enabled = false;
                        tokefmitamen.Enabled = false;

                    }
                    
                    if(dr==DialogResult.No)
                    {
                        button6.Visible = true;
                        tzmitamen.Enabled = false;
                        tzmitamen2.Enabled = false;
                        shemmitamen.Enabled = false;
                        mishmitamen.Enabled = false;
                        telmitamen.Enabled = false;
                        ktovetmitamen.Enabled = false;
                        gilmitamen.Enabled = false;
                        minmitamen.Enabled = false;
                        bdaymitamen.Enabled = false;
                        yeshuv.Enabled = false;
                        hiovmitamen.Enabled = false;
                        hugmitamen.Enabled = false;
                        tokefmitamen.Enabled = false;
                        tzmitamen2.Clear();
                        shemmitamen.Clear();
                        mishmitamen.Clear();
                        telmitamen.Clear();
                        ktovetmitamen.Clear();
                        gilmitamen.Clear();
                        minmitamen.Text = "";
                        bdaymitamen.Clear();
                        yeshuv.Clear();
                        hiovmitamen.Clear();
                        hugmitamen.Text = "";
                        tokefmitamen.Clear();
                        tzmitamen.Clear();

                    }
                }

            }
            tzmitamen2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmtamh_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (tzmitamen.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן תעודת זהות למחיקה");
            }

            if (blb == true)
            {
                mm = razan22DataSet1.mitamneem2;


                string s = tzmitamen.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["tz"].ToString();

                    if (s.Equals(ss))
                    {

                        bl = false;
                        blb2 = true;



                        DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה למחוק?", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {


                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "Delete from mitamneem2 where tz = '" + tzmitamen.Text + "' ";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();



                            formtrainees_Load(sender, e);
                            MessageBox.Show("!מחיקה בוצעה בהצלחה");
                        }

                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן תעודת זהות מאמן קיים למחיקה");
            }

            tzmitamen2.Visible = true;
        }

        private void tbtrainees_TextChanged(object sender, EventArgs e)
        {
            if (tbtrainees.Text.Length == 0)
            {
                formtrainees_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.mitamneem2;
            }

            else
            {

                DataTable dz = new DataTable();
                dz.Columns.Add("tz");
                dz.Columns.Add("shem");
                dz.Columns.Add("mishpaha");
                dz.Columns.Add("tel");
                dz.Columns.Add("ktovet");
                dz.Columns.Add("gil");
                dz.Columns.Add("[min]");
                dz.Columns.Add("tarikh");
                dz.Columns.Add("yeshuv");
                dz.Columns.Add("hiov");
                dz.Columns.Add("hug");
                dz.Columns.Add("tokef");


                razan22DataSet1.mitamneem2DataTable mz;
                mz = razan22DataSet1.mitamneem2;
                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbtrainees.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8], mz[j][9], mz[j][10], mz[j][11]);

                            k = mz.Columns.Count;



                        }

                    }


                }

                dataGridView1.DataSource = dz;

            }
        }
        private void btnmamidk_Click(object sender, EventArgs e)
        {
            bool bl111 = true;
            string st22 = telmitamen.Text;
            int xx = st22.IndexOf(' ');
            if (xx != -1)
            {
                MessageBox.Show("הזן מספר פלאפון ללא רווח");
                bl111 = false;
            }
            bool bl3 = true;
            bool bl11 = true;
            string st2 = tzmitamen.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }
            bool bl2 = true;

            if (tzmitamen.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (shemmitamen.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishmitamen.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (telmitamen.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (ktovetmitamen.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (gilmitamen.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (minmitamen.Text == "")
            {
                bl2 = false;
                label7.Visible = true;

            }
            else

                label7.Visible = false;

            if (bdaymitamen.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (yeshuv.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (hiovmitamen.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (hugmitamen.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (tokefmitamen.Text == "")
            {
                bl2 = false;
                label12.Visible = true;

            }
            else

                label12.Visible = false;


            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            if (tzmitamen.Text.Length != 9)
            {
                bl3 = false;
                MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
            }
            bool bl20 = true;
            bool bl4 = true;
            if (bdaymitamen.Text.Length != 10)
            {
                bl4 = false;
                MessageBox.Show("הזן תאריך");
                bl20 = false;
            }

            bool bl8 = true;
            bool bl7 = true;
            bool bl9 = true;
            if (bl20 == true)
            {
                string s28 = bdaymitamen.Text;
                string s29 = s28.Substring(6, 4);

                string s24 = bdaymitamen.Text;
                string s25 = s24.Substring(0, 2);


                string s26 = bdaymitamen.Text;
                string s27 = s26.Substring(3, 2);

                if (double.Parse(s27) == 01 || double.Parse(s27) == 03 || double.Parse(s27) == 05 || double.Parse(s27) == 10 || double.Parse(s27) == 12 || double.Parse(s27) == 07 || double.Parse(s27) == 08)
                {
                    if (double.Parse(s25) > 31 || double.Parse(s25) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }

                }

                else if (double.Parse(s27) == 04 || double.Parse(s27) == 06 || double.Parse(s27) == 09 || double.Parse(s27) == 11)
                {
                    if (double.Parse(s25) > 30 || double.Parse(s25) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }
                }

                else
                {
                    if (double.Parse(s25) > 28 || double.Parse(s25) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }
                }
                

                if (double.Parse(s27) > 12 || double.Parse(s27) < 1)
                {
                    bl8 = false;
                    MessageBox.Show("הזן חודש קיים");
                }

                if (double.Parse(s29) < 1948 || double.Parse(s29) > 2004)
                {
                    bl9 = false;
                    MessageBox.Show("הזן שנה בטווח 1948-2004");
                }
            }

            

            bool bl25 = true;
            bool bl5 = true;
            if (tokefmitamen.Text.Length != 10)
            {
                bl5 = false;
                MessageBox.Show("הזן תוקף חוקי");
                bl25 = false;
            }

            bool bl100 = true;
            string sv = telmitamen.Text;
            if (sv[0] != '0' || sv[1] != '5')
            {
                MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                bl100 = false;
            }

            bool bl88 = true;
            bool bl77 = true;
            bool bl99 = true;
            if (bl25 == true)
            {
                string s288 = tokefmitamen.Text;
                string s299 = s288.Substring(6, 4);

                string s244 = tokefmitamen.Text;
                string s255 = s244.Substring(0, 2);


                string s266 = tokefmitamen.Text;
                string s277 = s266.Substring(3, 2);

                if (double.Parse(s277) == 01 || double.Parse(s277) == 03 || double.Parse(s277) == 05 || double.Parse(s277) == 10 || double.Parse(s277) == 12 || double.Parse(s277) == 07 || double.Parse(s277) == 08)
                {
                    if (double.Parse(s255) > 31 || double.Parse(s255) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }

                }

                else if (double.Parse(s277) == 04 || double.Parse(s277) == 06 || double.Parse(s277) == 09 || double.Parse(s277) == 11)
                {
                    if (double.Parse(s255) > 30 || double.Parse(s255) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }
                }

                else
                {
                    if (double.Parse(s255) > 28 || double.Parse(s255) < 1)
                    {
                        bl7 = false;
                        MessageBox.Show("הזן יום קיים בחודש זה");
                    }
                }
                

                if (double.Parse(s277) > 12 || double.Parse(s277) < 1)
                {
                    bl88 = false;
                    MessageBox.Show("הזן חודש קיים");
                }

                if (double.Parse(s299) < 1948 || double.Parse(s299) < 2004)
                {
                    bl9 = false;
                    MessageBox.Show("הזן שנה בטווח 1948-2004");
                }
            }

            string s30 = bdaymitamen.Text;
            string s31 = s30.Substring(6, 4);

            int z1 = Convert.ToInt32(gilmitamen.Text);
            string currentyear = DateTime.Now.Year.ToString();
            int cc = Convert.ToInt32(currentyear);
            int cc2 = cc - z1;
            int z22 = Convert.ToInt32(s31);
            if (z22 != cc2)
                MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");

            bool bl777 = true;
            string st77 = gilmitamen.Text;
            if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
            {
                bl777 = false;
                MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
            }


            bool bl6 = true;
            if (telmitamen.Text.Length !=11)
            {
                bl6 = false;
                MessageBox.Show("הזן מספר טלפון תקין");
            }

            bool blb2 = true;
            bool blb = true;
            if (tzmitamen.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן תעודת זהות לעדכון");
            }

        
            if (bl2 == true && bl100==true && bl777==true && bl11 == true && bl3 == true && bl4 == true && blb == true && bl5 == true && bl6 == true && bl7 == true && bl77 == true && bl8 == true && bl88 == true && bl9 == true && bl99 == true && bl111==true)
            { 
                
                mm = razan22DataSet1.mitamneem2;


                string s = tzmitamen.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["tz"].ToString();

                    if (s.Equals(ss))
                    {
                        bl = false;
                       blb2 = true;

            DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה לעדכן?", "עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int r = Convert.ToInt32(hugmitamen.SelectedIndex);
            if (dr == DialogResult.Yes)
            {
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Update mitamneem2 SET shem = '" + shemmitamen.Text + "' , mishpaha = '" + mishmitamen.Text + "' , tel = '" + telmitamen.Text + "',ktovet = '" + ktovetmitamen.Text + "', gil = '" + gilmitamen.Text + "', [min] = '" + minmitamen.Text + "', tarikh = '" + bdaymitamen.Text + "', yeshuv = '" + yeshuv.Text + "',  hiov = '" + hiovmitamen.Text + "', hug = '" + hugmitamen.Text + "', tokef = '" + tokefmitamen.Text + "'    where tz = '" + tzmitamen.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                


                formtrainees_Load(sender, e);
                MessageBox.Show("!שינויים בוצעו בהצלחה");


                mn = razan22DataSet1.hugeem2;
                if (Convert.ToInt32(r) > -1)
                {
                    int ss24 = Convert.ToInt32(mn.Rows[r]["mispar"].ToString());
                    int ss244 = ss24 + 1;
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.CommandText = "Update hugeem2 SET mispar =  '" + ss244 + "'  where shem='" + mn.Rows[r]["shem"].ToString() + "' ";
                    cmd2.Connection = con;
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                    button5.Visible = true;
                    tzmitamen2.Enabled = false;
                    shemmitamen.Enabled = false;
                    mishmitamen.Enabled = false;
                    telmitamen.Enabled = false;
                    ktovetmitamen.Enabled = false;
                    gilmitamen.Enabled = false;
                    minmitamen.Enabled = false;
                    bdaymitamen.Enabled = false;
                    yeshuv.Enabled = false;
                    hiovmitamen.Enabled = false;
                    hugmitamen.Enabled = false;
                    tokefmitamen.Enabled = false;
                    tzmitamen.Enabled = false;
                    tzmitamen2.Clear();
                    shemmitamen.Clear();
                    mishmitamen.Clear();
                    telmitamen.Clear();
                    ktovetmitamen.Clear();
                    gilmitamen.Clear();
                    minmitamen.Text = "";
                    bdaymitamen.Clear();
                    yeshuv.Clear();
                    hiovmitamen.Clear();
                    hugmitamen.Text = "";
                    tokefmitamen.Clear();
                    tzmitamen.Enabled = true;
                
            }

              if(dr==DialogResult.No)
              {
                  button5.Visible = true;
                  tzmitamen2.Enabled = false;
                  shemmitamen.Enabled = false;
                  mishmitamen.Enabled = false;
                  telmitamen.Enabled = false;
                  ktovetmitamen.Enabled = false;
                  gilmitamen.Enabled = false;
                  minmitamen.Enabled = false;
                  bdaymitamen.Enabled = false;
                  yeshuv.Enabled = false;
                  hiovmitamen.Enabled = false;
            hugmitamen.Enabled = false;
            tokefmitamen.Enabled = false;
            tzmitamen.Enabled = false;
            tzmitamen2.Clear();
            shemmitamen.Clear();
            mishmitamen.Clear();
            telmitamen.Clear();
            ktovetmitamen.Clear();
            gilmitamen.Clear();
            minmitamen.Text = "";
            bdaymitamen.Clear();
            yeshuv.Clear();
            hiovmitamen.Clear();
            hugmitamen.Text = "";
            tokefmitamen.Clear();
            tzmitamen.Enabled = true;
              }


            
                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן תעודת זהות מ,אמן קיים לעדכון");
            }

            tzmitamen2.Visible = true;

        }

        private void tzmitamen2_Click(object sender, EventArgs e)
        {
            
        }

        private void tzmitamen2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yeshuv_TextChanged(object sender, EventArgs e)
        {

        }

        private void hiovmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbdaymitamen_Click(object sender, EventArgs e)
        {

        }

        private void bdaymitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelmitamen_Click(object sender, EventArgs e)
        {

        }

        private void lblmishmitamen_Click(object sender, EventArgs e)
        {

        }

        private void minmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void gilmitamen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mishmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void telmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktovetmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblshemmitamen_Click(object sender, EventArgs e)
        {

        }

        private void lbltzmitamen_Click(object sender, EventArgs e)
        {

        }

        private void tzmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void shemmitamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstrainees_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void minmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tzmitamen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void tzmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void shemmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mishmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ktovetmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void yeshuv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hugmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hiovmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bdaymitamen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void telmitamen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void gilmitamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mitamneem2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mitamneem2BindingSource.MoveLast();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tzmitamen2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            shemmitamen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mishmitamen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telmitamen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ktovetmitamen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            gilmitamen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            minmitamen.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            bdaymitamen.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            yeshuv.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            hiovmitamen.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            hugmitamen.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tokefmitamen.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void tzmitamen2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tzmitamen2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tzmitamen2_Click_2(object sender, EventArgs e)
        {
            tzmitamen2.Visible = false;
            tzmitamen.Focus();
        }

     private void tzmitamen2_TextChanged_1(object sender, EventArgs e)
        {
            tzmitamen.Text = tzmitamen2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            tzmitamen.Enabled = true;
            tzmitamen2.Enabled = true;
            shemmitamen.Enabled = true;
            mishmitamen.Enabled = true;
            telmitamen.Enabled = true;
            ktovetmitamen.Enabled = true;
            gilmitamen.Enabled = true;
            minmitamen.Enabled = true;
            bdaymitamen.Enabled = true;
            yeshuv.Enabled = true;
            hiovmitamen.Enabled = true;
            hugmitamen.Enabled = true;
            tokefmitamen.Enabled = true;
        
            tzmitamen.Enabled = true;

            tzmitamen2.Clear();
            shemmitamen.Clear();
            mishmitamen.Clear();
            telmitamen.Clear();
            ktovetmitamen.Clear();
            gilmitamen.Clear();
            minmitamen.Text = "";
            bdaymitamen.Clear();
            yeshuv.Clear();
            hiovmitamen.Clear();
            hugmitamen.Text = "";
            tokefmitamen.Clear();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Visible = false;
            tzmitamen2.Enabled = true;
            shemmitamen.Enabled = true;
            mishmitamen.Enabled = true;
            telmitamen.Enabled = true;
            ktovetmitamen.Enabled = true;
            gilmitamen.Enabled = true;
            minmitamen.Enabled = true;
            bdaymitamen.Enabled = true;
            yeshuv.Enabled = true;
            hiovmitamen.Enabled = true;
            hugmitamen.Enabled = true;
            tokefmitamen.Enabled = false;
            tzmitamen.Enabled = true;
            
        }
    }
}
