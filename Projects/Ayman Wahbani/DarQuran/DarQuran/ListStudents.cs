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
    public partial class ListStudents : Form
    {
        string kors1, kors2, kors3, kors4, kors5;
        bool blListAddStudents = false, blMa3lomat = false;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        //DarQuranDataSet.mnhelDataTable mo;
        OleDbCommand co = new OleDbCommand();
        OleDbCommand co2 = new OleDbCommand();
        DataTable dt = new DataTable();
        string tzkors; string gender;
        public ListStudents(string tzKors,string genderT,string NT,string NK)
        {
            InitializeComponent();

            tzkors = tzKors;
            gender = genderT;
            labelTeacher.Text = NT;
            labelKors.Text= NK;
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
          
            // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
            this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
            con.Open();
            co.Connection = con;
            string g = "SELECT tz From [korsANDstudents] where( kors1 = '" + tzkors + "' OR kors2 = '" + tzkors + "' OR kors3 = '" + tzkors + "' OR kors4 = '" + tzkors + "' OR kors5 = '" + tzkors + "' )";
            co.CommandText = g;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {

                string s = (r["tz"].ToString());

                co2.Connection = con;
                string a = "SELECT * From [students] where tz = '" + s + "' ";

                co2.CommandText = a;
                OleDbDataReader m;
                m = co2.ExecuteReader();
                while (m.Read())
                {
                    listBoxStudents.Items.Add(m["fname"].ToString() + " " + m["nfather"].ToString() + " " + m["lname"].ToString());
                }

                m.Close();
            }
            con.Close();
            r.Close();
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonMa3lomat.Visible = true;
            int i = 0; string fname = ""; string st2; string lname = ""; string fatherN = "";
            if (listBoxStudents.SelectedItem.ToString() != "")
            {
                
                st2 = listBoxStudents.SelectedItem.ToString();
                while (st2[i].ToString() != " ")
                {
                    fname = fname + st2[i];
                    i++;
                }
                if (st2[i].ToString() == " ")
                {
                    i++;
                }
                while (st2[i].ToString() != " ")
                {
                    fatherN = fatherN + st2[i];
                    i++;
                }
                if (st2[i].ToString() == " ")
                {
                    i++;
                }

                while (i < listBoxStudents.SelectedItem.ToString().Length)
                {
                    lname = lname + st2[i];
                    i++;
                }
                con.Open();
                co.Connection = con;
                string g = "SELECT * From [students] where fname='" + fname + "' AND lname='" + lname + "' AND nfather='" + fatherN + "' ";
                co.CommandText = g;
                OleDbDataReader r;
                r = co.ExecuteReader();
                while (r.Read())
                {
                    txtID.Text = r["tz"].ToString();
                    txtFName.Text = r["fname"].ToString();
                    txtLName.Text = r["lname"].ToString();
                    txtMName.Text = r["nfather"].ToString();
                    txtPhone.Text = r["phone"].ToString();
                }
                con.Close();
                r.Close();
            }

        }

        private void buttonDeleteS_Click(object sender, EventArgs e)
        {
            

             int i = 0; string fname = ""; string st2; string lname = ""; string fatherN = "";

             st2 = listBoxStudents.SelectedItem.ToString();
 
            while (st2[i].ToString() != " ")
                    {
                        fname = fname + st2[i];
                        i++;
                    }
                    if (st2[i].ToString() == " ")
                    {
                        i++;
                    }
                    while (st2[i].ToString() != " ")
                    {
                        fatherN = fatherN + st2[i];
                        i++;
                    }
                    if (st2[i].ToString() == " ")
                    {
                        i++;
                    }

                    while (i < listBoxStudents.SelectedItem.ToString().Length)
                    {
                        lname = lname + st2[i];
                        i++;
                    }
                   
             OleDbDataAdapter da = new OleDbDataAdapter("Select * from [students] where fname='"+fname+"' AND lname='"+lname+"' AND nfather='"+fatherN+"'", con);
             da.Fill(dt);
             OleDbCommand cmdUpdate = new OleDbCommand();
             con.Open();
            co.Connection = con;
            string g = "SELECT * From [korsANDstudents] where tz='"+dt.Rows[0][0].ToString()+"' ";
            co.CommandText = g;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                kors1 = r["kors1"].ToString();
                kors2 = r["kors2"].ToString();
                kors3 = r["kors3"].ToString();
                kors4 = r["kors4"].ToString();
                kors5 = r["kors5"].ToString();
            }
            con.Close();
            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد حذف معلومات الطالب؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drAcceptAdd == DialogResult.Yes)
            {
                if (tzkors == kors1)
                {
                    con.Open();
                    cmdUpdate.CommandText = "Update korsANDstudents set Kors1='"+""+"' Where tz='" + dt.Rows[0][0].ToString() + "'";
                    cmdUpdate.Connection = con;
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
                    this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
                    this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    listBoxStudents.Refresh();
                }
                else if (tzkors == kors2)
                {
                    con.Open();
                    cmdUpdate.CommandText = "Update korsANDstudents set Kors2='" + "" + "' Where tz='" + dt.Rows[0][0].ToString() + "'";
                    cmdUpdate.Connection = con;
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
                    this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
                    this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    listBoxStudents.Refresh();
                   }
                else if (tzkors == kors3)
                {
                    con.Open();
                    cmdUpdate.CommandText = "Update korsANDstudents set Kors3=='" + "" + "' Where tz='" + dt.Rows[0][0].ToString() + "'";
                    cmdUpdate.Connection = con;
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
                    this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
                    this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    listBoxStudents.Refresh();
                }
                else if (tzkors == kors4)
                {
                    con.Open();
                    cmdUpdate.CommandText = "Update korsANDstudents set Kors4='" + "" + "' Where tz='" + dt.Rows[0][0].ToString() + "'";
                    cmdUpdate.Connection = con;
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
                    this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
                    this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    listBoxStudents.Refresh();
                }
                else if (tzkors == kors5)
                {
                    con.Open();
                    cmdUpdate.CommandText = "Update korsANDstudents set Kors5='" + "" + "' Where tz='" + dt.Rows[0][0].ToString() + "'";
                    cmdUpdate.Connection = con;
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
                    this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    // TODO: This line of code loads data into the 'darQuranDataSet.korsAndstudents' table. You can move, or remove it, as needed.
                    this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    listBoxStudents.Refresh();
                }
                

            MessageBox.Show("تم حذف الطالب ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (blListAddStudents ==false)
            {
               
                
                con.Open();
                co.Connection = con;
                string g = "SELECT * From [students] where [gender]='"+gender+"'";
                co.CommandText = g;
                OleDbDataReader r;
                r = co.ExecuteReader();
                while (r.Read())
                {
                    
                    listBoxNewSINK.Items.Add(r["fname"].ToString() + " " + r["nfather"].ToString() + " " + r["lname"].ToString());
                }
                con.Close();
                r.Close();
                listBoxNewSINK.Visible = true;
                blListAddStudents  = true;
                buttonAdd.Text = "اغلق قائمة الاضافة";
            }
            else
            {
                blListAddStudents  = false;
                listBoxNewSINK.Items.Clear();
                listBoxNewSINK.Visible = false;
                buttonAddS.Visible = false;
            }
         

            //buttonAddS.Visible = true;
        }

        private void buttonMa3lomat_Click(object sender, EventArgs e)
        {
            if (blMa3lomat == false)
            {
                buttonMa3lomat.Text = "اغلق معلومات الطالب";
                blMa3lomat = true;
                int i = 0; string fname = ""; string st2; string lname = ""; string fatherN = "";
                if (listBoxStudents.SelectedItem.ToString() != "")
                {
                    labelID.Visible = true;
                    labelFName.Visible = true;
                    labelMName.Visible = true;
                    labelLname.Visible = true;
                    labelPhone.Visible = true;
                    labelDate.Visible = true;
                    txtID.Visible = true;
                    txtFName.Visible = true;
                    txtLName.Visible = true;
                    txtMName.Visible = true;
                    txtPhone.Visible = true;
                    dateTimePickerDate.Visible = true;
                    st2 = listBoxStudents.SelectedItem.ToString();
                    while (st2[i].ToString() != " ")
                    {
                        fname = fname + st2[i];
                        i++;
                    }
                    if (st2[i].ToString() == " ")
                    {
                        i++;
                    }
                    while (st2[i].ToString() != " ")
                    {
                        fatherN = fatherN + st2[i];
                        i++;
                    }
                    if (st2[i].ToString() == " ")
                    {
                        i++;
                    }

                    while (i < listBoxStudents.SelectedItem.ToString().Length)
                    {
                        lname = lname + st2[i];
                        i++;
                    }
                    con.Open();
                    co.Connection = con;
                    string g = "SELECT * From [students] where fname='" + fname + "' AND lname='" + lname + "' AND nfather='" + fatherN + "' ";
                    co.CommandText = g;
                    OleDbDataReader r;
                    r = co.ExecuteReader();
                    while (r.Read())
                    {
                        txtID.Text = r["tz"].ToString();
                        txtFName.Text = r["fname"].ToString();
                        txtLName.Text = r["lname"].ToString();
                        txtMName.Text = r["nfather"].ToString();
                        txtPhone.Text = r["phone"].ToString();
                    }
                    con.Close();
                    r.Close();
                }

            }
            else
            {
                buttonMa3lomat.Text = "معلومات عن طالب";
                labelID.Visible = false;
                labelFName.Visible = false;
                labelMName.Visible = false;
                labelLname.Visible = false;
                labelPhone.Visible = false;
                labelDate.Visible = false;
                txtID.Visible = false;
                txtFName.Visible = false;
                txtLName.Visible = false;
                txtMName.Visible = false;
                txtPhone.Visible = false;
                blMa3lomat = false;
                dateTimePickerDate.Visible = false;

            }
        }

        private void buttonAddS_Click(object sender, EventArgs e)
        {
            int i = 0; string fname = ""; string st2; string lname = ""; string fatherN = "";
            int heIsNotHere = listBoxStudents.Items.Count;
            int heIsHere = listBoxStudents.Items.Count;
            string tzSN="", tzSKiam="";
            string tzStudents;
            st2 = listBoxNewSINK.SelectedItem.ToString();
            while (st2[i].ToString() != " ")
            {
                
                fname = fname + st2[i];
                i++;
            }
            if (st2[i].ToString() == " ")
            {
                i++;
            }
            while (st2[i].ToString() != " ")
            {
                fatherN = fatherN + st2[i];
                i++;
            }

            if (st2[i].ToString() == " ")
            {
                i++;
            }
           
            while (i < st2.Length)
            {
                
                lname = lname + st2[i];
                i++;
            }
            con.Open();
            string fnameAdd = fname; string lnameAdd = lname; string fatherAdd = fatherN;
            co.Connection = con;
          
            string g = "SELECT * From [students] where fname='" + fname + "' AND lname='" + lname + "' AND nfather='" + fatherN + "' ";
            co.CommandText = g;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                tzSN = r["tz"].ToString();

            }
             tzStudents=tzSN;
            con.Close();
            r.Close();
            int t = 0;
            while (t < listBoxStudents.Items.Count)
            {
                fname = ""; lname = ""; fatherN = "";
                
                int tt = 0;  
                st2 = listBoxStudents.Items[t].ToString();
                MessageBox.Show(st2);
                t++;
                while (st2[tt].ToString() != " ")
                {
                    fname = fname + st2[tt];
                    tt++;
                }
                if (st2[tt].ToString() == " ")
                {
                    tt++;
                }
                while (st2[tt].ToString() != " ")
                {
                    fatherN = fatherN + st2[tt];
                    tt++;
                }
                if (st2[tt].ToString() == " ")
                {
                    tt++;
                }
                while (tt < st2.Length)
                {

                    lname = lname + st2[tt];
                    tt++;
                }
                con.Open();
                co.Connection = con;
                string h = "SELECT * From [students] where fname='" + fname + "' AND lname='" + lname + "' AND nfather='" + fatherN + "' ";     
                co.CommandText = h;
                OleDbDataReader w;
                w= co.ExecuteReader();
                while (w.Read())
                {

                   tzSKiam = (w["tz"].ToString());

                }
                con.Close();
                r.Close();
               if(tzSKiam==tzSN)
                {
                    heIsHere--;
                    
                }
                else
                {
                    heIsNotHere--;
                }
            }
            
            if(heIsNotHere==0)
            {
                con.Open();
                co.Connection = con;
                string q = "SELECT * From [students]";
                co.CommandText = q;
                OleDbDataReader p;
                p = co.ExecuteReader();
                if (p.Read())
                {
                    listBoxStudents.Items.Add(fnameAdd + " " + fatherAdd + " " + lnameAdd);

                }
                con.Close();
                p.Close();
                con.Open();
                co.Connection = con;
                string y = "SELECT * From [korsANDstudents] where tz='"+tzStudents+"'";
                co.CommandText = y;
                OleDbDataReader u;
                u = co.ExecuteReader();
                while (u.Read())
                {

                    string s = (u["kors1"].ToString());
                    string s2 = (u["kors2"].ToString());
                    string s3 = (u["kors3"].ToString());
                    string s4 = (u["kors4"].ToString());
                    string s5 = (u["kors5"].ToString());
                                         
                    if (s == "" && s2 != tzkors && s3 != tzkors && s4 != tzkors && s5 != tzkors )
                    {
                        korsAndstudentsTableAdapter.Updatekors1(tzkors, tzSN);
                        this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                        korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                   }
                    else if (s2 == "" && s != tzkors && s3 != tzkors && s4 != tzkors && s5 != tzkors)
                    {
                        korsAndstudentsTableAdapter.Updatekors2(tzkors, tzSN);
                        this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                        korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    }
                    else if (s3 == "" && s != tzkors && s2 != tzkors && s4 != tzkors && s5 != tzkors)
                    {
                        korsAndstudentsTableAdapter.Updatekors3(tzkors, tzSN);
                        this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                        korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    }
                    else if (s4 == "" && s != tzkors && s2 != tzkors && s3 != tzkors && s4 != tzkors)
                    {
                        korsAndstudentsTableAdapter.Updatekors5(tzkors, tzSN);
                        this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                        korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    }
                    else if (s5 == "" && s != tzkors && s2 != tzkors && s3 != tzkors && s4 != tzkors)
                    {
                        korsAndstudentsTableAdapter.Updatekors5(tzkors, tzSN);
                        this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                        korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    }                   
                }
                con.Close();
                u.Close();
               
                
            }
            else
            {
                MessageBox.Show("الطالب موجود بالكرس المطلوب", "لا يمكن ادخال الطالب");

            }
        }

        private void listBoxNewSINK_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddS.Visible = true;
        }

    }
}
