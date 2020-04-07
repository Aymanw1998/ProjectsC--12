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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user-19\Desktop\Hospital.mdb");
            

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {            
            if (txtUser.Text != "")
                txtUser.RightToLeft = RightToLeft.No;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
           
            if (txtPass.Text != "")
                txtPass.RightToLeft = RightToLeft.No;

        }
                             
        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Black;

            if (txtPass.Text == "הקש סיסמה")
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
            }

            if (txtPass.Text != "")
                txtPass.RightToLeft = RightToLeft.No;

            if (txtUser.Text == "")
            {
                txtUser.Text = "הקש תעודת זהות";
                txtPass.Focus();
                txtUser.ForeColor = SystemColors.ScrollBar;
                txtUser.RightToLeft = RightToLeft.Yes;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;

            if (txtUser.Text == "הקש תעודת זהות")
                txtUser.Text = "";

            if (txtUser.Text != "")
                txtUser.RightToLeft = RightToLeft.No;

            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "הקש סיסמה";
                txtUser.Focus();
                txtPass.ForeColor = SystemColors.ScrollBar;
                txtPass.RightToLeft = RightToLeft.Yes;
            }
        }

        private void btnEnter_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "הקש תעודת זהות";
                btnEnter.Focus();
                txtUser.ForeColor = SystemColors.ScrollBar;
                txtUser.RightToLeft = RightToLeft.Yes;
            }

            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "הקש סיסמה";
                btnEnter.Focus();
                txtPass.ForeColor = SystemColors.ScrollBar;
                txtPass.RightToLeft = RightToLeft.Yes;
            }
        }

       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Doctors", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["zhot"].ToString() == txtUser.Text)
                {
                    if (dt.Rows[i]["password"].ToString() == txtPass.Text)
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                    }
                    else
                        MessageBox.Show("wrong password");
                }
                
            }
        }

    }
}
