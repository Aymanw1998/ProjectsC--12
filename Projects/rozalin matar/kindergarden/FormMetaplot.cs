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
    public partial class formMetaplot : Form
    {
        public formMetaplot()
        {
            InitializeComponent();
        }
        bool bl_existing = true;
        kindergardenDataSet.metaplotDataTable metaplotDT;
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
        private void FormMetaplot_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'kindergardenDataSet.metaplot' table. You can Move, or reMove it, as needed.
            this.metaplotTableAdapter.Fill(this.kindergardenDataSet.metaplot);
            DateTime currentTime = DateTime.Now;
            int minYear = Convert.ToInt32(currentTime.Year.ToString()) - 65;
            int maxYear = Convert.ToInt32(currentTime.Year.ToString()) - 18;
            int day = Convert.ToInt32(currentTime.Day.ToString());
            int Month = Convert.ToInt32(currentTime.Month.ToString());


            DateTime x = new DateTime(minYear, Month, day);
            DateTime y = new DateTime(maxYear, Month,day);

            this.dateTimePicker_Birthday.MaxDate = y;
            this.dateTimePicker_Birthday.MinDate = x;
            metaplotDT = kindergardenDataSet.metaplot;
            
            for (int i = 0; i < metaplotDT.Rows.Count; i++)
            {
                cb_metaplot.Items.Add(metaplotDT.Rows[i]["first name"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool bl_add = true;
        bool bl_update = false;
        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!txt_ID.MaskCompleted || !txt_phone.MaskCompleted || !txt_housePhone.MaskCompleted)
            {
                MessageBox.Show("One or more of the information you've enterd is wrong.");
            }
            else
            {
                if (bl_add)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.Connection = con;
                    if (txt_ID.Text == "" || txt_firstName.Text == "" || txt_lastName.Text == "" || txt_phone.Text == ""||!bl_bDC)
                    {
                        MessageBox.Show(" Please fill all the neccessery information");
                    }
                    else
                    {
                        for (int i = 0; i < metaplotDT.Rows.Count && bl_existing; i++)
                        {
                            string c = txt_firstName.Text;
                            string cc = metaplotDT.Rows[i]["first name"].ToString();
                            if (c == cc)
                            {
                                bl_existing = false;
                                MessageBox.Show("This teacher have been added before.");
                            }

                        }
                        if (bl_existing)
                        {

                            DialogResult res = new DialogResult();
                            res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (res == DialogResult.Yes)
                            {
                                cmd.CommandText = " INSERT into metaplot ([ID],[first name],[last name],[phone],[house phone],[password],[username],[Bithday],[Address]) VALUES ('" + txt_ID.Text + "' ,'" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + txt_phone.Text + "','" + txt_housePhone.Text + "','" + txt_password.Text + "','" + txt_username.Text + "','" + dateTimePicker_Birthday.Value.ToShortDateString() + "','" + txt_address.Text + "')";

                                con.Open();

                                cmd.ExecuteNonQuery();
                                con.Close();
                                this.metaplotTableAdapter.Fill(this.kindergardenDataSet.metaplot);
                                dataGridView_metaplot.Refresh();
                                cb_metaplot.Items.Clear();
                                FormMetaplot_Load(sender, e);
                                MessageBox.Show("The teacher has been successfully added.");


                            }
                        }
                    }
                }
                if (bl_update)
                {
                    for (int i = 0; i < metaplotDT.Rows.Count && bl_existing; i++)
                    {
                        string c = metaplotDT.Rows[i]["first name"].ToString();
                        string cc = txt_firstName.Text;
                        if (c.Equals(cc))
                        {
                            DialogResult res2 = new DialogResult();
                            res2 = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (res2 == DialogResult.Yes)
                            {
                                OleDbCommand cmd = new OleDbCommand("UPDATE metaplot SET [ID]='" + txt_ID.Text + "',[first name]='" + txt_firstName.Text + "', [last name]='" + txt_lastName.Text + "', [phone]='" + txt_phone.Text + "', [house phone]='" + txt_housePhone.Text + "', [password]='" + txt_password.Text + "',[username]='" + txt_username.Text + "', [address]='" + txt_address.Text + "' where [first name]='" + txt_firstName.Text + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("The teacher has been successfully updated.");
                            }

                        }
                    }




                    txt_ID.Text = "";
                    txt_firstName.Text = "";
                    txt_lastName.Text = "";
                    txt_phone.Text = "";
                    txt_housePhone.Text = "";
                    txt_password.Text = "";
                    txt_username.Text = "";
                    txt_address.Text = "";
                    btn_add.Visible = true;
                    btn_rf_Click(sender, e);
                }
            }
        }
        //כפתור רענון
        private void btn_rf_Click(object sender, EventArgs e)
        {
            this.metaplotTableAdapter.Fill(this.kindergardenDataSet.metaplot);
            txt_ID.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_phone.Text = "";
            txt_housePhone.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_address.Text = "";
            cb_metaplot.Text = "";
            txt_ID.Enabled = true;
            txt_firstName.Enabled = true;
            txt_lastName.Enabled = true;
            dateTimePicker_Birthday.Enabled = true;
            btn_add.Enabled = true;
             bl_add = true;
             bl_update = false;
            
        }
        bool bl_bDC = false;
        private void dateTimePicker_Birthday_ValueChanged(object sender, EventArgs e)
        {
            bl_bDC = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int day= Convert.ToInt32(dateTimePicker_Birthday.Value.Date.Day.ToString());
            //int Month =  Convert.ToInt32(dateTimePicker_Birthday.Value.Date.Month.ToString());
            //int year =  Convert.ToInt32(dateTimePicker_Birthday.Value.Date.Year.ToString());
            //DateTime x = new DateTime(year, Month, day);
            //MessageBox.Show(x.ToString());
            
            MessageBox.Show( dateTimePicker_Birthday.Value.ToLongDateString());
        }
        //הצגת טבלאת חיפוש
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            search.Columns.Add("ID");
            search.Columns.Add("first name");
            search.Columns.Add("last name");
            search.Columns.Add("phone");
            search.Columns.Add("house phone");
            search.Columns.Add("password");
            search.Columns.Add("username");
            search.Columns.Add("Birthday");
            search.Columns.Add("address");

            for (int i = 0; i < metaplotDT.Rows.Count; i++)
            {
                for (int j = 0; j < metaplotDT.Columns.Count; j++)
                {

                    if (metaplotDT.Rows[i][j].ToString().Contains(txt_search.Text))
                    {
                        pnl_results.Visible = true;

                        search.Rows.Add(metaplotDT[i][0], metaplotDT[i][1], metaplotDT[i][2], metaplotDT[i][3], metaplotDT[i][4], metaplotDT[i][5], metaplotDT[i][6], metaplotDT[i][7], metaplotDT[i][8]);
                        j = search.Columns.Count;
                    }
                    dataGridView_search.DataSource = search;
                }

            }
        }

        private void lbl_search_Click(object sender, EventArgs e)
        {

        }
        //סגירת טבלאת חיפוש
        private void btn_closeResults_Click(object sender, EventArgs e)
        {
            pnl_results.Visible = false;
            txt_search.Text = "";
        }
        //כפתור הופסת מורה
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_phone.Text = "";
            txt_housePhone.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_address.Text = "";
            txt_ID.Enabled = true;
             bl_add = true;
             bl_update = false;
        }

        //בחירת מורה לעדכון
        private void cb_kitot_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ID.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["ID"].ToString();
            txt_lastName.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["last name"].ToString();
            txt_firstName.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["first name"].ToString();
            txt_phone.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["phone"].ToString();
            txt_housePhone.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["house phone"].ToString();
            txt_password.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["password"].ToString();
            txt_username.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["username"].ToString();
            txt_address.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["address"].ToString();
            dateTimePicker_Birthday.Text = metaplotDT.Rows[cb_metaplot.SelectedIndex]["Bithday"].ToString();
            txt_ID.Enabled = false;
            txt_firstName.Enabled = false;
            txt_lastName.Enabled = false;
            dateTimePicker_Birthday.Enabled = false;
            bl_add = false;
            btn_delete.Enabled = true;
            bl_update = true;
        }



        //בדיקות תקינות
        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות לת.ז
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות למספר הפלאפון
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_housePhone_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות למספר הטלפון
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות לשם פרטי
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות לשם משפחה
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_metaplot_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות לכתובת
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
        //כפתור מחיקה
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metaplotDT.Rows.Count && bl_existing; i++)
            {
                string name1 = metaplotDT.Rows[i]["first name"].ToString();
                string name2 = txt_firstName.Text;
                if (name1.Equals(name2))
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd_delete = new OleDbCommand("delete from metaplot where [first name]='" + txt_firstName.Text + "'", con);

                        con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();
                        cb_metaplot.Items.Clear();
                        cb_metaplot.Text = "";
                        btn_rf_Click(sender, e);
                        FormMetaplot_Load(sender, e);
                        MessageBox.Show("The teacher has been removed successfully.");

                    }

                }
            }
        }

        private void pnl_sadot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Leave(object sender, EventArgs e)
        {

        }
    }
}
