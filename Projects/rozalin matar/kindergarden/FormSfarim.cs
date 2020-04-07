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
    public partial class FormSfarim : Form
    {
        public FormSfarim()
        {
            InitializeComponent();
        }
        DateTime currentTime;
        bool bl_existing = true;
        kindergardenDataSet.sfarimDataTable sfarimDT;

        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
        private void FormSfarim_Load(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            // TODO: This line of code loads data into the 'kindergardenDataSet.sfarim' table. You can Move, or reMove it, as needed.
            this.sfarimTableAdapter.Fill(this.kindergardenDataSet.sfarim);
           
           
            //הגדרת FROM
            int maxYearFrom = Convert.ToInt32(currentTime.Year.ToString()) + 1;
            DateTime maxFrom = new DateTime(maxYearFrom, currentTime.Month, currentTime.Day);
            this.MoP_borrowing.MaxDate = maxFrom;
            this.MoP_borrowing.MinDate = currentTime;

           
            sfarimDT = kindergardenDataSet.sfarim;
            for (int i = 0; i < sfarimDT.Rows.Count; i++)
            {
                cb_sfarim.Items.Add(sfarimDT.Rows[i]["book's name"]);
            }
        }
        bool bl_dOB = false;
        private void MoP_borrowing_ValueChanged(object sender, EventArgs e)
        {
            bl_dOB = true;
            int y = Convert.ToInt32(MoP_borrowing.Value.Month.ToString()) + 2;
            DateTime x = new DateTime(MoP_borrowing.Value.Year, y, MoP_borrowing.Value.Day);
            MoP_toReturn.Value = x;
        }
        bool bl_add = true;
        bool bl_update = false;
        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!txt_IDBorrowingKid.MaskCompleted)
                MessageBox.Show("One of the information you've enterd is wrong.");
            else
            {
                if (bl_add)
                {
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.Connection = con;
                    if (txt_booksName.Text == "" || !bl_dOB)
                    {
                        MessageBox.Show(" Please fill all the neccessery information.");
                    }
                    else
                    {
                        for (int i = 0; i < sfarimDT.Rows.Count && bl_existing; i++)
                        {
                            string c = txt_booksName.Text;
                            string cc = sfarimDT.Rows[i]["book's name"].ToString();
                            if (c == cc)
                            {
                                bl_existing = false;
                                MessageBox.Show("this borrowing has been added before.");
                            }

                        }
                        if (bl_existing)
                        {

                            DialogResult res = new DialogResult();
                            res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (res == DialogResult.Yes)
                            {
                                cmd.CommandText = "INSERT into sfarim ([book's name],[date of borrowing],[date to return],[ID of borrowing kid]) VALUES ('" + txt_booksName.Text + "','" + MoP_borrowing.Text + "','" + MoP_toReturn.Text + "','" + txt_IDBorrowingKid.Text + "')";

                                con.Open();

                                cmd.ExecuteNonQuery();
                                con.Close();
                                this.sfarimTableAdapter.Fill(this.kindergardenDataSet.sfarim);
                                dataGridView_sfarim.Refresh();
                                cb_sfarim.Items.Clear();
                                btn_delete.Enabled = true;
                                FormSfarim_Load(sender, e);
                                btn_rf_Click(sender, e);
                                MessageBox.Show("The borrowing has been successfully added.");


                            }
                        }
                    }
                }
                if (bl_update)
                {
                    for (int i = 0; i < sfarimDT.Rows.Count && bl_existing; i++)
                    {
                        string c = sfarimDT.Rows[i]["book's name"].ToString();
                        string cc = txt_booksName.Text;
                        if (c.Equals(cc))
                        {
                            DialogResult res2 = new DialogResult();
                            res2 = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (res2 == DialogResult.Yes)
                            {
                                OleDbCommand cmd = new OleDbCommand("UPDATE sfarim SET [book's name]='" + txt_booksName.Text + "',[date of borrowing]='" + MoP_borrowing.Text + "',[date to return]='" + MoP_toReturn.Text + "' ,[ID of borrowing kid]='" + txt_IDBorrowingKid.Text + "' WHERE [book's name]='" + txt_booksName.Text + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                btn_delete.Enabled = true;
                                MessageBox.Show("The borrowing has been successfully updated.");
                            }

                        }
                    }


                    txt_booksName.Text = "";
                    txt_IDBorrowingKid.Text = "";
                    btn_rf_Click(sender, e);
                }
            }
        }
        //כפתור רענון
        private void btn_rf_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            bl_add = true;
            txt_booksName.Enabled = true;
            txt_booksName.Text = "";
            txt_IDBorrowingKid.Text = "";
            cb_sfarim.Text = "";
            cb_sfarim.Items.Clear();
            for (int i = 0; i < sfarimDT.Rows.Count; i++)
            {
                cb_sfarim.Items.Add(sfarimDT.Rows[i]["book's name"]);
            }
            this.sfarimTableAdapter.Fill(this.kindergardenDataSet.sfarim);
        }
        //הצגת טבלאת חיפוש
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            search.Columns.Add("book's name");
            search.Columns.Add("date of borrowing");
            search.Columns.Add("date to return");
            search.Columns.Add("ID of borrowing kid");
            
            

            for (int i = 0; i < sfarimDT.Rows.Count; i++)
            {
                for (int j = 0; j < sfarimDT.Columns.Count; j++)
                {

                    if (sfarimDT.Rows[i][j].ToString().Contains(txt_search.Text))
                    {
                        pnl_results.Visible = true;

                        search.Rows.Add(sfarimDT[i][0], sfarimDT[i][1], sfarimDT[i][2], sfarimDT[i][3]);
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
            txt_search.Text = "";
        }
        //הוספת ספר חדש
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_booksName.Text = "";
            txt_IDBorrowingKid.Text = "";
            txt_booksName.Enabled = true;
        }
        //בחירת ספר לעדכון
        private void cb_kitot_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btn_delete.Enabled = true;
            MoP_borrowing.Text = sfarimDT.Rows[cb_sfarim.SelectedIndex]["Date of borrowing"].ToString();
            MoP_toReturn.Text = sfarimDT.Rows[cb_sfarim.SelectedIndex]["Date of borrowing"].ToString();
            txt_booksName.Text = sfarimDT.Rows[cb_sfarim.SelectedIndex]["book's name"].ToString();
            txt_IDBorrowingKid.Text = sfarimDT.Rows[cb_sfarim.SelectedIndex]["ID of borrowing kid"].ToString();
            txt_booksName.Enabled = false;
            bl_update = true;
            bl_add = false;
            btn_rf.Enabled = true;
           

        }

        //בדיקות תקינות
        private void txt_booksName_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות לשם ספר
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
             
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_IDBorrowingKid_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות ת.ז ילד משאיל
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            for (int i = 0; i < sfarimDT.Rows.Count && bl_existing; i++)
            {
                string name1 = sfarimDT.Rows[i]["book's name"].ToString();
                string name2 = txt_booksName.Text;
                if (name1.Equals(name2))
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd_delete = new OleDbCommand("delete from sfarim where [book's name]='" + txt_booksName.Text + "'", con);

                        con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();
                        cb_sfarim.Items.Clear();
                        FormSfarim_Load(sender, e);
                        btn_rf_Click(sender, e);
                        btn_delete.Enabled = true;
                        MessageBox.Show("The borrowing has been removed successfully.");

                    }

                }
            }
        }

        private void pnl_sadot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_table_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void MoP_borrowing_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        
        private void MoP_toReturn_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void pnl_up_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
