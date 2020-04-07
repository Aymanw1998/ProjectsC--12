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
    public partial class MeE : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        string user, pass, name, family, tz, ph, g, d; string start, end;
        public MeE(string username,string password,string fname,string lname, string id, string phone, string email, string gender, string date)
        {
            InitializeComponent();
            user = username;
            textBoxUsername.Text = user;
            pass = password;
            textBoxPassword.Text = pass;
            name = fname;
            textBoxFName.Text = name;
            family = lname;
            textBoxLName.Text = family;
            ph = phone;
            textBoxPhone.Text =ph;
            g = gender;
            comboBoxgender.Text=g;
            d = date;
            tz = id;
            textBoxID.Text = tz;
            dateTimePickerBirth.Text=d;
            string s = email;
            int i=0;
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
            textBoxEmail.Enabled = true;
            textBoxEmail.Text = start;
            comboBoxEmail.Text = end;
        }

        private void MeE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet.mnhel' table. You can move, or remove it, as needed.
            this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool blUser = true;
          
            OleDbCommand co = new OleDbCommand();
            con.Open();
            co.Connection = con;
            string f = "Select username From mnhel";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                if (textBoxUsername.Text == r["username"].ToString())
                {
                    blUser = false;

                }
            }
            con.Close();
           

            labelFName.Visible = false; labelLName.Visible = false; labelPhone.Visible = false; labelEmail.Visible = false;

            OleDbCommand cmdUpdate = new OleDbCommand();

            if (textBoxFName.Text != "" && textBoxLName.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                if (blUser == false)
                {
                    if ((textBoxPhone.Text == "" || textBoxPhone.TextLength == 10) && (comboBoxEmail.Text == "(اختار طريق الارسال(الايميل"))
                    {
                        DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات المعلم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (drAcceptAdd == DialogResult.Yes)
                        {

                            cmdUpdate.CommandText = "UPDATE mnhel SET [username] = '" + textBoxUsername.Text + "', [password] = '" + textBoxPassword.Text + "',  [fname] = '" + textBoxFName.Text + "', [lname] = '" + textBoxLName.Text + "', [phone] = '" + textBoxPhone.Text + "', [Birthday] = '" + dateTimePickerBirth.Text + "', [email] = '" + textBoxEmail.Text + "@" + comboBoxEmail.Text + "' Where [tz] = '" + textBoxID.Text + "'";
                            cmdUpdate.Connection = con;
                            con.Open();
                            cmdUpdate.ExecuteNonQuery();

                            con.Close();


                            this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                            mnhelTableAdapter.Update(darQuranDataSet.mnhel);

                            MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (comboBoxEmail.Text != "(اختار طريق الارسال(الايميل" && textBoxEmail.Text != "" && textBoxEmail.Text.IndexOf('@') == -1)
                        {
                            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات المعلم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (drAcceptAdd == DialogResult.Yes)
                            {

                                cmdUpdate.CommandText = "UPDATE mnhel SET [username] = '" + textBoxUsername.Text + "', [password] = '" + textBoxPassword.Text + "',  [fname] = '" + textBoxFName.Text + "', [lname] = '" + textBoxLName.Text + "', [phone] = '" + textBoxPhone.Text + "', [Birthday] = '" + dateTimePickerBirth.Text + "', [email] = '" + textBoxEmail.Text + "@" + comboBoxEmail.Text + "' Where [tz] = '" + textBoxID.Text + "'";
                                cmdUpdate.Connection = con;
                                con.Open();
                                cmdUpdate.ExecuteNonQuery();

                                con.Close();
                                this.mnhelTableAdapter.Fill(this.darQuranDataSet.mnhel);
                                mnhelTableAdapter.Update(darQuranDataSet.mnhel);
                                con.Close();
                                MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }

                }
            }
      
            else
            {
                if (textBoxUsername.Text == "")
                {
                    labelUser.Text = "عليك ان تملائ الخانة";
                    labelUser.Visible = true;
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
            }
            this.Close();
        }

        private void panelNewT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
