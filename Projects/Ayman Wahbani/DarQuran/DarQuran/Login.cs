
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
namespace DarQuran
{
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        int aa = 5;
        int count = 5;
        DataTable dt = new DataTable();
        int z = 0;
        int a = 0;
        string sasa;
        Bitmap o = new Bitmap(@"C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran\bin\Debug\OK.png");
        Bitmap c = new Bitmap(@"C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran\bin\Debug\Cancel.png");
        Point mouseLocation;
        public Login()
        {
            InitializeComponent();
            labeltimer.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
            buttonShow.Image = o;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUser.Text))
            {

                MessageBox.Show("ادخل اسم المستخدم من فضلك", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser.Focus();
                return;
            }
            DarQuranDataSetTableAdapters.mnhelTableAdapter user = new DarQuranDataSetTableAdapters.mnhelTableAdapter();
            DarQuranDataSet.mnhelDataTable dt = user.GetDataByUserPass(textBoxUser.Text, textBoxPassword.Text);
            user.Fill(dt);
            MessageBox.Show("Yes");
            OleDbCommand co = new OleDbCommand();
            con.Open();
            co.Connection = con;
            string f = "SELECT role From mnhel where username = '" + textBoxUser.Text + "' ";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                sasa = r["role"].ToString();
            }
            con.Close();
            for (int i = 0; i < dt.Rows.Count; )
            {
                if (dt.Rows[i][0].ToString() == textBoxUser.Text && dt.Rows[i][1].ToString() == textBoxPassword.Text)
                {

                    z = 0;
                    TheMain d = new TheMain(textBoxUser.Text, labelTime.Text, labelDate.Text); d.Show();
                    this.Hide();
                    
                    i = dt.Rows.Count + 1;
                }
                else
                {

                    i++;
                    z = i;

                }
            }
            if (dt.Rows.Count == z)
            {
                a++;
                MessageBox.Show("اسم المسدخدم أو كلمة السر غير صالح", "يوجد خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (a == 5)
                {
                    labeltimer.Text = "";
                    labeltimer.Visible = true;
                    textBoxPassword.Enabled = false;
                    textBoxUser.Enabled = false;
                    buttonIN.Enabled = false;
                    timerhasima.Enabled = true;
                    a = 0;
                    timerhasima.Start();
                }


            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerTime.Start();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void timerhasima_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timerhasima.Stop();
                labeltimer.Visible = false;
                textBoxPassword.Enabled = true;
                textBoxUser.Enabled = true;
                buttonIN.Enabled = true;
                aa = aa + 5;

                count = aa;
            }
            else
            {
                labeltimer.Text = count.ToString();
                count--;
            }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (buttonShow.Image == o)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShow.Image = c;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonShow.Image = o;
            }
        }

        private void buttonOUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonIN.Focus();
            }
        }
    }
}
