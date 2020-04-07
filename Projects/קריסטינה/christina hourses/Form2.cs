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

namespace christina_hourses
{
    public partial class Form_main : Form
    {
        public static int xpass;
        

        public Form_main()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");
        hoursesDataSet.workeersDataTable dw;

        private void btovdim_Click(object sender, EventArgs e)
        {
            Form_workers frm = new Form_workers();
            frm.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);

            xpass = 0;
           
            
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string spass = workeersTableAdapter.passmnhel();
            
            if (Form1.pass!= spass)
            {
                bt_activities.Visible = false;
                bt_horses.Visible = false;
                bt_lehohot.Visible = false;
                bt_sapakim.Visible = false;
                bt_tsiod.Visible = false;
                btovdim.Visible = false;
                button1.Visible = false;
                enterform1.Visible = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoman frm = new yoman();
            frm.Show();
           
        }

        private void bt_horses_Click(object sender, EventArgs e)
        {
            next frm = new next();
            frm.Show();
          
        }

        private void bt_tsiod_Click(object sender, EventArgs e)
        {
            Form_tsiood frm = new Form_tsiood();
            frm.Show();

        }

        private void bt_lehohot_Click(object sender, EventArgs e)
        {
            Form_lekohot frm = new Form_lekohot();
            frm.Show();

        }

        private void bt_activities_Click(object sender, EventArgs e)
        {
            Form_activity frm = new Form_activity();
            frm.Show();

        }

        private void bt_sapakim_Click(object sender, EventArgs e)
        {
            Form_sapakim frm = new Form_sapakim();
            frm.Show();

        }

        private void bt_enter_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            enter frm = new enter();
            frm.Show();
        }

        private void mscoret_Click(object sender, EventArgs e)
        {
            mascoret frm = new mascoret();
            frm.Show();
        }

        private void enterform1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
