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
    public partial class HodorHeiab : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        string t; /*string k;*/ OleDbCommand co = new OleDbCommand();
        DataTable dt = new DataTable();
        DataTable dtd = new DataTable();
        DataTable dtdHelp = new DataTable();
        public HodorHeiab(string tN)
        {
            InitializeComponent();

            // k = kors;
            //con.Open();
            //co.Connection = con;
            //string g = "Select tzKors,shemKors from korsim where shemMora='" + t + "'";
            //co.CommandText = g;
            //OleDbDataReader r;
            //r = co.ExecuteReader();
            //while (r.Read())
            //{
            //    string sasashem = r["shemKors"].ToString();
            //    comboBoxKors.Items.Add(sasashem);
            //}
            t = tN;
            con.Open();
            co.Connection = con;
            string g = "Select tzKors,shemKors from korsim where shemMora='" +t + "'";
            co.CommandText = g;
            OleDbDataReader r;
            r = co.ExecuteReader();
            while (r.Read())
            {
              string  sasatz = r["tzKors"].ToString();
              string  sasashem = r["shemKors"].ToString();
                comboBoxKors.Items.Add(sasashem);
            }
            con.Close();
        }

        private void HodorHeiab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet1.Taakher' table. You can move, or remove it, as needed.
            this.taakherTableAdapter.Fill(this.darQuranDataSet.Taakher);
            // TODO: This line of code loads data into the 'darQuranDataSet1.heiab' table. You can move, or remove it, as needed.
            this.heiabTableAdapter.Fill(this.darQuranDataSet.heiab);
            // TODO: This line of code loads data into the 'darQuranDataSet1.Hodor' table. You can move, or remove it, as needed.
            this.hodorTableAdapter.Fill(this.darQuranDataSet.Hodor);
            // TODO: This line of code loads data into the 'darQuranDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.darQuranDataSet.students);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            //string s;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].ToString() != "")
                {

                    if (dataGridView1.Rows[i].Cells[4].Value != null)
                    {
                        count++;
                        MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());
                       if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "حاضر")
                        {
                            darQuranDataSet.Hodor.AddHodorRow(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), DateTime.Now.ToString("dd/MM/yyyy"));
                            hodorTableAdapter.Update(darQuranDataSet.Hodor);
                        }
                        else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "غائب")
                        {
                            darQuranDataSet.heiab.AddheiabRow(dataGridView1.Rows[i].Cells[0].ToString(), t, DateTime.Now.ToString("dd/MM/yyyy"));
                            heiabTableAdapter.Update(darQuranDataSet.heiab);
                        }
                        else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "متأخر")
                        {
                            darQuranDataSet.Taakher.AddTaakherRow(dataGridView1.Rows[i].Cells[0].ToString(), t, DateTime.Now.ToString("dd/MM/yyyy"));
                            taakherTableAdapter.Update(darQuranDataSet.Taakher);
                        }
                        else
                        {
                            MessageBox.Show("يوجد طلاب لم يُوطع لهم اشارة من اساران الحضور والغياب.أرجو ملائهم جميعاً");
                        }
                    }
                }
            }
            if (count == 0)
            {
                MessageBox.Show("لم يحفظ شيء");
            }
            else
            {
                MessageBox.Show("حفظ المعلومات");
            }
        }

        private void comboBoxKors_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Visible = true;

            dt.Columns.Add("رقم الهوية");
            dt.Columns.Add("الاسم الشخصي");
            dt.Columns.Add("اسم الوالد");
            dt.Columns.Add("اسم العائلة");


            if (comboBoxKors.Text != "")
            {
                con.Open();
                co.Connection = con;

                string g = "Select tzKors from korsim where shemKors='" + comboBoxKors.Text + "' AND shemMora='" + t + "'";
                co.CommandText = g;
                OleDbDataReader r;
                r = co.ExecuteReader();

                while (r.Read())
                {
                    string sasatz = r["tzKors"].ToString();

                    OleDbDataAdapter da = new OleDbDataAdapter("Select tz from [korsAndstudents] where Kors1='" + sasatz + "' OR Kors2='" + sasatz + "' OR Kors3='" + sasatz + "' OR Kors4='" + sasatz + "' OR Kors5='" + sasatz + "'", con);
                    da.Fill(dtd);
                    for (int i = 0; i < dtd.Rows.Count; i++)
                    {

                        OleDbDataAdapter dN = new OleDbDataAdapter("Select * from [students] where tz='" + dtd.Rows[i][0].ToString() + "'", con);
                        dN.Fill(dtdHelp);

                        if (dt.Rows.Count == 0)
                        {

                            dt.Rows.Add(dtdHelp.Rows[i][0], dtdHelp.Rows[i][1], dtdHelp.Rows[i][2], dtdHelp.Rows[i][3]);
                        }
                        else
                        {
                            int count = 0;
                            for (int w = 0; w < dt.Rows.Count; w++)
                            {

                                if (dt.Rows[w][0].ToString() == dtdHelp.Rows[i][0].ToString())
                                {
                                    count++;
                                }
                            }
                            if (count == 0)
                                dt.Rows.Add(dtdHelp.Rows[i][0], dtdHelp.Rows[i][1], dtdHelp.Rows[i][2], dtdHelp.Rows[i][3]);
                        }
                    }
                }
                con.Close();
                r.Close();


            }
            dataGridView1.DataSource = dt;
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "حضور وغياب";
            combo.ToolTipText = "إختار";
            combo.Items.Add("حاضر");
            combo.Items.Add("متأخر");
            combo.Items.Add("غائب");
            dataGridView1.Columns.Add(combo);
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
