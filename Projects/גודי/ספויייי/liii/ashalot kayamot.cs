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
    public partial class ashalot_kayamot : Form
    {
        public ashalot_kayamot()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.hazmanotDataTable kr;

        private void ashalot_kayamot_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'liDataSet.hazmanot' table. You can move, or remove it, as needed.
            this.hazmanotTableAdapter.Fill(this.liDataSet.hazmanot);
            kr = liDataSet.hazmanot;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("book name");
            dz.Columns.Add("date of hazmana");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ashalot_kayamot_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
