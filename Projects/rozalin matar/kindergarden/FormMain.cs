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

namespace kindergarden
{
    public partial class FormMain : Form
    {
        public Point MouseLocation;
       
        public FormMain()
        {
            InitializeComponent();
        }
        bool frmSize = true;
        private void btn_toHogim_Click(object sender, EventArgs e)
        {
            lbl_nameOfForm.Text = "Courses";
            pnl_chosenTable.Controls.Clear();
            FormHogim formH = new FormHogim();
            formH.TopLevel = false;
            formH.AutoScroll = true;
            pnl_chosenTable.Controls.Add(formH);
            formH.FormBorderStyle = FormBorderStyle.None;
            pnl_chosenTable.Size = pnl_chosenTable.Size;
            formH.Dock = DockStyle.Fill;
            formH.Show();
            pnl_chosenTable.Visible = true;

        }

        private void pnl_chosenTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_toKitot_Click(object sender, EventArgs e)
        {
            lbl_nameOfForm.Text = "Classes";
            pnl_chosenTable.Controls.Clear();
            FormKitot formK = new FormKitot();
            formK.TopLevel = false;
            formK.AutoScroll = true;
            pnl_chosenTable.Controls.Add(formK);
            formK.FormBorderStyle = FormBorderStyle.None;
            pnl_chosenTable.Size = pnl_chosenTable.Size;
            formK.Dock = DockStyle.Fill;
            formK.Show();
            pnl_chosenTable.Visible = true;
        }

        private void btn_toMetaplot_Click(object sender, EventArgs e)
        {
            lbl_nameOfForm.Text = "Teachers";
            pnl_chosenTable.Controls.Clear();
            formMetaplot formM = new formMetaplot();
            formM.TopLevel = false;
            formM.AutoScroll = true;
            pnl_chosenTable.Controls.Add(formM);
            formM.FormBorderStyle = FormBorderStyle.None;
            pnl_chosenTable.Size = pnl_chosenTable.Size;
            formM.Dock = DockStyle.Fill;
            formM.Show();
            pnl_chosenTable.Visible = true;
        }

        private void pnl_buttonsUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_toYeladim_Click(object sender, EventArgs e)
        {
            lbl_nameOfForm.Text = "Children";
            pnl_chosenTable.Controls.Clear();
            FormYeladim formY = new FormYeladim();
            formY.TopLevel = false;
            formY.AutoScroll = true;
            pnl_chosenTable.Controls.Add(formY);
            formY.FormBorderStyle = FormBorderStyle.None;
            pnl_chosenTable.Size = pnl_chosenTable.Size;
            formY.Dock = DockStyle.Fill;
            formY.Show();
            pnl_chosenTable.Visible = true;
        }

       

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_toSfarim_Click(object sender, EventArgs e)
        {
            lbl_nameOfForm.Text = "Books";
            pnl_chosenTable.Controls.Clear();
            FormSfarim formS = new FormSfarim();
            formS.TopLevel = false;
            formS.AutoScroll = true;
            pnl_chosenTable.Controls.Add(formS);
            formS.FormBorderStyle = FormBorderStyle.None;
            pnl_chosenTable.Size = pnl_chosenTable.Size;
            formS.Dock = DockStyle.Fill;
            formS.Show();
            pnl_chosenTable.Visible = true;
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }
         DateTime currentTime;
        
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
        kindergardenDataSet.sfarimDataTable sfarimDT;
        kindergardenDataSet.yeladimDataTable yeladimDT;
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergardenDataSet.yeladim' table. You can move, or remove it, as needed.
            this.yeladimTableAdapter.Fill(this.kindergardenDataSet.yeladim);
            currentTime = DateTime.Now;
            // TODO: This line of code loads data into the 'kindergardenDataSet.sfarim' table. You can move, or remove it, as needed.
            this.sfarimTableAdapter.Fill(this.kindergardenDataSet.sfarim);
            sfarimDT = kindergardenDataSet.sfarim;
            yeladimDT = kindergardenDataSet.yeladim;
            for (int i = 0; i < sfarimDT.Rows.Count; i++)
            {
                string c = sfarimDT.Rows[i]["date to return"].ToString();
                string cc = currentTime.Date.ToString();
                if (c.Equals(cc))
                {
                    string bookName=sfarimDT.Rows[i]["book's name"].ToString();
                    string name = "";
                    for (int j = 0; j < yeladimDT.Rows.Count; i++)
                    {
                        string id = sfarimDT.Rows[i]["ID of borrowing kid"].ToString();
                        string id2 = yeladimDT.Rows[i]["ID"].ToString();
                        if (id.Equals(id2))
                        {
                            name = yeladimDT.Rows[i]["first name"].ToString() + yeladimDT.Rows[i]["last name"].ToString();
                        }
                    }
                    DialogResult res = new DialogResult();
                    res = MessageBox.Show("'"+name+"' is supposed to return the book'"+bookName+"',do you want to delay the returning date in one month?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes) 
                    {

                      DateTime d=  Convert.ToDateTime(sfarimDT.Rows[i]["ID of borrowing kid"].ToString());
                      int newMonth = Convert.ToInt32(d.Month.ToString()) + 1;
                      DateTime newDate= new DateTime(d.Year, newMonth, d.Day);

                      sfarimDT.Rows[i]["ID of borrowing kid"] = newDate.ToString();
                    }
                   
                }
            }
        }

       private void timer_clock_Tick(object sender, EventArgs e)
        {
        //    lbl_nameOfForm.Text = DateTime.Now.ToLongTimeString();

        }


        //שינוי גודל
        private void lbl_sizeChange_Click(object sender, EventArgs e)
        {

            if (frmSize == true)
            {
                //lbl_sizeChange.Text ="gggg";
                lbl_sizeChange.Location=new Point(1900,0);
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                frmSize = false;
            }
            else
            {
                //lbl_sizeChange.Text = "rrrr";
                this.WindowState = FormWindowState.Normal;
                frmSize = true;
            }

        }

        private void lbl_sizeChange_MouseEnter(object sender, EventArgs e)
        {
            lbl_sizeChange.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lbl_sizeChange_MouseLeave(object sender, EventArgs e)
        {
            lbl_sizeChange.ForeColor = SystemColors.ControlDark;
        }




        





       //מזעור
        private void lbl_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_hide_MouseEnter(object sender, EventArgs e)
        {
            lbl_hide.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lbl_hide_MouseLeave(object sender, EventArgs e)
        {
            lbl_hide.ForeColor = SystemColors.ControlDark;
        }



        //לא עובד (הזזת התוכנה 

        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnl_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && frmSize == true)
            {
                Point MousePos = Control.MousePosition;
                MousePos.Offset(MouseLocation.X, MouseLocation.Y);
                Location = MousePos;
            }
        }

        private void pnl_Move_DoubleClick(object sender, EventArgs e)
        {
            lbl_sizeChange_Click(sender, e);
        }

        private void pnl_Move_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Move_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        
    }
}
