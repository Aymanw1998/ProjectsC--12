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
    public partial class EnterWorkForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        OleDbCommand cmd = new OleDbCommand();
        HospitalDataSet.MishmarotDataTable dt;
        bool frmSize = true;
        public Point mouseLocation;
        string zhot;

        public EnterWorkForm(string Zh)
        {
            InitializeComponent();
            zhot = Zh;
        }

        private void EnterWorkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
            dt = hospitalDataSet.Mishmarot;

           

            clock.Start();
            for (int i = 0; i < dt.Rows.Count; i++)
            {                               
                if (zhot == dt.Rows[i]["zhot"].ToString())
                {
                    dataGridView.Rows.Clear();               
                    dataGridView.Rows.Add(zhot.ToString(), dt.Rows[i]["start"].ToString(), dt.Rows[i]["end"].ToString());

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

        }


        //                    כפתור היציאה
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Firebrick;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.ControlDark;
        }

        private void lblClose_MouseDown(object sender, MouseEventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }



        //                    כפתור ההסתרה
        private void lblHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblHide_MouseEnter(object sender, EventArgs e)
        {
            lblHide.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblHide_MouseLeave(object sender, EventArgs e)
        {
            lblHide.ForeColor = SystemColors.ControlDark;
        }

        private void lblHide_MouseDown(object sender, MouseEventArgs e)
        {
            lblHide.ForeColor = Color.Black;
        }

        //             כדי להזיז את הפורם         
        private void HeaderPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void HeaderPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && frmSize == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }


        //                   שעון
        bool fnd = false;
        private void clock_Tick(object sender, EventArgs e)
        {
            Status();
        }

        private void Status()
        {            
            TimeSpan duration;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (zhot == dt.Rows[i]["zhot"].ToString())
                {
                    if (dt.Rows[i]["end"].ToString() == "")
                    {
                        duration = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i]["start"].ToString()));
                        lblClock.Text = "סטטוס   |   תאריך ושעה - " + DateTime.Now.ToString() + "   |   זמן המשמרת - " + Convert.ToInt32(duration.TotalHours) + duration.ToString(@"\:mm\:ss");
                        fnd = true;
                    }
                }
            }

            if (!fnd)
                lblClock.Text = lblClock.Text = "סטטוס   |   תאריך ושעה - " + DateTime.Now.ToString() + "   |   לא במשמרת";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
           
            cmd.CommandText = "INSERT INTO Mishmarot(zhot,start,[end]) Values('" + zhot + "','" + DateTime.Now.ToString() + "','')";
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
            dt = hospitalDataSet.Mishmarot;
            fnd = false;
            dataGridView.Rows.Clear();
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                if (zhot == dt.Rows[k]["zhot"].ToString())
                {
                    dataGridView.Rows.Add(zhot.ToString(), dt.Rows[k]["start"].ToString(), dt.Rows[k]["end"].ToString());
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bool found = false;
            TimeSpan duration;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (zhot == dt.Rows[i]["zhot"].ToString())
                {
                    if (dt.Rows[i]["end"].ToString() == "")
                    {
                        

                        duration = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i]["start"].ToString()));
                        found = true;

                        if (duration.TotalHours > 2)
                        {
                            btnStart.Enabled = true;
                            btnStop.Enabled = false;

                            cmd.CommandText = "UPDATE Mishmarot Set  [end]='" + DateTime.Now.ToString() + "' Where zhot = '" + zhot + "' And start = '" + dt.Rows[i]["start"].ToString() + "'";
                            cmd.Connection = con;

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            fnd = false;
                            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
                            dt = hospitalDataSet.Mishmarot;
                            dataGridView.Rows.Clear();
                            for (int k = 0; k < dt.Rows.Count; k++)
                            {
                                if (zhot == dt.Rows[k]["zhot"].ToString())
                                {
                                    dataGridView.Rows.Add(zhot.ToString(), dt.Rows[k]["start"].ToString(), dt.Rows[k]["end"].ToString());                                    
                                }
                            }

                        }
                        else
                            MessageBox.Show("משמרת לפחות שעתיים");
                    }
                }
            }

            if (!found)
                MessageBox.Show("אתה לא נמצא במערכת", "שגיאה");          
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            EnterForm frm = new EnterForm();
            frm.Show();
            this.Close();
        }

    }
}
