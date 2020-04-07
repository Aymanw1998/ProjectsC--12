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
    public partial class EnterForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        public Point mouseLocation;
        bool btnShowClicked;
        bool over;

        public EnterForm()
        {
            InitializeComponent();
        }


        //                    בפתיחת הפורם
        private void EnterForm_Load(object sender, EventArgs e)
        {
            txtUser.Select();
            hintPass.Text = "";
            hintUser.Text = "";
        }


        //                     אזור המשתמש
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtUser.Text != "הקש תעודת זהות")
            {
                txtUser.RightToLeft = RightToLeft.No;
                hintUser.Text = "";
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            UserPnl.BackColor = SystemColors.ControlLight;
            UserSpl.BackColor = SystemColors.MenuHighlight;
            PassPnl.BackColor = SystemColors.Window;
            PassSpl.BackColor = SystemColors.Window;
            txtUser.ForeColor = Color.Black;

            if (txtUser.Text == "הקש תעודת זהות")
                txtUser.Clear();

            if (txtUser.Text != "")
                txtUser.RightToLeft = RightToLeft.No;

            if (txtPass.Text == "" && hintPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = SystemColors.ScrollBar;
                txtPass.RightToLeft = RightToLeft.Yes;
                btnShow.Visible = false;
                txtPass.Text = "הקש סיסמה";
                txtUser.Focus();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text != "")
                {
                    if (txtPass.Text == "הקש סיסמה")
                        txtPass.Focus();
                    else
                        btnEnter.PerformClick();
                }
                else
                    hintUser.Text = "הקש תעודת זהות בבקשה";

                if (txtPass.Text == "הקש סיסמה")
                {
                    hintPass.Text = "הקש סיסמה בבקשה";
                    txtPass.Clear();
                }

            }

            if (e.KeyCode == Keys.Down)
                txtPass.Focus();
        }


        //                     אזור הסיסמה
        private void txtPass_TextChanged(object sender, EventArgs e)
        {

            if (txtPass.Text != "" && txtPass.Text != "הקש סיסמה")
            {
                txtPass.RightToLeft = RightToLeft.No;
                if (btnShowClicked == false)
                    txtPass.UseSystemPasswordChar = true;
                btnShow.Visible = true;
                hintPass.Text = "";
            }

            if (txtPass.Text == "")
            {
                btnShow.Visible = false;
                over = false;
            }

        }
                             
        private void txtPass_Enter(object sender, EventArgs e)
        {
            PassPnl.BackColor = SystemColors.ControlLight;
            PassSpl.BackColor = SystemColors.MenuHighlight;
            UserPnl.BackColor = SystemColors.Window;
            UserSpl.BackColor = SystemColors.Window;
            txtPass.ForeColor = Color.Black;

            if (txtPass.Text == "הקש סיסמה")
                txtPass.Clear();

            if (txtPass.Text != "")                         
                txtPass.RightToLeft = RightToLeft.No;
            
            if (txtUser.Text == "" && hintUser.Text == "")
            {                
                txtUser.Text = "הקש תעודת זהות";
                txtPass.Focus();
                txtUser.ForeColor = SystemColors.ScrollBar;
                txtUser.RightToLeft = RightToLeft.Yes;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter.PerformClick();

            if (e.KeyCode == Keys.Down)
                btnEnter.Focus();

            if (e.KeyCode == Keys.Up)
                txtUser.Focus();
        }


        //                 אזור כפתור הכניסה 
        private void btnEnter_Enter(object sender, EventArgs e)
        {
            UserPnl.BackColor = SystemColors.Window;
            UserSpl.BackColor = SystemColors.Window;
            PassPnl.BackColor = SystemColors.Window;
            PassSpl.BackColor = SystemColors.Window;

            if (txtUser.Text == "" && hintUser.Text =="")
            {
                txtUser.Text = "הקש תעודת זהות";
                btnEnter.Focus();
                txtUser.ForeColor = SystemColors.ScrollBar;
                txtUser.RightToLeft = RightToLeft.Yes;
            }

            if (txtPass.Text == "" && hintPass.Text == "")
            {
                txtPass.Text = "הקש סיסמה";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = SystemColors.ScrollBar;
                txtPass.RightToLeft = RightToLeft.Yes;
                btnShow.Visible = false;             
                btnEnter.Focus();
                
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            hintPass.Text = "";
            hintUser.Text = "";
            bool found = false, txtUserIsEmpty= false;

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM DoctorsNurses", con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (txtUser.Text != "הקש תעודת זהות" && txtUser.Text != "")
            {
                for (int i = 0; i < dt.Rows.Count && !found; i++)
                {
                    if (dt.Rows[i]["zhot"].ToString() == txtUser.Text)
                    {
                        if (dt.Rows[i]["password"].ToString() == txtPass.Text)
                        {
                            found = true;
                            
                            this.Hide();

                            if (dt.Rows[i]["tafkid"].ToString() == "רופא/ה-מנהל/ת")
                            {
                                MainForm frm2 = new MainForm(txtUser.Text);
                                frm2.lblWel.Text += " " + dt.Rows[i]["shem"].ToString() + " " + dt.Rows[i]["mishpaha"].ToString();
                                frm2.Show();
                            }
                            else
                            {
                                EnterWorkForm frm2 = new EnterWorkForm(txtUser.Text);
                                frm2.lblWel.Text += " " + dt.Rows[i]["shem"].ToString() + " " + dt.Rows[i]["mishpaha"].ToString();
                                frm2.Show();
                            }                        
                        }                       
                    }                    
                }               
            }
            else
            {
                hintUser.Text = "הקש תעודת זהות בבקשה";
                txtUser.Clear();
                txtUser.Focus();
                found = true;
                txtUserIsEmpty = true;
            }
 
            if (txtPass.Text == "הקש סיסמה" || txtPass.Text == "")
            {
                hintPass.Text = "הקש סיסמה בבקשה";
                txtPass.Clear();
                if (!txtUserIsEmpty)
                    txtPass.Focus();
            }
            else
            {
                if (!found)
                {
                    hintUser.Text = "אחד הפרטים שהזנתה שגוי";
                    txtUser.Focus();
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


        //                כדי להזיז את הפורם
        private void HeaderPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void HeaderPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void HeaderPnl_MouseEnter(object sender, EventArgs e)
        {
            //if(MouseButtons.Left.

        }

        //             כפתור כדי להראות את הסיסמה
        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPass.Text != "הקש סיסמה")
                txtPass.UseSystemPasswordChar = false;

            over = true;
            txtPass.Focus();
            btnShowClicked = true;
            btnShow.ForeColor = SystemColors.Window;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\5555.png");
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPass.Text != "הקש סיסמה")
                txtPass.UseSystemPasswordChar = true;

            over = false;
            btnShowClicked = false;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\52882.png");
            btnShow.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            if (txtPass.Text != "הקש סיסמה")
                txtPass.UseSystemPasswordChar = true;

            btnShowClicked = false;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\52882.png");
            btnShow.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            if(over == true)
            {
            if (txtPass.Text != "הקש סיסמה")
                txtPass.UseSystemPasswordChar = false;

            txtPass.Focus();
            btnShowClicked = true;
            btnShow.ForeColor = SystemColors.Window;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\5555.png");
            }
        }

       
       
        
    }
}
