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
    public partial class hazmanot_kayamot : Form
    {
        public hazmanot_kayamot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.borrowDataTable kr;

        private void hazmanot_kayamot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.liDataSet.borrow);
            kr = liDataSet.borrow;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("book name");
            dz.Columns.Add("date of borowing");
            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    
                    
                        dz.Rows.Add(kr[j][0], kr[j][1], kr[j][2]);
                        k = kr.Columns.Count;
                    
                }

            }

            dataGridView1.DataSource = dz;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void hazmanot_kayamot_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }
    }
}
