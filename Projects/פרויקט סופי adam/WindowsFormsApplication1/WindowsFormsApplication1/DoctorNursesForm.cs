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
    public partial class DoctorNursesForm : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\adam\Desktop\פרויקט סופי\Hospital.mdb");
        HospitalDataSet.TsyodDataTable dt;
        OleDbCommand cmd = new OleDbCommand();
        bool Search;
        bool Accept = true;
        bool add = true;

        public DoctorNursesForm()
        {
            InitializeComponent();
        }

        //                  בפתיחת הפורם
        private void DoctorNursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.DoctorsNurses' table. You can move, or remove it, as needed.
            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
            MainForm frm = new MainForm();

            comboSearch.SelectedIndex = 0;
            dt = hospitalDataSet.Tsyod;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                comboSearch.Items.Add(dataGridView.Columns[i].HeaderText);
            }

            pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);
        }


        //                  אזור החיפוש
        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e) // בחירת החיפוש
        {
            dt = hospitalDataSet.Tsyod;

            txtSearch.Clear();
            txtMis.Clear();
            txtSapak.Clear();
            txtShem.Clear();
            txtPrice.Clear();
            txtKamot.Clear();
            txtShimosh.Clear();
            txtKhevra.Clear();

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
            txtMis.Clear();
            txtShem.Clear();
            txtPrice.Clear();
            txtSapak.Clear();
            txtKamot.Clear();
            txtShimosh.Clear();
            txtKhevra.Clear();
            pnlResult.Visible = false;

        } 

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) // לחיצת ENTER
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }    

        private void btnSearch_Click(object sender, EventArgs e) // כפתור החיפוש
        {
            dataGridViewResult.Rows.Clear();
            txtMis.Clear();
            txtShem.Clear();
            txtSapak.Clear();
            txtPrice.Clear();
            txtKamot.Clear();
            txtShimosh.Clear();
            txtKhevra.Clear();
            dt = hospitalDataSet.Tsyod;

            int count = 0;
            bool found = false;

            if (comboSearch.Text != "- בחר -")
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
            }
            else
                MessageBox.Show("בחר חיפוש לפי");

            if (found)
            {
                if (count > 1)
                {
                    pnlResult.Visible = true;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtSearch.Text == dt.Rows[i][comboSearch.SelectedIndex - 1].ToString())
                        {
                            string[] row = new string[] { dt.Rows[i]["mispar"].ToString(), dt.Rows[i]["name"].ToString(), dt.Rows[i]["spak"].ToString(), dt.Rows[i]["kamot"].ToString(), dt.Rows[i]["price"].ToString(), dt.Rows[i]["shimosh"].ToString(), dt.Rows[i]["khevra"].ToString() };
                            dataGridViewResult.Rows.Add(row);
                            dataGridViewResult.Rows[0].Selected = true;
                            


                        }
                    }
                    Search = true;
                    pnlData.Size = new Size((pnlTables.Width / 2) - 1, pnlData.Size.Height);
                    lblSearchQuantity.Text = "ציוד: 1 מתוך" + " " + count.ToString();
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
                            txtMis.Text = dt.Rows[i]["mispar"].ToString();
                            txtShem.Text = dt.Rows[i]["name"].ToString();
                            txtSapak.Text = dt.Rows[i]["spak"].ToString();
                            txtPrice.Text = dt.Rows[i]["price"].ToString();
                            txtKamot.Text = dt.Rows[i]["kamot"].ToString();
                            txtShimosh.Text = dt.Rows[i]["shimosh"].ToString();
                            txtKhevra.Text = dt.Rows[i]["khevra"].ToString();
                        }
                    }
                    dataGridViewResult.Select();
                    Search = false;
                    pnlData.Size = new Size(pnlTables.Width, pnlData.Size.Height);
                    lblSearchQuantity.Text = "1 ציוד: 1 מתוך";

                    splHalf.Visible = false;
                    pnlResultButtons.Visible = false;
                }
            }

        } 


        //                 אזור הפעולות 
        private void btnAdd_Click(object sender, EventArgs e) // כפתור ההוספה
        {
            add = true;
            if (Accept)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnUpdate.Enabled = false;

                txtMis.Clear();
                txtShem.Clear();
                txtSapak.Clear();
                txtPrice.Clear();
                txtKamot.Clear();
                txtShimosh.Clear();
                txtKhevra.Clear();

                bool found = false;
                bool bl = false;
                int max = 0;
                string s = "";

                btnAccept.Visible = true;
                btnCancel.Visible = true;
                txtShem.Focus();

                txtKamot.ReadOnly = false;
                txtShem.ReadOnly = false;
                txtKhevra.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtSapak.ReadOnly = false;
                txtShimosh.ReadOnly = false;

                for (int i = 0; i < dt.Rows.Count + 1 && bl != true; i++)
                {
                    found = false;
                    for (int k = 0; k < dt.Rows.Count && bl != true; k++)
                    {
                        if (i + 1 == int.Parse(dt.Rows[k]["mispar"].ToString()))
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

                txtMis.Text = s;
            }
            else
            {

                dt = hospitalDataSet.Tsyod;

                bool bl = true;

                if (txtMis.Text == "" || txtKamot.Text == "" || txtKhevra.Text == "" || txtSapak.Text == "" || txtShimosh.Text == "" || txtPrice.Text == "" || txtShem.Text == "")
                {
                    MessageBox.Show("מלא פרטים בבקשה");
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count && bl == false; i++)
                    {
                        if (dt.Rows[i]["mispar"].ToString() == txtMis.Text)
                            bl = false;
                    }
                    if (bl == true)
                    {
                        if (MessageBox.Show("האם אתה מעוניין להוסיף?", "הערה", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //for (int i = 0; i < 7; i++)
                            //{
                            //    cmd.CommandText += this.pnlTables.TabIndex[i]

                            //}

                            cmd.CommandText = "Insert Into Tsyod(mispar,name,spak,kamot,price,shimosh,khevra) values ('" + txtMis.Text + "','" + txtShem.Text + "','" + txtSapak.Text + "','" + txtKamot.Text + "','" + txtPrice.Text + "','" + txtShimosh.Text + "','" + txtKhevra.Text + "')";
                            cmd.Connection = con;

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            comboSearch.SelectedIndex = 0;
                            this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
                            dataGridView.Refresh();

                            if(Search == true)
                                btnSearch_Click( sender, e);

                            if (comboSearch.SelectedIndex != 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    txtSearch.AutoCompleteCustomSource.Add(dt.Rows[i][comboSearch.SelectedIndex - 1].ToString());
                                }
                            }

                            txtMis.Text = "";
                            txtKamot.Text = "";
                            txtKhevra.Text = "";
                            txtPrice.Clear();
                            txtShem.Clear();
                            txtSapak.Text = "";
                            txtShimosh.Text = "";

                            btnAccept.Visible = false;
                            btnCancel.Visible = false;

                            btnAdd.Enabled = true;
                            btnDel.Enabled = true;
                            btnUpdate.Enabled = true;

                            txtKamot.ReadOnly = true;
                            txtKhevra.ReadOnly = true;
                            txtShem.ReadOnly = true;
                            txtPrice.ReadOnly = true;
                            txtMis.ReadOnly = true;
                            txtSapak.ReadOnly = true;
                            txtShimosh.ReadOnly = true;
                        }
                    }
                    else
                        MessageBox.Show("מספר זה כבר קיימת");
                }
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
            dt = hospitalDataSet.Tsyod;
            bool found = false;

            if (txtMis.Text != "" && txtKamot.Text != "" && txtKhevra.Text != "" && txtSapak.Text != "" && txtShimosh.Text != "")
            {
                if (MessageBox.Show("האם אתה מעוניין למחוק?", "הערה", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtMis.Text == dt.Rows[i]["mispar"].ToString())
                        {
                            cmd.CommandText = "DELETE FROM Tsyod WHERE mispar='" + txtMis.Text + "'";
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
                            txtMis.Clear();
                            txtShem.Clear();
                            txtSapak.Clear();
                            txtKamot.Clear();
                            txtPrice.Clear();
                            txtShimosh.Clear();
                            txtKhevra.Clear();


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

        private void btnUpdate_Click(object sender, EventArgs e) // כפתור העדכון
        {
            add = false;
            if (txtMis.Text != "")
            {
                if (Accept)
                {
                    btnAdd.Enabled = false;
                    btnDel.Enabled = false;
                    btnUpdate.Enabled = false;

                    btnAccept.Visible = true;
                    btnCancel.Visible = true;
                    txtShem.Focus();

                    txtKamot.ReadOnly = false;
                    txtShem.ReadOnly = false;
                    txtKhevra.ReadOnly = false;
                    txtPrice.ReadOnly = false;
                    txtSapak.ReadOnly = false;
                    txtShimosh.ReadOnly = false;
                }
                else
                {
                    if (txtMis.Text == "" || txtKamot.Text == "" || txtKhevra.Text == "" || txtSapak.Text == "" || txtShimosh.Text == "" || txtPrice.Text == "" || txtShem.Text == "")
                    {
                        MessageBox.Show("מלא פרטים בבקשה");
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE Tsyod SET spak='" + txtSapak.Text + "', name='" + txtShem.Text + "', kamot='" + txtKamot.Text + "', price='" + txtPrice.Text + "', shimosh='" + txtShimosh.Text + "', khevra='" + txtKhevra.Text + "' WHERE mispar='" + txtMis.Text + "'";
                        cmd.Connection = con;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        this.doctorsNursesTableAdapter.Fill(this.hospitalDataSet.DoctorsNurses);
                        dataGridView.Refresh();

                        if(Search)
                          btnSearch_Click(sender, e);

                        if (comboSearch.SelectedIndex != 0)
                        {
                            for (int z = 0; z < dt.Rows.Count; z++)
                            {
                                txtSearch.AutoCompleteCustomSource.Add(dt.Rows[z][comboSearch.SelectedIndex - 1].ToString());
                            }
                        }
                        
                        btnAccept.Visible = false;
                        btnCancel.Visible = false;

                        btnAdd.Enabled = true;
                        btnDel.Enabled = true;
                        btnUpdate.Enabled = true;

                        txtKamot.ReadOnly = true;
                        txtKhevra.ReadOnly = true;
                        txtShem.ReadOnly = true;
                        txtPrice.ReadOnly = true;
                        txtMis.ReadOnly = true;
                        txtSapak.ReadOnly = true;
                        txtShimosh.ReadOnly = true;
                        Accept = true;
                    }
                }
            }
            else
                MessageBox.Show("חפש מספר הציוד");
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

            txtMis.Clear();
            txtShem.Clear();
            txtSapak.Clear();
            txtPrice.Clear();
            txtKamot.Clear();
            txtShimosh.Clear();
            txtKhevra.Clear();

            btnAccept.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnUpdate.Enabled = true;

            txtPrice.ReadOnly = true;
            txtShem.ReadOnly = true;
            txtKamot.ReadOnly = true;
            txtKhevra.ReadOnly = true;
            txtMis.ReadOnly = true;
            txtSapak.ReadOnly = true;
            txtShimosh.ReadOnly = true;
        }


        //              כשהפורם משנה גודל
        private void DoctorNursesForm_SizeChanged(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();

            pnlTables.Size = new Size((frm.pnlDisplay.Width / 2) - 1,Convert.ToInt32(frm.pnlDisplay.Height*0.4));
            pnlResult.Size = new Size((pnlTables.Width / 2) - 1, pnlResult.Size.Height);

            if(Search)
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
            txtMis.Clear();
            txtShem.Clear();
            txtSapak.Clear();
            txtPrice.Clear();
            txtKamot.Clear();
            txtShimosh.Clear();
            txtKhevra.Clear();

            pnlResultButtons.Visible = false;
            splHalf.Visible = false;

        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e) // שינוי בחירת התוצאה
        {
            int a = dataGridViewResult.CurrentCell.RowIndex;
            
            lblSearchQuantity.Text = "ציוד: " + (a + 1).ToString() + " מתוך " + (dataGridViewResult.Rows.Count-1);
            if (a < dataGridViewResult.RowCount-1)
            {
                txtKhevra.Text = dataGridViewResult.Rows[a].Cells[6].Value.ToString();
                txtKamot.Text = dataGridViewResult.Rows[a].Cells[3].Value.ToString();
                txtMis.Text = dataGridViewResult.Rows[a].Cells[0].Value.ToString();
                txtShem.Text = dataGridViewResult.Rows[a].Cells[1].Value.ToString();
                txtPrice.Text = dataGridViewResult.Rows[a].Cells[4].Value.ToString();
                txtSapak.Text = dataGridViewResult.Rows[a].Cells[2].Value.ToString();
                txtShimosh.Text = dataGridViewResult.Rows[a].Cells[5].Value.ToString();
            }
            
        }

        //                 כפתורי הזזה
        private void btnNext_Click(object sender, EventArgs e) // כפתור הבא
        {
            if(dataGridViewResult.CurrentCell.RowIndex !=  dataGridViewResult.Rows.Count-2)
                dataGridViewResult.CurrentCell= dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex + 1].Cells[0];

         dataGridViewResult.FirstDisplayedScrollingRowIndex= dataGridViewResult.SelectedRows[0].Index;
         dataGridViewResult_SelectionChanged(sender,e);

        }

        private void btnPrevious_Click(object sender, EventArgs e) // כפתור הקודם
        {
            if (dataGridViewResult.CurrentCell.RowIndex != 0)
                dataGridViewResult.CurrentCell = dataGridViewResult.Rows[dataGridViewResult.CurrentCell.RowIndex - 1].Cells[0];

            dataGridViewResult_SelectionChanged(sender, e);
        }

        private void btnLast_Click(object sender, EventArgs e) // כפתור האחרון
        {

        }

        private void btnFirst_Click(object sender, EventArgs e) // כפתור הראשון
        {         
            dataGridViewResult.CurrentCell = dataGridViewResult.Rows[0].Cells[0];
            dataGridViewResult.FirstDisplayedScrollingRowIndex = dataGridViewResult.SelectedRows[0].Index;
            lblSearchQuantity.Text =  "ציוד: 1 מתוך " + (dataGridViewResult.Rows.Count - 1);
            dataGridViewResult_SelectionChanged(sender, e);
        }
    }
}
