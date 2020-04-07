using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public static string ps2;
        Thread th;
        public frmMain()
        {
            InitializeComponent();

            
        }

        
        bool bl1 = false;
        bool bl2 = false;
       

        private void btnOpenmnhlim_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpenOvdeem_Click(object sender, EventArgs e)
        {
            frmOvdim ov = new frmOvdim();
            if (bl1&&!(bl2))
            {
                ov.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spakim sp = new spakim();
            if (bl1 && !(bl2))
            {
                sp.Show();

            }

            
        }

        private void btnOpenSokhen_Click(object sender, EventArgs e)
        {
            sokhnim sk = new sokhnim();
            if (bl1  ||(bl2))
            {
                sk.Show();
            }
        }

        private void btnOpenLkohot_Click(object sender, EventArgs e)
        {
            Frmlakohot lk = new Frmlakohot();
            if (bl1 && !(bl2))
            {
                lk.Show();
            }

        }

        private void btnOpenMotzarim_Click(object sender, EventArgs e)
        {
            frmmotzarim mz = new frmmotzarim();
            if (bl1 && !(bl2))
            {
                mz.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            
            
            if (frm.pass5 == "600")
            {
                MessageBox.Show("שלום מנהל");
                MessageBox.Show("ברוך הבא");
                bl1 = true;
            }
            else
            {
                if (frm.pass5 == "400" || frm.pass5 == "450")
                {
                    MessageBox.Show("שלום מזכירה");
                    MessageBox.Show("ברוך הבא");
                    bl2 = true;
                }

                else
                {
                    MessageBox.Show("קוד שגוי");
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    frm.ps2 = frm.ps2+1;
                }
            } 
            
                
            
         }

        private void opennewform(object obj)
        {
           Application.Run(new frm());
        }




            
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            mikom mk = new mikom();
            if (bl1||bl2)
            {
                mk.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmhz1 hz = new frmhz1();
            if (bl1||bl2)
            {
                hz.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hzSpk swp = new hzSpk();
            if (bl1 && !(bl2))
            {
                swp.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmkhirot mkh = new frmkhirot();
            if (bl1||bl2)
            {
                mkh.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            frmhazrot hza = new frmhazrot();
            if (bl1 || bl2)
            {
                hza.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmhlk22 hza = new frmhlk22();
            if (bl1 && !(bl2))
            {
                hza.Show();
            }
        }
    }
}
