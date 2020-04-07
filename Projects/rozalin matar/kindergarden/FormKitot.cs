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
    public partial class FormKitot : Form
    {
        public FormKitot()
        {
            InitializeComponent();
        }
        bool bl_existing = true;
        kindergardenDataSet.kitotDataTable kitotDT;
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
        private void FormKitot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kindergardenDataSet.kitot' table. You can Move, or reMove it, as needed.
            this.kitotTableAdapter.Fill(this.kindergardenDataSet.kitot);
            kitotDT = kindergardenDataSet.kitot;
          
            for (int i = 0; i < kitotDT.Rows.Count; i++)
            {
                cb_kitot.Items.Add(kitotDT.Rows[i]["name"]);
            }
            
        }

        private void btn_rf_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_code.Text = "";
            txt_nuMofKids.Text = "";
            txt_minAge.Text = "";
            txt_maxAge.Text = "";
            txt_code.Enabled = true;
            txt_name.Enabled = true;
            cb_kitot.Text = "";
            this.kitotTableAdapter.Fill(this.kindergardenDataSet.kitot);
        }


        bool bl_add = true;
        bool bl_update = false;

        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            int nuMofKids = Convert.ToInt32(txt_nuMofKids.Text.ToString());
            if (10 > nuMofKids)
            {
                DialogResult dr = MessageBox.Show("The children's number is too low to open a new class. Do you want to add them to an existing class?", "Erorr", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < kitotDT.Rows.Count && bl_existing; i++)
                    {
                        string n = txt_nuMofKids.Text;
                        string nn = kitotDT.Rows[i]["number of kids"].ToString();
                        string cc = kitotDT.Rows[i]["code"].ToString();
                        string name = kitotDT.Rows[i]["name"].ToString();
                        int numKids = Convert.ToInt32(nn.ToString()) + Convert.ToInt32(n.ToString());
                        if ( numKids<= 30)
                        {
                            if ((Convert.ToInt16(txt_minAge.Text.ToString()) >= Convert.ToInt16(kitotDT.Rows[i]["min age"].ToString())) && (Convert.ToInt16(txt_maxAge.Text.ToString())) <= (Convert.ToInt16(kitotDT.Rows[i]["max age"].ToString())))
                            {
                                string num = Convert.ToInt16(nn) + Convert.ToInt16(n).ToString();

                                OleDbCommand cmd = new OleDbCommand("UPDATE kitot SET [number of kids]='" + num + "' where [code]='" + cc + "'", con);
                                MessageBox.Show("The children have been added successfuly to ." );
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("A matching class is not avaliable. Please add more children or wait.");
                            }

                        }
                        else
                        {
                            btn_rf_Click(sender, e);
                        }


                    }
                }
            }

                else if ((Convert.ToInt32(txt_nuMofKids.Text.ToString()) > 30))
                {
                    MessageBox.Show("There are too much children for one class. Open another class.", "Erorr", MessageBoxButtons.YesNo);
                    txt_nuMofKids.Text = "30";
                }

                else
                {

                    if (bl_add)
                    {
                        OleDbCommand cmd = new OleDbCommand();

                        cmd.Connection = con;
                        if (txt_code.Text == "" || txt_name.Text == "" || txt_nuMofKids.Text == "" || txt_minAge.Text == "" || txt_maxAge.Text == "")
                        {
                            MessageBox.Show(" Please fill all the neccessery information");
                        }
                        else if (Convert.ToInt16(txt_minAge.Text) > Convert.ToInt16(txt_maxAge.Text))
                        {
                            MessageBox.Show("The minimum age can't be above than the maximum age.Please try again.");
                            txt_maxAge.Text = "";
                            txt_minAge.Text = "";

                        }

                        else
                        {
                            for (int i = 0; i < kitotDT.Rows.Count && bl_existing; i++)
                            {
                                string c = txt_code.Text;
                                string cc = kitotDT.Rows[i]["code"].ToString();
                                if (c == cc)
                                {
                                    bl_existing = false;
                                    MessageBox.Show("This class have been added before.");
                                }

                            }
                            if (bl_existing)
                            {

                                DialogResult res = new DialogResult();
                                res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (res == DialogResult.Yes)
                                {
                                    cmd.CommandText = "INSERT INTO kitot ([code],[name],[number of kids],[Min age],[Max age]) VALUES ('" + txt_code.Text + "' ,'" + txt_name.Text + "','" + txt_nuMofKids.Text + "','" + txt_minAge.Text + "','" + txt_maxAge.Text + "')";
                                    txt_name.Text = "";
                                    txt_code.Text = "";
                                    txt_nuMofKids.Text = "";
                                    txt_minAge.Text = "";
                                    txt_maxAge.Text = "";
                                    txt_code.Enabled = true;
                                    txt_name.Enabled = true;
                                    con.Open();

                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    this.kitotTableAdapter.Fill(this.kindergardenDataSet.kitot);
                                    dataGridView_kitot.Refresh();
                                    cb_kitot.Items.Clear();
                                    FormKitot_Load(sender, e);
                                    btn_rf_Click(sender, e);
                                    MessageBox.Show("The class has been successfully added");


                                }
                            }
                        }
                    }

                    if (bl_update)
                    {
                        if (txt_code.Text == "" || txt_name.Text == "" || txt_nuMofKids.Text == "" || txt_minAge.Text == "" || txt_maxAge.Text == "")
                        {
                            MessageBox.Show(" Please fill all the neccessery information");
                        }
                        else
                        {
                            for (int i = 0; i < kitotDT.Rows.Count && bl_existing; i++)
                            {
                                string c = kitotDT.Rows[i]["code"].ToString();
                                string cc = txt_code.Text;
                                if (c.Equals(cc))
                                {
                                    DialogResult res2 = new DialogResult();
                                    res2 = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                    if (res2 == DialogResult.Yes)
                                    {
                                        OleDbCommand cmd = new OleDbCommand("UPDATE kitot SET [code]='" + txt_code.Text + "', [name]='" + txt_name.Text + "',[number of kids]='" + txt_nuMofKids.Text + "',[Min age]='" + txt_minAge.Text + "',[Max age]='" + txt_maxAge.Text + "' where [code]='" + txt_code.Text + "'", con);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        txt_name.Text = "";
                                        txt_code.Text = "";
                                        txt_nuMofKids.Text = "";
                                        txt_minAge.Text = "";
                                        txt_maxAge.Text = "";
                                        txt_code.Enabled = true;
                                        txt_name.Enabled = true;
                                        MessageBox.Show("The class has been successfully updated. ");
                                    }
                                }
                            }
                        }
                    }







                    btn_rf_Click(sender, e);



            
            }
        }


        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_code_Click(object sender, EventArgs e)
        {

        }

        private void txt_nuMofKids_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nuMofKids_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string n = txt_nuMofKids.Text;
            //string nn = kitotDT.Rows[0]["number of kids"].ToString();
            //if ((Convert.ToInt16(nn) + Convert.ToInt16(n)) > 30)
            //    MessageBox.Show("true");
        }

        private void dataGridView_kitot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //הצגת טבלאת חיפוש
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            search.Columns.Add("code");
            search.Columns.Add("name");
            search.Columns.Add("number of kids");
            search.Columns.Add("Min age");
            search.Columns.Add("Max age");



            for (int i = 0; i < kitotDT.Rows.Count; i++)
            {
                for (int j = 0; j < kitotDT.Columns.Count; j++)
                {

                    if (kitotDT.Rows[i][j].ToString().Contains(txt_search.Text))
                    {
                        pnl_results.Visible = true;

                        search.Rows.Add(kitotDT[i][0], kitotDT[i][1], kitotDT[i][2], kitotDT[i][3], kitotDT[i][4]);
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

        //כפתור הוספת כיתה
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_code.Text = "";
            txt_nuMofKids.Text = "";
            txt_minAge.Text = "";
            txt_maxAge.Text = "";
            txt_code.Enabled = true;
            txt_name.Enabled = true;
            
            bl_add = true;
            bl_update = false;
            
        }

        //בחירת כיתה לעדכון
        private void cb_kitot_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_name.Text = kitotDT.Rows[cb_kitot.SelectedIndex]["name"].ToString();
            txt_code.Text = kitotDT.Rows[cb_kitot.SelectedIndex]["code"].ToString();
            txt_nuMofKids.Text = kitotDT.Rows[cb_kitot.SelectedIndex]["number of kids"].ToString();
            txt_minAge.Text = kitotDT.Rows[cb_kitot.SelectedIndex]["min age"].ToString();
            txt_maxAge.Text = kitotDT.Rows[cb_kitot.SelectedIndex]["max age"].ToString();
            txt_code.Enabled = false;
            txt_name.Enabled = false;
            btn_delete.Enabled = true;
            bl_update = true;
            btn_add.Enabled= true;
            bl_add = false;
        }

        //כפתור מחיקה
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kitotDT.Rows.Count && bl_existing; i++)
            {
                string name1 = kitotDT.Rows[i]["name"].ToString();
                string name2 = txt_name.Text;
                if (name1.Equals(name2))
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd_delete = new OleDbCommand("delete from kitot where name='" + txt_name.Text + "'", con);

                        con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();
                        cb_kitot.Items.Clear();
                        cb_kitot.Text = "";
                        FormKitot_Load(sender, e);
                        MessageBox.Show("The class has been removed successfully.");
                        txt_name.Text = "";
                        txt_code.Text = "";
                        txt_nuMofKids.Text = "";
                        txt_minAge.Text = "";
                        txt_maxAge.Text = "";
                        txt_code.Enabled = true;
                        txt_name.Enabled = true;
                    }

                }
            }
            
            bl_add = false;
            bl_update = false;
            txt_name.ReadOnly = false;
            txt_code.ReadOnly = false;
            txt_nuMofKids.ReadOnly = false;
            txt_minAge.ReadOnly = false;
            txt_maxAge.ReadOnly = false;
            
            
        }

        private void txt_maxAge_TextChanged(object sender, EventArgs e)
        {

        }
        //בדיקת תקינות
        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות קוד
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nuMofKids_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות מספר ילדים
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_minAge_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות גיל מינימלי
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_maxAge_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות גיל מקסימלי
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

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שם
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnl_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_sadot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

