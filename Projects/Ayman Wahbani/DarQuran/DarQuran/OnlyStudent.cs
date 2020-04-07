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
    public partial class OnlyStudent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        DataTable dt = new DataTable(); string tz; DataTable dt2 = new DataTable(); DataTable dt3 = new DataTable();
        public OnlyStudent(string Tz)
        {
            InitializeComponent();
            tz = Tz;
        }

        private void OnlyStudent_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'darQuranDataSet.Hodor' table. You can move, or remove it, as needed.
            this.hodorTableAdapter.Fill(this.darQuranDataSet.Hodor);
            // TODO: This line of code loads data into the 'darQuranDataSet.Taakher' table. You can move, or remove it, as needed.
            this.taakherTableAdapter.Fill(this.darQuranDataSet.Taakher);
            // TODO: This line of code loads data into the 'darQuranDataSet.heiab' table. You can move, or remove it, as needed.
            this.heiabTableAdapter.Fill(this.darQuranDataSet.heiab);
            label1.Text = "0"; label2.Text = "0";label2.Text = "0";
            OleDbDataAdapter da = new OleDbDataAdapter("Select NT,Tarekh from Hodor where TZ='"+tz+"'", con);
            da.Fill(dt);
            dataGridViewGreen.DataSource = dt;
            OleDbDataAdapter daa = new OleDbDataAdapter("Select NT,Tarekh from heiab where TZ='" + tz + "'", con);
            daa.Fill(dt2);
            dataGridViewRed.DataSource = dt2;
            OleDbDataAdapter dad = new OleDbDataAdapter("Select NT,Tarekh from Taakher where TZ='" + tz + "'", con);
            dad.Fill(dt3);
            dataGridViewYellow.DataSource = dt3;
          //if (dt.Rows[0]["NT"].ToString() != "")
            label1.Text = (dt.Rows.Count).ToString();
            //if (dt3.Rows[0]["NT"].ToString() != "")
            label2.Text = (dt3.Rows.Count).ToString();
           // if (dt2.Rows[0]["NT"].ToString() != "")
            label3.Text = (dt2.Rows.Count).ToString();

        }

        private void panelGreen_Click(object sender, EventArgs e)
        {
            dataGridViewGreen.Visible = true;
        }

        private void panelYellow_Click(object sender, EventArgs e)
        {
            dataGridViewYellow.Visible = true;
        }

        private void panelRed_Click(object sender, EventArgs e)
        {
            dataGridViewRed.Visible = true;
        }
    }
}
