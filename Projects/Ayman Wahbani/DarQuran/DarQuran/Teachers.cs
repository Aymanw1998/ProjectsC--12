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
    public partial class Teachers : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        DarQuranDataSet.mnhelDataTable mo;
        string role; 
        /*string s;*/
        string thisrole;
        string e;
        DataTable dt = new DataTable();
        public Teachers(string r) 
        {
            InitializeComponent();
            thisrole = r;
            role = "مدير";
            OleDbDataAdapter d = new OleDbDataAdapter("Select * From mnhel WHERE role Not IN('" + role + "')", con);
            d.Fill(dt);
            dataGridViewTeachers.DataSource = dt;
            if(thisrole=="معلم")
            {
                label12.Text = "أضغط مرتيين متتاليتان على السطر لترى معلومات المعلم";
                buttonNewT.Visible = false;
                buttonEdit.Visible = false;
                buttonDeleteT.Visible = false;
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet.BetHKisif' table. You can move, or remove it, as needed.
            this.betHKisifTableAdapter.Fill(this.darQuranDataSet.BetHKisif);
            // TODO: This line of code loads data into the 'darQuranDataSet.mnhel' table. You can move, or remove it, as needed.
            this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
            mo = darQuranDataSet.mnhel;

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Visible = true;
            DataTable dz = new DataTable();
            dz.Columns.Add("رقم الهوية");
            dz.Columns.Add("الاسم الشخصي");
            dz.Columns.Add("اسم العائلة");
            dz.Columns.Add("رقم الهاتف");
            dz.Columns.Add("البريد الالكتروني");
            dz.Columns.Add("تاريخ الميلاد");



            for (int j = 0; j < mo.Rows.Count; j++)
            {
                for (int k = 0; k < mo.Columns.Count; k++)
                {
                    if (mo.Rows[j][k].ToString().Contains(textBoxSearch.Text)) 
                    {


                        dz.Rows.Add(mo[j][4], mo[j][2], mo[j][3], mo[j][5], mo[j][6], mo[j][7]);
                        k = mo.Columns.Count;
                    }
                }
            }

            dataGridViewSearch.DataSource = dz;
            if (textBoxSearch.Text == "")
                dataGridViewSearch.Visible = false;
        }

        private void dataGridViewTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[2].Value.ToString() != "")
            {
                string start = "", end = ""; int i = 0;
                txtID.Text = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtFName.Text = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtLName.Text = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[4].Value.ToString();

                txtPhone.Text = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[5].Value.ToString();
                if (dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[6].Value.ToString() != "")
                {

                    string s = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[6].Value.ToString();
                    while (s[i] != '@')
                    {
                        start = start + s[i].ToString();
                        i++;
                    }
                    i++;
                    while (i < s.Length)
                    {
                        end = end + s[i].ToString();
                        i++;
                    }
                    txtEmail.Enabled = true;
                    txtEmail.Text = start;
                    comboBoxEEmail.Text = end;
                }
                 txtDate.Text = dataGridViewTeachers.Rows[dataGridViewTeachers.CurrentCell.RowIndex].Cells[7].Value.ToString();

                panelEdit.Visible = true;
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void buttonInTeachers_Click(object sender, EventArgs e)
        {
            bool blUser = true;
            //OleDbDataAdapter d = new OleDbDataAdapter("Select username From mnhel", con);
            //d.Fill(dt);
            //for (int m = 0; m < dt.Rows.Count; m++)
            //{
            //    if (textBoxUsername.Text == dt.Rows[m][0].ToString())
            //    {
            //        blUser = false;
            //        m = dt.Rows.Count;
            //    }
            //}
            OleDbCommand co = new OleDbCommand();
            con.Open();
            co.Connection = con;
            string f = "Select username From mnhel";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                if (textBoxUsername.Text ==  r["username"].ToString())
                {
                    blUser = false;
                  
                }
            }
            con.Close();
            bool blID = true;
            //OleDbDataAdapter da = new OleDbDataAdapter("Select tz From mnhel", con);
            //da.Fill(dt);
            //for (int u = 0; u < dt.Rows.Count; u++)
            //{
            //    if (textBoxID.Text == dt.Rows[u][0].ToString())
            //    {
            //        blUser = false;
            //        u = dt.Rows.Count;
            //    }
            //}
          
            con.Open();
            co.Connection = con;
            string f1 = "Select tz From mnhel";
            co.CommandText = f1;
            r = co.ExecuteReader();
            while (r.Read())
            {
                if (textBoxID.Text == r["tz"].ToString())
                {
                    blID = false;

                }
            }
            con.Close();
            labelID.Visible = false; labelUser.Visible = false; labelPassword.Visible = false; labelFName.Visible = false;
            labelLName.Visible = false; labelPhone.Visible = false; labelEmail.Visible = false; labelGender.Visible = false;


            if (textBoxUsername.Text != "" && blUser == true && textBoxPassword.Text != "" && blID == true && textBoxID.Text.Length == 9 && textBoxFName.Text != "" && textBoxLName.Text != "" && (comboBoxgender.Text == "ذكر" || comboBoxgender.Text == "انثى"))
            {
                if ((textBoxPhone.Text == "" || textBoxPhone.TextLength == 10) && (comboBoxEmail.Text == "(اختار طريق الارسال(الايميل"))
                {


                    darQuranDataSet.mnhel.AddmnhelRow(textBoxUsername.Text, textBoxPassword.Text, textBoxFName.Text, textBoxLName.Text, textBoxID.Text, textBoxPhone.Text, "", dateTimePickerBirth.Text, "معلم", comboBoxgender.Text);
                    darQuranDataSet.BetHKisif.AddBetHKisifRow(textBoxID.Text, textBoxFName.Text, textBoxLName.Text, "0", "100");
                    mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                    this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                    Teachers_Load(sender, e);
                    
                }
                else
                {
                    if (comboBoxEmail.Text != "(اختار طريق الارسال(الايميل" && textBoxEmail.Text != "" && textBoxEmail.Text.IndexOf('@') == -1)
                    {
                        string email = textBoxEmail.Text + "@" + comboBoxEmail.Text;
                        darQuranDataSet.mnhel.AddmnhelRow(textBoxUsername.Text, textBoxPassword.Text, textBoxFName.Text, textBoxLName.Text, textBoxID.Text, textBoxPhone.Text, email, dateTimePickerBirth.Text, "معلم", comboBoxgender.Text);
                       mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                       this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                       Teachers_Load(sender, e);
                    }
                }
            }
            else
            {
                if (textBoxID.Text == "")
                {
                    labelID.Text = "عليك ان تملائ الخانة";
                    labelID.Visible = true;
                }
                if (textBoxID.Text != "" && textBoxID.Text.Length != 9)
                {
                    labelID.Text = "عليك ان تملائ الخانة ب9 ارقام";
                    labelID.Visible = true;
                }
                if (blID == false)
                {
                    labelID.Text = "صاحب الهوية موجود";
                    labelID.Visible = true;
                }
                if (textBoxUsername.Text == "")
                {
                    labelUser.Text = "عليك ان تملائ الخانة";
                    labelUser.Visible = true;
                }
                if (blUser == false)
                {
                    labelUser.Text = "اسم المستخدم غير صالح";
                    labelUser.Visible = true;
                }
                if (textBoxPassword.Text == "")
                {
                    labelPassword.Text = "عليك ان تملائ الخانة";
                    labelPassword.Visible = true;
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

                if (comboBoxEmail.Text != "(اختار طريق الارسال(الايميل")
                {
                    if (textBoxEmail.Text == "")
                    {
                        labelEmail.Text = "عليك ان تملائ الخانة";
                        labelEmail.Visible = true;
                    }
                    else
                    {
                        if (textBoxEmail.Text.IndexOf('@') != -1)
                        {
                            labelEmail.Text = " @ عليك الانتباه لا يمكن ان يكون بالخانةالرمز ";
                            labelEmail.Visible = true;
                        }
                    }
                }
                if ((comboBoxgender.Text != "ذكر" && comboBoxgender.Text != "انثى"))
                {
                    labelGender.Text = "عليك ان تختار جنسك";
                    labelGender.Visible = true;
                }
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            lbl_Name.Visible = false; lbl_Family.Visible = false; lbl_Phone.Visible = false; lbl_Email.Visible = false;

            OleDbCommand cmdUpdate = new OleDbCommand();

            if (txtFName.Text != "" && txtLName.Text != "")
            {
                if ((txtPhone.Text == "" || textBoxPhone.TextLength == 10) && (comboBoxEEmail.Text == "(اختار طريق الارسال(الايميل"))
                {
                    DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات المعلم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (drAcceptAdd == DialogResult.Yes)
                    {

                        cmdUpdate.CommandText = "UPDATE mnhel SET  [fname] = '" + txtFName.Text + "', [lname] = '" + txtLName.Text + "', [phone] = '" + txtPhone.Text + "', [Birthday] = '" + txtDate.Text + "', [email] = '" + txtEmail.Text+"@"+comboBoxEEmail.Text + "' Where [tz] = '" + txtID.Text + "'";
                        cmdUpdate.Connection = con;
                        con.Open();
                        cmdUpdate.ExecuteNonQuery();

                        con.Close();
                        

                        this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                       mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                       con.Close();
                        dataGridViewTeachers.Refresh();
                        dataGridViewSearch.Refresh();
                        MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelEdit.Visible = false;
                    }
                }
                else
                {
                    if (comboBoxEEmail.Text != "(اختار طريق الارسال(الايميل" && txtEmail.Text != "" && txtEmail.Text.IndexOf('@') == -1)
                    {
                        DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات المعلم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (drAcceptAdd == DialogResult.Yes)
                        {

                            cmdUpdate.CommandText = "UPDATE mnhel SET  [fname] = '" + txtFName.Text + "', [lname] = '" + txtLName.Text + "', [phone] = '" + txtPhone.Text + "', [Birthday] = '" + txtDate.Text + "', [email] = '" + txtEmail.Text+"@"+comboBoxEEmail.Text + "' Where [tz] = '" + txtID.Text + "'";
                            cmdUpdate.Connection = con;
                            con.Open();
                            cmdUpdate.ExecuteNonQuery();

                            
                            this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                            mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                            dataGridViewTeachers.Refresh();
                            con.Close();
                            MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panelEdit.Visible = false;
                        }
                    }
                }
               
            }
            else
            {
                if (txtFName.Text == "")
                {
                    lbl_Name.Text = "عليك ان تملائ الخانة";
                    lbl_Name.Visible = true;
                }
                if (txtLName.Text == "")
                {
                    lbl_Family.Text = "عليك ان تملائ الخانة";
                    lbl_Family.Visible = true;
                }

                if (comboBoxEEmail.Text != "(اختار طريق الارسال(الايميل")
                {
                    if (txtEmail.Text == "")
                    {
                        lbl_Email.Text = "عليك ان تملائ الخانة";
                        lbl_Email.Visible = true;
                    }
                    else
                    {
                        if (txtEmail.Text.IndexOf('@') != -1)
                        {
                            lbl_Email.Text = " @ عليك الانتباه لا يمكن ان يكون بالخانةالرمز ";
                            lbl_Email.Visible = true;
                        }
                    }
                }
            }
        }


        private void buttonNewT_Click(object sender, EventArgs e)
        {
            panelNewT.Visible = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
        }

        private void dataGridViewSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                string start = "", end = ""; int i = 0;
                txtID.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtFName.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtLName.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[2].Value.ToString();

                txtPhone.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[3].Value.ToString();
                if (dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[4].Value.ToString() != "")
                {

                    string s = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[4].Value.ToString();
                    while (s[i] != '@')
                    {
                        start = start + s[i].ToString();
                        i++;
                    }
                    i++;
                    while (i < s.Length)
                    {
                        end = end + s[i].ToString();
                        i++;
                    }
                    txtEmail.Enabled = true;
                    txtEmail.Text = start;
                    comboBoxEEmail.Text = end;
                }
                txtDate.Text = dataGridViewSearch.Rows[ dataGridViewSearch.CurrentCell.RowIndex].Cells[5].Value.ToString();

                panelEdit.Visible = true;
                panelEdit.Visible = true;
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
            
        }

        private void buttonDeleteT_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdDelete = new OleDbCommand();

            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد حذف معلومات المعلم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drAcceptAdd == DialogResult.Yes)
            {
                OleDbDataAdapter d = new OleDbDataAdapter("Select fname,lname From mnhel WHERE  TZ='" + txtID.Text + "'", con);
                d.Fill(dt);
                string fn = dt.Rows[0][0].ToString();
                string ln = dt.Rows[0][1].ToString();
                cmdDelete.CommandText = "Delete From mnhel Where TZ='" + txtID.Text + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();
                con.Close();
                OleDbDataAdapter da = new OleDbDataAdapter("Select tzKors From Korsim WHERE  shemMora='" +fn+" "+ln+ "'", con);
                da.Fill(dt);
                string tzkors = dt.Rows[0][0].ToString();
                cmdDelete.CommandText = "Delete From Korsim Where tzKors='" + tzkors + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();
                con.Close();
                cmdDelete.CommandText = "Delete From korsAndstudents Where tz='" + tzkors + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();
                con.Close();
                this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                dataGridViewTeachers.Refresh();
                panelEdit.Visible = false;

                MessageBox.Show("تم حذف المعلم ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                dataGridViewTeachers.Refresh();
                panelEdit.Visible = false;
            }
        }

        private void comboBoxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEmail.Enabled = true;
            if(comboBoxEmail.Text=="(اختار طريق الارسال(الايميل")
            {
                textBoxEmail.Enabled = false;

            }
        }

        private void comboBoxEEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            if (comboBoxEEmail.Text == "(اختار طريق الارسال(الايميل")
            {
                txtEmail.Enabled = false;

            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
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
                textBoxID.Focus();
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
                textBoxLName.Focus();
            }
        }

        private void textBoxLName_KeyDown(object sender, KeyEventArgs e)
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
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
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
                dateTimePickerBirth.Focus();
            }
        }

       
        private void dateTimePickerBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonInTeachers.Focus();
            }
        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
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
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDate.Focus();
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEdit.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
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

        private void button2_Click(object sender, EventArgs e)
        {
            panelNewT.Visible = false;
        }

       

        
    }
}

