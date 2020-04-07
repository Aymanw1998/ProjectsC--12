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


namespace חנות_נעליים
{
    public partial class archives : Form
    {
        public archives()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        shoe_shopDataSet.archivesDataTable aa;
        int selectedRow;


        private void archives_Load(object sender, EventArgs e)
        {
            this.archivesTableAdapter.Fill(this.shoe_shopDataSet.archives);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            aa = shoe_shopDataSet.archives;
            DataTable dz = new DataTable();
            dz.Columns.Add("date");
            dz.Columns.Add("tz");
            dz.Columns.Add("shaot avoda");
            for (int j = 0; j < aa.Rows.Count; j++)
            {
                if (aa.Rows[j][1].ToString().Contains(textBox1.Text))
                {
                    dz.Rows.Add(aa[j][0], aa[j][1], aa[j][2]);
                }
            }
            dataGridView1.DataSource = dz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 9)
            {
                aa = shoe_shopDataSet.archives;
                int sum_hh = 0;
                int sum_mm = 0;
                int hh_int;
                int mm_int;

                if (dataGridView1.Rows.Count > 0)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                    {
                        string shaot = aa.Rows[j][2].ToString();
                        string hh_string = shaot.Substring(0, 2);
                        hh_int = Convert.ToInt32(hh_string);
                        string mm_string = shaot[3] + shaot[4].ToString();
                        mm_int = Convert.ToInt32(mm_string);
                        sum_hh = hh_int + sum_hh;
                        sum_mm = mm_int + sum_mm;
                    }
                    sum_hh = sum_hh + sum_mm / 60;
                    sum_mm = sum_mm % 60;

                    MessageBox.Show(sum_hh.ToString() + ":" + sum_mm.ToString() + " סך הכל שעות עבודה לעובד זה ");
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("נקה ארכיון", "נקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                aa = shoe_shopDataSet.archives;

                for (int i = 0; i < aa.Rows.Count; i++)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "delete from archives where date='" + aa.Rows[i]["date"].ToString() + "' ";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    archives_Load(sender, e);

                }
            }
        }
        
    }
}
