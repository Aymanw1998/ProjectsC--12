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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\alif bishara\alif bishara\Alif's database.mdb");
        _Alif_s_databaseDataSet.teachersDataTable ma;



        private void frmTeacher_Load(object sender, EventArgs e)
        {
            ma = _Alif_s_databaseDataSet.teachers;
            
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.teachers' table. You can move, or remove it, as needed.
            
           this.teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
           int i = 0;
           while (i < ma.Rows.Count)
           {
               combosahar.Items.Add(ma.Rows[i][0].ToString());
               i++;
           }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTair.MaskCompleted == true && txtTsahar.MaskCompleted == true && txtTsham.MaskCompleted == true && txtTshamfamily.MaskCompleted == true && txtTtel.MaskCompleted == true && txtTtz.MaskCompleted == true)
            {
                teachersTableAdapter.addTeacher(txtTtz.Text.ToString(), txtTsham.Text.ToString(), txtTshamfamily.Text.ToString(), txtTtel.Text.ToString(), txtTsahar.Text.ToString(), txtTair.Text.ToString());
                teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
                txtTair.Text = "";
                txtTsahar.Text = "";
                txtTsham.Text = "";
                txtTshamfamily.Text = "";
                txtTtel.Text = "";
                txtTtz.Text = "";
            }
            else
            {
                MessageBox.Show("אחד או יותר מהנתונים שהקשת אינו  תקין");
            }


        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtTair.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtAirUpdate.Text = "";
            txtsaharcal.Text = "";
            txtSaharUpdate.Text = "";
            txtTelUpdate.Text = "";
            txtTZupdate.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                string s = dataGridView1.Rows[a].Cells[0].Value.ToString();

                OleDbCommand da = new OleDbCommand("Delete from teachers where TZ='" + s + "'", con);
                con.Open();
                da.ExecuteNonQuery();
                con.Close();
                teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
                frmTeacher_Load(sender, e);

            }

            else
            {
                string s = txtTtz.Text.ToString();
                OleDbCommand da = new OleDbCommand("Delete from teachers where TZ='" + s + "'", con);
                con.Open();
                da.ExecuteNonQuery();
                con.Close();
                teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
                frmTeacher_Load(sender, e);


            }

            dataGridView1.DataSource = _Alif_s_databaseDataSet.teachers;
        }

        private void btnADdStudent_Click(object sender, EventArgs e)
        {
            btnclean.Visible = true;
            btnOkAdd.Visible = true;
            panel1.Visible = true;
            btnOkDelete.Visible = false;
            
            
            btncancel.Visible = true;
            btnokupdate.Visible = false;
            btnupdateteacher.Visible = true;
            panel2.Visible = false;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
        }

        private void btnDeletestudent_Click(object sender, EventArgs e)
        {
            panelsahar.Visible = false;
            MessageBox.Show("למחיקה בחר במורה שתרצה למחוק מהטבלה ולחץ על מחיקה");
            btnclean.Visible = true;
            btnOkAdd.Visible = false;
            panel1.Visible = true;
            btnOkDelete.Visible = true;
            btnADdteacher.Visible = true;
            btncancel.Visible = true;
            btnokupdate.Visible = false;
            btnupdateteacher.Visible = true;
            panel2.Visible = false;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panelsahar.Visible = false;
            panel2.Visible = false;
            btnclean.Visible = false;
            btnOkAdd.Visible = false;
            panel1.Visible = false;
            btnOkDelete.Visible = false;
            btnADdteacher.Visible = true;
            btnDeleteteacher.Visible = true;
            btncancel.Visible = false;
            btnokupdate.Visible = false;
            btnupdateteacher.Visible = true;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (txtAirUpdate.MaskCompleted == true && txtSaharUpdate.MaskCompleted == true && txtTZupdate.MaskCompleted == true && txtTelUpdate.MaskCompleted == true)
            {
                teachersTableAdapter.a(txtSaharUpdate.Text.ToString(), txtAirUpdate.Text, txtTelUpdate.Text, txtTZupdate.Text);
                this.teachersTableAdapter.Fill(this._Alif_s_databaseDataSet.teachers);
            }
            else
            {
                MessageBox.Show("הנתונים שהזנת לא תקינים ");
            
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
                DataTable dz = new DataTable();
                dz.Columns.Add("TZ");
                dz.Columns.Add("sham");
                dz.Columns.Add("shamf");
                dz.Columns.Add("tel");
                dz.Columns.Add("sahar");
                dz.Columns.Add("shaot avoda");
                dz.Columns.Add("air");
                
                for (int j = 0; j < ma.Rows.Count; j++)
                {
                    for (int k = 0; k < ma.Columns.Count; k++)
                    {
                        if (ma.Rows[j][k].ToString().Contains(txtsearch.Text))//(ma.Rows[j][k].ToString() == txtSearch.Text.ToString()) 
                        {
                            
                            dataGridView1.Visible = true;
                            dz.Rows.Add(ma[j][0], ma[j][1], ma[j][2], ma[j][3], ma[j][4], ma[j][5], ma[j][6]);
                            k = ma.Columns.Count;

                        }
                    }
                }
                dataGridView1.DataSource = dz;
           
        }

        private void btnupdateteacher_Click(object sender, EventArgs e)
        {
            btnokupdate.Visible = true;
            btnclean.Visible = true;
            btncancel.Visible = true;
            btnOkDelete.Visible = false;
            btnOkAdd.Visible = false;
            
            panel2.Visible = true;
            panel1.Visible = false;
            panelsahar.Visible = false;

            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtTtz_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTsahar_Click(object sender, EventArgs e)
        {

        }

        private void btndeletebut_Click(object sender, EventArgs e)
        {
            btncancel.Visible = true;
            btnclean.Visible = true;
            btnOkAdd.Visible=true;
            btnupdateteacher.Visible = false;
            btnOkDelete.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
            


        }

        private void btnUpdatebtn_Click(object sender, EventArgs e)
        {
            btncancel.Visible = true;
            btnclean.Visible = true;
            btnOkAdd.Visible = false;
            btnupdateteacher.Visible = true;
            btnOkDelete.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
        }

        private void btnDeletebtn_Click(object sender, EventArgs e)
        {
            btncancel.Visible = true;
            btnclean.Visible = false;
            btnOkAdd.Visible = false;
            btnupdateteacher.Visible = false;
            btnOkDelete.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            txtAirUpdate.Text = "";
            txtSaharUpdate.Text = "";
            txtsearch.Text = "";
            txtTair.Text = "";
            txtTelUpdate.Text = "";
            txtTsahar.Text = "";
            txtTsham.Text = "";
            txtTshamfamily.Text = "";
            txtTtel.Text = "";
            txtTtz.Text = "";
            txtTZupdate.Text = "";
        }

        private void txtTelUpdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSaharUpdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btncalall_Click(object sender, EventArgs e)
        {
            combosahar.Text = "";
            double sum = 0;
            int i=0;
            while(i<ma.Rows.Count)
            {
                if(ma.Rows[i][5].ToString()!="")
                {
                    double s = Convert.ToDouble(ma.Rows[i][4].ToString()) * Convert.ToDouble(ma.Rows[i][5].ToString());
                    sum = sum + s;
                    
                }
                i++;
            }
            txtsaharcal.Text = sum.ToString();
        }

        private void btncalculate1_Click(object sender, EventArgs e)
        {
            if (combosahar.Text != "")
            {
                int i = 0;
                while (combosahar.Text != ma.Rows[i][0].ToString())
                {
                    i++;
                }
                if (ma.Rows[i][5].ToString() != "")
                {
                    double s = Convert.ToDouble(ma.Rows[i][4].ToString()) * Convert.ToDouble(ma.Rows[i][5].ToString());
                    txtsaharcal.Text = s.ToString();
                }
                else
                {
                    txtsaharcal.Text = "0";
                }
            }
        }

        private void btnopenpanelsalary_Click(object sender, EventArgs e)
        {
            panelsahar.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            btncancel.Visible = false;
            btnclean.Visible = false;
            btnokupdate.Visible = false;
            btncancel.Visible = true;

        }

        private void txtsaharcal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTsham_Click(object sender, EventArgs e)
        {

        }

        private void txtTsham_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
