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
    
    public partial class tashlom : Form
    {
        string shom;
        public tashlom(string shom1)
        {
            InitializeComponent();
            shom = shom1;
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Comp-19\Desktop\עבודות בגרות יב 2017\alif bishara\alif bishara\Alif's database.mdb");
       
        _Alif_s_databaseDataSet.tashlomDataTable mz;
        private void tashlom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Alif_s_databaseDataSet.tashlom' table. You can move, or remove it, as needed.
            this.tashlomTableAdapter.Fill(this._Alif_s_databaseDataSet.tashlom);
            mz = _Alif_s_databaseDataSet.tashlom;
            txtskhom.Text = shom;
        if(shom=="")
        {
            panel1.Visible = false;
        }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = "50";
            txtTz.Text =s;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtSham.MaskCompleted && txtShamMshpha.MaskCompleted && txtTz.MaskCompleted && txtskhom.Text!="")
            {
                string code = dataGridView1.Rows.Count.ToString();
                tashlomTableAdapter.add(code, txtTz.Text, txtSham.Text, txtShamMshpha.Text, DateTime.Now.ToShortDateString(), txtskhom.Text, comboBox1.Text);
                this.tashlomTableAdapter.Fill(this._Alif_s_databaseDataSet.tashlom);
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("אחד מהנתונים שהזנת אינו תקין");
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dz = new DataTable();
            dz.Columns.Add("codekabla");
            dz.Columns.Add("tzLkoah");
            dz.Columns.Add("sham");
            dz.Columns.Add("shamfamily");
            dz.Columns.Add("tarikh");
            dz.Columns.Add("shomkolal");
            dz.Columns.Add("aofnTashlom");
            


            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(txtSearch.Text))//(ma.Rows[j][k].ToString() == txtSearch.Text.ToString()) 
                    {


                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6]);
                        k = mz.Columns.Count;

                    }
                }
            }
            dataGridView1.DataSource = dz;

        }

        private void txtTz_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int a = dataGridView1.SelectedRows[0].Index;
                string s = dataGridView1.Rows[a].Cells[0].Value.ToString();
                
                OleDbCommand da = new OleDbCommand("Delete from tashlom where codekabla='" + s + "'", con);
                con.Open();
                da.ExecuteNonQuery();
                con.Close();
                tashlomTableAdapter.Update(this._Alif_s_databaseDataSet.tashlom);
                this.tashlomTableAdapter.Fill(this._Alif_s_databaseDataSet.tashlom);
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            double sum=0;
            int i = 0;
            DateTime ss;
            while (i<mz.Rows.Count)
            {
                ss = DateTime.Parse(mz.Rows[i][4].ToString());
                if(dateTimePicker1.Value.Year<=ss.Year && dateTimePicker2.Value.Year>ss.Year)
                {
                    sum = sum + Convert.ToDouble(mz.Rows[i][5].ToString());
                }
                else if((dateTimePicker1.Value.Year==ss.Year && dateTimePicker2.Value.Year==ss.Year)||(dateTimePicker1.Value.Year<ss.Year && dateTimePicker2.Value.Year==ss.Year))
                {
                    if(dateTimePicker1.Value.Month<=ss.Month && dateTimePicker2.Value.Month>ss.Month)
                    {
                        sum = sum + Convert.ToDouble(mz.Rows[i][5].ToString());
                    }
                    else if(dateTimePicker1.Value.Month==ss.Month && dateTimePicker2.Value.Month==ss.Month)
                    { 
                        if(dateTimePicker1.Value.Day<=ss.Month && dateTimePicker2.Value.Month>=ss.Month)
                    {
                        sum=sum+Convert.ToDouble(mz.Rows[i][5].ToString());
                    }
                        
                    }
                }
                i++;

            }
            txthknsa.Text = sum.ToString();

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if(panel2.Visible==false)
            panel2.Visible = true;
            else
            {
                panel2.Visible = false;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}

