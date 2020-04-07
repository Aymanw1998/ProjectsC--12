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
    public partial class Students : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        OleDbCommand co = new OleDbCommand();
        DataTable dt = new DataTable();
        DataTable dtd = new DataTable();
        DataTable dtdHelp = new DataTable();
        string who, /*y,*/ h;
        //int ee = 0 ;
        string agee;
        DarQuranDataSet.studentsDataTable mo;
        string sasatz,sasashem;
        OleDbCommand command = new OleDbCommand();
      
       /* bool bb = false;*/
        string ageee;
        string id;
        string fname,lname;
        public Students(string f, string s1, string tz, string l)
        {

            InitializeComponent();
            
            id = tz;
            fname = f;
            lname = l;
            panelEdit.Visible = false;
            buttonE.Visible = false;
            who = s1;



            //label7.Text = "جميع الطلاب";

            if (who == "مدير")
            {
                buttonNewS.Visible = true;
                button2.Visible = true;
                //labelDaysComboBox.Visible = false;


            }
            if (who != "مدير")
            {
                panel2.Visible = true;
                label8.Visible = true;
                dataGridView1.Visible = true;
                con.Open();
                co.Connection = con;
                string g = "Select tzKors,shemKors from korsim where shemMora='" + f + " " + l + "'";
                co.CommandText = g;
                OleDbDataReader r;
                r = co.ExecuteReader();
                while (r.Read())
                {
                    sasatz = r["tzKors"].ToString();
                    sasashem = r["shemKors"].ToString();
                    comboBoxKors.Items.Add(sasashem);
                }
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{

                    //    h = dt.Rows[i][0].ToString();
                        
                    //    OleDbDataAdapter da = new OleDbDataAdapter("Select * from [students] where tz='" + h + "'", con);
                    //    da.Fill(dtd);
                    //    dataGridViewStudents.DataSource = dtd;
                    //    dtdHelp = dtd;
                    //    bb = true;
                    //    //   }
                    //}
                    //if (bb == false)
                    //{
                    //    dataGridViewStudents.Visible = false;
                    //}

                
                con.Close();
                r.Close();

            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet1.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter1.Fill(this.darQuranDataSet1.students);
            // TODO: This line of code loads data into the 'darQuranDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
            
            mo = this.darQuranDataSet.students;
            

            
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
        }

        private void buttonInStudent_Click(object sender, EventArgs e)
        {
            bool blID = true;
            OleDbCommand co = new OleDbCommand();
            con.Open();
            co.Connection = con;
            string f = "Select tz From students";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                if (textBoxID.Text == r["tz"].ToString())
                {
                    blID = false;

                }
            }
            con.Close();
            labelID.Visible = false; labelFName.Visible = false; labelLName.Visible = false; labelFatherName.Visible = false; labelGender.Visible = false; labelPhone.Visible = false;
            if (string.IsNullOrEmpty(textBoxID.Text))
            {

                MessageBox.Show("ادخل رقم هويتك الشخصية من فضلك", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxID.Focus();
                return;
            }
           // MessageBox.Show(comboBoxgender.Text + " " + textBoxLName.Text + " " + textBoxNfather.Text + " " + textBoxFName.Text + " " + textBoxID.Text);
            if (textBoxID.TextLength == 9 && blID == true && textBoxNfather.Text != "" && textBoxLName.Text != "" && textBoxFName.Text != "" && (comboBoxgender.Text == "ذكر" || comboBoxgender.Text == "انثى"))
            {
                if ( textBoxPhone.TextLength == 10)
                {
                    darQuranDataSet.students.AddstudentsRow(textBoxID.Text, textBoxFName.Text, textBoxNfather.Text, textBoxLName.Text, textBoxPhone.Text, dateTimePickerBirth.Text, comboBoxgender.Text);
                    darQuranDataSet.korsAndstudents.AddkorsAndstudentsRow(textBoxID.Text, "", "", "", "", "");
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    Students_Load(sender, e);
                    panel1.Refresh();
                    MessageBox.Show("تم إضافة الطالب بنجاح");
                }
                else
                {
                    darQuranDataSet.students.AddstudentsRow(textBoxID.Text, textBoxFName.Text, textBoxNfather.Text, textBoxLName.Text, textBoxPhone.Text, dateTimePickerBirth.Text, comboBoxgender.Text);
                    darQuranDataSet.korsAndstudents.AddkorsAndstudentsRow(textBoxID.Text, "", "", "", "", "");
                    studentsTableAdapter.Update(darQuranDataSet.students);
                    korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
                    Students_Load(sender, e);
                    panel1.Refresh();
                    MessageBox.Show("تم إضافة الطالب بنجاح");
                }
            }
            else
            {
                if (blID == false)
                {
                    labelID.Text = "صاحب الهوية موجود";
                    labelID.Visible = true;
                }

                if (textBoxID.Text == "" )
                {
                    labelID.Text = " عليك ان تملائ الخانة ب9 ارقام";
                    labelID.Visible = true;
                }
                else if (textBoxID.TextLength != 9)
                {
                    labelID.Text = " عليك ان تملائ الخانة ب9 ارقام";
                    labelID.Visible = true;
                }
                if (textBoxNfather.Text == "")
                {
                    labelFatherName.Text = "عليك ان تملائ الخانة";
                    labelFatherName.Visible = true;
                }
                if (textBoxFName.Text == "")
                {
                    labelFName.Text = "عليك ان تملائ الخانة";
                    labelFName.Visible = true;
                }
                if (textBoxLName.Text == "")
                {
                    labelLName.Text = "عليك ان تملائ الخانة";
                    labelLName.Visible = true;
                }
                if ((comboBoxgender.Text != "ذكر" && comboBoxgender.Text != "انثى"))
                {
                    labelGender.Text = "عليك ان تختار جنسك";
                    labelGender.Visible = true;
                }
                if (textBoxPhone.Text != "")
                {
                    if (textBoxPhone.TextLength != 10)
                    {
                        labelPhone.Text = " عليك ان تملائ الخانة ب10 ارقام";
                        labelPhone.Visible = true;
                    }
                }
            }
        }
        private void buttonNewS_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (who != "مدير")
            {

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Visible = true;
            DataTable dz = new DataTable();
            dz.Columns.Add("رقم الهوية");
            dz.Columns.Add("الاسم الشخصي");
            dz.Columns.Add("اسم الوالد");
            dz.Columns.Add("اسم العائلة");
            dz.Columns.Add("رقم الهاتف");
            dz.Columns.Add("تاريخ الميلاد");
            
            
            for (int j = 0; j < mo.Rows.Count; j++)
            {
                for (int k = 0; k < mo.Columns.Count; k++)
                {
                    if (mo.Rows[j][k].ToString().Contains(textBoxSearch.Text))
                    {
                       
                            dz.Rows.Add(mo[j][0], mo[j][1], mo[j][2], mo[j][3], mo[j][4], mo[j][5]);
                            k = mo.Columns.Count;
                      
                    }
                }
            }

            dataGridViewSearch.DataSource = dz;
            if(textBoxSearch.Text=="")
                dataGridViewSearch.Visible=false; 
        }
       
        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            agee = ((int)(DateTime.Now.Subtract(dateTimePickerBirth.Value).TotalDays / 365.25)).ToString();
        }

        private void dataGridViewStudents_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString()!="")
            {
            txtID.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtFName.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtFatherN.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //dateTimePickerDateS.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[5].Value.ToString();
            
            panelEdit.Visible = true;
         
            buttonE.Visible = true;
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void dateTimePickerDateS_ValueChanged(object sender, EventArgs e)
        {
            ageee = ((int)(DateTime.Now.Subtract(dateTimePickerBirth.Value).TotalDays / 365.25)).ToString();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            buttonNewS.Visible = true;
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            lbl_Name.Visible = false; lbl_Family.Visible = false; lbl_Phone.Visible = false; lbl_Father.Visible = false;
            OleDbCommand cmdUpdate = new OleDbCommand();

            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات الطالب؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drAcceptAdd == DialogResult.Yes)
            {

                cmdUpdate.CommandText = "UPDATE students SET  [fname] = '" + txtFName.Text + "', [nfather] = '" + txtFatherN.Text + "',  [lname] = '" + txtLName.Text + "', [phone] = '" + txtPhone.Text + "', [birthday] = '" + dateTimePickerDateS.Text + "' where [tz] = '" + txtID.Text + "'";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();

                con.Close();

                this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                dataGridViewStudents.Refresh();
                MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelEdit.Visible = false;
            }
        }
        private void buttonDeleteS_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdDelete = new OleDbCommand();

            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد حذف معلومات الطالب؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drAcceptAdd == DialogResult.Yes)
            {

                cmdDelete.CommandText = "Delete From students Where TZ='" + txtID.Text + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();

                con.Close();
                cmdDelete.CommandText = "Delete From korsANDstudents Where tz='" + txtID.Text + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();

                con.Close();

                this.studentsTableAdapter.Fill(this.darQuranDataSet.students);
                this.korsAndstudentsTableAdapter.Fill(this.darQuranDataSet.korsAndstudents);
                dataGridViewStudents.Refresh();
                dataGridViewSearch.Refresh();
                panelEdit.Visible = false;

                MessageBox.Show("تم حذف الطالب ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelEdit.Visible = false;
            }
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxFName.Focus();
            }
        }

        private void textBoxFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNfather.Focus();
            }
        }

        private void textBoxNfather_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxLName.Focus();
            }
        }

        private void textBoxLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxgender.Focus();
            }
        }

        private void comboBoxgender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPhone.Focus();
            }
        }

        private void textBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerBirth.Focus();
            }
        }

        private void dateTimePickerBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonInStudent.Focus();
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFatherN.Focus();
            }
        }

        private void txtFatherN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLName.Focus();
            }
        }

        private void txtLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerDateS.Focus();
            }
        }

        private void dateTimePickerDateS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEdit.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            darQuranDataSet.students.AddstudentsRow(textBoxID.Text, textBoxFName.Text, textBoxNfather.Text, textBoxLName.Text, textBoxPhone.Text, dateTimePickerBirth.Text, comboBoxgender.Text);
            darQuranDataSet.korsAndstudents.AddkorsAndstudentsRow(textBoxID.Text, "", "", "", "", "");
            studentsTableAdapter.Update(darQuranDataSet.students);
            korsAndstudentsTableAdapter.Update(darQuranDataSet.korsAndstudents);
            Students_Load(sender, e);
                                     
        }

        private void comboBoxKors_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            dataGridView1.ClearSelection();
            dataGridViewStudents.ClearSelection();
            dt.Columns.Add("رقم الهوية");
            dt.Columns.Add("الاسم الشخصي");
            dt.Columns.Add("اسم الوالد");
            dt.Columns.Add("اسم العائلة");
            dt.Columns.Add("رقم الهاتف");
            dt.Columns.Add("تاريخ الميلاد");
            dt.Columns.Add("جنس");
            
            if(comboBoxKors.Text!="")
            {
                con.Open();
                co.Connection = con;
                
                string g = "Select tzKors from korsim where shemKors='" +comboBoxKors.Text+ "' AND shemMora='"+fname+" "+lname+"'";
                co.CommandText = g;
                OleDbDataReader r;
                r = co.ExecuteReader();
                
                while (r.Read())
                {
                    sasatz = r["tzKors"].ToString();
                    
                    OleDbDataAdapter da = new OleDbDataAdapter("Select tz from [korsAndstudents] where Kors1='" + sasatz + "' OR Kors2='" + sasatz + "' OR Kors3='" + sasatz + "' OR Kors4='" + sasatz + "' OR Kors5='" + sasatz + "'", con);
                    da.Fill(dtd);
                    for (int i = 0; i < dtd.Rows.Count; i++)
                    {
                         
                        OleDbDataAdapter dN = new OleDbDataAdapter("Select * from [students] where tz='" + dtd.Rows[i][0].ToString() + "'", con);
                        dN.Fill(dtdHelp);

                        if (dt.Rows.Count == 0)
                        {
                            
                            dt.Rows.Add(dtdHelp.Rows[i][0], dtdHelp.Rows[i][1], dtdHelp.Rows[i][2], dtdHelp.Rows[i][3], dtdHelp.Rows[i][4], dtdHelp.Rows[i][5], dtdHelp.Rows[i][6]);
                        }
                        else
                        {
                            int count = 0;
                            for (int w = 0; w < dt.Rows.Count; w++)
                            {

                                if (dt.Rows[w][0].ToString() == dtdHelp.Rows[i][0].ToString())
                                {
                                    count++;
                                }
                            }
                            if (count == 0)
                                dt.Rows.Add(dtdHelp.Rows[i][0], dtdHelp.Rows[i][1], dtdHelp.Rows[i][2], dtdHelp.Rows[i][3], dtdHelp.Rows[i][4], dtdHelp.Rows[i][5], dtdHelp.Rows[i][6]);
                        }
                    }
                }
                con.Close();
                r.Close();
               
               
            }
           dataGridView1.DataSource = dt;
           button1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewSearch_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString()!="")
            {
            txtID.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtFName.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtFatherN.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[4].Value.ToString();
            dateTimePickerDateS.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[5].Value.ToString();

            panelEdit.Visible = true;
          //  buttonNewS.Visible = false;
            buttonE.Visible = true;
            }
            else
            {
                 MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void buttonESearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                txtID.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtFName.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtLName.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtFatherN.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[4].Value.ToString();
                dateTimePickerDateS.Text = dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[5].Value.ToString();

                panelEdit.Visible = true;
               
                
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxNfather_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtFatherN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                OnlyStudent only = new OnlyStudent(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                only.Show();
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                OnlyStudent only = new OnlyStudent(dataGridViewStudents.Rows[dataGridViewStudents.CurrentCell.RowIndex].Cells[0].Value.ToString());
                only.Show();
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

       
    }
}
