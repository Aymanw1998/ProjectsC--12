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
    public partial class Korsim : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        DarQuranDataSet.korsimDataTable mo;
        DataTable dt = new DataTable();
        DataTable dtd = new DataTable();
        string genderg;
        public Korsim(string role, string name, string family)
        {

            InitializeComponent();
            if (role != "مدير")
            {
              
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [korsim] where shemMora='" + name + " " + family + "'", con);
                da.Fill(dtd);
                dataGridViewKorsim.DataSource = dtd;


            }
        }

        private void Korsim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet.korsim' table. You can move, or remove it, as needed.
            this.korsimTableAdapter.Fill(this.darQuranDataSet.korsim);
            mo = darQuranDataSet.korsim;
            OleDbDataAdapter d = new OleDbDataAdapter("Select * From mnhel Where role='" + "معلم" + "'", con);
            d.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string x = dt.Rows[i]["fname"].ToString();
                string y = dt.Rows[i]["lname"].ToString();
                comboBoxETeacher.Items.Add(x + " " + y);
                comboBoxTeacher.Items.Add(x + " " + y);
            }
        }

        private void dataGridViewKorsim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                /*textBoxEID*/  dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[0].Value.ToString();               
                /*NameKors*/ dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[1].Value.ToString();
                /*NameTeacher*/dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[2].Value.ToString();
                OleDbDataAdapter d = new OleDbDataAdapter("Select * From mnhel Where role='" + "معلم" + "'", con);
                d.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string x = dt.Rows[i]["fname"].ToString();
                    string y = dt.Rows[i]["lname"].ToString();
                    if ((x + " " + y).ToString() == dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[2].Value.ToString())
                    {
                        genderg = dt.Rows[i]["gender"].ToString();
                        i = dt.Rows.Count;
                    }


                }
            }
            if (dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                ListStudents kors = new ListStudents(dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[0].Value.ToString(), genderg, dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[2].Value.ToString(), dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[1].Value.ToString());
                kors.Show();
            }
        }

        private void buttonInKorsim_Click(object sender, EventArgs e)
        {
            labelID.Enabled = false;
            labelKors.Enabled = false;
            labelNameTeacher.Enabled = false;
            labelDay.Enabled = false;
           
            bool blID = true;
            OleDbCommand co = new OleDbCommand();
            con.Open();
            co.Connection = con;
            string f = "Select tzKors From korsim";
            co.CommandText = f;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
                if (textBoxID.Text == r["tzKors"].ToString())
                {
                    blID = false;

                }
            }
           
            if (textBoxID.Text.Length == 9 && blID == true && textBoxNameKors.Text != "" && comboBoxDay.Text != "" && comboBoxTeacher.Text != "")
            {
                darQuranDataSet.korsim.AddkorsimRow(textBoxID.Text, textBoxNameKors.Text, comboBoxTeacher.Text, comboBoxDay.Text, dateTimePickerOpen.Text, dateTimePickerClose.Text);
                korsimTableAdapter.Update(darQuranDataSet.korsim);
                Korsim_Load(sender, e);
                lblID.Visible = false;
                lblKors.Visible = false;
                lblDay.Visible = false;
                lblTeacher.Visible = false;
            }
            else
            {
                if (textBoxID.Text == "")
                {
                    labelID.Text = "عليك ان تملائ الخانة";
                    labelID.Visible = true;
                }
                if (textBoxID.Text != "" && textBoxID.Text.Length != 9)
                {
                    labelID.Text = "عليك ان تملائ الخانة ب9 ارقام";
                    labelID.Visible = true;
                }
                if (blID == false)
                {
                    labelID.Text = "الرقم غير صالج للاستعمال الان";
                    labelID.Visible = true;
                }
                if (textBoxNameKors.Text == "")
                {
                    labelKors.Text = "عليك ان تملائ الخانة";
                    labelKors.Visible = true;
                }
                if (comboBoxDay.Text == "")
                {
                    labelDay.Text = "اختار يوم من الاسبوع";
                    labelDay.Visible = true;
                }
                if (comboBoxTeacher.Text == "")
                {
                    labelNameTeacher.Text = "اختار احد االمعلمين";
                    labelNameTeacher.Visible = true;
                }
            }
        }

        private void buttonNewK_Click(object sender, EventArgs e)
        {
            panelNewK.Visible = true;
        }

        private void dataGridViewKorsim_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                textBoxEID.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[0].Value.ToString();
                textBoxENameKors.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[1].Value.ToString();
                comboBoxETeacher.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[2].Value.ToString();
                comboBoxEDay.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[3].Value.ToString();
                dateTimePickerEOpen.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[4].Value.ToString();
                dateTimePickerEClose.Text = dataGridViewKorsim.Rows[dataGridViewKorsim.CurrentCell.RowIndex].Cells[5].Value.ToString();
                panelEdit.Visible = true;
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            labelEKors.Enabled = false;
            labelENameTeacher.Enabled = false;
            labelEDay.Enabled = false;
            OleDbCommand cmdUpdate = new OleDbCommand();
            if (textBoxENameKors.Text != "" && comboBoxEDay.Text != "" && comboBoxETeacher.Text != "")
            {
                DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد تعديل معلومات الدورة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (drAcceptAdd == DialogResult.Yes)
                {

                    cmdUpdate.CommandText = "UPDATE korsim SET  [tzKors] = '" + textBoxEID.Text + "',[shemMora] = '" + comboBoxETeacher.Text + "', [shemKors] = '" + textBoxENameKors.Text + "',  [Days] = '" + comboBoxEDay.Text + "', [TimeOpen] = '" + dateTimePickerEOpen.Text + "', [TimeClose] = '" + dateTimePickerEClose.Text + "' where [tzKors] = '" + textBoxEID.Text + "'";
                    cmdUpdate.Connection = con;
                    con.Open();
                    cmdUpdate.ExecuteNonQuery();

                    con.Close();

                    this.korsimTableAdapter.Fill(this.darQuranDataSet.korsim);
                    korsimTableAdapter.Update(darQuranDataSet.korsim);
                    dataGridViewKorsim.Refresh();
                    MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelEdit.Visible = false;
                }
            }
            else
            {
                if (textBoxENameKors.Text == "")
                {
                    labelEKors.Text = "عليك ان تملائ الخانة";
                    labelEKors.Visible = true;
                }
                if (comboBoxEDay.Text == "")
                {
                    labelEDay.Text = "اختار يوم من الاسبوع";
                    labelEDay.Visible = true;
                }
                if (comboBoxETeacher.Text == "")
                {
                    labelENameTeacher.Text = "اختار احد االمعلمين";
                    labelENameTeacher.Visible = true;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Visible = true;
            DataTable dz = new DataTable();
            dz.Columns.Add("رقم خاص");
            dz.Columns.Add("الاسم الدورة");
            dz.Columns.Add("الاستاذ");
            dz.Columns.Add("يوم التعليم");
            dz.Columns.Add("ساعة البدء ");
            dz.Columns.Add("ساعة الانتهاء ");



            for (int j = 0; j < mo.Rows.Count; j++)
            {
                for (int k = 0; k < mo.Columns.Count; k++)
                {

                    if (mo.Rows[j][k].ToString().Contains(textBoxSearch.Text))//(mo.Rows[j][k].ToString() == txtSearch.Text.ToString()) 
                    {


                        dz.Rows.Add(mo[j][0], mo[j][1], mo[j][2], mo[j][3], mo[j][4], mo[j][5]);
                        k = mo.Columns.Count;
                    }
                }
            }

            dataGridViewSearch.DataSource = dz;
            if (textBoxSearch.Text == "")
                dataGridViewSearch.Visible = false;
        }

        private void buttonDeleteK_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdDelete = new OleDbCommand();

            DialogResult drAcceptAdd = MessageBox.Show("هل انت متأكد من انك تريد حذف معلومات الدورة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drAcceptAdd == DialogResult.Yes)
            {

                cmdDelete.CommandText = "Delete From korsim Where tzKors='" + textBoxEID.Text + "'";
                cmdDelete.Connection = con;
                con.Open();
                cmdDelete.ExecuteNonQuery();

                con.Close();


                this.korsimTableAdapter.Fill(this.darQuranDataSet.korsim);
                korsimTableAdapter.Update(darQuranDataSet.korsim);
                dataGridViewKorsim.Refresh();
                panelEdit.Visible = false;

                MessageBox.Show("تم حذف الطالب ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelEdit.Visible = false;
            }
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNameKors.Focus();
            }
        }

        private void textBoxNameKors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxTeacher.Focus();
            }
        }

       

        private void comboBoxTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxDay.Focus();
            }
        }

        private void comboBoxDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerOpen.Focus();
            }
        }

        private void dateTimePickerOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerClose.Focus();
            }
        }

        private void dateTimePickerClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonInKorsim.Focus();
            }
        }

        private void textBoxENameKors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxETeacher.Focus();
            }
        }

        private void comboBoxETeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxEDay.Focus();
            }
        }

        private void comboBoxEDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerEOpen.Focus();
            }
        }

        private void dateTimePickerEOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerEClose.Focus();
            }
        }

        private void dateTimePickerEClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEdit.Focus();
            }
        }

        private void dataGridViewSearch_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                textBoxEID.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[0].Value.ToString();
                textBoxENameKors.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[1].Value.ToString();
                comboBoxETeacher.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[2].Value.ToString();
                comboBoxEDay.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[3].Value.ToString();
                dateTimePickerEOpen.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[4].Value.ToString();
                dateTimePickerEClose.Text = dataGridViewSearch.Rows[dataGridViewSearch.CurrentCell.RowIndex].Cells[5].Value.ToString();
                panelEdit.Visible = true;
            }
            else
            {
                MessageBox.Show("عليك ان تدغظ على سطر يوجد به معلومات");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void textBoxENameKors_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxENameKors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBoxNameKors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                //מכניס כל התווים שהם אותיות רק
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelNewK.Visible = false;
        }

       
    }
}