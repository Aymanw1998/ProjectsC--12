using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }
        razan22DataSet1.mitamneem2DataTable ms;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.mitamneem2' table. You can move, or remove it, as needed.
            this.mitamneem2TableAdapter.Fill(this.razan22DataSet1.mitamneem2);

            
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if(hh<10)
            {
                time += "0" + hh;

            }

            else
            {
                time += hh;
            }

            time += ":";

            if(mm<10)
            {
                time += "0" + mm;
            }
            
            else
            {
                time += mm;
            }

            time += ":";

            if(ss<10)
            {
                time += "0" + ss;

            }

            else
            {
                time += ss;
            }
            label2.Text = time;
        }
        private void lblrashi_Click(object sender, EventArgs e)
        {

        }

        private void maskorot_Click(object sender, EventArgs e)
        {
          
        }

        private void mitamnim_Click(object sender, EventArgs e)
        {
            int count1 = 0;
            DateTime date1 = DateTime.Today;
            ms = razan22DataSet1.mitamneem2;
            for (int i = 0; i < ms.Rows.Count; i++)
            {

                DateTime date2 = Convert.ToDateTime(ms.Rows[i]["tokef"].ToString());

                int result = DateTime.Compare(date1, date2);

                if (result > 0)
                {
                    count1++;

                }

            }

        

            if(count1==0)
            {
                formtrainees frmtra = new formtrainees();
                frmtra.Show();
              
            }

            else if(count1>0)
            {
                DialogResult dr = MessageBox.Show("ישנם מנויים אשר פג תוקפם, תרצה לראות את הרשימה או להיכנס לרשימת המתאמנים?", "מנויים", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        manui frmtra = new manui();
                        frmtra.Show();
                       
                    }
                    else
                    {
                        formtrainees frmtra = new formtrainees();
                        frmtra.Show();
              
                    }

            }
            
        }

        private void meamnim_Click(object sender, EventArgs e)
        {
            

        }

        private void hugeem_Click(object sender, EventArgs e)
        {
            formhugeem frmhug = new formhugeem();
            frmhug.Show();
        }

        private void mahshireem_Click(object sender, EventArgs e)
        {
            formmahshireem frmmah = new formmahshireem();
            frmmah.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            formabout frmabo = new formabout();
            frmabo.Show();

        }

        private void ovdeem_Click(object sender, EventArgs e)
        {
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            formsapakim frmsup = new formsapakim();
            frmsup.Show();
        }

        private void menahel_Click(object sender, EventArgs e)
        {
            password frmpas = new password();
            frmpas.Show();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mahshireem_Click_1(object sender, EventArgs e)
        {

        }

        private void mahshireem_Click_2(object sender, EventArgs e)
        {
            formmahshireem frmmah = new formmahshireem();
            frmmah.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
