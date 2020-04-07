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
    public partial class formovdeem : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public formovdeem()
        {
            InitializeComponent();
        }

        razan22DataSet1.ovdeem2DataTable mm;
        razan22DataSet1.ovdeem2DataTable mz;

        private void btnbkab_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void formovdeem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.ovdeem2' table. You can move, or remove it, as needed.
            this.ovdeem2TableAdapter.Fill(this.razan22DataSet1.ovdeem2);
           
            
        }

        private void lblovd_Click(object sender, EventArgs e)
        {
            

        }

        private void btnovdho_Click(object sender, EventArgs e)
        {
            bool bl3 = true;
            bool bl2 = true;
            bool bl11 = true;
            string st2 = tzoved.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }

            if(tzoved.Text=="")
            {
                bl2 = false;
                label1.Visible = true;
            }

            else
                label1.Visible=false;

            if (shemoved.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishoved.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (tafkidoved.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (yamimoved.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (teloved.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

           
            if (ktovetoved.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (giloved.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (minoved.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (yeshuvoved.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (maskedTextBox1.Text == "")
            {
                bl2 = false;
                label12.Visible = true;

            }
            else

                label12.Visible = false;

            if (bl2 == false)
                MessageBox.Show("הזן ערך בשדה חובה");

            bool bl9 = true;
            bool bl8 = true;
            bool bl77 = true;
            bool bl7 = true;
            bool bl5 = true;
            bool bl4 = true;
            bool bl111 = true;
            bool bl20 = true;

            if (bl2 == true)
            {



                if (tzoved.Text.Length != 9)
                {
                    bl3 = false;
                    MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
                }

               
                if (maskedTextBox1.Text.Length != 10)
                {
                    bl4 = false;
                    MessageBox.Show("הזן תאריך חוקי");
                    bl20 = false;
                }
                
                if (bl20 == true)
                {
                    string s28 = maskedTextBox1.Text;
                    string s29 = s28.Substring(6, 4);

                    string s24 = maskedTextBox1.Text;
                    string s25 = s24.Substring(0, 2);


                    string s26 = maskedTextBox1.Text;
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


                string s30 = maskedTextBox1.Text;
                string s31 = s30.Substring(6, 4);

                int z1 = Convert.ToInt32(giloved.Text);
                string currentyear = DateTime.Now.Year.ToString();
                int cc = Convert.ToInt32(currentyear);
                int cc2 = cc - z1;
                int z22 = Convert.ToInt32(s31);
                if (z22 != cc2)
                    MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");

                if (bl2 == false)
                {
                    MessageBox.Show("הזן ערך בשדה חובה");
                }

                
                if (teloved.Text.Length != 11)
                {
                    bl5 = false;
                    MessageBox.Show("הזן מספר פלאפון חוקי");
                }

                
                string st77 = giloved.Text;
                if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
                {
                    bl77 = false;
                    MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
                }


               
                string st22 = teloved.Text;
                int xx = st22.IndexOf(' ');
                if (xx != -1)
                {
                    MessageBox.Show("הזן מספר פלאפון ללא רווח");
                    bl111 = false;
                }

                int z = Convert.ToInt32(yamimoved.Text);
                int r = z * 8 * 50;
                masoved.Text = Convert.ToString(r);
            }

            if (bl2 == true &&  bl77==true && bl3==true && bl4==true && bl11==true && bl5==true && bl7==true && bl8==true && bl9==true && bl111==true)
            {
                mm = razan22DataSet1.ovdeem2;


                string s = tzoved.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["tz"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("עובד זה קיים");
                        bl = false;
                        


                    }

                }




                if (bl == true)
                {
                    

                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into ovdeem2 (tz,shem,mishpaha,tafkid,yamim,tel,maskoret,ktovet,gil,[min],yeshuv,tarih) VALUES('" + tzoved.Text + "' , '" + shemoved.Text + "' , '" + mishoved.Text + "' , '" + tafkidoved.Text + "' , '" + yamimoved.Text + "' , '" + teloved.Text + "' , '" + masoved.Text + "' , '" + ktovetoved.Text + "' , '" + giloved.Text + "' , '" + minoved.Text + "' , '" + yeshuvoved.Text + "' , '" + maskedTextBox1.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formovdeem_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                        button6.Visible = true;
                        maskedTextBox2.Enabled = false;
                        shemoved.Enabled = false;
                        mishoved.Enabled = false;
                        tafkidoved.Enabled = false;
                        yamimoved.Enabled = false;
                        teloved.Enabled = false;
                        masoved.Enabled = false;
                        ktovetoved.Enabled = false;
                        giloved.Enabled = false;
                        minoved.Enabled = false;
                        yeshuvoved.Enabled = false;
                        maskedTextBox1.Enabled = false;

                    }


                    if (dr == DialogResult.No)
                    {
                        button6.Visible = true;
                        maskedTextBox2.Enabled = false;
                        shemoved.Enabled = false;
                        mishoved.Enabled = false;
                        tafkidoved.Enabled = false;
                        yamimoved.Enabled = false;
                        teloved.Enabled = false;
                        masoved.Enabled = false;
                        ktovetoved.Enabled = false;
                        giloved.Enabled = false;
                        minoved.Enabled = false;
                        yeshuvoved.Enabled = false;
                        maskedTextBox1.Enabled = false;

                        maskedTextBox2.Clear();
                        shemoved.Clear();
                        mishoved.Clear();
                        tafkidoved.Text = "";
                        yamimoved.Clear();
                        teloved.Clear();
                        masoved.Clear();
                        ktovetoved.Clear();
                        giloved.Clear();
                        minoved.Text = "";
                        yeshuvoved.Clear();
                        maskedTextBox1.Clear();
                    }



                }
  
            }
            maskedTextBox2.Visible = true;
        }

        private void btnovdmh_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (tzoved.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן תעודת זהות למחיקה");
            }

            if (blb == true)
            {
                mm = razan22DataSet1.ovdeem2;


                string s = tzoved.Text;
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
                    cmd.CommandText = "Delete from ovdeem2 where tz = '" + tzoved.Text + "' ";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();



                    formovdeem_Load(sender, e);
                    MessageBox.Show("!מחיקה בוצעה בהצלחה");


                }
                        
                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן תעודת זהות עובד קיים למחיקה");
            }

            maskedTextBox2.Visible = true;
        }


        private void btnovdidk_Click(object sender, EventArgs e)
        {
            bool bl11 = true;
            string st2 = tzoved.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }
            bool bl2 = true;

            if (shemoved.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (mishoved.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (tafkidoved.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (yamimoved.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (teloved.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;


            if (ktovetoved.Text == "")
            {
                bl2 = false;
                label8.Visible = true;

            }
            else

                label8.Visible = false;

            if (giloved.Text == "")
            {
                bl2 = false;
                label9.Visible = true;

            }
            else

                label9.Visible = false;

            if (minoved.Text == "")
            {
                bl2 = false;
                label10.Visible = true;

            }
            else

                label10.Visible = false;

            if (yeshuvoved.Text == "")
            {
                bl2 = false;
                label11.Visible = true;

            }
            else

                label11.Visible = false;

            if (maskedTextBox1.Text == "")
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
            bool bl3 = true;
            if (tzoved.Text.Length != 9)
            {
                bl3 = false;
                MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
            }
            bool bl20 = true;
            bool bl4 = true;
            if (maskedTextBox1.Text.Length != 10)
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
                string s28 = maskedTextBox1.Text;
                string s29 = s28.Substring(6, 4);

                string s24 = maskedTextBox1.Text;
                string s25 = s24.Substring(0, 2);


                string s26 = maskedTextBox1.Text;
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

            string s30 = maskedTextBox1.Text;
            string s31 = s30.Substring(6, 4);

            int z1 = Convert.ToInt32(giloved.Text);
            string currentyear = DateTime.Now.Year.ToString();
            int cc = Convert.ToInt32(currentyear);
            int cc2 = cc - z1;
            int z22 = Convert.ToInt32(s31);
            if (z22 != cc2)
                MessageBox.Show("השנה אינה מתאימה לגיל שהוזן");

            bool bl5 = true;
            if (teloved.Text.Length != 11)
            {
                bl5 = false;
                MessageBox.Show("הזן מספר פלאפון חוקי");
            }

            bool bl77 = true;
            string st77 = giloved.Text;
            if (double.Parse(st77) > 70 || double.Parse(st77) < 14)
            {
                bl77 = false;
                MessageBox.Show("הזן גיל מאמן בטווח גילאים 14-70");
            }

            bool blb2 = true;
            bool blb = true;
            if (tzoved.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן תעודת זהות לעדכון");
            }

            bool bl111 = true;
            string st22 = teloved.Text;
            int xx = st22.IndexOf(' ');
            if (xx != -1)
            {
                MessageBox.Show("הזן מספר פלאפון ללא רווח");
                bl111 = false;
            }

            int z = Convert.ToInt32(yamimoved.Text);
            int r = z * 8 * 50;
            masoved.Text = Convert.ToString(r);

            if (blb == true && bl11 == true && bl2==true && bl77==true && bl3 == true && bl4 == true && bl5==true && bl7==true && bl8==true && bl9==true && bl111==true)
            {
                mm = razan22DataSet1.ovdeem2;


                string s = tzoved.Text;
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
                            cmd.CommandText = "Update ovdeem2 SET shem='" + shemoved.Text + "' , mishpaha='" + mishoved.Text + "' , tafkid='" + tafkidoved.Text + "' , yamim='" + yamimoved.Text + "' , tel='" + teloved.Text + "' , maskoret='" + masoved.Text + "' , ktovet='" + ktovetoved.Text + "' , gil='" + giloved.Text + "' , [min]='" + minoved.Text + "' , yeshuv='" + yeshuvoved.Text + "' , tarih='" + maskedTextBox1.Text + "' where tz='" + tzoved.Text + "' ";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();



                            formovdeem_Load(sender, e);
                            MessageBox.Show("!שינויים בוצעו בהצלחה");
                            button5.Visible = true;
                            maskedTextBox2.Enabled = false;
                            shemoved.Enabled = false;
                            mishoved.Enabled = false;
                            tafkidoved.Enabled = false;
                            yamimoved.Enabled = false;
                            teloved.Enabled = false;
                            masoved.Enabled = false;
                            ktovetoved.Enabled = false;
                            giloved.Enabled = false;
                            minoved.Enabled = false;
                            yeshuvoved.Enabled = false;
                            maskedTextBox1.Enabled = false;

                        }

                        if (dr == DialogResult.No)
                        {
                            button5.Visible = true;
                            maskedTextBox2.Enabled = false;
                            shemoved.Enabled = false;
                            mishoved.Enabled = false;
                            tafkidoved.Enabled = false;
                            yamimoved.Enabled = false;
                            teloved.Enabled = false;
                            masoved.Enabled = false;
                            ktovetoved.Enabled = false;
                            giloved.Enabled = false;
                            minoved.Enabled = false;
                            yeshuvoved.Enabled = false;
                            maskedTextBox1.Enabled = false;

                            maskedTextBox2.Clear();
                            shemoved.Clear();
                            mishoved.Clear();
                            tafkidoved.Text = "";
                            yamimoved.Clear();
                            teloved.Clear();
                            masoved.Clear();
                            ktovetoved.Clear();
                            giloved.Clear();
                            minoved.Text = "";
                            yeshuvoved.Clear();
                            maskedTextBox1.Clear();
                        }


                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן תעודת זהות עובד קיים לעדכון");
            }

            maskedTextBox2.Visible = true;

        }

        private void tbworkers_TextChanged(object sender, EventArgs e)
        {
            if (tbworkers.Text.Length == 0)
            {
                formovdeem_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.ovdeem2;
            }

            else
            {
                mz = razan22DataSet1.ovdeem2;
                DataTable dz = new DataTable();
                dz.Columns.Add("tz");
                dz.Columns.Add("shem");
                dz.Columns.Add("mishpaha");
                dz.Columns.Add("tafkid");
                dz.Columns.Add("yamim");
                dz.Columns.Add("tel");
                dz.Columns.Add("maskoret");
                dz.Columns.Add("ktovet");
                dz.Columns.Add("gil");
                dz.Columns.Add("min");
                dz.Columns.Add("yeshuv");
                dz.Columns.Add("tarih");




                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbworkers.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8], mz[j][9], mz[j][10], mz[j][11]);

                            k = mz.Columns.Count;

                        }

                    }


                }

                dataGridView1.DataSource = dz;


            }
       

        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Visible = false;
            tzoved.Focus();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            tzoved.Text = maskedTextBox2.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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

        private void lblbdayoved_Click(object sender, EventArgs e)
        {

        }

        private void lblyeshuvoved_Click(object sender, EventArgs e)
        {

        }

        private void yeshuvoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblminoved_Click(object sender, EventArgs e)
        {

        }

        private void lblgiloved_Click(object sender, EventArgs e)
        {

        }

        private void minoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void giloved_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblktovetoved_Click(object sender, EventArgs e)
        {

        }

        private void lblmasoved_Click(object sender, EventArgs e)
        {

        }

        private void ktovetoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void masoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblteloved_Click(object sender, EventArgs e)
        {

        }

        private void lblyamimoved_Click(object sender, EventArgs e)
        {

        }

        private void lbltafkidoved_Click(object sender, EventArgs e)
        {

        }

        private void teloved_TextChanged(object sender, EventArgs e)
        {

        }

        private void yamimoved_TextChanged(object sender, EventArgs e)
        {
            if (yamimoved.Text != "")
            {
                int r = Convert.ToInt32(yamimoved.Text);
                int r2 = r * 50;
                masoved.Text = Convert.ToString(r2);

            }
        }

        private void tafkidoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void lblmishoved_Click(object sender, EventArgs e)
        {

        }

        private void lblshemoved_Click(object sender, EventArgs e)
        {

        }

        private void lbltzoved_Click(object sender, EventArgs e)
        {

        }

        private void tzoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void shemoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void mishoved_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsworkers_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void tzoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void shemoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mishoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tafkidoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ktovetoved_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void minoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void yeshuvoved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void giloved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovdeem2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ovdeem2BindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ovdeem2BindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ovdeem2BindingSource.MovePrevious();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            shemoved.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mishoved.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tafkidoved.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yamimoved.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            teloved.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            masoved.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ktovetoved.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            giloved.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            minoved.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            yeshuvoved.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void bcsapak_Click(object sender, EventArgs e)
        {
            this.Close();
            formmenahel menback1 = new formmenahel();
            menback1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            maskedTextBox2.Enabled = true;
            shemoved.Enabled = true;
            mishoved.Enabled = true;
            tafkidoved.Enabled = true;
            yamimoved.Enabled = true;
            teloved.Enabled = true;
            masoved.Enabled =false;
            ktovetoved.Enabled = true;
            giloved.Enabled = true;
            minoved.Enabled = true;
            yeshuvoved.Enabled = true;
            maskedTextBox1.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            maskedTextBox2.Enabled = true;
            tzoved.Enabled = true;
            shemoved.Enabled = true;
            mishoved.Enabled = true;
            tafkidoved.Enabled = true;
            yamimoved.Enabled = true;
            teloved.Enabled = true;
            masoved.Enabled = false;
            ktovetoved.Enabled = true;
            giloved.Enabled = true;
            minoved.Enabled = true;
            yeshuvoved.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Clear();
            shemoved.Clear();
            mishoved.Clear();
            tafkidoved.Text = "";
            yamimoved.Clear();
            teloved.Clear();
            masoved.Clear();
            ktovetoved.Clear();
            giloved.Clear();
            minoved.Text = "";
            yeshuvoved.Clear();
            maskedTextBox1.Clear();
            



        }

        private void masoved_TextChanged_1(object sender, EventArgs e)
        {

        }

       

       
    }
}
