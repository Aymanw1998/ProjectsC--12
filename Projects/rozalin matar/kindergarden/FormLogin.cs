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
    public partial class FormLogin : Form
    {
        public Point MouseLocation;
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
        DataTable Mo = new DataTable();
        int z = 0, a = 0, aa = 5;
        Point mP; int count = 5;
        kindergardenDataSet.metaplotDataTable mt;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btm_save_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM metaplot", con);
            DataTable Mo = new DataTable();
            da.Fill(Mo);

            bool currectUsername = false;
            bool currectPassword = false;

            if (txt_username.Text != "" && txt_password.Text != "")
            {
                for (int i = 0; i < Mo.Rows.Count && !currectUsername && !currectPassword; i++)
                {
                    if (Mo.Rows[i]["username"].ToString() == txt_username.Text)
                        currectUsername = true;
                    if (txt_password.Text == Mo.Rows[i]["password"].ToString())
                        currectPassword = true;
                }

                if (!currectUsername || !currectPassword)
                {
                    MessageBox.Show("The username or the password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You've logged in successfuly.", "Message", MessageBoxButtons.OK);
                    FormMain forMopen = new FormMain();
                    this.Visible = false;
                    forMopen.Show();

                }

            }
            else
            {
                MessageBox.Show("Please don't leave empty values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txt_username.Text == "")
                {
                    lbl_mustUsername.Visible = true;
                   
                }
                else
                {
                    lbl_mustUsername.Visible = false;
                   
                }

                if (txt_password.Text == "")
                {
                    lbl_mustPassword.Visible = true;
                    
                }
                else
                {
                    lbl_mustPassword.Visible = false;
                   
                }
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mP = new Point(-e.X, -e.Y);
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left)
            {
                Point mP2 = Control.MousePosition;
                mP2.Offset(mP.X, mP.Y);
                Location = mP2;

                

                 }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergardenDataSet.metaplot' table. You can Move, or reMove it, as needed.
            this.metaplotTableAdapter.Fill(this.kindergardenDataSet.metaplot);
           
            mt = kindergardenDataSet.metaplot;
            for (int i = 0; i < mt.Rows.Count; i++)
            {
                //comboSearch.Items.Add(Mo.Rows[i]["employeename"]);
            }
        }

        private void timerBlock_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {

                lbl_timeLeft.Visible = false;
                txt_password.Enabled = true;
                txt_username.Enabled = true;
                btm_save.Enabled = true;
                aa = aa + 5;
                timerBlock.Stop();
                count = aa;

            }
            else
            {
                lbl_timeLeft.Text = count.ToString();
                count--;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rb_showP_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
                txt_password.UseSystemPasswordChar = false;
            else
                txt_password.UseSystemPasswordChar = true;
        }

        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnl_Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point MousePos = Control.MousePosition;
                MousePos.Offset(MouseLocation.X, MouseLocation.Y);
                Location = MousePos;
            }
        }

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

        private void lbl_hide_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_hide.ForeColor = Color.Black;
        }

        private void pnl_Move_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        
    }
}
