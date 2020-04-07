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
    public partial class frmKors : Form
    {
        public frmKors()
        {

            InitializeComponent();
        }
        _Alif_s_databaseDataSet.teachersDataTable ma;
        _Alif_s_databaseDataSet.korsimDataTable mz;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\alif bishara\alif bishara\Alif's database.mdb");

        
        private void frmKors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.korsim' table. You can move, or remove it, as needed.
            this.korsimTableAdapter.Fill(this._Alif_s_databaseDataSet.korsim);
            
            ma = _Alif_s_databaseDataSet.teachers;
            mz = _Alif_s_databaseDataSet.korsim;
            int i = 0;
           int x= mz.Rows.Count;

           while (i < x)
           {
               comboBokCod.Items.Add(mz.Rows[i][6].ToString());
               i++;
           }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblday3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




        private void lblTime2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOkAdd_Click(object sender, EventArgs e)
        {
            if (txtday1.MaskCompleted == true && txtday2.MaskCompleted == true && txtday3.MaskCompleted == true && txtday4.MaskCompleted == true && txtmikom.MaskCompleted == true
                   && txtShamKors.MaskCompleted == true && txtTashlomlkors.MaskCompleted == true && txttime1.MaskCompleted == true && txtTime2.MaskCompleted == true && txtTime3.MaskCompleted == true && txtTime4
                   .MaskCompleted == true && txtTzMora.MaskCompleted == true)
            {
                if (ma.Rows.Count == 0)
                { MessageBox.Show("בשביל לעשות קורס אתה צריך לפחות מורה 1"); }
                else
                {
                    int i = 0;
                    int k = ma.Rows.Count;
                    bool bl = true;
                    while (i < k && bl == true)
                    {
                        if (ma.Rows[i][0].ToString() == txtTzMora.Text.ToString())
                        {
                            bl = false;
                            i--;
                        }
                        i++;

                    }
                    if (bl == true)
                    {
                        MessageBox.Show("לא נמצא מורה בעל תעודת זהות זהה");
                    }
                    else
                    {
                        string sham = ma.Rows[i][1].ToString();
                        string family = ma.Rows[i][2].ToString();
                        int n = mz.Rows.Count;
                        int y;
                        if (n == 0)
                        { y = 1; }
                        else
                        {
                            y = int.Parse(mz.Rows[n][6].ToString()) + 1;
                        }
                        string cod = y.ToString();

                        korsimTableAdapter.addKors(txtShamKors.Text, txtTzMora.Text, sham, family, txtTashlomlkors.Text, txtmikom.Text, cod, dateTimePicker1.Text, txtday1.Text, txtday2.Text, txtday3.Text, txtday4.Text, txttime1.Text, txtTime2.Text, txtTime3.Text, txtTime4.Text, txtzmankors.Text);
                        korsimTableAdapter.Fill(this._Alif_s_databaseDataSet.korsim);


                        double j = 0;
                        if (txtday1.Text.ToString() != "")
                        {
                            j++;
                        }
                        if (txtday2.Text.ToString() != "")
                        {
                            j++;
                        }
                        if (txtday3.Text.ToString() != "")
                        {
                            j++;
                        }
                        if (txtday4.Text.ToString() != "")
                        {
                            j++;
                        }
                        if (ma.Rows[i][5].ToString() == "")
                        {
                            double o = j * Convert.ToDouble(txtzmankors.Text.ToString());
                            string t = o.ToString();

                            OleDbCommand da = new OleDbCommand("UPDATE teachers SET [shaot avoda] = '" + t + "' where [TZ]='" + ma.Rows[i][0] + "'", con);
                            con.Open();
                            da.ExecuteNonQuery();
                            con.Close();

                        }

                        else
                        {
                            //string sz = ma.Rows[i][5].ToString();
                            string K = txtzmankors.Text.ToString();
                            double x;
                            x = Convert.ToDouble(ma.Rows[i][5]);
                            double z = Convert.ToDouble(K);
                            double u = x + z;


                            OleDbCommand db = new OleDbCommand("UPDATE teachers SET [shaot avoda] = '" + u.ToString() + "' where [TZ]='" + ma.Rows[i][0] + "'", con);
                            con.Open();
                            db.ExecuteNonQuery();
                            con.Close();
                            frmKors_Load(sender, e);

                            txtday1.Text = "";
                            txtday2.Text = "";
                            txtday3.Text = "";
                            txtday4.Text = "";
                            txtmikom.Text = "";
                            txtShamKors.Text = "";
                            txtTashlomlkors.Text = "";
                            txttime1.Text = "";
                            txtTime2.Text = "";
                            txtTime3.Text = "";
                            txtTime4.Text = "";
                            txtzmankors.Text = "";
                            txtTzMora.Text = "";

                        }



                    }
                }
            }
            else
            {
                MessageBox.Show("אחד מהנתונים שהזנתה אינו תקין נסה שנית");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("sham");
            dz.Columns.Add("tzMora");
            dz.Columns.Add("shamTeacher");
            dz.Columns.Add("shamFamily");
            dz.Columns.Add("tshlomLkors");
            dz.Columns.Add("mikom");
            dz.Columns.Add("code");
            dz.Columns.Add("korsEndingDate");
            dz.Columns.Add("yom1");
            dz.Columns.Add("yom2");
            dz.Columns.Add("yom3");
            dz.Columns.Add("yom4");
            dz.Columns.Add("time1");
            dz.Columns.Add("time2");
            dz.Columns.Add("time3");
            dz.Columns.Add("time4");
            dz.Columns.Add("zmanMfgash");



            


            for (int j = 0; j <mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(txtsearch.Text ))//(ma.Rows[j][k].ToString() == txtSearch.Text.ToString()) 
                    {

                        
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7], mz[j][8], mz[j][9], mz[j][10], mz[j][11], mz[j][12], mz[j][13], mz[j][14], mz[j][15],mz[j][16]);
                        k = mz.Columns.Count;

                    }
                }
            }
            dataGridView1.DataSource = dz;

           
        }

        private void btnMhika_Click(object sender, EventArgs e)
        {
            
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    int a = dataGridView1.SelectedRows[0].Index;
                    string s = dataGridView1.Rows[a].Cells[6].Value.ToString();

                    OleDbCommand da = new OleDbCommand("Delete from korsim where code='" + s + "'", con);
                    con.Open();
                    da.ExecuteNonQuery();
                    con.Close();
                    teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
                    frmKors_Load(sender, e);
                }
            }
            
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            

            if (comboBokCod.Text=="")
            {
                MessageBox.Show("בחר את קוד הקורס שתרצה לעדכן");
            }
            else
            {
                int i = 0;
                while (mz.Rows[i][6].ToString() != comboBokCod.Text)
                {
                    
                    i++;
                }
                string s;
                if (txtmikom.Text.ToString() == "")
                {
                     s = mz.Rows[i][5].ToString();
                }
                else
                {
                    s = txtmikom.Text.ToString();
                }
                string day1;
                if(txtday1.Text=="")
                {
                    day1 =mz.Rows[i][8].ToString();
                }
                else
                {
                    day1 = txtday1.Text.ToString();
                }
                string day2;
                if (txtday1.Text == "")
                {
                    day2 = mz.Rows[i][9].ToString();
                }
                else
                {
                    day2 = txtday2.Text.ToString();
                }
                string day3;
                if (txtday1.Text == "")
                {
                    day3 = mz.Rows[i][10].ToString();
                }
                else
                {
                    day3 = txtday3.Text.ToString();
                }
                string day4;
                if (txtday1.Text == "")
                {
                    day4 = mz.Rows[i][11].ToString();
                }
                else
                {
                    day4 = txtday4.Text.ToString();
                }
                string zman1;
                    if(txttime1.Text=="  :")
                    {
                        zman1 = mz.Rows[i][12].ToString();
                    }
                    else
                    {
                        zman1 = txttime1.Text.ToString();
                    }
                    string zman2;
                    if (txtTime2.Text == "  :")
                    {
                        zman2 = mz.Rows[i][13].ToString();
                    }
                    else
                    {
                        zman2 = txtTime2.Text.ToString();
                    }
                    string zman3;
                    if (txtTime2.Text == "  :")
                    {
                        zman3 = mz.Rows[i][14].ToString();
                    }
                    else
                    {
                        zman3 = txtTime3.Text.ToString();
                    }
                    string zman4;
                    if (txtTime2.Text == "  :")
                    {
                        zman4 = mz.Rows[i][15].ToString();
                    }
                    else
                    {
                        zman4 = txtTime4.Text.ToString();
                    }
                    string zmanMfgash;
                    string teachernewtime;
                    if (txtzmankors.Text == "")
                    {
                        zmanMfgash = mz.Rows[i][16].ToString();
                    }
                    else
                    {
                        double j = 0;
                        if (mz.Rows[i][8].ToString() != "")
                        {
                            j++;
                        }
                        if (mz.Rows[i][9].ToString() != "")
                        {
                            j++;

                        }
                        if (mz.Rows[i][10].ToString() != "")
                        {
                            j++;
                        }
                        if (mz.Rows[i][11].ToString() != "")
                        {
                            j++;
                        }
                        double time = Convert.ToDouble(mz.Rows[i][16].ToString());
                        zmanMfgash = txtzmankors.Text.ToString();
                        double newtime = Convert.ToDouble(ma.Rows[i][5]) - time + j * Convert.ToDouble(zmanMfgash.ToString());
                        teachernewtime = newtime.ToString();
                        OleDbCommand dt = new OleDbCommand("UPDATE teachers SET [shaot avoda] = '" + teachernewtime + "' where [TZ] = '" + ma.Rows[i][1].ToString() + "' ");
                        con.Open();
                        dt.ExecuteNonQuery();
                        con.Close();
                    }

                    OleDbCommand da = new OleDbCommand("UPDATE korsim SET [mikom] = '" + s + "', [yom1] = '" + day1 + "', [yom2] = '" + day2 + "', [yom3] = '" + day3 + "', [yom4] = '" + day4 + "', [time1] = '" + zman1 + "', [time2] = '" + zman2 + "', [time3] = '" + zman3 + "', [time4] = '" + zman4 + "', [zmanMfgash] = '" + zmanMfgash + "' where [code]='" + comboBokCod.Text + "'", con);
                    con.Open();
                    da.ExecuteNonQuery();
                    con.Close();
                    this.korsimTableAdapter.Fill(this._Alif_s_databaseDataSet.korsim);
            }
            
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void comboBokCod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnclean.Visible = true;
            btCancel.Visible = true;
            comboBokCod.Visible = true;
            lblCode.Visible = true;
            BtnOkAdd.Visible = false;
            btnupdate.Visible = true;
            btnMhika.Visible = false;
            panel1.Visible = true;
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btnclean.Visible = true;
            btCancel.Visible = true;
            comboBokCod.Visible = false;
            lblCode.Visible = false;
            BtnOkAdd.Visible = true;
            btnupdate.Visible = false;
            btnMhika.Visible = false;
            panel1.Visible = true;
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("למחיקה בחר בקורס שתרצה למחוק מהטבלה ולחץ על מחיקה");
            btnclean.Visible = false;
            btCancel.Visible = true;
            comboBokCod.Visible = false;
            lblCode.Visible = false;
            BtnOkAdd.Visible = false;
            btnupdate.Visible = false;
            btnMhika.Visible = true;
            panel1.Visible = false;
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btnclean.Visible = false;
            btCancel.Visible = false;
            comboBokCod.Visible = false;
            lblCode.Visible = false;
            BtnOkAdd.Visible = false;
            btnupdate.Visible = false;
            btnMhika.Visible = false;
            panel1.Visible = false;
            
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
            txtShamKors.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtTzMora.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtTashlomlkors.Text=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtmikom.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            comboBokCod.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtday1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtday2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
            txtday3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString();
            txtday4.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString();
            txttime1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[12].Value.ToString();
            txtTime2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[13].Value.ToString();
            txtTime3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[14].Value.ToString();
            txtTime4.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[15].Value.ToString();
            txtzmankors.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[16].Value.ToString();
        }

        private void txtShamKors_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnclean_Click_1(object sender, EventArgs e)
        {
            txtday1.Text = "";
            txtday2.Text = "";
            txtday3.Text = "";
            txtday4.Text = "";
            txtmikom.Text = "";
            txtShamKors.Text = "";
            txtTashlomlkors.Text = "";
            txttime1.Text = "";
            txtTime2.Text = "";
            txtTime3.Text = "";
            txtTime4.Text = "";
            txtzmankors.Text = "";
            txtTzMora.Text = "";
        }
    }
}
