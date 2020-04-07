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


namespace christina_hourses
{
    public partial class yoman : Form
    {
        public yoman()
        {
            InitializeComponent();
        }


        int selectedRow;

        hoursesDataSet.yoman1DataTable dz;

        hoursesDataSet.activityDataTable mz;


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        hoursesDataSet.workeersDataTable dw;



        private void yoman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);
            // TODO: This line of code loads data into the 'hoursesDataSet.activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.hoursesDataSet.activity);
            // TODO: This line of code loads data into the 'hoursesDataSet.yoman1' table. You can move, or remove it, as needed.
            this.yoman1TableAdapter.Fill(this.hoursesDataSet.yoman1);


            dw = hoursesDataSet.workeers;

            for (int i = 0; i < dw.Rows.Count; i++)
            {
                txb_worker.Items.Add(dw.Rows[i]["shem"].ToString());
            }




            if (DateTime.Now.DayOfWeek.ToString() == "Sunday")
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update yoman SET sunday='" + "" + "',monday='" + "" + "',tuesday='" + "" + "' ,wednesday='" + "" + "',thursdy='" + "" + "',friday='" + "" + "',satarday='" + "" + "' ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }


            if (DateTime.Now.DayOfWeek.ToString() == "Sunday")
            {
                mz = hoursesDataSet.activity;

                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    string tar = mz.Rows[j][6].ToString();
                    tar = tar + " " + "00:00:00";

                    string act = mz.Rows[j][0].ToString();
                    string ho = mz.Rows[j][2].ToString();


                    if (tar == Convert.ToString(DateTime.Today.AddDays(0)))
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "update yoman SET [sunday]='" + act + "' where hours='" + ho + "'";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                     if (tar == Convert.ToString(DateTime.Today.AddDays(1)))
                        {
                           
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [monday]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                     if (tar == Convert.ToString(DateTime.Today.AddDays(2)))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [tuesday]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }

                     if (tar == Convert.ToString(DateTime.Today.AddDays(3)))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [wednesday]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                     if (tar == Convert.ToString(DateTime.Today.AddDays(4)))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [thrsdy]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }


                     if (tar == Convert.ToString(DateTime.Today.AddDays(5)))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [friday]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }

                     if (tar == Convert.ToString(DateTime.Today.AddDays(6)))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update yoman SET [satarday]='" + act + "' where hours='" + ho + "'";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                    }
                }


            }



    



        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            hour.Text = row.Cells[0].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool bl = true;
            if (hour2.Text != "08:00" && hour2.Text != "08:30" && hour2.Text != "09:00" && hour2.Text != "09:30" && hour2.Text != "10:00" && hour2.Text != "10:30" && hour2.Text != "11:00" && hour2.Text != "11:30" && hour2.Text != "12:00" && hour2.Text != "12:30" && hour2.Text != "13:00" && hour2.Text != "13:30" && hour2.Text != "14:00" && hour2.Text != "14:30" && hour2.Text != "15:00" && hour2.Text != "15:30" && hour2.Text != "16:00" && hour2.Text != "16:30" && hour2.Text != "17:00" && hour2.Text != "17:30" && hour2.Text != "18:00" && hour2.Text != "18:30" && hour2.Text != "19:00" && hour2.Text != "19:30" && hour2.Text != "20:00")
            {
                bl = false;
                MessageBox.Show("אנו לא עובדים עד שעה זאת,יש לשנות את שעת סיום הפעילות על מנת להוסיף פעילות זאת !");
            }


            dz = hoursesDataSet.yoman1;
            int count = 0;
            bool bul = true;
            for (int i = 0; i < dz.Rows.Count && bul; i++)
            {


                if (hour.Text == dz.Rows[i][0].ToString())
                {

                    bul = false;

                }
                else
                    count++;

            }

            if (dz.Rows[count][combo.SelectedIndex + 1].ToString() != "")
            {
                MessageBox.Show("שעה זו אינה פנויה אנא בחר שעה אחרת!");

            }



            else
            {


                OleDbCommand cmd = new OleDbCommand();
                OleDbCommand ocb = new OleDbCommand();

                if (combo.Text == "ראשון" && bl == true)
                {



                    cmd.CommandText = "update yoman SET [sunday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();



                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";

                }


                else if (combo.Text == "שני" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [monday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);


                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";


                }
                else if (combo.Text == "שלישי" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [tuesday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();



                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";

                }
                else if (combo.Text == "רביעי" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [wednesday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";

                }
                else if (combo.Text == "חמישי" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [thursdy]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";

                }
                else if (combo.Text == "שישי" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [friday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";
                }
                else if (combo.Text == "שבת" && bl == true)
                {
                    cmd.CommandText = "update yoman SET [satarday]='" + activity.Text + "' where hours='" + hour.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    ocb.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + activity.Text + "','" + combo.Text + "','" + hour.Text + "','" + hour2.Text + "','" + txb_worker.Text + "',' ','" + txb_tarich.Text + "')";
                    ocb.Connection = con;
                    con.Open();
                    ocb.ExecuteNonQuery();
                    con.Close();
                    yoman_Load(sender, e);

                    combo.Text = "";
                    hour.Text = "";
                    hour2.Text = "";
                    activity.Text = "";
                    txb_worker.Text = "";
                    txb_tarich.Text = "";


                }
            }


        }

        private void combo_ChangeUICues(object sender, UICuesEventArgs e)
        {



        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int sum;
            int num = -1;

            if (DateTime.Today.DayOfWeek.ToString() == "sunday")
            {
                num = 0;
            }

            if (DateTime.Today.DayOfWeek.ToString() == "monday")
            {
                num = 1;
            }
            if (DateTime.Today.DayOfWeek.ToString() == "tuesday")
            {
                num = 2;
            }
            if (DateTime.Today.DayOfWeek.ToString() == "wednesday")
            {
                num = 3;
            }
            if (DateTime.Today.DayOfWeek.ToString() == "thursday")
            {
                num = 4;
            }
            if (DateTime.Today.DayOfWeek.ToString() == "friday")
            {
                num = 5;
            }
            if (DateTime.Today.DayOfWeek.ToString() == "satarday")
            {
                num = 6;
            }

            sum = combo.SelectedIndex - num;
            DateTime today = DateTime.Today;
            DateTime chosenday = today.AddDays(sum - 2);
            txb_tarich.Text = Convert.ToString(chosenday);
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        


        }
    }
}
