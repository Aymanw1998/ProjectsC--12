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
    public partial class RashiForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        OleDbCommand cmd = new OleDbCommand();
        HospitalDataSet.MishmarotDataTable dt;
        HospitalDataSet.DoctorsNursesDataTable dtDN;
        HospitalDataSet.OvdimDataTable dtO;
        double p1, per1,count1;
        double p2, per2, count2;
        string Zhot;

        public RashiForm(string Zh)
        {
            InitializeComponent();
            Zhot = Zh;
        }

        private void RashiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Ovdim' table. You can move, or remove it, as needed.
            this.ovdimTableAdapter.Fill(this.hospitalDataSet.Ovdim);
            dtO = hospitalDataSet.Ovdim;
            // TODO: This line of code loads data into the 'hospitalDataSet.DoctorsNurses' table. You can move, or remove it, as needed.
            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
            dtDN = hospitalDataSet.DoctorsNurses;
            // TODO: This line of code loads data into the 'hospitalDataSet.Mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
            dt = hospitalDataSet.Mishmarot;

            p1 = (100/dtDN.Rows.Count);
            per1 = 0;
            count1 = 0;

            p2 = (100 / dtO.Rows.Count);
            per2 = 0;
            count2 = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int z = 0; z < dtDN.Rows.Count; z++)
                {
                    if (dtDN.Rows[z]["zhot"].ToString() == dt.Rows[i]["zhot"].ToString() && dt.Rows[i]["end"].ToString() == "")
                    {
                        per1 += p1;
                        count1++;
                        string[] row = new string[] { dt.Rows[i]["zhot"].ToString(), dtDN.Rows[z][1].ToString(), dtDN.Rows[z][2].ToString(), dt.Rows[i][1].ToString() };
                        dataDoctorsNurses.Rows.Add(row);
                    }
                }

                for (int z = 0; z < dtO.Rows.Count; z++)
                {
                    if (dtO.Rows[z]["zhot"].ToString() == dt.Rows[i]["zhot"].ToString() && dt.Rows[i]["end"].ToString() == "")
                    {
                        per2 += 2;
                        count2++;
                        string[] row = new string[] { dt.Rows[i]["zhot"].ToString(), dtDN.Rows[z][1].ToString(), dtDN.Rows[z][2].ToString(), dt.Rows[i][1].ToString() };
                        dataOvdim.Rows.Add(row);
                    }
                }

                if (Zhot == dt.Rows[i]["zhot"].ToString())
                {
                    if (dt.Rows[i]["end"].ToString() == "")
                    {
                        
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                    }
                    else
                    {
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                    }
                }
            }

            pBOvdim.Increment(Convert.ToInt32(per2));
            lblOvdim.Text = "עובדי תחזוקה ונקיון במשמרת: " + count2.ToString() + " מתוך " + dtO.Rows.Count.ToString();
            pBDoctorsNurses.Increment(Convert.ToInt32(per1));
            lblDoctorsNurses.Text = "רופאים ואחיות במשמרת: " + count1.ToString() + " מתוך " + dtDN.Rows.Count.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime lastDate = DateTime.Now ;

            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0]["end"].ToString() != "")
                {
                    if (Zhot == dt.Rows[0]["zhot"].ToString())
                    {
                        lastDate = Convert.ToDateTime(dt.Rows[0]["end"].ToString());
                    }
                }

                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    if (Zhot == dt.Rows[i]["zhot"].ToString())
                    {
                        if (dt.Rows[0]["end"].ToString() != "")
                        {
                            if (DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[0]["end"].ToString())).TotalMinutes < DateTime.Now.Subtract(lastDate).TotalMinutes)
                                lastDate = Convert.ToDateTime(dt.Rows[0]["end"].ToString());
                        }
                    }
                }

                if (DateTime.Now.Subtract(lastDate).TotalMinutes > 30)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    MainForm frm2 = new MainForm(Zhot);
                    frm2.found = false;

                    cmd.CommandText = "INSERT INTO Mishmarot(zhot,start,[end]) Values('" + Zhot + "','" + DateTime.Now.ToString() + "','')";
                    cmd.Connection = con;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
                    dtDN = hospitalDataSet.DoctorsNurses;
                    this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
                    dt = hospitalDataSet.Mishmarot;

                    count1 = 0;
                    dataDoctorsNurses.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int z = 0; z < dtDN.Rows.Count; z++)
                        {
                            if (dtDN.Rows[z]["zhot"].ToString() == dt.Rows[i]["zhot"].ToString() && dt.Rows[i]["end"].ToString() == "")
                            {
                                count1++;
                                string[] row = new string[] { dt.Rows[i]["zhot"].ToString(), dtDN.Rows[z][1].ToString(), dtDN.Rows[z][2].ToString(), dt.Rows[i][1].ToString() };
                                dataDoctorsNurses.Rows.Add(row);
                            }
                        }
                    }
                    pBDoctorsNurses.Increment(Convert.ToInt32(p1));
                    lblDoctorsNurses.Text = "רופאים ואחיות במשמרת: " + count1.ToString() + " מתוך " + dtDN.Rows.Count.ToString();
                }
                else
                {
                    int t = 30 - Convert.ToInt32((DateTime.Now.Subtract(lastDate).TotalMinutes));
                    if(t != 1)
                    MessageBox.Show("אתה יכול להיכנס בעוד " + t.ToString() + " דקות");
                    else
                             MessageBox.Show("אתה יכול להיכנס בעוד דקה");
                }
            }
            else
            {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    MainForm frm2 = new MainForm(Zhot);
                    frm2.found = false;

                    cmd.CommandText = "INSERT INTO Mishmarot(zhot,start,[end]) Values('" + Zhot + "','" + DateTime.Now.ToString() + "','')";
                    cmd.Connection = con;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
                    dtDN = hospitalDataSet.DoctorsNurses;
                    this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
                    dt = hospitalDataSet.Mishmarot;

                    count1 = 0;
                    dataDoctorsNurses.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int z = 0; z < dtDN.Rows.Count; z++)
                        {
                            if (dtDN.Rows[z]["zhot"].ToString() == dt.Rows[i]["zhot"].ToString() && dt.Rows[i]["end"].ToString() == "")
                            {
                                count1++;
                                string[] row = new string[] { dt.Rows[i]["zhot"].ToString(), dtDN.Rows[z][1].ToString(), dtDN.Rows[z][2].ToString(), dt.Rows[i][1].ToString() };
                                dataDoctorsNurses.Rows.Add(row);
                            }
                        }
                    }
                    pBDoctorsNurses.Increment(Convert.ToInt32(p1));
                    lblDoctorsNurses.Text = "רופאים ואחיות במשמרת: " + count1.ToString() + " מתוך " + dtDN.Rows.Count.ToString();
                }
            }
        


        private void timer_Tick(object sender, EventArgs e)
        {

            pBOvdim.Increment(Convert.ToInt32(per2));
            pBDoctorsNurses.Increment(Convert.ToInt32(per1));
            timer.Stop();           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bool found = false;
            TimeSpan duration;
            MainForm frm2 = new MainForm(Zhot);
            frm2.found = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Zhot == dt.Rows[i]["zhot"].ToString())
                {
                    if (dt.Rows[i]["end"].ToString() == "")
                    {
                        duration = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i]["start"].ToString()));
                        found = true;
                        
                        if (duration.TotalHours > 2)
                        {                          
                            btnStart.Enabled = true;
                            btnStop.Enabled = false;

                            cmd.CommandText = "UPDATE Mishmarot Set  [end]='" + DateTime.Now.ToString() + "' Where zhot = '" + Zhot + "' And start = '" + dt.Rows[i]["start"].ToString() + "'";
                            cmd.Connection = con;

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
                            dtDN = hospitalDataSet.DoctorsNurses;
                            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
                            dt = hospitalDataSet.Mishmarot;

                            count1 = 0;
                            dataDoctorsNurses.Rows.Clear();
                            for (int k = 0; k < dt.Rows.Count; k++)
                            {
                                for (int z = 0; z < dtDN.Rows.Count; z++)
                                {
                                    if (dtDN.Rows[z]["zhot"].ToString() == dt.Rows[k]["zhot"].ToString() && dt.Rows[k]["end"].ToString() == "")
                                    {
                                        count1++;
                                        string[] row = new string[] { dt.Rows[k]["zhot"].ToString(), dtDN.Rows[z][1].ToString(), dtDN.Rows[z][2].ToString(), dt.Rows[k][1].ToString() };
                                        dataDoctorsNurses.Rows.Add(row);
                                    }
                                }
                            }
                            pBDoctorsNurses.Value -= Convert.ToInt32(p1);
                            lblDoctorsNurses.Text = "רופאים ואחיות במשמרת: " + count1.ToString() + " מתוך " + dtDN.Rows.Count.ToString();
                        }
                        else
                            MessageBox.Show("משמרת לפחות שעתיים");
                    }
                }
            }

            if (!found)
                MessageBox.Show("אתה לא נמצא במערכת","שגיאה");          
        }

        private string TimeNow()
        {
            return DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss");
        }

        private void RashiForm_SizeChanged(object sender, EventArgs e)
        {
            pnlInWork.Size = new Size(this.Width,Convert.ToInt32(this.Height*0.5));
            pnlDoctorsNurses.Size = new Size((this.Width / 2), pnlDoctorsNurses.Height);
            pnlOvdim.Size = new Size((this.Width / 2) - 1, pnlOvdim.Height);
        }
    }
}
