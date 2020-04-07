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

namespace WindowsFormsApplication1
{
    public partial class MishmarotForm : Form
    {
         private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        HospitalDataSet.MishmarotDataTable dt;
        OleDbCommand cmd = new OleDbCommand();
        bool Search;
        bool inProgress;
        bool Accept = true;
        bool add = true;
        TextBox[] textBoxsArray;
        Label[] hintsArray;
        Label[] labelsArray;
        Button btn; string zh;

        public MishmarotForm(Button btnClicked, string Zhot)
        {
            InitializeComponent(); zh=Zhot;
            btn = btnClicked;
            dt = hospitalDataSet.Mishmarot;
            textBoxsArray = new TextBox[] { txtZhot, txtStartDate, txtStart, txtEndDate, txtEnd };
            hintsArray = new Label[] { hintZhot, hintStartDate, hintStart, hintEndDate, hintEnd };
            labelsArray = new Label[] { lblZhot, lblStartDate, lblStart, lblEndDate, lblEnd };
        }


        //                  בפתיחת הפורם
        private void MishmarotForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);
            MainForm frm = new MainForm(zh);

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridViewResult.Columns.Add(dataGridView.Columns[i].Name, dataGridView.Columns[i].HeaderText);
            }

            comboSearch.SelectedIndex = 0;
            dt = hospitalDataSet.Mishmarot;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                comboSearch.Items.Add(dataGridView.Columns[i].HeaderText);
            }

            lblData.Text += btn.Text;
            MishmarotForm_SizeChanged(sender, e);

            dateEnd.MaxDate = DateTime.Now;
            dateStart.MaxDate = DateTime.Now;
        }


        //                  אזור החיפוש
        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e) // בחירת החיפוש 
        {

            txtSearch.AutoCompleteCustomSource.Clear();
            if (comboSearch.SelectedIndex != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtSearch.AutoCompleteCustomSource.Add(dt.Rows[i][comboSearch.SelectedIndex - 1].ToString());
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) // שם החיפוש
        {
            ClearAll();
            pnlResult.Visible = false;
            pnlResultButtons.Visible = false;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) // לחיצת ENTER
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e) // כפתור החיפוש
        {
            dataGridViewResult.Rows.Clear();

            int count = 0;
            bool found = false;

            if (comboSearch.SelectedIndex != 0)
            {
                if (txtSearch.Text != "")
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtSearch.Text == dt.Rows[i][comboSearch.SelectedIndex - 1].ToString())
                        {
                            count++;
                            found = true;
                        }
                    }

                    if (found == false)
                        MessageBox.Show("לא נמצא");


                    if (found)
                    {
                        if (count > 1)
                        {
                            pnlResult.Visible = true;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (txtSearch.Text == dt.Rows[i][comboSearch.SelectedIndex - 1].ToString())
                                {
                                    string[] row = new string[textBoxsArray.Length];

                                    for (int z = 0; z < 3; z++)
                                    {
                                        row[z] = dt.Rows[i][z].ToString();
                                    }
                                    dataGridViewResult.Rows.Add(row);
                                    dataGridViewResult.Rows[0].Selected = true;
                                }
                            }
                            dataGridViewResult.Select();
                            Search = true;
                            pnlData.Size = new Size((pnlTables.Width / 2) - 1, pnlData.Size.Height);
                            lblSearchQuantity.Text = btn.Text + ": 1 מתוך" + " " + count.ToString();
                            splHalf.Visible = true;
                            pnlResultButtons.Visible = true;
                        }
                        else
                        {
                            pnlResult.Visible = false;

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (txtSearch.Text == dt.Rows[i][comboSearch.SelectedIndex - 1].ToString())
                                {
                                    textBoxsArray[0].Text = dt.Rows[i][0].ToString();

                                    if (dt.Rows[i][1].ToString() != "")
                                    {
                                        DateTime dtS = Convert.ToDateTime(dt.Rows[i][1].ToString());
                                        textBoxsArray[1].Text = dtS.ToString(@"dd\/MM\/yyyy");
                                        dateStart.Value = dtS;
                                        textBoxsArray[2].Text = dtS.ToString(@"HH:mm:ss");
                                        timeStart.Text = dtS.ToString(@"HH:mm:ss");
                                    }

                                    if (dt.Rows[i][2].ToString() != "")
                                    {
                                        DateTime dtE = Convert.ToDateTime(dt.Rows[i][2].ToString());
                                        textBoxsArray[3].Text = dtE.ToString(@"dd\/MM\/yyyy");
                                        dateEnd.Value = dtE;
                                        textBoxsArray[4].Text = dtE.ToString(@"HH:mm:ss");
                                        timeEnd.Text = dtE.ToString(@"HH:mm:ss");
                                    }
                                }
                            }
                            
                            Search = false;
                            pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);
                            lblSearchQuantity.Text = btn.Text + ": 1 מתוך 1";

                            splHalf.Visible = false;
                            pnlResultButtons.Visible = false;
                        }
                        MishmarotForm_SizeChanged(sender, e);
                    }
                }
                else
                    MessageBox.Show("הקש בבקשה " + comboSearch.Text + " כדי לחפש");
            }
            else
                MessageBox.Show("בחר חיפוש לפי");

        }


        //                 אזור הפעולות 
        private void btnRefresh_Click(object sender, EventArgs e) // כפתור הרענן
        {
            this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);;
            dataGridView.Refresh();
        }

        private void btnDel_Click(object sender, EventArgs e) // כפתור המחק
        {
            bool found = false;

            if (!inProgress)
            {
                if (textBoxsArray[0].Text != "")
                {
                    if (MessageBox.Show("האם אתה מעוניין למחוק?", "הערה", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (textBoxsArray[0].Text == dt.Rows[i][0].ToString())
                            {
                                cmd.CommandText = "DELETE FROM " + dt.TableName + " WHERE " + dt.Columns[0].ColumnName + "='" + textBoxsArray[0].Text + "' AND " + dt.Columns[1].ColumnName + "='" + textBoxsArray[1].Text + " " + textBoxsArray[2].Text + "'";
                                cmd.Connection = con;

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                found = true;
                                this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);;
                                dataGridView.Refresh();
                                MessageBox.Show("מחקתה משמרת בהצלחה");
                                if (Search == true)
                                    btnSearch_Click(sender, e);

                                if (comboSearch.SelectedIndex != 0)
                                {
                                    for (int z = 0; z < dt.Rows.Count; z++)
                                    {
                                        txtSearch.AutoCompleteCustomSource.Add(dt.Rows[z][comboSearch.SelectedIndex - 1].ToString());
                                    }
                                }

                                txtSearch.Clear();
                                ClearAll();
                            }

                        }
                        if (found == false)
                        {
                            MessageBox.Show("המספר אינו קיים", "הערה");
                        }
                    }
                }
                else
                    MessageBox.Show("מלא פרטים בבקשה");
            }
            else
                MessageBox.Show("סיים את עדכון הפרטים");


        }

        private void btnUpdate_Click(object sender, EventArgs e) // כפתור העדכון
        {
            add = false;
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Now;
            if (textBoxsArray[0].Text != "")
            {
                if (Accept)
                {
                    radioButtonStart.Checked = true;
                    radioButtonStart.Visible = true;
                    radioButtonEnd.Visible = true;
                    dateStart.Enabled = true;
                    dateEnd.Enabled = false;
                    timeStart.Enabled = true;
                    timeEnd.Enabled = false;
                    inProgress = true;
                    btnClean.Enabled = false;
                    btnUpdate.Enabled = false;
                    comboSearch.Enabled = false;
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                    txtStartDate.Focus();

                    btnAccept.Visible = true;
                    btnCancel.Visible = true;
                }
                else
                {
                    bool detailsAreOk = true;

                    //                בדיקה כללית

                    d1 = Convert.ToDateTime(txtStart.Text + " " + txtStartDate.Text);

                    if (txtEnd.Text + " " + txtEndDate.Text != "")
                    {
                        d2 = Convert.ToDateTime(txtEnd.Text + " " + txtEndDate.Text);

                        if (d2.Subtract(d1).TotalHours < 2)
                        {
                            MessageBox.Show("משמרת לפחות שעתיים");
                            detailsAreOk = false;
                        }
                    }

                    if (radioButtonStart.Checked)
                    {                      
                        for (int i = 1; i < hintsArray.Length; i++)
                        {
                            if (textBoxsArray[i].Text == "" && i != 3 && i != 4)
                            {
                                string s = "";
                                for (int z = 0; z < labelsArray[i].Text.Length - 1; z++)
                                {
                                    s += labelsArray[i].Text[z];
                                }
                                hintsArray[i].Text = "הקש בבקשה " + s;
                                hintsArray[i].Visible = true;
                                detailsAreOk = false;
                            }
                            else
                                hintsArray[i].Visible = false;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < hintsArray.Length; i++)
                        {                           
                            if (textBoxsArray[i].Text == "" && i!=1 && i!=2)
                            {
                                string s = "";
                                for (int z = 0; z < labelsArray[i].Text.Length - 1; z++)
                                {
                                    s += labelsArray[i].Text[z];
                                }
                                hintsArray[i].Text = "הקש בבקשה " + s;
                                hintsArray[i].Visible = true;
                                detailsAreOk = false;
                            }
                            else
                                hintsArray[i].Visible = false;
                        }
                    }
                              
                    if(detailsAreOk)
                    {
                        radioButtonStart.Visible = false;
                        radioButtonEnd.Visible = false;

                        cmd.CommandText = "UPDATE " + dt.TableName + " Set ";

                        if (radioButtonStart.Checked)
                        {
                            cmd.CommandText += dt.Columns[1].ColumnName + "='" + textBoxsArray[1].Text + " " + textBoxsArray[2].Text + "' ";
                            cmd.CommandText += " WHERE " + dt.Columns[0].ColumnName + "='" + textBoxsArray[0].Text + "' AND " + "[" + dt.Columns[2].ColumnName + "]" + "='" + textBoxsArray[3].Text + " " + textBoxsArray[4].Text + "'";
                        }
                        else
                        {
                            cmd.CommandText += "[" + dt.Columns[2].ColumnName + "]" + "='" + textBoxsArray[3].Text + " " + textBoxsArray[4].Text + "' ";
                            cmd.CommandText += " WHERE " + dt.Columns[0].ColumnName + "='" + textBoxsArray[0].Text + "' AND " + dt.Columns[1].ColumnName + "='" + textBoxsArray[1].Text + " " + textBoxsArray[2].Text + "'";
                        }                       
                        
                        cmd.Connection = con;
                        //textBox1.Text = cmd.CommandText;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.mishmarotTableAdapter.Fill(this.hospitalDataSet.Mishmarot);;
                        dataGridView.Refresh();

                        if (Search)
                            btnSearch_Click(sender, e);

                        if (comboSearch.SelectedIndex != 0)
                        {
                            for (int z = 0; z < dt.Rows.Count; z++)
                            {
                                txtSearch.AutoCompleteCustomSource.Add(dt.Rows[z][comboSearch.SelectedIndex - 1].ToString());
                            }
                        }

                        MessageBox.Show("עדכנתה משמרת בהצלחה");

                        btnAccept.Visible = false;
                        btnCancel.Visible = false;

                        btnUpdate.Enabled = true;

                        btnClean.Enabled = true;
                        comboSearch.Enabled = true;
                        txtSearch.Enabled = true;
                        btnSearch.Enabled = true;

                        txtZhot.ReadOnly = true;

                        ReadOnlyAll(false);
                        Accept = true;
                        inProgress = false;
                    }
                }
            }
            else
                MessageBox.Show("חפש " + btn.Text);

            txtZhot.ReadOnly = true;
        }


        //                כפתורי ההרשאה
        private void btnAccept_Click(object sender, EventArgs e) // כפתור האישור
        {
            Accept = false;
            btnUpdate_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e) // כפתור הביטול
        {
            radioButtonStart.Visible = false;
            radioButtonEnd.Visible = false;
            Accept = true;
            inProgress = false;

            if (add)
                ClearAll();
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (textBoxsArray[0].Text == dataGridView.Rows[i].Cells[0].ToString())
                    {
                        if (dataGridView.Rows[i].Cells[1].ToString() != "")
                        {
                            DateTime dtS = Convert.ToDateTime(dataGridView.Rows[i].Cells[1].ToString());
                            textBoxsArray[1].Text = dtS.ToString(@"dd\/MM\/yyyy");
                            dateStart.Value = dtS;
                            textBoxsArray[2].Text = dtS.ToString(@"HH:mm:ss");
                            timeStart.Text = dtS.ToString(@"HH:mm:ss");
                        }

                        if (dataGridView.Rows[i].Cells[2].ToString() != "")
                        {
                            DateTime dtE = Convert.ToDateTime(dataGridView.Rows[i].Cells[2].ToString());
                            textBoxsArray[3].Text = dtE.ToString(@"dd\/MM\/yyyy");
                            dateEnd.Value = dtE;
                            textBoxsArray[4].Text = dtE.ToString(@"HH:mm:ss");
                            timeEnd.Text = dtE.ToString(@"HH:mm:ss");
                        }
                    }
                }
            }

            HintsClear();
            ReadOnlyAll(false);

            btnClean.Enabled = true;
            comboSearch.Enabled = true;
            txtSearch.Enabled = true;
            btnSearch.Enabled = true;
            txtZhot.ReadOnly = true;

            btnAccept.Visible = false;
            btnCancel.Visible = false;

            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
        }


        //              כשהפורם משנה גודל
        private void MishmarotForm_SizeChanged(object sender, EventArgs e)
        {
            pnlTables.Size = new Size(pnlTables.Width, Convert.ToInt32( this.Height * 0.4));
            pnlResult.Size = new Size((pnlTables.Width / 2) - 1, pnlResult.Size.Height);

            if (Search)
                pnlData.Size = new Size((pnlTables.Width / 2) - 1, pnlData.Size.Height);
            else
                pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);
        }



        //                 אזור התוצאות
        private void btnCloseSrch_Click(object sender, EventArgs e) // כפתור סוגר התוצאות
        {
            comboSearch.SelectedIndex = 0;
            Search = false;
            pnlResult.Visible = false;
            pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);

            dataGridViewResult.Rows.Clear();
            ClearAll();

            pnlResultButtons.Visible = false;
            splHalf.Visible = false;

        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e) // שינוי בחירת התוצאה
        {
            ClearAll();
            int a = dataGridViewResult.CurrentCell.RowIndex;

            lblSearchQuantity.Text = btn.Text + ": " + (a + 1).ToString() + " מתוך " + (dataGridViewResult.Rows.Count - 1);

            if (a < dataGridViewResult.RowCount - 1 && !inProgress)
            {
                textBoxsArray[0].Text = dataGridView.Rows[dataGridViewResult.CurrentCell.RowIndex].Cells[0].Value.ToString();

                if (dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex].Cells[1].Value.ToString() != "")
                {
                    DateTime dtS = Convert.ToDateTime(dataGridView.Rows[dataGridViewResult.CurrentCell.RowIndex].Cells[1].Value.ToString());
                    textBoxsArray[1].Text = dtS.ToString(@"dd\/MM\/yyyy");
                    dateStart.Value = dtS;
                    textBoxsArray[2].Text = dtS.ToString(@"HH:mm:ss");
                    timeStart.Text = dtS.ToString(@"HH:mm:ss");
                }

                if (dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex].Cells[2].Value.ToString() != "")
                {
                    DateTime dtE = Convert.ToDateTime(dataGridView.Rows[dataGridViewResult.CurrentCell.RowIndex].Cells[2].Value.ToString());
                    textBoxsArray[3].Text = dtE.ToString(@"dd\/MM\/yyyy");
                    dateEnd.Value = dtE;
                    textBoxsArray[4].Text = dtE.ToString(@"HH:mm:ss");
                    timeEnd.Text = dtE.ToString(@"HH:mm:ss");
                }
            }

        }


        //                 כפתורי הזזה
        private void btnNext_Click(object sender, EventArgs e) // כפתור הבא
        {
            if (dataGridViewResult.CurrentCell.RowIndex != dataGridViewResult.Rows.Count - 2)
                dataGridViewResult.CurrentCell = dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex + 1].Cells[0];

            dataGridViewResult.FirstDisplayedScrollingRowIndex = dataGridViewResult.SelectedRows[0].Index;
            dataGridViewResult_SelectionChanged(sender, e);

        }

        private void btnPrevious_Click(object sender, EventArgs e) // כפתור הקודם
        {
            if (dataGridViewResult.CurrentCell.RowIndex != 0)
                dataGridViewResult.CurrentCell = dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex - 1].Cells[0];

            dataGridViewResult_SelectionChanged(sender, e);
        }

        private void btnLast_Click(object sender, EventArgs e) // כפתור האחרון
        {
            dataGridViewResult.CurrentCell = dataGridViewResult.Rows[dataGridViewResult.Rows.Count - 2].Cells[0];
            dataGridViewResult.FirstDisplayedScrollingRowIndex = dataGridViewResult.SelectedRows[0].Index;
            lblSearchQuantity.Text = btn.Text + ": " + (dataGridViewResult.Rows.Count - 1) + " מתוך " + (dataGridViewResult.Rows.Count - 1);
            dataGridViewResult_SelectionChanged(sender, e);
        }

        private void btnFirst_Click(object sender, EventArgs e) // כפתור הראשון
        {
            dataGridViewResult.CurrentCell = dataGridViewResult.Rows[0].Cells[0];
            dataGridViewResult.FirstDisplayedScrollingRowIndex = dataGridViewResult.SelectedRows[0].Index;
            lblSearchQuantity.Text = btn.Text + ": 1 מתוך" + (dataGridViewResult.Rows.Count - 1);
            dataGridViewResult_SelectionChanged(sender, e);
        }


        //              פעולות חיצוניות 
        private void ClearAll()
        {
            for (int i = 0; i < textBoxsArray.Length; i++)
                textBoxsArray[i].Clear();
        }

        private void ReadOnlyAll(bool t)
        {           
            dateStart.Enabled = t;
            dateEnd.Enabled = t;
            timeEnd.Enabled = t;
            timeStart.Enabled = t;
        }

        private void HintsClear()
        {
            for (int i = 0; i < hintsArray.Length; i++)
                hintsArray[i].Visible = false;
        }
  
   
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            ClearAll();
            if (dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1)
            {
                if (!inProgress)
                {
                    for (int i = 0; i < textBoxsArray.Length; i++)
                    {
                        textBoxsArray[0].Text = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                        if (dt.Rows[dataGridView.CurrentCell.RowIndex][1].ToString() != "")
                        {
                            DateTime dtS = Convert.ToDateTime(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
                            textBoxsArray[1].Text = dtS.ToString(@"dd\/MM\/yyyy");
                            dateStart.Value = dtS;
                            textBoxsArray[2].Text = dtS.ToString(@"HH:mm:ss");
                            timeStart.Text = dtS.ToString(@"HH:mm:ss");
                        }

                        if (dt.Rows[dataGridView.CurrentCell.RowIndex][2].ToString() != "")
                        {
                            DateTime dtE = Convert.ToDateTime(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                            textBoxsArray[3].Text = dtE.ToString(@"dd\/MM\/yyyy");
                            dateEnd.Value = dtE;
                            textBoxsArray[4].Text = dtE.ToString(@"HH:mm:ss");
                            timeEnd.Text = dtE.ToString(@"HH:mm:ss");
                        }
                    }
                }
                else 
                    MessageBox.Show("לא ניתן להוסיף כרגע");
            }              
        }
       
        private void btnClean_Click(object sender, EventArgs e)
        {
            pnlResultButtons.Visible = false;
            ClearAll();
            comboSearch.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            txtStartDate.Text = dateStart.Value.ToString(@"dd\/MM\/yyyyyy");
        }

        private void radioButtonStart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStart.Checked)
            {               
                dateStart.Enabled = true;
                dateEnd.Enabled = false;
                timeStart.Enabled = true;
                timeEnd.Enabled = false;
            }
        }

        private void radioButtonEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEnd.Checked)
            {              
                dateStart.Enabled = false;
                dateEnd.Enabled = true;
                timeStart.Enabled = false;
                timeEnd.Enabled = true;
            }
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = dateEnd.Value.ToString(@"dd\/MM\/yyyyyy");
        }

        private void timeStart_ValueChanged(object sender, EventArgs e)
        {
            txtStart.Text = timeStart.Text;
        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {
            txtEnd.Text = timeEnd.Text;
        }

      

    }
}
