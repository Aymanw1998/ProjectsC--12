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
    public partial class FormYeladim : Form
    {
        public FormYeladim()
        {
            InitializeComponent();

        }
        bool bl_existing = true;
        kindergardenDataSet.yeladimDataTable yeladimDT;
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
       
        private void FormYeladim_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'kindergardenDataSet.yeladim' table. You can move, or remove it, as needed.
            this.yeladimTableAdapter.Fill(this.kindergardenDataSet.yeladim);
            
            DateTime currentTime = DateTime.Now;
            int minYear = Convert.ToInt32(currentTime.Year.ToString()) - 5;
            DateTime x = new DateTime(minYear, 1, 1);
            this.dateTimePicker_BD.MaxDate = currentTime;
            this.dateTimePicker_BD.MinDate = x;
            yeladimDT = kindergardenDataSet.yeladim;
            for (int i = 0; i <yeladimDT.Rows.Count; i++)
            {
                cb_yeladim.Items.Add(yeladimDT.Rows[i]["first name"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool bl_add =true;  
        bool bl_update = false;
        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (bl_add)
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = con;
                if (txt_ID.Text == "" || txt_firstName.Text == "" || txt_lastName.Text == "" || txt_eP.Text == ""||comboBox_gender.Text==""||!bl_bDC)
                {
                    MessageBox.Show("Please fill all the neccessery information.");
                }
          
                if (!txt_ID.MaskCompleted || !txt_eP.MaskCompleted || !txt_eP2.MaskCompleted)
                {
                    MessageBox.Show("One or more of the information you've enterd is wrong.");
                }
            bool bl_genderCheck = false;
            for (int i = 0; i < comboBox_gender.Items.Count && !bl_genderCheck; i++)
            {
                if (comboBox_gender.Items[i].Equals(comboBox_gender.Text))
                {
                    bl_genderCheck = true;
                }
            }
            if (!bl_genderCheck)
            {
                MessageBox.Show("Please select again a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {       
              
                    for (int i = 0; i < yeladimDT.Rows.Count && bl_existing; i++)
                    {
                        string c = txt_firstName.Text;
                        string cc = yeladimDT.Rows[i]["first name"].ToString();
                        if (c == cc)
                        {
                            bl_existing = false;
                            MessageBox.Show("This child have been added before.");
                        }

                    }
                    if (bl_existing)
                    {

                        DialogResult res = new DialogResult();
                        res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.CommandText = "INSERT into yeladim ([ID],[First name],[Last name],[Gender],[Birthday date],[Emergency phone],[Emergency phone2],[Address]) VALUES ('" + txt_ID.Text + "' ,'" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + comboBox_gender.Text + "','" +dateTimePicker_BD.Text + "','" + txt_eP.Text + "','" + txt_eP2.Text + "','" + txt_address.Text + "')";

                            con.Open();

                            cmd.ExecuteNonQuery();
                            con.Close();
                            this.yeladimTableAdapter.Fill(this.kindergardenDataSet.yeladim);
                            dataGridView_yeladim.Refresh();
                            cb_yeladim.Items.Clear();
                            btn_rf_Click(sender, e);
                            FormYeladim_Load(sender, e);
                            MessageBox.Show("The child has been successfully added.");


                        }
                   
                }
            }


            }
            if (bl_update)
            {
                for (int i = 0; i < yeladimDT.Rows.Count && bl_existing; i++)
                {
                    string c = yeladimDT.Rows[i]["first name"].ToString();
                    string cc = txt_firstName.Text;
                    if (c.Equals(cc))
                    {
                        DialogResult res2 = new DialogResult();
                        res2 = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res2 == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE yeladim SET [ID]='" + txt_ID.Text + "',[first name]='" + txt_firstName.Text + "', [last name]='" + txt_lastName.Text + "',[emergency phone]='" + txt_eP.Text + "',[emergency phone2]='" + txt_eP2.Text + "',[address]='" + txt_address.Text + "',[gender]='" + comboBox_gender.Text + "' WHERE [first name]='" + txt_firstName.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("The child has been successfully updated.");
                        }

                    }
                }
                
                txt_ID.Text = "";
                txt_firstName.Text = "";
                txt_lastName.Text = "";
                comboBox_gender.Text = "";
                txt_eP.Text = "";
                txt_eP2.Text = "";
                txt_address.Text = "";
                btn_rf_Click(sender, e);

            }

           
        
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //בדיקת שינוי תאריך
        bool bl_bDC = false;
        private void dateTimePicker_BD_ValueChanged(object sender, EventArgs e)
        {
            bl_bDC = true;
        }

        //כפתור רענון
        private void btn_rf_Click(object sender, EventArgs e)
        {
            bl_bDC = false;
           this.yeladimTableAdapter.Fill(this.kindergardenDataSet.yeladim);
           txt_ID.Text = "";
           txt_firstName.Text = "";
           txt_lastName.Text = "";
           comboBox_gender.Text = "";
           txt_eP.Text = "";
           txt_eP2.Text = "";
           txt_address.Text = "";
           txt_ID.Enabled = true;
           txt_firstName.Enabled = true;
           txt_lastName.Enabled = true;
           comboBox_gender.Enabled = true;
           dateTimePicker_BD.Enabled = true;
           btn_add.Enabled = true;
           cb_yeladim.Text = "";
        }
        //הצגת טבלאת חיפוש
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
            DataTable search = new DataTable();
            search.Columns.Add("ID");
            search.Columns.Add("first name");
            search.Columns.Add("last name");
            search.Columns.Add("gender");
            search.Columns.Add("Birthday date");
            search.Columns.Add("emergency phone");
            search.Columns.Add("emergency phone2");
            search.Columns.Add("address");

            for (int i = 0; i < yeladimDT.Rows.Count; i++)
            {
                for (int j = 0; j < yeladimDT.Columns.Count; j++)
                {
                    
                    if (yeladimDT.Rows[i][j].ToString().Contains(txt_search.Text)) 
                    {
                        pnl_results.Visible = true;

                        search.Rows.Add(yeladimDT[i][0], yeladimDT[i][1], yeladimDT[i][2], yeladimDT[i][3], yeladimDT[i][4], yeladimDT[i][5], yeladimDT[i][6], yeladimDT[i][7]);
                        j = search.Columns.Count;
                    }
                    dataGridView_search.DataSource = search;
                    }

            }

        }
        //סגירת טבלאת חיפוש
        private void btn_closeResults_Click(object sender, EventArgs e)
        {
            pnl_results.Visible = false;
            txt_search.Text ="";
        }

        private void lbl_search_Click(object sender, EventArgs e)
        {

        }
        //כפתור הוספת תלמיד
        private void btn_add_Click(object sender, EventArgs e)
        {
            bl_bDC = false;
            txt_ID.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            comboBox_gender.Text = "";
            txt_eP.Text = "";
            txt_eP2.Text = "";
            txt_address.Text = "";
            cb_yeladim.Text = "";
            txt_ID.Enabled = true;
            txt_firstName.Enabled = true;
            txt_lastName.Enabled = true;
            comboBox_gender.Enabled = true;
            dateTimePicker_BD.Enabled = true;
        }
        //בחירת ילד לעדכון
        private void cb_yeladim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ID.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["ID"].ToString();
            txt_lastName.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["last name"].ToString();
            txt_firstName.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["first name"].ToString();
            txt_eP.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["emergency phone"].ToString();
            txt_eP2.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["emergency phone2"].ToString();
            txt_address.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["address"].ToString();
            comboBox_gender.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["gender"].ToString();
            dateTimePicker_BD.Text = yeladimDT.Rows[cb_yeladim.SelectedIndex]["Birthday date"].ToString();
            bl_add = false;
            btn_delete.Enabled = true;
            bl_update = true;
            txt_ID.Enabled = false;
            txt_firstName.Enabled = false;
            txt_lastName.Enabled = false;
            comboBox_gender.Enabled = false;
            dateTimePicker_BD.Enabled = false;
           
            
        }
        //כפתור מחיקה
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < yeladimDT.Rows.Count && bl_existing; i++)
            {
                string name1 = yeladimDT.Rows[i]["first name"].ToString();
                string name2 = txt_firstName.Text;
                if (name1.Equals(name2))
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd_delete = new OleDbCommand("delete from yeladim where [first name]='" + txt_firstName.Text + "'", con);

                        con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();
                        cb_yeladim.Items.Clear();
                        cb_yeladim.Text = "";
                        FormYeladim_Load(sender, e);
                        btn_rf_Click(sender, e);
                        MessageBox.Show("The child has been removed successfully.");

                    }

                }
            }     
        }
        //בדיקת תקינות
        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות ת.ז
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שם פרטי
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שם משפחה
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_eP_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות מספר פלאפון1
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_eP2_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינותץ מספר פלאפון2
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות כתובת
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers or chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שדה חיפוש
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers or chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pnl_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_sadot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
