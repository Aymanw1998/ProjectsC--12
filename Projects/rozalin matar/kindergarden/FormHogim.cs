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
    public partial class FormHogim : Form
    {
        public FormHogim()
        {
            InitializeComponent(); 
        }
        bool bl_existing ;
        kindergardenDataSet.kitotDataTable classesDS;
        OleDbConnection con = new OleDbConnection(@"provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\rozalin matar\kindergarden.mdb");
       kindergardenDataSet.hogimDataTable hogimDT;
       bool bl_fromChanged;
       bool bl_toChanged;
       bool bl_timeChanged;
       DateTime currentTime;
        private void FormHogim_Load(object sender, EventArgs e)
       {
            bl_existing = true;
            bl_timeChanged = false;
            bl_fromChanged = false;
            bl_toChanged = false;
            // TODO: This line of code loads data into the 'kindergardenDataSet.hogim' table. You can move, or remove it, as needed.
            this.hogimTableAdapter.Fill(this.kindergardenDataSet.hogim);
            // TODO: This line of code loads data into the 'kindergardenDataSet.kitot' table. You can move, or remove it, as needed.
            this.kitotTableAdapter.Fill(this.kindergardenDataSet.kitot);
          
            currentTime = DateTime.Now;
           //הגדרת FROM
           int maxYearFrom = Convert.ToInt32(currentTime.Year.ToString()) + 1;
           DateTime maxFrom = new DateTime(maxYearFrom, currentTime.Month, currentTime.Day);
           this.dateTimePicker_from.MaxDate = maxFrom;
           this.dateTimePicker_from.MinDate = currentTime;

            //הגדרת TO
           int maxYearTo = Convert.ToInt32(currentTime.Year.ToString()) + 2;
           int minDayTo = Convert.ToInt32(currentTime.Day.ToString()) + 1;
           DateTime minTo = new DateTime(currentTime.Year, currentTime.Month, minDayTo);
           DateTime maxTo = new DateTime(maxYearTo, currentTime.Month, currentTime.Day);
           this.dateTimePicker_to.MaxDate = maxTo;
           this.dateTimePicker_to.MinDate = minTo;
            //אתחול שעון
           this.hourOfStarting.Value.Add(currentTime.TimeOfDay);
           classesDS = kindergardenDataSet.kitot;

           for (int i = 0; i < classesDS.Rows.Count; i++)
           {
               cbl_participatingClasses.Items.Add(classesDS[i]["name"]);


           }

           hogimDT = kindergardenDataSet.hogim;
           for (int i = 0; i < hogimDT.Rows.Count; i++)
           {
               cb_hogim.Items.Add(hogimDT.Rows[i]["name"]);
           }




            //DataTable search = new DataTable();
            //search.Columns.Add("name");
            //for (int i = 0; i < classesDS.Columns.Count; i++)
            //{
            //    search.Rows.Add(classesDS[i][0]);

            //    cbl_participatingClasses.Items.Add(classesDS[i][0]);
            //}



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         bool bl_add = true;
        bool bl_update = false;
        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (bl_add)
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = con;
                if (txt_name.Text == "" || txt_lN.Text == "" || comboBox_dayAWeek.Text == "" || comboBox_oneMeetingLength.Text == ""||bl_fromChanged==false||bl_toChanged==false||bl_timeChanged==false)
                {
                    MessageBox.Show(" Please fill all the neccessery information");
                }
                if (dateTimePicker_from.Value.Month.CompareTo(dateTimePicker_to.Value.Month) == 1 || (dateTimePicker_from.Value.Day.CompareTo(dateTimePicker_to.Value.Day) == 1 && dateTimePicker_from.Value.Month.CompareTo(dateTimePicker_to.Value.Month) == 0) || dateTimePicker_from.Value.Year.CompareTo(dateTimePicker_to.Value.Year)==1)
                {
                    MessageBox.Show("Please check again the dates.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bool bl_dayCheck=false;
                for(int i=0;i<comboBox_dayAWeek.Items.Count &&!bl_dayCheck;i++)
                {
                    if (comboBox_dayAWeek.Items[i].Equals(comboBox_dayAWeek.Text))
                    {
                        bl_dayCheck=true;
                    }
                }
                if (!bl_dayCheck)
                {
                    MessageBox.Show("Please select again a day.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bool bl_hourCheck = false;
                for (int i = 0; i < comboBox_oneMeetingLength.Items.Count && !bl_hourCheck; i++)
                {
                    if (comboBox_oneMeetingLength.Items[i].Equals(comboBox_oneMeetingLength.Text))
                    {
                        bl_hourCheck = true;
                    }
                }
                if (!bl_hourCheck)
                {
                    MessageBox.Show("Please select again a meeting length.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < hogimDT.Rows.Count && bl_existing; i++)
                    {
                        string c = txt_name.Text;
                        string cc = hogimDT.Rows[i]["name"].ToString();
                        if (c == cc)
                        {
                            bl_existing = false;
                            MessageBox.Show("This course have been added before.");
                        }

                    }
                    if (bl_existing)
                    {

                        DialogResult res = new DialogResult();
                        res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            cmd.CommandText = "INSERT into hogim ([name],[from],[to],[Participating classes],[Lecturer's name],[Day a week],[starting hour],[one meeting length]) VALUES ('" + txt_name.Text + "' ,'" + dateTimePicker_from.Text + "','" + dateTimePicker_to.Text + "','" + kitot + "','" + txt_lN.Text + "','" + comboBox_dayAWeek.Text + "','" + hourOfStarting.Text + "','" + comboBox_oneMeetingLength.Text + "')";

                            con.Open();

                            cmd.ExecuteNonQuery();
                            con.Close();
                            this.kitotTableAdapter.Fill(this.kindergardenDataSet.kitot);
                            dataGridView_hogim.Refresh();
                            cb_hogim.Items.Clear();
                            FormHogim_Load(sender, e);
                            btn_rf_Click(sender, e);
                            MessageBox.Show("The course has been successfully added");


                        }
                    }
                }
            }
            if (bl_update)
            {
                for (int i = 0; i < hogimDT.Rows.Count && bl_existing; i++)
                {
                    string c = hogimDT.Rows[i]["name"].ToString();
                    string cc = txt_name.Text;
                    if (c.Equals(cc))
                    {
                        DialogResult res2 = new DialogResult();
                        res2 = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res2 == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE hogim SET [name]='" + txt_name.Text + "', [from]='" + dateTimePicker_from.Text + "',[to]='" + dateTimePicker_to.Text + "',[lecturer's name]='" + txt_lN.Text + "',[day a week]='" + comboBox_dayAWeek.Text + "',[one meeting length]='" + comboBox_oneMeetingLength.Text + "' where [name]='"+txt_name.Text+"'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("The course has been successfully updated ");
                        }

                    }
                }



                txt_name.Text = "";
                txt_lN.Text = "";
                comboBox_dayAWeek.Text = "";
                comboBox_oneMeetingLength.Text = "";
                kitot = "";
                btn_rf_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bool bl=false;
           // DataTable Mo = new DataTable();
           // OleDbDataAdapter da = new OleDbDataAdapter("select name from hogim", con);
           // da.Fill(Mo);
           //int count = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

           //for (int i = 0; i < count-1; i++)
           //{
               //txt_changeName.Text == Mo.Rows[i][0].ToString())
              
                    //OleDbCommand cmd = new OleDbCommand();
                    //cmd.Connection = con;
                    //cmd.CommandText = "Delete from hogim where name='" + txt_changeName.Text + "'";
                    //con.Open();
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    
                    //txt_changeName.Text = "";
                    //btn_rf_Click(sender, e);
                //}

            //if(bl)
                //{
                //    OleDbCommand cmd = new OleDbCommand();
                //    cmd.Connection = con;
                //    cmd.CommanMoext = "Delete from hogim where name='" + txt_changeName.Text + "'";
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //    button1_Click(sender, e);
                //}
            //} MessageBox.Show("name doesn't exist");
        }
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_dsr_Click(object sender, EventArgs e)
        {
          
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnt_show_Click(object sender, EventArgs e)
        {
            dataGridView_hogim.Visible = true;
           
        }

        private void txt_pC_TextChanged(object sender, EventArgs e)
        {

        }
       private void selectedCellsButton_Click(object sender, System.EventArgs e)
       {
       }

        public string name { get; set; }

        private void btn_rf_Click(object sender, EventArgs e)
        {
            cb_hogim.Text = "";
            txt_name.Text = "";
            txt_lN.Text = "";
            comboBox_dayAWeek.Text = "";
            kitot = "";
            btn_add.Enabled = true;
            txt_from.Text= "";
            txt_to.Text = "";
            txt_from.Visible = false;
            txt_to.Visible = false;
            comboBox_oneMeetingLength.Text = "";
            txt_name.Enabled = true;
            this.hourOfStarting.Value = currentTime;
            this.hogimTableAdapter.Fill(this.kindergardenDataSet.hogim);
            cbl_participatingClasses.Items.Clear();
            for (int i = 0; i < classesDS.Rows.Count; i++)
            {
                cbl_participatingClasses.Items.Add(classesDS[i]["name"]);


            }
            cb_hogim.Items.Clear();
            for (int i = 0; i < hogimDT.Rows.Count; i++)
            {
                cb_hogim.Items.Add(hogimDT.Rows[i]["name"]);
            }

        }
        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        //הצגת טבלאת חיפוש
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            search.Columns.Add("name");
            search.Columns.Add("from");
            search.Columns.Add("to");
            search.Columns.Add("participating classes");
            search.Columns.Add("lecturer's name"); 
            search.Columns.Add("day a week");
            search.Columns.Add("starting hour");
            search.Columns.Add("one meeting length");
            

            for (int i = 0; i < hogimDT.Rows.Count; i++)
            {
                for (int j = 0; j < hogimDT.Columns.Count; j++)
                {

                    if (hogimDT.Rows[i][j].ToString().Contains(txt_search.Text))
                    {
                        pnl_results.Visible = true;

                        search.Rows.Add(hogimDT[i][0], hogimDT[i][1], hogimDT[i][2], hogimDT[i][3], hogimDT[i][4], hogimDT[i][5], hogimDT[i][6], hogimDT[i][7]);
                        j = search.Columns.Count;
                    }
                    dataGridView_search.DataSource = search;
                }

            }
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }
        //סגירת טבלאת חיפוש
        private void btn_closeResults_Click(object sender, EventArgs e)
        {
            pnl_results.Visible = false;
            txt_search.Text = "";
        }
        
        string pc = "";

        //בחירת חוג לעדכון
        bool bl = false;
        private void cb_hogim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_from.Visible = true;
            txt_to.Visible = true;
            
            hourOfStarting.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["starting hour"].ToString();
            txt_name.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["name"].ToString();
            txt_lN.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["lecturer's name"].ToString();
            comboBox_dayAWeek.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["day a week"].ToString();
            comboBox_oneMeetingLength.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["one meeting length"].ToString();
            pc = hogimDT.Rows[cb_hogim.SelectedIndex]["participating classes"].ToString();
            txt_from.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["from"].ToString();
            txt_to.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["to"].ToString();
            //dateTimePicker_from.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["from"].ToString();
            //MessageBox.Show(hogimDT.Rows[cb_hogim.SelectedIndex]["from"].ToString());
            //dateTimePicker_to.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["to"].ToString();
            txt_name.Enabled = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            bl_update = true;
            bl_add = false;
            //btn_delete.Enabled = true;
            //while (bl)
            //{
            //    for (int i = 0; i < hogimDT.Rows.Count; i++)
            // {
            //     if (kitot.Contains(cbl_participatingClasses.Items[i].ToString()))
            //     { }
            // }
            //}


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
              //MessageBox.Show(cbl_participatingClasses.GetItemChecked(1).ToString()); 
            
            //MessageBox.Show(cbl_participatingClasses.SelectedItem.ToString());
              //string participatingClasses = "";
              //for (int i = 0; i < classesDS.Rows.Count; i++)
              //{
              //    if (cbl_participatingClasses.GetItemChecked(i))
              //    {
              //        participatingClasses = participatingClasses + cbl_participatingClasses.SelectedItems.ToString();
              //    }


              //}

            MessageBox.Show(dateTimePicker_from.Value.Month.CompareTo(dateTimePicker_to.Value.Month).ToString());
               
               
        }
        string kitot = "";

        private void cbl_participatingClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            kitot = kitot +'\n' +cbl_participatingClasses.SelectedItem.ToString();
           
        }
       
        private void hourOfStarting_ValueChanged(object sender, EventArgs e)
        {
            bl_timeChanged = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hogimBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        
        //private void cb_hogim_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    hourOfStarting.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["starting hour"].ToString();
        //    txt_name.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["name"].ToString();
        //    txt_lN.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["lecturer's name"].ToString();
        //    comboBox_dayAWeek.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["day a week"].ToString();
        //    comboBox_oneMeetingLength.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["one meeting length"].ToString();
        //    pc = hogimDT.Rows[cb_hogim.SelectedIndex]["participating classes"].ToString();
        //    dateTimePicker_from.Value =
        //      MessageBox.Show(hogimDT.Rows[cb_hogim.SelectedIndex]["from"].ToString());
        //    dateTimePicker_to.Text = hogimDT.Rows[cb_hogim.SelectedIndex]["to"].ToString();

        //    while (bl)
        //    {
        //        for (int i = 0; i < hogimDT.Rows.Count; i++)
        //        {
        //            if (kitot.Contains(cbl_participatingClasses.Items[i].ToString()))
        //            { }
        //        }
        //    }



        //}

        //כפתור הוספת קורס חדש 
        private void btn_add_Click(object sender, EventArgs e)
        {
            bl_update = false;
            bl_add = true;
            txt_name.Text = "";
            txt_lN.Text = "";
            comboBox_dayAWeek.Text = "";
            kitot = "";
        }

        //בדיקת תקינות
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שם חוג
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_lN_KeyPress(object sender, KeyPressEventArgs e)//בדיקת תקינות שם מרצה
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only chars.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool bl_no=true;
        //כפתור מחיקה
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hogimDT.Rows.Count && bl_existing && bl_no; i++)
            {
                string name1 = hogimDT.Rows[i]["name"].ToString();
                string name2 = txt_name.Text;
                if (name1.Equals(name2))
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        OleDbCommand cmd_delete = new OleDbCommand("delete from hogim where name='" + txt_name.Text + "'", con);

                        con.Open();
                        cmd_delete.ExecuteNonQuery();
                        con.Close();
                        cb_hogim.Items.Clear();
                      FormHogim_Load(sender, e);
                        btn_rf_Click(sender, e);
                        MessageBox.Show("The course has been removed successfully.");

                    }
                    else if (result == DialogResult.No)
                    {
                        bl_no = true;
                    }

                    else
                    {
                        if (txt_name.Text == "")
                        {
                            MessageBox.Show("Please choose a course first.");
                            bl_no = true;
                        }
                        //else
                        //{
                        //    MessageBox.Show("This course doesn't exist");
                        //}

                    }
                    //bl_no = true;
                    bl_existing = true;
                }
            }
        }

        private void pnl_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_sadot_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            bl_fromChanged = true;
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            bl_toChanged = true;
        }

        private void dateTimePicker_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_from.Visible = false;
        }

        private void dateTimePicker_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_to.Visible = false;
        }

        private void comboBox_dayAWeek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_up_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {

        }

     
  }
}
   
   

