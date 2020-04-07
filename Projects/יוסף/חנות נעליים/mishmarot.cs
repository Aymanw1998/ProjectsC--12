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


namespace חנות_נעליים
{
    public partial class mishmarot : Form
    {
        public mishmarot()
        {
            InitializeComponent();
        }
        shoe_shopDataSet.ovdimDataTable yy;
        shoe_shopDataSet.mishmarotDataTable ss;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        string date = DateTime.Now.Year.ToString() + ":" + DateTime.Now.Month.ToString() + ":" + DateTime.Now.Day.ToString();
        
        private void mishmarot_Load(object sender, EventArgs e)
        {

            password.Text = "";
            this.archivesTableAdapter.Fill(this.shoe_shopDataSet.archives);
            this.mishmarotTableAdapter.Fill(this.shoe_shopDataSet.mishmarot);
            this.ovdimTableAdapter.Fill(this.shoe_shopDataSet.ovdim);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shem_TextChanged(object sender, EventArgs e)
        {
        }

        private void ovdimBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string time_hour = DateTime.Now.Hour.ToString();
            string time_min = DateTime.Now.Minute.ToString();


            if (DateTime.Now.Hour.ToString().Count() == 1)//אם מספר השעה הוא ספרה אחת
            {
                time_hour = 0 + DateTime.Now.Hour.ToString();
            }

            if (DateTime.Now.Minute.ToString().Count() == 1)//אם מספר הדקות הוא ספרה אחת
            {
                time_min = 0 + DateTime.Now.Minute.ToString();
            }


            string time = time_hour + ":" + time_min;
            ss = shoe_shopDataSet.mishmarot;
            yy = shoe_shopDataSet.ovdim;
            bool bl = true;
            for (int j = 0; j < yy.Rows.Count; j++)
            {
                if (password.Text == yy.Rows[j]["password"].ToString())
                {
                    string tz_oved = yy.Rows[j]["tz"].ToString();
                    MessageBox.Show(tz_oved);

                    for (int k = 0; k < ss.Rows.Count && bl; k++)
                    {
                        if (tz_oved == ss.Rows[k]["tz"].ToString())
                        {
                            MessageBox.Show("עובד במשמרת");
                            bl = false;
                        }
                    }
                }
            }
            if (bl)
            {
                for (int i = 0; i < yy.Rows.Count; i++)
                {
                    if (yy.Rows[i]["password"].ToString() == password.Text)
                    {

                        DialogResult dr = MessageBox.Show("התחל משמרת", "כן", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "INSERT into mishmarot(tz,shem,start) VALUES('" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "','" + time + "')";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            mishmarot_Load(sender, e);
                            MessageBox.Show("יופי");
                            bl = false;

                        }
                    }

                }


            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool bl = true;
            yy = shoe_shopDataSet.ovdim;
            ss = shoe_shopDataSet.mishmarot;
            string tz_oved = "";
            int hh_int = 0;
            int mm_int = 0;
            int hh1_int = DateTime.Now.Hour;
            int mm1_int = DateTime.Now.Minute;

            for (int j = 0; j < yy.Rows.Count; j++)
            {
                if (password.Text == yy.Rows[j]["password"].ToString())
                {
                    tz_oved = yy.Rows[j]["tz"].ToString();
                }
            }
            for (int i = 0; i < ss.Rows.Count && bl; i++)
            {
                if (tz_oved != "")
                {
                    if (tz_oved == ss.Rows[i]["tz"].ToString())
                    {
                        string shaot = ss.Rows[i]["start"].ToString();
                        MessageBox.Show(shaot + "  שעת התחלה   ");
                        string hh_string = shaot.Substring(0, 2);
                        hh_int = Convert.ToInt32(hh_string);
                        string mm_string = shaot[3] + shaot[4].ToString();
                        mm_int = Convert.ToInt32(mm_string);
                        hh1_int = DateTime.Now.Hour;
                        mm1_int = DateTime.Now.Minute;

                        if (DateTime.Now.Hour.ToString().Count() == 1)//אם מספר השעה הוא ספרה אחת
                        {
                            hh1_int = 0 + DateTime.Now.Hour;
                        }

                        if (DateTime.Now.Minute.ToString().Count() == 1)//אם מספר הדקות הוא ספרה אחת
                        {
                            mm1_int = 0 + DateTime.Now.Minute;
                        }
                        MessageBox.Show(hh1_int.ToString() + ":" + mm1_int.ToString() + "   השעה כעת    ");
                        int hh_sofi = hh1_int - hh_int;
                        int mm_sofi = mm1_int - mm_int;
                        string hh_sofi_string;
                        string mm_sofi_string;

                        if (mm1_int - mm_int < 0)
                        {
                            hh_sofi--;
                            mm_sofi = mm1_int - mm_int + 60;
                        }

                        hh_sofi_string = hh_sofi.ToString();
                        mm_sofi_string = mm_sofi.ToString();
                        if (hh_sofi.ToString().Length == 1)
                        {
                            hh_sofi_string = 0 + hh_sofi.ToString();
                        }
                        if(mm_sofi.ToString().Length == 1)
                        {
                            mm_sofi_string = 0 + mm_sofi.ToString();
                        }
                        string time_sofi = hh_sofi_string + ":" + mm_sofi_string;
                        MessageBox.Show(time_sofi + "  משך זמן עבודה  ");


                        DialogResult dr = MessageBox.Show("סיים משמררת", "צא", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "INSERT into archives([date],tz,[shaot avoda]) VALUES('" + date + "','" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "','" + time_sofi + "')";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            mishmarot_Load(sender, e);
                            MessageBox.Show("יופי");

                            OleDbCommand cmd1 = new OleDbCommand();
                            cmd1.CommandText = "delete from mishmarot where tz='" + tz_oved + "' ";
                            cmd1.Connection = con;
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            mishmarot_Load(sender, e);
                        }
                        else
                        {
                            bl = false;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            shop sho = new shop();
            sho.Show();
            this.Hide();

        }
    }
}
