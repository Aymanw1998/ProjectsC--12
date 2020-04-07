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
    public partial class formmeamnim : Form
    {
        

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public formmeamnim()
        {
            InitializeComponent();
        }
        razan22DataSet1.meamnim2DataTable mm;
        razan22DataSet1.meamnim2DataTable mz;

        razan22DataSet1.hugeem2DataTable mw;

        private void lblT_Click(object sender, EventArgs e)
        {

        }

        private void btnbkab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formmeamnim_Load(object sender, EventArgs e)
        {
           

            // TODO: This line of code loads data into the 'razan22DataSet1.hugeem2' table. You can move, or remove it, as needed.
            this.hugeem2TableAdapter.Fill(this.razan22DataSet1.hugeem2);

            // TODO: This line of code loads data into the 'razan22DataSet1.meamnim2' table. You can move, or remove it, as needed.
            this.meamnim2TableAdapter.Fill(this.razan22DataSet1.meamnim2);
            hug.Items.Clear();
            mw = razan22DataSet1.hugeem2;
            for (int i = 0; i < mw.Rows.Count; i++)
            {
                
                hug.Items.Add(mw.Rows[i]["shem"].ToString());
            }
            
        }

        private void btnmamho_Click(object sender, EventArgs e)
        {
            
            bool bl3 = true;
            bool bl2 = true;
            bool bl11 = true;
            string st2 = tzmeamen.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }


            if (tzmeamen.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (shemmeamen.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishmeamen.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (telmeamen.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

        

            if (ktovetmeamen.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (gilmeamen.Text == "")
            {
                bl2 = false;
                label7.Visible = true;

            }
            else

                label7.Visible = false;

            if (minmeamen.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (maskedTextBox2.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (yeshuvmeamen.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (mismeamen.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (hug.Text == "")
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

            bool bl9 = true;
            bool bl8 = true;
            bool bl77 = true;
            bool bl7 = true;
            bool bl55 = true;
            bool bl4 = true;
            bool bl111 = true;
            bool bl100 = true;
            bool bl57 = true;
            bool bl5 = true;


            if (bl2 == true)
            {



                if (tzmeamen.Text.Length != 9)
                {
                    bl3 = false;
                    MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
                }




                
                bool bl20 = true;
                if (maskedTextBox2.Text.Length != 10)
                {
                    bl4 = false;
                    MessageBox.Show("הזן תאריך חוקי");
                    bl20 = false;
                }



                
                if (bl20 == true)
                {
                    string s28 = maskedTextBox2.Text;
                    string s29 = s28.Substring(6, 4);

                    string s24 = maskedTextBox2.Text;
                    string s25 = s24.Substring(0, 2);


                    string s26 = maskedTextBox2.Text;
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

                string s30 = maskedTextBox2.Text;
                string s31 = s30.Substring(6, 4);

                int z1 = Convert.ToInt32(gilmeamen.Text);
                string currentyear = DateTime.Now.Year.ToString();
                int cc = Convert.ToInt32(currentyear);
                int cc2 = cc - z1;
                int z22 = Convert.ToInt32(s31);
                if (z22 != cc2)
                    MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");



                
                string st77 = gilmeamen.Text;
                if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
                {
                    bl77 = false;
                    MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
                }

               
                string sv = telmeamen.Text;
                if (sv[0] != '0' || sv[1] != '5')
                {
                    MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                    bl100 = false;
                }

                
                string st22 = telmeamen.Text;
                int xx = st22.IndexOf(' ');
                if (xx != -1)
                {
                    MessageBox.Show("הזן מספר פלאפון ללא רווח");
                    bl111 = false;
                }

                
                string st55 = mismeamen.Text;
                if (double.Parse(st55) > 7)
                {
                    bl55 = false;
                    MessageBox.Show("הזן מספר ימי עבודה קטן מ8");
                }

                
                if (telmeamen.Text.Length != 11)
                {
                    bl5 = false;
                    MessageBox.Show("הזן מספר פלאפון חוקי");
                }
                int z = Convert.ToInt32(mismeamen.Text);
                int r = z * 8 * 50;
                masmeamen.Text = Convert.ToString(r);
            }
            
           

            if (bl2 == true &&  bl57==true &&bl100 == true && bl77 == true && bl55 == true && bl3 == true && bl4 == true && bl11 == true && bl5 == true && bl7 == true && bl8 == true && bl9 == true && bl111 == true)
            {

                mm = razan22DataSet1.meamnim2;


                string s = tzmeamen.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["tz"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("מאמן זה קיים");
                        bl = false;
                 


                    }

                }




                if (bl == true)
                {
                   
                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into meamnim2(tz,shem,mishpaha,tel,maskoret,ktovet,gil,[min],tarikh,yeshuv,yamim,hug) VALUES('" + tzmeamen.Text + "' , '" + shemmeamen.Text + "', '" + mishmeamen.Text + "', '" + telmeamen.Text + "', '" + masmeamen.Text + "', '" + ktovetmeamen.Text + "', '" + gilmeamen.Text + "', '" + minmeamen.Text + "', '" + maskedTextBox2.Text + "', '" + yeshuvmeamen.Text + "' , '" + mismeamen.Text + "' , '"
                        + hug.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formmeamnim_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                        button5.Visible = true;
                        maskedTextBox1.Enabled = false;
                        shemmeamen.Enabled =false;
                        mishmeamen.Enabled = false;
                        telmeamen.Enabled = false;
                        masmeamen.Enabled = false;
                        ktovetmeamen.Enabled = false;
                        gilmeamen.Enabled = false;
                        minmeamen.Enabled = false;
                        maskedTextBox2.Enabled = false;
                        yeshuvmeamen.Enabled = false;
                        mismeamen.Enabled = false;
                        hug.Enabled = false;

                    }

                    if (dr == DialogResult.No)
                    {
                        button5.Visible = true;
                        maskedTextBox1.Enabled = false;
                        tzmeamen.Enabled = false;
                        shemmeamen.Enabled = false;
                        mishmeamen.Enabled = false;
                        telmeamen.Enabled = false;
                        masmeamen.Enabled = false;
                        ktovetmeamen.Enabled = false;
                        gilmeamen.Enabled = false;
                        minmeamen.Enabled = false;
                        maskedTextBox2.Enabled = false;
                        yeshuvmeamen.Enabled = false;
                        mismeamen.Enabled = false;
                        hug.Enabled = false;
                        maskedTextBox1.Clear();
                        shemmeamen.Clear();
                        mishmeamen.Clear();
                        telmeamen.Clear();
                        masmeamen.Clear();
                        ktovetmeamen.Clear();
                        gilmeamen.Clear();
                        minmeamen.Text = "";
                        maskedTextBox2.Clear();
                        yeshuvmeamen.Clear();
                        mismeamen.Clear();
                        hug.Text = "";
                    }

                }

            }

            maskedTextBox1.Visible = true;



        }
        private void btnmamma_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (tzmeamen.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן תעודת זהות למחיקה");
            }

            if (blb == true)
            {
                mm = razan22DataSet1.meamnim2;


                string s = tzmeamen.Text;
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
                            cmd.CommandText = "Delete from meamnim2 where tz = '" + tzmeamen.Text + "' ";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();



                            formmeamnim_Load(sender, e);
                            MessageBox.Show("!מחיקה בוצעה בהצלחה");

                        }

                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן תעודת זהות מאמן קיים למחיקה");
            }

            maskedTextBox1.Visible = true;
        }
            
        private void btnmamidk_Click(object sender, EventArgs e)
        {
            bool bl111 = true;
            string st22 = telmeamen.Text;
            int xx = st22.IndexOf(' ');
            if (xx != -1)
            {
                MessageBox.Show("הזן מספר פלאפון ללא רווח");
                bl111 = false;
            }

            bool bl13 = true;
            string st3 = masmeamen.Text;
            int y = st3.IndexOf(' ');
            if (y != -1)
            {
                MessageBox.Show("הזן משכורת מאמן ללא רווח");
                bl13 = false;
            }

            bool bl11 = true;
            string st2 = tzmeamen.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }
            bool bl2 = true;

            if (shemmeamen.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishmeamen.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (telmeamen.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (masmeamen.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (ktovetmeamen.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (gilmeamen.Text == "")
            {
                bl2 = false;
                label7.Visible = true;

            }
            else

                label7.Visible = false;

            if (minmeamen.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (maskedTextBox2.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (yeshuvmeamen.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (mismeamen.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (hug.Text == "")
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

            bool bl100 = true;
            string sv = telmeamen.Text;
            if (sv[0] != '0' || sv[1] != '5')
            {
                MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                bl100 = false;
            }

            bool bl3 = true;
            if (tzmeamen.Text.Length != 9)
            {
                bl3 = false;
                MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
            }
            bool bl20 = true;
            bool bl4 = true;
            if (maskedTextBox2.Text.Length != 10)
            {
                bl4 = false;
                MessageBox.Show("הזן תאריך חוקי");
                bl20 = false;
            }

            bool bl8 = true;
            bool bl7 = true;
            bool bl9 = true;
            if (bl20 == true)
            {
                string s28 = maskedTextBox2.Text;
                string s29 = s28.Substring(6, 4);

                string s24 = maskedTextBox2.Text;
                string s25 = s24.Substring(0, 2);


                string s26 = maskedTextBox2.Text;
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

            bool bl77 = true;
            if (gilmeamen.Text != "")
            {

                string st77 = gilmeamen.Text;
                if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
                {
                    bl77 = false;
                    MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
                }
            }

            bool bl5 = true;
            if (telmeamen.Text.Length != 11)
            {
                bl5 = false;
                MessageBox.Show("הזן מספר פלאפון חוקי");
            }

            string s30 = maskedTextBox2.Text;
            string s31 = s30.Substring(6, 4);

            int z1 = Convert.ToInt32(gilmeamen.Text);
            string currentyear = DateTime.Now.Year.ToString();
            int cc = Convert.ToInt32(currentyear);
            int cc2 = cc - z1;
            int z22 = Convert.ToInt32(s31);
            if (z22 != cc2)
                MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");

            bool bl55 = true;
            string st55 = mismeamen.Text;
            if (double.Parse(st55) > 7)
            {
                bl55 = false;
                MessageBox.Show("הזן מספר ימי עבודה קטן מ8");
            }

                bool blb2 = true;
                bool blb = true;
                if (tzmeamen.Text == "")
                {
                    blb = false;
                    MessageBox.Show("הזן תעודת זהות לעדכון");


                }

                
                if (blb == true && bl100==true&& bl55==true && bl77==true &&  bl11 == true && bl3 == true && bl4==true && bl2==true && bl5==true && bl7==true && bl8==true && bl9==true && bl13==true && bl111==true)
                {

                  mm = razan22DataSet1.meamnim2;


                string s = tzmeamen.Text;
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

                if (dr == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Update meamnim2 SET shem='" + shemmeamen.Text + "',mishpaha='" + mishmeamen.Text + "', tel='" + telmeamen.Text + "', maskoret='" + masmeamen.Text + "', ktovet='" + ktovetmeamen.Text + "', gil='" + gilmeamen.Text + "', [min]='" + minmeamen.Text + "' , tarikh='" + maskedTextBox2.Text + "' , yeshuv='" + yeshuvmeamen.Text + "' , yamim='" + mismeamen.Text + "' , hug='"+hug.Text+"' where tz='" + tzmeamen.Text + "' ";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    formmeamnim_Load(sender, e);
                    MessageBox.Show("!שינויים בוצעו בהצלחה");
                    button6.Visible = true;
                    maskedTextBox1.Enabled = false;
                    shemmeamen.Enabled = false;
                    mishmeamen.Enabled = false;
                    telmeamen.Enabled = false;
                    masmeamen.Enabled = false;
                    ktovetmeamen.Enabled = false;
                    gilmeamen.Enabled = false;
                    minmeamen.Enabled = false;
                    maskedTextBox2.Enabled = false;
                    yeshuvmeamen.Enabled = false;
                    mismeamen.Enabled = false;
                    hug.Enabled = false;

                }

                if (dr == DialogResult.No)
                {
                    button6.Visible = true;
                    maskedTextBox1.Enabled = false;
                    shemmeamen.Enabled = false;
                    mishmeamen.Enabled = false;
                    telmeamen.Enabled =false;
                    masmeamen.Enabled = false;
                    ktovetmeamen.Enabled = false;
                    gilmeamen.Enabled = false;
                    minmeamen.Enabled = false;
                    maskedTextBox2.Enabled = false;
                    yeshuvmeamen.Enabled = false;
                    mismeamen.Enabled = false;
                    hug.Enabled = false;
                    maskedTextBox1.Clear();
                    shemmeamen.Clear();
                    mishmeamen.Clear();
                    telmeamen.Clear();
                    masmeamen.Clear();
                    ktovetmeamen.Clear();
                    gilmeamen.Clear();
                    minmeamen.Text = "";
                    maskedTextBox2.Clear();
                    yeshuvmeamen.Clear();
                    mismeamen.Clear();
                    hug.Text = "";


                }

                    }
                           
                    else
                            blb2 = false;

                    }

                    if (blb2 == false)
                        MessageBox.Show("הזן תעודת זהות מאמן קיים לעדכון");
                }

                maskedTextBox1.Visible = true;
                
        }


        private void tbtrainers_TextChanged(object sender, EventArgs e)
        {
            if (tbtrainers.Text.Length == 0)
            {
                formmeamnim_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.meamnim2;
            }

            else
            {

                mz = razan22DataSet1.meamnim2;
                DataTable dz = new DataTable();
                dz.Columns.Add("tz");
                dz.Columns.Add("shem");
                dz.Columns.Add("mishpaha");
                dz.Columns.Add("tel");
                dz.Columns.Add("maskoret");
                dz.Columns.Add("ktovet");
                dz.Columns.Add("gil");
                dz.Columns.Add("min");
                dz.Columns.Add("tarikh");
                dz.Columns.Add("yeshuv");
                dz.Columns.Add("yamim");
                dz.Columns.Add("hug");



                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbtrainers.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8], mz[j][9], mz[j][10] , mz[j][11]);

                            k = mz.Columns.Count;

                        }

                    }


                }

                dataGridView1.DataSource = dz;



            }
        }
       


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            tzmeamen.Focus();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            tzmeamen.Text = maskedTextBox1.Text;
        }

        private void shemmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mishmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ktovetmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void yeshuvmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void tzmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void minmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mismeamen_TextChanged(object sender, EventArgs e)
        {
            if(mismeamen.Text!="")
            {
                int r = Convert.ToInt32(mismeamen.Text);
                int r2 = r * 50;
                masmeamen.Text = Convert.ToString(r2);

            }
        }

        private void gilmeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void mismeamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meamnim2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meamnim2BindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meamnim2BindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meamnim2BindingSource.MovePrevious();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            shemmeamen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mishmeamen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telmeamen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            masmeamen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ktovetmeamen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            gilmeamen.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            minmeamen.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            yeshuvmeamen.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            mismeamen.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();


        }

        private void bcsapak_Click(object sender, EventArgs e)
        {
            this.Close();
            formmenahel menback1 = new formmenahel();
            menback1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            maskedTextBox1.Enabled = true;
            shemmeamen.Enabled = true;
            mishmeamen.Enabled = true;
            telmeamen.Enabled = true;
            masmeamen.Enabled = false;
            ktovetmeamen.Enabled = true;
            gilmeamen.Enabled = true;
            minmeamen.Enabled = true;
            maskedTextBox2.Enabled = true;
            yeshuvmeamen.Enabled = true;
            mismeamen.Enabled = true;
            hug.Enabled = true;
            tzmeamen.Enabled = true;




        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            maskedTextBox1.Enabled = true;
            tzmeamen.Enabled = true;
            shemmeamen.Enabled = true;
            mishmeamen.Enabled = true;
            telmeamen.Enabled = true;
            masmeamen.Enabled = false;
            ktovetmeamen.Enabled = true;
            gilmeamen.Enabled = true;
            minmeamen.Enabled = true;
            maskedTextBox2.Enabled = true;
            yeshuvmeamen.Enabled = true;
            mismeamen.Enabled = true;
            hug.Enabled = true;
            tzmeamen.Clear();
            shemmeamen.Clear();
            mishmeamen.Clear();
            telmeamen.Clear();
            masmeamen.Clear();
            ktovetmeamen.Clear();
            gilmeamen.Clear();
            minmeamen.Text = "";
            maskedTextBox2.Clear();
            yeshuvmeamen.Clear();
            mismeamen.Clear();
            hug.Text = "";


        }

        private void masmeamen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void telmeamen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblyeshuvmeamen_Click(object sender, EventArgs e)
        {

        }

        private void yeshuvmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbdaymeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblminmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblgilmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblktovetmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblmasmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lbltelmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblmishmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lblshemmeamen_Click(object sender, EventArgs e)
        {

        }

        private void lbltzmeamen_Click(object sender, EventArgs e)
        {

        }

        private void gilmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktovetmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tzmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void shemmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void mishmeamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void minmeamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hug_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblmismeamen_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblstrainers_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}
