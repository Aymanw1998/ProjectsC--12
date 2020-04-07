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
    public partial class MainForm : Form
    {
        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\Hospital.mdb");
        bool frmSize = true;
        public Point mouseLocation;
        public Button btnClicked = null;
        string zhot;
        TimeSpan duration;
        HospitalDataSet.MishmarotDataTable dt;

        public MainForm(string txtUser)
        {
            zhot = txtUser;
            InitializeComponent();
            dt = hospitalDataSet.Mishmarot;
        }
     
        //                  בפתיחת הפורם
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);

            clock_Tick(sender, e);
            clock.Start();

            btnRashi.PerformClick();

            for (int i = 0; i < dt.Rows.Count && !found; i++)
            {
                if (zhot == dt.Rows[i][0].ToString())
                {
                    if (dt.Rows[i][2].ToString() == "")
                    {
                        duration = Convert.ToDateTime(dt.Rows[0][1].ToString()).Subtract(DateTime.Now);
                    }
                }
            }

            lblRights.Text = "© " + DateTime.Now.Year.ToString();
        }


        //                  כפתור הסגור   
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
        

        //                 כפתור ההסתרה
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


        //                 כפתור ההגדלה  
        private void lblSize_Click(object sender, EventArgs e)
        {
            if (frmSize == true)
            {
                lblSize.Text = "🗗";
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                frmSize = false;
            }
            else
            {
                lblSize.Text = "🗖";
                this.WindowState = FormWindowState.Normal;
                frmSize = true;
            }

        }
       
        private void lblSize_MouseEnter(object sender, EventArgs e)
        {
            lblSize.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblSize_MouseLeave(object sender, EventArgs e)
        {
            lblSize.ForeColor = SystemColors.ControlDark;
        }


        //                 כפתור ההתנתק
        private void btnDisconnect_Click(object sender, EventArgs e)
        {           
            EnterForm frm = new EnterForm();
            frm.Show();
            this.Close();
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

        private void HeaderPnl_DoubleClick(object sender, EventArgs e)
        {
            lblSize_Click(sender, e);
        }

    
       //                 כפתורי התפריט 
        private void btnRashi_Click(object sender, EventArgs e)
        {
            if (btnRashi != btnClicked)
            {      
                if(btnClicked != null)
                    btnClicked.BackColor = Color.SteelBlue;

                btnRashi.BackColor = Color.Orange;
                btnClicked = btnRashi;                         
                
                pnlDisplay.Visible = false;

                pnlDisplay.Controls.Clear();
                RashiForm myForm = new RashiForm(zhot);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Size = pnlDisplay.Size;
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

                pnlDisplay.Visible = true;
            }           
        }

        private void btnOvdim_Click(object sender, EventArgs e)
        {          
            if (btnOvdim != btnClicked)
            {
                btnClicked.BackColor = Color.SteelBlue;
                btnOvdim.BackColor = Color.Orange;
                btnClicked = btnOvdim;

                pnlDisplay.Visible = false;

                pnlDisplay.Controls.Clear();
                OvdimForm myForm = new OvdimForm(btnClicked,zhot);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Size = pnlDisplay.Size;
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

                pnlDisplay.Visible = true;
            }           
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            if (btnDoctors != btnClicked)
            {
                btnClicked.BackColor = Color.SteelBlue;
                btnDoctors.BackColor = Color.Orange;
                btnClicked = btnDoctors;

                pnlDisplay.Visible = false;
                pnlDisplay.Controls.Clear();

                DoctorsNursesForm myForm = new DoctorsNursesForm(btnClicked,zhot);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Show();
                myForm.Dock = DockStyle.Fill;
                pnlDisplay.Visible = true;
            }
                       
        }

        private void btnMishmarot_Click(object sender, EventArgs e)
        {
            if (btnMishmarot != btnClicked)
            {
                btnClicked.BackColor = Color.SteelBlue;
                btnMishmarot.BackColor = Color.Orange;
                btnClicked = btnMishmarot;

                pnlDisplay.Visible = false;
                pnlDisplay.Controls.Clear();

                MishmarotForm myForm = new MishmarotForm(btnClicked,zhot);
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Show();
                myForm.Dock = DockStyle.Fill;
                pnlDisplay.Visible = true;
            }          
        }
        
        private void btnTsyod_Click(object sender, EventArgs e)
        {
            if (btnTsyod != btnClicked)
            {
                pnlDisplay.Visible = false;

                btnClicked.BackColor = Color.SteelBlue;
                btnTsyod.BackColor = Color.Orange;
                btnClicked = btnTsyod;

                pnlDisplay.Controls.Clear();
                TsyodForm myForm = new TsyodForm(btnClicked,zhot);
                myForm.TopLevel = false;
                pnlDisplay.Controls.Add(myForm);
                myForm.Dock = DockStyle.Fill;
                myForm.Show();

                pnlDisplay.Visible = true;
            }                      
        }

        private void btnSpak_Click(object sender, EventArgs e)
        {
            if (btnSpak != btnClicked)
            {
                pnlDisplay.Visible = false;

                btnClicked.BackColor = Color.SteelBlue;
                btnSpak.BackColor = Color.Orange;
                btnClicked = btnSpak;

                SapakForm myForm = new SapakForm(btnClicked,zhot);
                pnlDisplay.Controls.Clear();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Show();
                myForm.Dock = DockStyle.Fill;

                pnlDisplay.Visible = true;
            }
        }

        private void btnHazmanot_Click(object sender, EventArgs e)
        {
            if (btnHazmanot != btnClicked)
            {
                btnClicked.BackColor = Color.SteelBlue;
                btnHazmanot.BackColor = Color.Orange;
                btnClicked = btnHazmanot;

                pnlDisplay.Visible = false;
                pnlDisplay.Controls.Clear();

                HazmanotForm myForm = new HazmanotForm(btnClicked,zhot);
                myForm.TopLevel = false;
                pnlDisplay.Controls.Add(myForm);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Show();
                myForm.Dock = DockStyle.Fill;
                pnlDisplay.Visible = true;
            }                   
        }


        //                   שעון
        public bool found = false;
        private void clock_Tick(object sender, EventArgs e)
        {
            found = false;
            Status();
        }

        private void Status()
        {
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
            dt = hospitalDataSet.Mishmarot;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (zhot == dt.Rows[i]["zhot"].ToString())
                {
                    if (dt.Rows[i]["end"].ToString() == "")
                    {
                        duration = DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[i]["start"].ToString()));
                        lblClock.Text = "סטטוס   |   תאריך ושעה - " + DateTime.Now.ToString() + "   |   זמן המשמרת - " + Convert.ToInt32(duration.TotalHours) + duration.ToString(@"\:mm\:ss");
                        found = true;
                    }
                }
            }

            if (!found)
                lblClock.Text = lblClock.Text = "סטטוס   |   תאריך ושעה - " + DateTime.Now.ToString() + "   |   לא במשמרת";
        }

        private void pnlDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
      
    }
}
