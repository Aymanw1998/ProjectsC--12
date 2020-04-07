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
    public partial class SapakForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        HospitalDataSet.SapakDataTable dt;
        OleDbCommand cmd = new OleDbCommand();
        bool Search;
        bool inProgress;
        bool Accept = true;
        bool add = true;
        TextBox[] textBoxsArray;
        Label[] hintsArray;
        Label[] labelsArray;
        Button btn; string zh;

        public SapakForm(Button btnClicked, string Zhot)
        {
            InitializeComponent(); zh=Zhot;
            btn = btnClicked;
            textBoxsArray = new TextBox[] {txtMispar,txtShem, txtTelephone, txtEmail, txtKtovet, txtCity};
            hintsArray = new Label[] { hintMispar, hintShem, hintTelephone, hintEmail, hintKtovet, hintCity};
            labelsArray = new Label[] { lblMispar, lblShem, lblTelephone, lblEmail, lblKtovet, lblCity };
        }


        //                  בפתיחת הפורם
        private void SapakForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Sapak' table. You can move, or remove it, as needed.
            this.sapakTableAdapter.Fill(this.hospitalDataSet.Sapak);
            
            MainForm frm = new MainForm(zh);
            dt = hospitalDataSet.Sapak;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridViewResult.Columns.Add(dataGridView.Columns[i].Name, dataGridView.Columns[i].HeaderText);
            }

            comboSearch.SelectedIndex = 0;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                comboSearch.Items.Add(dataGridView.Columns[i].HeaderText);
            }

            lblData.Text += btn.Text;
            SapakForm_SizeChanged(sender, e); 
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

                                    for (int z = 0; z < textBoxsArray.Length; z++)
                                    {
                                        row[z] = dt.Rows[i][z].ToString();
                                    }
                                    dataGridViewResult.Rows.Add(row);
                                    dataGridViewResult.Rows[0].Selected = true;
                                }
                            }
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
                                    for (int z = 0; z < textBoxsArray.Length; z++)
                                    {
                                        textBoxsArray[z].Text = dt.Rows[i][z].ToString();
                                    }
                                }
                            }
                            dataGridViewResult.Select();
                            Search = false;
                            pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);
                            lblSearchQuantity.Text = btn.Text + ": 1 מתוך 1";

                            splHalf.Visible = false;
                            pnlResultButtons.Visible = false;
                        }
                        SapakForm_SizeChanged(sender, e);
                    }
                }
                else
                    MessageBox.Show("הקש בבקשה " + comboSearch.Text + " כדי לחפש");
            }
            else
                MessageBox.Show("בחר חיפוש לפי");

        }


        //                 אזור הפעולות 
        private void btnAdd_Click(object sender, EventArgs e) // כפתור ההוספה
        {
            add = true;

            if (Search)
                btnCloseSrch.PerformClick();

            if (Accept)
            {
                inProgress = true;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnUpdate.Enabled = false;
                comboSearch.Enabled = false;
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;

                ClearAll();

                btnAccept.Visible = true;
                btnCancel.Visible = true;
                textBoxsArray[0].Focus();

                ReadOnlyAll();

                bool found = false;
                bool bl = false;
                int max = 0;
                string s = "";

                for (int i = 0; i < dt.Rows.Count + 1 && bl != true; i++)
                {
                    found = false;
                    for (int k = 0; k < dt.Rows.Count && bl != true; k++)
                    {
                        if (i + 1 == int.Parse(dt.Rows[k][0].ToString()))
                            found = true;
                    }

                    if (found == false)
                    {
                        max = i + 1;
                        bl = true;
                    }
                }

                for (int z = 0; z < 7 - (max.ToString().Length); z++)
                {
                    s += "0";
                }
                s += max.ToString();

                txtMispar.Text = s;
            }
            else
            {
                bool detailsAreOk = true;
                //                בדיקה כללית
                for (int i = 1; i < hintsArray.Length; i++)
                {
                    if (textBoxsArray[i].Text == "" && i != 2 && i != 3)
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

               
                if (txtTelephone.Text.Length != 10 && txtTelephone.Text.Length != 0)
                {
                    hintTelephone.Text = "מספר טלפון מכיל 10 מספרים";
                    hintTelephone.Visible = true;
                    detailsAreOk = false;
                }
                else
                {
                    if (txtTelephone.Text == "")
                    {
                        hintTelephone.Text = "הקש מספר טלפון בבקשה";
                        hintTelephone.Visible = true;
                        detailsAreOk = false;
                    }
                    else
                        hintTelephone.Visible = false;
                }

                int count1 = 0, count2 = 0;
                for (int i = 0; i < txtEmail.Text.Length; i++)
                {
                    if (txtEmail.Text[i] == '@')
                        count1++;
                    if (txtEmail.Text[i] == '.')
                        count2++;
                }

                if (txtEmail.Text != "")
                {
                    if (count1 != 1 || count2 == 0)
                    {
                        hintEmail.Text = "אמייל אינו חוקי";
                        hintEmail.Visible = true;
                        detailsAreOk = false;
                    }
                    else                      
                            hintEmail.Visible = false;
                }
                else
                {
                    hintEmail.Text = "הקש אמייל בבקשה";
                    hintEmail.Visible = true;
                    detailsAreOk = false;
                }

                if (detailsAreOk)
                {
                    cmd.CommandText = "INSERT INTO " + dt.TableName + " (";

                    for (int i = 0; i < dt.Columns.Count - 1; i++)
                    {
                        cmd.CommandText += dt.Columns[i].ColumnName + ", ";
                    }

                    cmd.CommandText += "[" + dt.Columns[dt.Columns.Count - 1].ColumnName + "]" + ") VALUES (";

                    for (int i = 0; i < textBoxsArray.Length - 1; i++)
                    {
                        cmd.CommandText += "'" + textBoxsArray[i].Text + "',";

                    }
                    cmd.CommandText += "'" + textBoxsArray[textBoxsArray.Length - 1].Text + "')";
                    cmd.Connection = con;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    comboSearch.SelectedIndex = 0;
                    this.sapakTableAdapter.Fill(this.hospitalDataSet.Sapak);
                    dataGridView.Refresh();

                    if (Search == true)
                        btnSearch_Click(sender, e);

                    if (comboSearch.SelectedIndex != 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            txtSearch.AutoCompleteCustomSource.Add(dt.Rows[i][comboSearch.SelectedIndex - 1].ToString());
                        }
                    }

                    MessageBox.Show("הוספת ספק בהצלחה");
                    ClearAll();
                    HintsClear();
                    ReadOnlyAll();

                    btnAccept.Visible = false;
                    btnCancel.Visible = false;

                    btnAdd.Enabled = true;
                    btnDel.Enabled = true;
                    btnUpdate.Enabled = true;

                    comboSearch.Enabled = true;
                    txtSearch.Enabled = true;
                    btnSearch.Enabled = true;

                    textBoxsArray[0].ReadOnly = true;
                    inProgress = false;
                }

                detailsAreOk = true;
                Accept = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) // כפתור הרענן
        {
            this.sapakTableAdapter.Fill(this.hospitalDataSet.Sapak);
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
                                cmd.CommandText = "DELETE FROM " + dt.TableName + " WHERE " + dt.Columns[0].ColumnName + "='" + textBoxsArray[0].Text + "'";
                                cmd.Connection = con;

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                found = true;
                                this.sapakTableAdapter.Fill(this.hospitalDataSet.Sapak);
                                dataGridView.Refresh();

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
            if (textBoxsArray[0].Text != "")
            {
                if (Accept)
                {                 
                    inProgress = true;
                    btnClean.Enabled = false;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    comboSearch.Enabled = false;
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                    textBoxsArray[1].Focus();

                    btnAccept.Visible = true;
                    btnCancel.Visible = true;

                    ReadOnlyAll();
                }
                else
                {
                    bool detailsAreOk = true;

                    //                בדיקה כללית
                    for (int i = 1; i < hintsArray.Length; i++)
                    {
                        if (textBoxsArray[i].Text == "" && i != 2 && i != 3)
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

                    if (txtTelephone.Text.Length != 10 && txtTelephone.Text.Length != 0)
                    {
                        hintTelephone.Text = "מספר טלפון מכיל 10 מספרים";
                        hintTelephone.Visible = true;
                        detailsAreOk = false;
                    }
                    else
                    {
                        if (txtTelephone.Text == "")
                        {
                            hintTelephone.Text = "הקש מספר טלפון בבקשה";
                            hintTelephone.Visible = true;
                            detailsAreOk = false;
                        }
                        else
                            hintTelephone.Visible = false;
                    }

                    int count1 = 0, count2 = 0;
                    for (int i = 0; i < txtEmail.Text.Length; i++)
                    {
                        if (txtEmail.Text[i] == '@')
                            count1++;
                        if (txtEmail.Text[i] == '.')
                            count2++;
                    }

                    if (txtEmail.Text != "")
                    {
                        if (count1 != 1 || count2 == 0)
                        {
                            hintEmail.Text = "אמייל אינו חוקי";
                            hintEmail.Visible = true;
                            detailsAreOk = false;
                        }
                        else
                            hintEmail.Visible = false;
                    }
                    else
                    {
                        hintEmail.Text = "הקש אמייל בבקשה";
                        hintEmail.Visible = true;
                        detailsAreOk = false;
                    }
                   
                    if (detailsAreOk)
                    {
                        cmd.CommandText = "UPDATE " + dt.TableName + " Set ";
                        for (int i = 1; i < textBoxsArray.Length - 1; i++)
                        {
                            cmd.CommandText += dt.Columns[i].ColumnName + "='" + textBoxsArray[i].Text + "', ";
                        }
                        cmd.CommandText += "[" + dt.Columns[textBoxsArray.Length - 1].ColumnName + "]" + "='" + textBoxsArray[textBoxsArray.Length - 1].Text + "'";
                        cmd.CommandText += " WHERE " + dt.Columns[0].ColumnName + "='" + textBoxsArray[0].Text + "'";
                        cmd.Connection = con;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.sapakTableAdapter.Fill(this.hospitalDataSet.Sapak);
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

                        MessageBox.Show("עדכנתה ספק בהצלחה");

                        btnAccept.Visible = false;
                        btnCancel.Visible = false;

                        btnAdd.Enabled = true;
                        btnUpdate.Enabled = true;

                        btnClean.Enabled = true;
                        comboSearch.Enabled = true;
                        txtSearch.Enabled = true;
                        btnSearch.Enabled = true;

                        ReadOnlyAll();
                        Accept = true;
                        inProgress = false;
                    }
                }
            }
            else
                MessageBox.Show("חפש " + btn.Text);

            textBoxsArray[0].ReadOnly = true;
        }


        //                כפתורי ההרשאה
        private void btnAccept_Click(object sender, EventArgs e) // כפתור האישור
        {
            Accept = false;
            if (add)
                btnAdd_Click(sender, e);
            else
                btnUpdate_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e) // כפתור הביטול
        {
            Accept = true;
            inProgress = false;

            if (add)
                ClearAll();
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (textBoxsArray[0].Text == dt.Rows[i][0].ToString())
                    {
                        for (int z = 0; z < textBoxsArray.Length; z++)
                        {
                            textBoxsArray[z].Text = dt.Rows[i][z].ToString();
                        }
                    }
                }
            }

            HintsClear();
            ReadOnlyAll();

            btnClean.Enabled = true;
            comboSearch.Enabled = true;
            txtSearch.Enabled = true;
            btnSearch.Enabled = true;
            textBoxsArray[0].ReadOnly = true;

            btnAccept.Visible = false;
            btnCancel.Visible = false;

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
        }


        //              כשהפורם משנה גודל
        private void SapakForm_SizeChanged(object sender, EventArgs e)
        {
            pnlTables.Size = new Size(pnlTables.Width, Convert.ToInt32(this.Height * 0.4));
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
            int a = dataGridViewResult.CurrentCell.RowIndex;

            lblSearchQuantity.Text = btn.Text + ": " + (a + 1).ToString() + " מתוך " + (dataGridViewResult.Rows.Count - 1);

            if (a < dataGridViewResult.RowCount - 1 && !inProgress)
            {
                for (int i = 0; i < textBoxsArray.Length; i++)
                {
                    textBoxsArray[i].Text = dataGridViewResult.Rows[a].Cells[i].Value.ToString();
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

        private void ReadOnlyAll()
        {
            for (int i = 1; i < textBoxsArray.Length; i++)
                textBoxsArray[i].ReadOnly = !textBoxsArray[i].ReadOnly;
        }

        private void HintsClear()
        {
            for (int i = 0; i < hintsArray.Length; i++)
                hintsArray[i].Visible = false;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.RowIndex < dataGridView.RowCount - 1)
            {
                if (!inProgress)
                {
                    for (int i = 0; i < textBoxsArray.Length; i++)
                        textBoxsArray[i].Text = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[i].Value.ToString();
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

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

    }
}
