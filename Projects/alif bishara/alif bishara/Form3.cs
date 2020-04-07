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

namespace alif_bishara
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\alif bishara\alif bishara\Alif's database.mdb");
        _Alif_s_databaseDataSet.studentsDataTable mz;
        _Alif_s_databaseDataSet.korsimDataTable ms;
        _Alif_s_databaseDataSet.statusDataTable mk;

        private void btnADDstudent_Click(object sender, EventArgs e)
        {
            
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
            panelKOLBO.Visible = true;
            btndOk.Visible = true;
            btnUpdate.Visible = false;
            btnokdel.Visible = false;
            btndcancel.Visible = true;
            btnddclear.Visible = true;
            txtdShamp.ReadOnly = false;
            txtdshamp2.ReadOnly = false;
            txtdShamF.ReadOnly = false;
            txtdsham.ReadOnly = false;
            txtAir.ReadOnly = false;
            btnOut.Visible = false;
            btnIn.Visible = false;



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.korsim' table. You can move, or remove it, as needed.
            this.korsimTableAdapter.Fill(this._Alif_s_databaseDataSet.korsim);
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this._Alif_s_databaseDataSet.status);
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter1.Fill(this._Alif_s_databaseDataSet.students);

            mz = _Alif_s_databaseDataSet.students;
            ms = _Alif_s_databaseDataSet.korsim;
            mk = _Alif_s_databaseDataSet.status;
            int i =0;
           while (i<ms.Rows.Count)
           {
               combocode.Items.Add(ms.Rows[i][6].ToString());
               i++;
           }
        }

        private void btnDeletesrudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("למחיקה בחר בתלמיד שתרצה למחוק מהטבלה ולחץ על מחיקה");
       
            btndOk.Visible = false;
            btnUpdate.Visible = false;
            btnokdel.Visible = true;
            panelKOLBO.Visible = false;
            btnddclear.Visible = false;
            btnOut.Visible = false;
            btnIn.Visible = false;
            btndcancel.Visible = true;

            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
            
           
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }




        private void btnokdel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                string s = dataGridView1.Rows[a].Cells[0].Value.ToString();

                OleDbCommand da = new OleDbCommand("Delete from students where tz='" + s + "'", con);
                con.Open();
                da.ExecuteNonQuery();
                con.Close();
                studentsTableAdapter1.Fill(this._Alif_s_databaseDataSet.students);
                   

            }
        }
        

        private void btncountinueDEl_Click(object sender, EventArgs e)
        {
            
        }

        private void btndClear_Click(object sender, EventArgs e)
        {
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
        }

        private void btncanceldel_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btndcancel_Click(object sender, EventArgs e)
        {
            btnddclear.Visible = false;
            btndcancel.Visible =false;
            btnokdel.Visible = false;
            btndOk.Visible = false;
            btnUpdate.Visible = false;
            btnOut.Visible = false;
            btnIn.Visible = false;
            panelKOLBO.Visible = false;
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
        }

        private void btnddclear_Click(object sender, EventArgs e)
        {
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtdsham.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
        }

        private void btndOk_Click(object sender, EventArgs e)
        {
            bool bl=false ;
            string S = "";
            if (txtAir.MaskCompleted == true && txtdsham.MaskCompleted == true && txtdShamF.MaskCompleted == true && txtdShamp.MaskCompleted == true && txtdshamp2.MaskCompleted == true && txtdtz.MaskCompleted == true)
            {
                int z = dateTimePicker2.Value.Month;
                if (z != DateTime.Now.Month || z != DateTime.Now.Day || z != DateTime.Now.Year || combocode.Text != "")
                {
                    int i = 0;
                    bl = false;

                    while (ms.Rows[i][6].ToString() != combocode.Text && i < ms.Rows.Count)
                    {
                        if (ms.Rows[i][6].ToString() == combocode.Text)
                        {
                            bl = true;
                            i--;
                        }
                        i++;
                    }

                    if (DateTime.Now.Month < z)
                    {

                        int n = (dateTimePicker2.Value.Year - DateTime.Now.Year) * 12 - DateTime.Now.Month + dateTimePicker2.Value.Month;
                        double shom = n * Convert.ToDouble(ms.Rows[i][4].ToString());
                        S = shom.ToString();
                        shom1.Text = S;
                    }
                    else if (z < DateTime.Now.Month)
                    {

                        double shom = (((dateTimePicker2.Value.Year - DateTime.Now.Year) * 12) + (dateTimePicker2.Value.Month - DateTime.Now.Month)) * Convert.ToDouble(ms.Rows[i][4].ToString());
                        S = shom.ToString();
                        shom1.Text = S;

                    }



                    studentsTableAdapter1.addStudent(txtdtz.Text, txtdsham.Text, txtdShamF.Text.ToString(), txtdShamp.Text.ToString(), txtdshamp2.Text.ToString(), txtdTel.Text, txtdtelp1.Text, txtdtelp2.Text, txtAir.Text.ToString(), txtKtovat.Text.ToString(), dateTimePicker1.Value.ToShortDateString());
                    this.studentsTableAdapter1.Fill(this._Alif_s_databaseDataSet.students);
                    statusTableAdapter.addStatusPos1(txtdtz.Text, combocode.Text, dateTimePicker2.Text);
                    this.statusTableAdapter.Fill(this._Alif_s_databaseDataSet.status);

                    txtdShamp.Text = "";
                    txtdtz.Text = "";
                    txtdShamF.Text = "";
                    txtAir.Text = "";
                    txtdsham.Text = "";
                    txtdshamp2.Text = "";
                    txtdtelp1.Text = "";
                    txtdtelp2.Text = "";
                    txtKtovat.Text = "";
                    tashlom ts = new tashlom(S);
                    ts.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("אחד מהנתונים שהגשת אינו תקין ");
            }
              
        }
    
        private void btndADD2_Click(object sender, EventArgs e)
        {
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtdsham.Text = "";
        }

        private void panelKOLBO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("tz");
            dz.Columns.Add("sham");
            dz.Columns.Add("shamfamily");
            dz.Columns.Add("shamhora");
            dz.Columns.Add("shamHora2");
            dz.Columns.Add("telTalmid");
            dz.Columns.Add("telHora1");
            dz.Columns.Add("telHora2");
            dz.Columns.Add("air");
            dz.Columns.Add("ktovat");
            dz.Columns.Add("tarichLida");


            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(txtSearch.Text))//(ma.Rows[j][k].ToString() == txtSearch.Text.ToString()) 
                    {


                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8], mz[j][9], mz[j][10]);
                        k = mz.Columns.Count;

                    }
                }
            }
            dataGridView1.DataSource = dz;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtAir.MaskCompleted == true||txtAir.Text=="") && (txtdsham.MaskCompleted == true ||txtdsham.Text=="") && (txtdShamF.MaskCompleted == true ||txtdShamF.Text=="") && (txtdShamp.MaskCompleted == true ||txtdShamp.Text=="") && (txtdshamp2.MaskCompleted == true||txtdshamp2.Text=="") && (txtdtz.MaskCompleted == true ||txtdtz.Text==""))
            {
                bool bl = false;
                int i = 0;

                while (i < mz.Rows.Count && bl != true)
                {
                    if (mz.Rows[i][0].ToString() == txtdtz.Text)
                    {
                        bl = true;
                    }
                    i++;
                }



                if (bl == false)
                {
                    MessageBox.Show("תלמיד בעל תעודת זהות זהה אינו קיים במערכת אנא נסה שנית ");
                }
                else
                {
                    string telTalmid;
                    if (txtdTel.Text == "")
                    {
                        telTalmid = mz.Rows[i - 1][5].ToString();
                    }
                    else
                    {
                        telTalmid = txtdTel.Text;
                    }
                    string telhora;
                    if (txtdtelp1.Text == "")
                    {
                        telhora = mz.Rows[i - 1][6].ToString();
                    }
                    else
                    {
                        telhora = txtdtelp1.Text;
                    }

                    string telhora2;

                    if (txtdtelp2.Text == "")
                    {
                        telhora2 = mz.Rows[i - 1][7].ToString();
                    }
                    else
                    {
                        telhora2 = txtdtelp2.Text;
                    }
                    string ktovat;
                    if (txtKtovat.Text == "")
                    {
                        ktovat = mz.Rows[i - 1][9].ToString();
                    }
                    else
                    {
                        ktovat = txtKtovat.Text;
                    }

                    OleDbCommand da = new OleDbCommand("UPDATE students SET [telTalmid] = '" + telTalmid + "', [telHora1] = '" + telhora + "', [telHora2] = '" + telhora2 + "', [ktovat] = '" + ktovat + "' where [tz]='" + txtdtz.Text + "'", con);
                    con.Open();
                    da.ExecuteNonQuery();
                    con.Close();
                    this.studentsTableAdapter1.Fill(this._Alif_s_databaseDataSet.students);
                    txtdTel.Text = "";
                    txtdShamp.Text = "";
                    txtdtz.Text = "";
                    txtdShamF.Text = "";
                    txtAir.Text = "";
                    txtdsham.Text = "";
                    txtdshamp2.Text = "";
                    txtdtelp1.Text = "";
                    txtdtelp2.Text = "";
                    txtKtovat.Text = "";

                }
            }
            else
            {
                MessageBox.Show("אחד מהנתונים שהזנת אינו תקין ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdshamp2.ReadOnly = true;
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdShamp.ReadOnly = true;
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtdShamF.ReadOnly = true;
            txtdsham.ReadOnly = true;
            txtAir.ReadOnly = true;
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
            panelKOLBO.Visible = true;
            btnUpdate.Visible = true;
            btndOk.Visible = false;
            btnokdel.Visible = false;
            btndcancel.Visible = true;
            btnddclear.Visible = true;
            btnOut.Visible = false;
            btnIn.Visible = false;

        }

        private void btnStudentOut_Click(object sender, EventArgs e)
        {
            btndcancel.Visible = true;
            btnddclear.Visible = true;
            txtdShamp.ReadOnly = false;
            txtdshamp2.ReadOnly = false;
            txtdShamF.ReadOnly = false;
            txtdsham.ReadOnly = false;
            txtAir.ReadOnly = false;
            btndOk.Visible = false;
            btnUpdate.Visible = false;
            btnokdel.Visible = false;
            panelKOLBO.Visible = true;
            btnddclear.Visible = false;
            btndcancel.Visible = true;
            btnOut.Visible = true;
            btnIn.Visible = false;
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            OleDbCommand da = new OleDbCommand("UPDATE status SET [kors1] = '" + combocode.Text + "', [ending1] = '" + dateTimePicker2.Value.ToShortDateString() + "' where [tz]='" + txtdtz.Text + "'", con);
            OleDbCommand db = new OleDbCommand("UPDATE status SET [kors2] = '" + combocode.Text + "', [ending2] = '" + dateTimePicker2.Value.ToShortDateString() + "' where [tz]='" + txtdtz.Text + "'", con);
            OleDbCommand dc = new OleDbCommand("UPDATE status SET [kors3] = '" + combocode.Text + "', [ending3] = '" + dateTimePicker2.Value.ToShortDateString() + "' where [tz]='" + txtdtz.Text + "'", con);
            
            int i=0;
            bool bl =false;
           
            while (i < mk.Rows.Count && bl != true)
            {
                if (txtdtz.Text == mk.Rows[i][0].ToString())
                {
                    bl = true;
                    i--;
                }
                i++;
            }
            if (bl == true)
            {
                
                if (mk.Rows[i][1].ToString() == "")
                {
                   
                    con.Open();
                    da.ExecuteNonQuery();
                    con.Close();
                  
                    tashlom ts = new tashlom(shom1.Text);
                    ts.Show();
                    this.Hide();
                }
                else if (mk.Rows[i][3].ToString() == "")
                {
                    
                    
                    con.Open();
                    db.ExecuteNonQuery();
                    con.Close();
                    tashlom ts = new tashlom(shom1.Text);
                    ts.Show();
                    this.Hide();
                }
                else
                {

                    con.Open();
                    dc.ExecuteNonQuery();
                    con.Close();
                    tashlom ts = new tashlom(shom1.Text);
                    ts.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("תלמיד בעל תעודת זהות זהה אינו קיים במערכת");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool bl = false;

            while (i < mk.Rows.Count && bl != true)
            {
                if (txtdtz.Text == mk.Rows[i][0].ToString())
                {
                    bl = true;
                    i--;
                }
                i++;
            }
            string s = "";
            OleDbCommand da = new OleDbCommand("UPDATE status SET [kors1] = '" + "" + "', [ending1] = '" + "" + "' where [tz]='" + txtdtz.Text + "'", con);
            OleDbCommand db = new OleDbCommand("UPDATE status SET [kors2] = '" + "" + "', [ending2] = '" + "" + "' where [tz]='" + txtdtz.Text + "'", con);
            OleDbCommand dc = new OleDbCommand("UPDATE status SET [kors3] = '" + "" + "', [ending3] = '" + "" + "' where [tz]='" + txtdtz.Text + "'", con);

            if (bl == true)
            {
                if (mk.Rows[i][1].ToString() == combocode.Text)
                {
                    con.Open();
                    da.ExecuteNonQuery();
                    con.Close();
                }
                else if (mk.Rows[i][3].ToString() == combocode.Text)
                {
                    con.Open();
                    db.ExecuteNonQuery();
                    con.Close();

                }
                else if (mk.Rows[i][5].ToString() == combocode.Text)
                {
                    con.Open();
                    dc.ExecuteNonQuery();
                    con.Close();

                }

                if (mk.Rows[i][3].ToString() == "" && mk.Rows[i][1].ToString() == "" && mk.Rows[i][5].ToString() == "")
                {
                    OleDbCommand dh = new OleDbCommand("Delete from status where tz='" + mk.Rows[i][0].ToString() + "'", con);
                    OleDbCommand dt = new OleDbCommand("Delete from students where tz='" + mk.Rows[i][0].ToString() + "'", con);
                    con.Open();
                    da.ExecuteNonQuery();
                    dh.ExecuteNonQuery();
                    con.Close();
                    studentsTableAdapter1.Fill(this._Alif_s_databaseDataSet.students);

                }
            }
            else
            {
                MessageBox.Show("התלמיד אינו משתתף בקורס זה");
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           //if(combocode.Text!="")
           //{
           //    int i =0;
           //        bool bl = false;

           //    while( i<ms.Rows.Count && bl!= true)
           //    {
           //        if(ms.Rows[i][6].ToString()==combocode.Text)
           //        {
           //            bl = true;
           //            i--;
           //        }
           //        i++;
           //    }
           //    if(DateTime.Now.Month>dateTimePicker2.Value.Month)
           //    {
           //        int n = 12 - DateTime.Now.Month + dateTimePicker2.Value.Month;
           //        double shom=n*Convert.ToDouble(ms.Rows[i][4].ToString());
           //        shom1.Text = Convert.ToString(shom);
           //    }

           //    else if(DateTime.Now.Month>dateTimePicker2.Value.Month)
           //    {
           //        double shom = (DateTime.Now.Month - dateTimePicker2.Value.Month) * Convert.ToDouble(ms.Rows[i][4].ToString());
           //        shom1.Text = Convert.ToString(shom);
           //    }
           //}
        }

        private void combocode_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (dateTimePicker2.Value.Month!=DateTime.Now.Month && dateTimePicker2.Value.Day!=DateTime.Now.Day && dateTimePicker2.Value.Year!=DateTime.Now.Year)
            //{
            //    int i = 0;
            //    bool bl = false;

            //    while (ms.Rows[i][6].ToString() != combocode.SelectedText && i < ms.Rows.Count)
            //    {
            //        if (ms.Rows[i][6].ToString() == combocode.SelectedText)
            //        {
            //            bl = true;
            //            i--;
            //        }
            //        i++;
            //    }
            //    if (DateTime.Now.Month > dateTimePicker2.Value.Month)
            //    {
            //        int n = 12 - DateTime.Now.Month + dateTimePicker2.Value.Month;
            //        double shom = n * Convert.ToDouble(ms.Rows[i][4].ToString());
            //        shom1.Text = Convert.ToString(shom);
            //    }
            //    else if (DateTime.Now.Month > dateTimePicker2.Value.Month)
            //    {
            //        double shom = (DateTime.Now.Month - dateTimePicker2.Value.Month) * Convert.ToDouble(ms.Rows[i][4].ToString());
            //        shom1.Text = Convert.ToString(shom);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bl = true;
            int z = dateTimePicker2.Value.Month;
            if (z != DateTime.Now.Month || z != DateTime.Now.Day || z != DateTime.Now.Year || combocode.Text != "")
            {
                int i = 0;
                 bl = false;

                while (ms.Rows[i][6].ToString() != combocode.Text && i < ms.Rows.Count  )
                {
                    if (ms.Rows[i][6].ToString() == combocode.Text)
                    {
                        bl = true;
                        i--;
                    }
                    i++;
                }

                if (DateTime.Now.Month < z)
                {

                    int n = (dateTimePicker2.Value.Year - DateTime.Now.Year) * 12 - DateTime.Now.Month + dateTimePicker2.Value.Month;
                    double shom = n * Convert.ToDouble(ms.Rows[i][4].ToString());
                    string j = shom.ToString();
                    shom1.Text = j;
                }
                else if (z < DateTime.Now.Month)
                {

                    double shom = (((dateTimePicker2.Value.Year - DateTime.Now.Year) * 12) + (dateTimePicker2.Value.Month - DateTime.Now.Month)) * Convert.ToDouble(ms.Rows[i][4].ToString());
                    string S = shom.ToString();
                    shom1.Text = S;

                }
                else
                {
                    shom1.Text = "0";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtdShamF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdShamp_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnStudentIN_Click(object sender, EventArgs e)
        {
            btndcancel.Visible = true;
            btnddclear.Visible = true;
            txtdShamp.ReadOnly = false;
            txtdshamp2.ReadOnly = false;
            txtdShamF.ReadOnly = false;
            txtdsham.ReadOnly = false;
            txtAir.ReadOnly = false;
            btndOk.Visible = false;
            btnUpdate.Visible = false;
            btnokdel.Visible = false;
            panelKOLBO.Visible = true;
            btnddclear.Visible = false;
            
            btnOut.Visible = false;
            btnIn.Visible = true;
            txtdTel.Text = "";
            txtdShamp.Text = "";
            txtdtz.Text = "";
            txtdShamF.Text = "";
            txtAir.Text = "";
            txtdsham.Text = "";
            txtdshamp2.Text = "";
            txtdtelp1.Text = "";
            txtdtelp2.Text = "";
            txtKtovat.Text = "";
            txtdTel.Text = "";
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        { 
        txtdtz.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
        txtdsham.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
        txtdShamF.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
        txtdShamp.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
        txtdshamp2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
        txtdTel.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
        txtdtelp1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
        txtdtelp2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
        txtAir.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
        txtKtovat.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
        }

    }
}





