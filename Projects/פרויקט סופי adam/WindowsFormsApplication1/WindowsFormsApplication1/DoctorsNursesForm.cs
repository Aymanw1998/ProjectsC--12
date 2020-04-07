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
    public partial class DoctorsNursesForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\פרויקט סופי adam\Hospital.mdb");
        HospitalDataSet.DoctorsNursesDataTable dt;
        OleDbCommand cmd = new OleDbCommand();
        bool Search;
        bool inProgress;
        bool Accept = true;
        bool add = true;
        TextBox[] textBoxsArray;
        Label[] hintsArray;
        Label[] labelsArray;
        Button btn; string zh;

        public DoctorsNursesForm(Button btnClicked, string Zhot)
        {
            InitializeComponent();
            zh=Zhot;
            btn = btnClicked;
            dt = hospitalDataSet.DoctorsNurses;          
            textBoxsArray = new TextBox[] { txtZhot, txtShem, txtMishpaha, txtBirthday, txtGil, txtGender, txtKtovet, txtCity, txtTafkid, txtMahot, txtTelephone, txtEmail, txtMaskort, txtPassword };
            hintsArray = new Label[] { hintZhot, hintShem, hintMishpaha, hintBirthday, hintGil, hintGender, hintKtovet, hintCity, hintTafkid, hintMahot, hintTelephone, hintEmail, hintMaskort, hintPassword };
            labelsArray = new Label[] { lblZhot, lblShem, lblMishpaha, lblBirthday, lblGil, lblGender, lblKtovet, lblCity, lblTafkid, lblMahot, lblTelephone, lblEmail, lblMaskort, lblPassword };
        }


        //                  בפתיחת הפורם
        private void DoctorsNursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.DoctorsNurses' table. You can move, or remove it, as needed.
            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
            MainForm frm = new MainForm(zh);;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridViewResult.Columns.Add(dataGridView.Columns[i].Name, dataGridView.Columns[i].HeaderText);
            }
            dataGridViewResult.Columns[dataGridView.Columns.Count - 1].Visible = false;

            comboSearch.SelectedIndex = 0;
            dt = hospitalDataSet.DoctorsNurses;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                comboSearch.Items.Add(dataGridView.Columns[i].HeaderText);
            }

            dateBirthday.MaxDate = DateTime.Now;
            lblData.Text += btn.Text;
            DoctorsNursesForm_SizeChanged(sender, e);
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
                        DoctorsNursesForm_SizeChanged(sender, e);
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
                txtZhot.Focus();

                ReadOnlyAll();
            }
            else
            {
                bool found = false, detailsAreOk = true;
 
                //                בדיקה כללית
                for (int i = 1; i < hintsArray.Length; i++)
                {
                    if (textBoxsArray[i].Text == "" && i != 3 && i != 4 && i!=10 && i!=11)
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

                if (txtZhot.Text.Length != 9 && txtZhot.Text.Length != 0)
                {
                    hintZhot.Text = "תעודת זהות אינה חוקית";
                    hintZhot.Visible = true;
                    detailsAreOk = false;
                }
                else
                {
                    if (txtZhot.Text == "")
                    {
                        hintZhot.Text = "הקש בבקשה תעודת זהות";
                        hintZhot.Visible = true;
                        detailsAreOk = false;
                    }
                    else
                    {
                        for (int i = 0; i < dt.Rows.Count && found != true; i++)
                        {
                            if (dt.Rows[i][0].ToString() == textBoxsArray[0].Text)
                                found = true;
                        }
                        if (found)
                        {
                            hintZhot.Text = "תעודת זהות כבר קיימת";
                            hintZhot.Visible = true;
                            detailsAreOk = false;
                        }
                        else
                            hintZhot.Visible = false;
                    }
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
                    
                if (txtBirthday.Text != "")
                {
                    if (int.Parse(txtGil.Text) < 25 || int.Parse(txtGil.Text) > 90)
                    {
                        hintGil.Text = "גילאים 90 - 25";
                        hintBirthday.Text = "תאריך לידה אינו חוקי";
                        hintGil.Visible = true;
                        hintBirthday.Visible = true;
                        detailsAreOk = false;
                    }
                    else
                    {
                        hintGil.Visible = false;
                        hintBirthday.Visible = false;
                    }
                }
                else
                {
                    hintGil.Visible = true;
                    hintBirthday.Visible = true;
                    detailsAreOk = false;
                    hintGil.Text = "הקש בבקשה את הגיל";
                    hintBirthday.Text = "הקש בבקשה את תאריך הלידה";
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
                        this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
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

                        MessageBox.Show("הוספת " + txtTafkid.Text + " בהצלחה");
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
            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
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
                                this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
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
                    if (txtBirthday.Text != "")
                    {
                        dateBirthday.Value = DateTime.Parse(txtBirthday.Text);
                        txtGil.Text = ((int)(DateTime.Now.Subtract(DateTime.Parse(txtBirthday.Text)).TotalDays / 365.25)).ToString();
                    }

                    inProgress = true;
                    btnClean.Enabled = false;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    comboSearch.Enabled = false;
                    txtSearch.Enabled = false;
                    btnSearch.Enabled = false;
                    txtShem.Focus();

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
                        if (textBoxsArray[i].Text == "" && i != 3 && i != 4 && i != 10 && i != 11)
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

                    if (txtBirthday.Text != "")
                    {
                        if (int.Parse(txtGil.Text) < 25 || int.Parse(txtGil.Text) > 90)
                        {
                            hintGil.Text = "גילאים 90 - 25";
                            hintBirthday.Text = "תאריך לידה אינו חוקי";
                            hintGil.Visible = true;
                            hintBirthday.Visible = true;
                            detailsAreOk = false;
                        }
                        else
                        {
                            hintGil.Visible = false;
                            hintBirthday.Visible = false;
                        }
                    }
                    else
                    {
                        hintGil.Visible = true;
                        hintBirthday.Visible = true;
                        detailsAreOk = false;
                        hintGil.Text = "הקש בבקשה את הגיל";
                        hintBirthday.Text = "הקש בבקשה את תאריך הלידה";
                    }

                    if(detailsAreOk)
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

                        this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
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

                        MessageBox.Show("עדכנתה " + txtTafkid.Text + " בהצלחה");

                        btnAccept.Visible = false;
                        btnCancel.Visible = false;

                        btnAdd.Enabled = true;
                        btnUpdate.Enabled = true;

                        btnClean.Enabled = true;
                        comboSearch.Enabled = true;
                        txtSearch.Enabled = true;
                        btnSearch.Enabled = true;

                        txtZhot.ReadOnly = true;

                        ReadOnlyAll();
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
            txtZhot.ReadOnly = true;

            btnAccept.Visible = false;
            btnCancel.Visible = false;

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;
        }


        //              כשהפורם משנה גודל
        private void DoctorsNursesForm_SizeChanged(object sender, EventArgs e)
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


        bool over;
        //             כפתור כדי להראות את הסיסמה
        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            over = true;
            txtPassword.Focus();
            btnShow.ForeColor = SystemColors.Window;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\5555.png");
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

            over = false;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\52882.png");
            btnShow.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\52882.png");
            btnShow.ForeColor = SystemColors.ControlDarkDark;
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            if (over == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Focus();
                btnShow.ForeColor = SystemColors.Window;
                btnShow.Image = new Bitmap(@"C:\Users\Comp-19\Desktop\פרויקט סופי adam\WindowsFormsApplication1\WindowsFormsApplication1\Resources\5555.png");
            }
        }


        //              פעולות חיצוניות 
        private void ClearAll()
        {
            for (int i = 0; i < textBoxsArray.Length; i++)
            {
                textBoxsArray[i].Clear();
            }
        }

        private void ReadOnlyAll()
        {
            for (int i = 0; i < textBoxsArray.Length; i++)
            {
                textBoxsArray[i].ReadOnly = !textBoxsArray[i].ReadOnly;
            }
            dateBirthday.Enabled = !dateBirthday.Enabled;
            comboBoxGender.Enabled = !comboBoxGender.Enabled;
            comboBoxMahot.Enabled = !comboBoxMahot.Enabled;
            comboBoxTafkid.Enabled = !comboBoxTafkid.Enabled;

            txtBirthday.ReadOnly = true;
            txtGil.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtTafkid.ReadOnly = true;
            txtMahot.ReadOnly = true;
        }

        private void HintsClear()
        {
            for (int i = 0; i < hintsArray.Length; i++)
                hintsArray[i].Visible = false;
        }



        private void dateBirthday_ValueChanged(object sender, EventArgs e)
        {
            txtBirthday.Text = dateBirthday.Value.Day + "/" + dateBirthday.Value.Month + "/" + dateBirthday.Value.Year;
            txtGil.Text = ((int)(DateTime.Now.Subtract(dateBirthday.Value).TotalDays / 365.25)).ToString();          
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGender.Text = comboBoxGender.Text;
        }

        private void txtZhot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtGil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtMaskort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
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

        private void comboBoxTafkid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMahot.Clear();
            txtTafkid.Text = comboBoxTafkid.Text;
            if (comboBoxTafkid.Text != "אח/ות")
            {
                comboBoxMahot.Items.Clear();
                comboBoxMahot.Items.Add("אונקולוגיה");
                comboBoxMahot.Items.Add("אימונולוגיה קלינית ואלרגולוגיה");
                comboBoxMahot.Items.Add("אנטומיה פתולוגית");
                comboBoxMahot.Items.Add("אנדוקרינולוגיה");
                comboBoxMahot.Items.Add("ביוכימיה קלינית");
                comboBoxMahot.Items.Add("אנדוקרינולוגית ילדים");
                comboBoxMahot.Items.Add("בריאות הציבור");
                comboBoxMahot.Items.Add("גנטיקה רפואית");
                comboBoxMahot.Items.Add("גריאטריה");
                comboBoxMahot.Items.Add("גסטרואנטרולוגיה");
                comboBoxMahot.Items.Add("הרדמה");
                comboBoxMahot.Items.Add("גסטרואנטרולוגית ילדים");
                comboBoxMahot.Items.Add("יילוד וגינקולוגיה");
                comboBoxMahot.Items.Add("גריאטריה");
                comboBoxMahot.Items.Add("כירורגיה אורולוגית");
                comboBoxMahot.Items.Add("המטו-אונקולוגית ילדים");
                comboBoxMahot.Items.Add("כירורגיה אורטופדית");
                comboBoxMahot.Items.Add("המטולוגיה");
                comboBoxMahot.Items.Add("כירורגיה כללית");
                comboBoxMahot.Items.Add("טיפול נמרץ ילדים");
                comboBoxMahot.Items.Add("כירורגיה פלסטית");
                comboBoxMahot.Items.Add("טיפול נמרץ כללי");
                comboBoxMahot.Items.Add("כירורגיה של בית החזה");
                comboBoxMahot.Items.Add("כירורגיה ילדים");
                comboBoxMahot.Items.Add("כירורגית כלי דם");
                comboBoxMahot.Items.Add("כירורגית של היד");
                comboBoxMahot.Items.Add("מחלות אף אוזן גרון וכירורגיית ראש וצוואר");
                comboBoxMahot.Items.Add("מחלות זיהומיות");
                comboBoxMahot.Items.Add("מחלות עור ומין");
                comboBoxMahot.Items.Add("מחלות ריאה");
                comboBoxMahot.Items.Add("מחלות עיניים");
                comboBoxMahot.Items.Add("מחלות ריאה ילדים");
                comboBoxMahot.Items.Add("מיקרוביולוגיה קלינית");
                comboBoxMahot.Items.Add("מנהל רפואי");
                comboBoxMahot.Items.Add("נוירוכירורגיה");
                comboBoxMahot.Items.Add("נאונטולוגיה");
                comboBoxMahot.Items.Add("נוירולוגיה");
                comboBoxMahot.Items.Add("נוירולוגית ילדים והתפתחות הילד");
                comboBoxMahot.Items.Add("פסיכיאטריה");
                comboBoxMahot.Items.Add("נפרולוגיה");
                comboBoxMahot.Items.Add("פסיכיאטריה של הילד והמתבגר");
                comboBoxMahot.Items.Add("נפרולוגית ילדים");
                comboBoxMahot.Items.Add("רדיולוגיה אבחנתית");
                comboBoxMahot.Items.Add("פרמקולוגיה קלינית");
                comboBoxMahot.Items.Add("רפואה גרעינית");
                comboBoxMahot.Items.Add("קרדיולוגיה");
                comboBoxMahot.Items.Add("רפואה דחופה");
                comboBoxMahot.Items.Add("קרדיולוגית ילדים");
                comboBoxMahot.Items.Add("רפואה משפטית");
                comboBoxMahot.Items.Add("ריאומטולוגיה");
                comboBoxMahot.Items.Add("רפואה פיסיקלית ושיקום");
                comboBoxMahot.Items.Add("רפואה דחופה");
                comboBoxMahot.Items.Add("רפואה פנימית");
                comboBoxMahot.Items.Add("רפואה לשיכוך כאב");
                comboBoxMahot.Items.Add("רפואה תעסוקתית");
                comboBoxMahot.Items.Add("רפואה פליאטיבי");
                comboBoxMahot.Items.Add("רפואת ילדים ");
                comboBoxMahot.Items.Add("רפואת המשפחה");
            }
            else
            {
                comboBoxMahot.Items.Clear();
                comboBoxMahot.Items.Add("סיעוד במיילדות  ");
                comboBoxMahot.Items.Add("סיעוד בחדר ניתוח");
                comboBoxMahot.Items.Add("סיעוד בטיפול נמרץ משולב");
                comboBoxMahot.Items.Add("סיעוד בטיפול נמרץ פ.י.ת.י (פג, ילוד, תינוק וילד)");
                comboBoxMahot.Items.Add("סיעוד באונקולוגיה");
                comboBoxMahot.Items.Add("סיעוד בנפרולוגיה");
                comboBoxMahot.Items.Add("סיעוד בגריאטריה");
                comboBoxMahot.Items.Add("סיעוד ברפואה דחופה");
                comboBoxMahot.Items.Add("סיעוד בבריאות הנפש");
                comboBoxMahot.Items.Add("סיעוד בבריאות הציבור");
                comboBoxMahot.Items.Add("סיעוד בבריאות הקהילה");

            }
        }

        private void comboBoxMahot_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMahot.Text = comboBoxMahot.Text;
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                btnShow.Visible = false;
            else
                btnShow.Visible = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            pnlResultButtons.Visible = false;
            ClearAll();
            comboSearch.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void txtTafkid_TextChanged(object sender, EventArgs e)
        {
            if (txtTafkid.Text != "אח/ות")
            {
                if (txtTafkid.Text != "")
                {
                    comboBoxMahot.Items.Clear();
                    comboBoxMahot.Items.Add("אונקולוגיה");
                    comboBoxMahot.Items.Add("אימונולוגיה קלינית ואלרגולוגיה");
                    comboBoxMahot.Items.Add("אנטומיה פתולוגית");
                    comboBoxMahot.Items.Add("אנדוקרינולוגיה");
                    comboBoxMahot.Items.Add("ביוכימיה קלינית");
                    comboBoxMahot.Items.Add("אנדוקרינולוגית ילדים");
                    comboBoxMahot.Items.Add("בריאות הציבור");
                    comboBoxMahot.Items.Add("גנטיקה רפואית");
                    comboBoxMahot.Items.Add("גריאטריה");
                    comboBoxMahot.Items.Add("גסטרואנטרולוגיה");
                    comboBoxMahot.Items.Add("הרדמה");
                    comboBoxMahot.Items.Add("גסטרואנטרולוגית ילדים");
                    comboBoxMahot.Items.Add("יילוד וגינקולוגיה");
                    comboBoxMahot.Items.Add("גריאטריה");
                    comboBoxMahot.Items.Add("כירורגיה אורולוגית");
                    comboBoxMahot.Items.Add("המטו-אונקולוגית ילדים");
                    comboBoxMahot.Items.Add("כירורגיה אורטופדית");
                    comboBoxMahot.Items.Add("המטולוגיה");
                    comboBoxMahot.Items.Add("כירורגיה כללית");
                    comboBoxMahot.Items.Add("טיפול נמרץ ילדים");
                    comboBoxMahot.Items.Add("כירורגיה פלסטית");
                    comboBoxMahot.Items.Add("טיפול נמרץ כללי");
                    comboBoxMahot.Items.Add("כירורגיה של בית החזה");
                    comboBoxMahot.Items.Add("כירורגיה ילדים");
                    comboBoxMahot.Items.Add("כירורגית כלי דם");
                    comboBoxMahot.Items.Add("כירורגית של היד");
                    comboBoxMahot.Items.Add("מחלות אף אוזן גרון וכירורגיית ראש וצוואר");
                    comboBoxMahot.Items.Add("מחלות זיהומיות");
                    comboBoxMahot.Items.Add("מחלות עור ומין");
                    comboBoxMahot.Items.Add("מחלות ריאה");
                    comboBoxMahot.Items.Add("מחלות עיניים");
                    comboBoxMahot.Items.Add("מחלות ריאה ילדים");
                    comboBoxMahot.Items.Add("מיקרוביולוגיה קלינית");
                    comboBoxMahot.Items.Add("מנהל רפואי");
                    comboBoxMahot.Items.Add("נוירוכירורגיה");
                    comboBoxMahot.Items.Add("נאונטולוגיה");
                    comboBoxMahot.Items.Add("נוירולוגיה");
                    comboBoxMahot.Items.Add("נוירולוגית ילדים והתפתחות הילד");
                    comboBoxMahot.Items.Add("פסיכיאטריה");
                    comboBoxMahot.Items.Add("נפרולוגיה");
                    comboBoxMahot.Items.Add("פסיכיאטריה של הילד והמתבגר");
                    comboBoxMahot.Items.Add("נפרולוגית ילדים");
                    comboBoxMahot.Items.Add("רדיולוגיה אבחנתית");
                    comboBoxMahot.Items.Add("פרמקולוגיה קלינית");
                    comboBoxMahot.Items.Add("רפואה גרעינית");
                    comboBoxMahot.Items.Add("קרדיולוגיה");
                    comboBoxMahot.Items.Add("רפואה דחופה");
                    comboBoxMahot.Items.Add("קרדיולוגית ילדים");
                    comboBoxMahot.Items.Add("רפואה משפטית");
                    comboBoxMahot.Items.Add("ריאומטולוגיה");
                    comboBoxMahot.Items.Add("רפואה פיסיקלית ושיקום");
                    comboBoxMahot.Items.Add("רפואה דחופה");
                    comboBoxMahot.Items.Add("רפואה פנימית");
                    comboBoxMahot.Items.Add("רפואה לשיכוך כאב");
                    comboBoxMahot.Items.Add("רפואה תעסוקתית");
                    comboBoxMahot.Items.Add("רפואה פליאטיבי");
                    comboBoxMahot.Items.Add("רפואת ילדים ");
                    comboBoxMahot.Items.Add("רפואת המשפחה");
                }
                else
                {
                    comboBoxMahot.Items.Clear();
                    comboBoxMahot.Items.Add("בחר תפקיד");
                }
            }
            else
            {
                if (txtTafkid.Text != "")
                {
                    comboBoxMahot.Items.Clear();
                    comboBoxMahot.Items.Add("סיעוד במיילדות");
                    comboBoxMahot.Items.Add("סיעוד בחדר ניתוח");
                    comboBoxMahot.Items.Add("סיעוד בטיפול נמרץ משולב");
                    comboBoxMahot.Items.Add("סיעוד בטיפול נמרץ פ.י.ת.י (פג, ילוד, תינוק וילד)");
                    comboBoxMahot.Items.Add("סיעוד באונקולוגיה");
                    comboBoxMahot.Items.Add("סיעוד בנפרולוגיה");
                    comboBoxMahot.Items.Add("סיעוד בגריאטריה");
                    comboBoxMahot.Items.Add("סיעוד ברפואה דחופה");
                    comboBoxMahot.Items.Add("סיעוד בבריאות הנפש");
                    comboBoxMahot.Items.Add("סיעוד בבריאות הציבור");
                    comboBoxMahot.Items.Add("סיעוד בבריאות הקהילה");
                }
                else
                {
                    comboBoxMahot.Items.Clear();
                    comboBoxMahot.Items.Add("בחר תפקיד");
                }
            }
        }   
    }
}
