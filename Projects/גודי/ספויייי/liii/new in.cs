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
    public partial class new_in : Form
    {
        public new_in()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.spakimDataTable kr;

        private void new_in_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.spakim' table. You can move, or remove it, as needed.
            this.spakimTableAdapter.Fill(this.liDataSet.spakim);
            kr = liDataSet.spakim;
            DataTable dz = new DataTable();
            dz.Columns.Add("coname");
            dz.Columns.Add("maname");
            dz.Columns.Add("cophone");
            dz.Columns.Add("manphone");
            dz.Columns.Add("mail");
            dz.Columns.Add("adress");

            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    
                    
                        dz.Rows.Add(kr[j][0], kr[j][1], kr[j][2], kr[j][3], kr[j][4], kr[j][5]);
                        k = kr.Columns.Count;
                    
                }

            }
            dataGridView1.DataSource = dz;
        }
            

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void new_in_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
