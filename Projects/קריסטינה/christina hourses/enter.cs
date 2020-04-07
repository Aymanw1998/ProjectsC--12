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
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        string s, ss, dd, bb, en;
        hoursesDataSet.workeersDataTable mm;
        hoursesDataSet.mishmarotDataTable mn;
        hoursesDataSet.shaotDataTable mk;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void enter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.shaot' table. You can move, or remove it, as needed.
            this.shaotTableAdapter.Fill(this.hoursesDataSet.shaot);
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);
            // TODO: This line of code loads data into the 'hoursesDataSet.mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hoursesDataSet.mishmarot);


            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            if (today == firstDayOfMonth && Form_main.xpass == 0)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from mishmarot  ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_main.xpass = 1;


            }

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

            string k, r;
            bool bl = false;
            mm = hoursesDataSet.workeers;
            k = textbox_password.Text;
            for (int i = 0; i < mm.Rows.Count; i++)
            {
                r = mm.Rows[i]["mispar oved"].ToString();

                if (k == r)
                {
                    bl = true;

                }
            }
            if (bl == false)
            {
                MessageBox.Show("עובד זה אינו קיים במערכת");
                textbox_password.Text = "";
            }

            if (bl == true)
            {

                string tarich, p, b, st;

                bool bl1 = true;
                mn = hoursesDataSet.mishmarot;
                k = textbox_password.Text;
                for (int i = 0; i < mn.Rows.Count && bl1 == true; i++)
                {
                    tarich = DateTime.Today.ToString();

                    dd = mn.Rows[i]["tarich"].ToString();
                    r = mn.Rows[i]["mispar oved"].ToString();
                    en = mn.Rows[i]["end"].ToString();


                    if (k.Equals(r) && dd.Equals(tarich) && en == "")
                    {


                        p = DateTime.Now.ToShortTimeString();

                        string p2 = "";
                        p2 = p[0].ToString() + p[1].ToString();

                        string p3 = "";
                        p3 = p[3].ToString() + p[4].ToString();


                        bb = mn.Rows[i]["begin"].ToString();

                        string p22 = "";
                        p22 = bb[0].ToString() + bb[1].ToString();

                        string p33 = "";
                        p33 = bb[3].ToString() + bb[4].ToString();

                        int x1 = Convert.ToInt32(p2);
                        int x2 = Convert.ToInt32(p3);
                        int y1 = Convert.ToInt32(p22);
                        int y2 = Convert.ToInt32(p33);

                        int sumhours = x1 - y1;
                        int summinuts = x2 - y2;

                        if (summinuts < 0)
                        {
                            summinuts = x2 - y2 + 60;
                            sumhours = x1 - y1 - 1;
                        }


                        st = sumhours + ":" + summinuts;



                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "update mishmarot SET [end]='" + p + "' , [sum]='" + st + "' where [mispar oved]= '" + k + "' and tarich = '" + tarich + "'";

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        enter_Load(sender, e);

                        MessageBox.Show("להתראות!");
                        bl1 = false;
                        textbox_password.Text = "";

                    }

                }
                if (bl1 == true)
                {
                    tarich = DateTime.Today.ToString();
                    p = "";
                    b = DateTime.Now.ToShortTimeString();
                    OleDbCommand cnd = new OleDbCommand();
                    cnd.CommandText = "INSERT into mishmarot([mispar oved],tarich,[end],[begin]) VALUES('" + textbox_password.Text + "','" + tarich + "','" + p + "','" + b + "' )";
                    cnd.Connection = con;
                    con.Open();
                    cnd.ExecuteNonQuery();
                    con.Close();
                    enter_Load(sender, e);

                    MessageBox.Show("משמרת נעימה!");
                    textbox_password.Text = "";

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)
                textbox_password.UseSystemPasswordChar = true;
            else
                textbox_password.UseSystemPasswordChar = false;
        }


    }
}