using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alif_bishara
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            frmTeacher teacher = new frmTeacher();
            teacher.TopLevel = false;
            teacher.AutoScroll = true;
            panelMain.Controls.Add(teacher);
            teacher.FormBorderStyle = FormBorderStyle.None;
            panelMain.Size = panelMain.Size;
            teacher.Dock = DockStyle.Fill;
            teacher.Show();
            panelMain.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            frmKors kors = new frmKors();
            kors.TopLevel = false;
            kors.AutoScroll = true;
            panelMain.Controls.Add(kors);
            kors.FormBorderStyle = FormBorderStyle.None;
            panelMain.Size = panelMain.Size;
            kors.Dock = DockStyle.Fill;
            kors.Show();
            panelMain.Visible = true;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

            panelMain.Controls.Clear();
            Form3 students = new Form3();
            students.TopLevel = false;
            students.AutoScroll = true;
            panelMain.Controls.Add(students);
            students.FormBorderStyle = FormBorderStyle.None;
            panelMain.Size = panelMain.Size;
            students.Dock = DockStyle.Fill;
            students.Show();
            panelMain.Visible = true;
        }

        private void btnKabla_Click(object sender, EventArgs e)
        {
            string s = "";
            panelMain.Controls.Clear();
            tashlom kbla = new tashlom(s);
            kbla.TopLevel = false;
            kbla.AutoScroll = true;
            panelMain.Controls.Add(kbla);
            kbla.FormBorderStyle = FormBorderStyle.None;
            panelMain.Size = panelMain.Size;
            kbla.Dock = DockStyle.Fill;
            kbla.Show();
            panelMain.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
