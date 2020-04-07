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
    public partial class lobtokef : Form
    {
        public lobtokef()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.kartis_korehDataTable kr;

        private void lobtokef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.kartis_koreh' table. You can move, or remove it, as needed.
            this.kartis_korehTableAdapter.Fill(this.liDataSet.kartis_koreh);
            kr = liDataSet.kartis_koreh;

            DataTable dz = new DataTable();
                dz.Columns.Add("id ");
                dz.Columns.Add("name ");
                dz.Columns.Add("last name");
                dz.Columns.Add("phone");
                dz.Columns.Add("start day");
                dz.Columns.Add("end day");

            
                for (int j = 0; j < kr.Rows.Count; j++)
                {
                   

                        if (kr.Rows[j]["tokef"].ToString() == "לא")
                        {

                            dz.Rows.Add(kr[j][1], kr[j][2], kr[j][3]);

                           
                        }

                    
                }
                dataGridView1.DataSource = dz;

            }
        }
    }

