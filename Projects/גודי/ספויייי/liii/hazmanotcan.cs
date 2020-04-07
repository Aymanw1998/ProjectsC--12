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

namespace liii
{
    public partial class hazmanotcan : Form
    {
        public hazmanotcan()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.trashDataTable kr;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hazmanotcan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.trash' table. You can move, or remove it, as needed.
            this.trashTableAdapter.Fill(this.liDataSet.trash);
            kr = liDataSet.trash;
            DataTable dz = new DataTable();
            dz.Columns.Add("id ");
            dz.Columns.Add("book name ");
            dz.Columns.Add("date");
            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {

                    if (kr.Rows[j]["bitol"].ToString() == "hz")
                    {

                        dz.Rows.Add(kr[j][1], kr[j][2], kr[j][3]);

                        k = kr.Columns.Count;
                    }

                }
            }
            dataGridView1.DataSource = dz;

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void hazmanotcan_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
