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
    public partial class TheMain : Form
    {
        int tabIndex = 0;
        int studentsIndex = -1;
        int teachersIndex = -1;
        int korsimIndex = -1;
        int whoINIndex = -1;
        int moneyIndex = -1;
        int hodorIndex = -1;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        string username, password, tz, fname, lname, phone, email, birthday, role, datee, timee,gender;
        public TheMain(string user, string time, string date)
        {
            InitializeComponent();
            timee = time; datee = date;
            con.Open();

            OleDbCommand co = new OleDbCommand();
            co.Connection = con;
            string f = "SELECT * From mnhel where username = '" + user + "' ";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                username = r["username"].ToString();
                password = r["password"].ToString();
                tz = r["tz"].ToString();
                fname = r["fname"].ToString();
                lname = r["lname"].ToString();
                phone = r["phone"].ToString();
                email = r["email"].ToString();
                birthday = r["Birthday"].ToString();
                role = r["role"].ToString();
                gender = r["gender"].ToString();

            }
            lbl_ID.Text = tz;
            lbl_Name.Text = fname;
            lbl_Family.Text = lname;
            lbl_Phone.Text = phone;
            lbl_Email.Text = email;
            lbl_Date.Text = birthday;
            if (phone == "")
                lbl_Phone.Text = "لا يوجد";
            if (email == "")
                lbl_Email.Text = "لا يوجد";
            if (birthday == "")
                lbl_Date.Text = "لا يوجد";

            con.Close();

            if (role != "مدير")
            {
                buttonTeachers.Text = "تفقد اخواني من المعلمين";
                buttonINOUT.Visible = false;
                buttonHodor.Visible=true;
                buttonSave.Visible = false;
                buttonHodor.BackColor = Color.Orange;
                panelList.BackColor = Color.Orange;
                buttonStudents.BackColor = Color.Blue;
                buttonTeachers.BackColor = Color.Blue;
                buttonKorsim.BackColor = Color.Blue;
                // button3.Visible = false;
                // button4.Visible = false;
                MessageBox.Show("المعلم الفاضل " + fname + " " + lname + " انت دخلت للبرنامج في تاريخ " + date + " في الوم " + time);
                Save myForm = new Save(tz, fname, lname, timee, datee, role);
                myForm.Show(); myForm.Close();


            }
            else
            {
                buttonINOUT.Left=595;
                buttonSave.Left = 408;
            }
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            if (studentsIndex < 0)
            {
                panelMain.TabPages.Add("Students", "طلاب");
                Students student = new Students(fname, role, tz, lname);
                student.TopLevel = false;
                student.Visible = true;
                student.FormBorderStyle = FormBorderStyle.None;
                student.Dock = DockStyle.Top;
                panelMain.TabPages[tabIndex].Controls.Add(student);
                tabIndex++;
                panelMain.SelectTab("Students");

            }
            else
            {
                panelMain.SelectTab("Students");
            }
            studentsIndex = tabIndex;

        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            if (teachersIndex < 0)
            {
                panelMain.TabPages.Add("Teachers", "معلمين");
                Teachers teacher = new Teachers(role);
                teacher.TopLevel = false;
                teacher.Visible = true;
                teacher.FormBorderStyle = FormBorderStyle.None;
                teacher.Dock = DockStyle.Fill;
                panelMain.TabPages[tabIndex].Controls.Add(teacher);
                tabIndex++;
                panelMain.SelectTab("Teachers");
            }
            else
            {
                panelMain.SelectTab("Teachers");
            }
            teachersIndex = tabIndex;
        }


        private void panelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKorsim_Click(object sender, EventArgs e)
        {
            if (korsimIndex < 0)
            {
                panelMain.TabPages.Add("Korsim", "دورات");
                Korsim kors = new Korsim(role, fname, lname);
                kors.TopLevel = false;
                kors.Visible = true;
                kors.FormBorderStyle = FormBorderStyle.None;
                kors.Dock = DockStyle.Fill;
                panelMain.TabPages[tabIndex].Controls.Add(kors);
                tabIndex++;
                panelMain.SelectTab("Korsim");
            }
            else
            {
                panelMain.SelectTab("Korsim");
            }
            korsimIndex = tabIndex;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }




        private void panelMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (whoINIndex < 0)
            {
                panelMain.TabPages.Add("Save", "من دخل");
                Save save = new Save(tz, fname, lname, timee, datee, role);
                save.TopLevel = false;
                save.Visible = true;
                save.FormBorderStyle = FormBorderStyle.None;
                save.Dock = DockStyle.Fill;
                panelMain.TabPages[tabIndex].Controls.Add(save);
                tabIndex++;
                panelMain.SelectTab("Save");
            }
            else
            {
                panelMain.SelectTab("Save");
            }
            whoINIndex = tabIndex;
        }

        private void buttonINOUT_Click(object sender, EventArgs e)
        {
            if (moneyIndex < 0)
            {
                panelMain.TabPages.Add("money", "بيت المال");
                BetKasef betKasef = new BetKasef();
                betKasef.TopLevel = false;
                betKasef.Visible = true;
                betKasef.FormBorderStyle = FormBorderStyle.None;
                betKasef.Dock = DockStyle.Fill;
                panelMain.TabPages[tabIndex].Controls.Add(betKasef);
                tabIndex++;
                panelMain.SelectTab("money");
            }
            else
            {
                panelMain.SelectTab("money");
            }
            moneyIndex = tabIndex;
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void buttonHodor_Click(object sender, EventArgs e)
        {
            if (hodorIndex < 0)
            {
                panelMain.TabPages.Add("hodor", "حضولر وغياب");
                HodorHeiab h = new HodorHeiab(fname + " " + lname);
                h.TopLevel = false;
                h.Visible = true;
                h.FormBorderStyle = FormBorderStyle.None;
                h.Dock = DockStyle.Fill;
                panelMain.TabPages[tabIndex].Controls.Add(h);
                tabIndex++;
                panelMain.SelectTab("hodor");
            }
            else
            {
                panelMain.SelectTab("hodor");
            }
            hodorIndex = tabIndex;
        }

        private void labelE_Click(object sender, EventArgs e)
        {
            MeE me = new MeE(username, password, fname, lname, tz, phone, email, gender, birthday);
            me.Show();
           
        }
    }
}

