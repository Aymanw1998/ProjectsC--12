using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace christina_hourses
{
    public partial class mascoret : Form
    {
        public mascoret()
        {
            InitializeComponent();

        }
          hoursesDataSet.workeersDataTable mm;
          hoursesDataSet.workeersDataTable dw;

          hoursesDataSet.mishmarotDataTable mk;


        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OK_Click(object sender, EventArgs e)
        { 
            
                mm = hoursesDataSet.workeers;
                string k = textbox_password.Text;
                string c = combokod.Text;
                bool bl = true;
                string kk;
                for (int j = 0; (j < mm.Rows.Count); j++)
                {
                    kk = mm.Rows[j]["mispar oved"].ToString();

                    if (k.Equals(kk)||c.Equals(kk))
                    {
                        k = "";
                        c = "";
                        txb_shem.Visible = true;
                        txb_mscoret.Visible = true;
                        txb_hour.Visible = true;
                        oved.Visible = true;
                        mscoret.Visible = true;
                        hour.Visible = true;

                        DataGridViewRow row = dataGridView1.Rows[j];
                        txb_shem.Text = row.Cells[1].Value.ToString();
                        bl = false;

                    }


                }

                if  (bl == true)
                {
                    MessageBox.Show("עובד זה לא קיים במערכת!");
                }
                textbox_password.Text = "";



                int summinuts1 = 0;
                 int sumhours1 = 0;
                 string st1 = "";
                 string st2 = ""; ;
                mk = hoursesDataSet.mishmarot;
                for (int j = 0; j < mk.Rows.Count; j++)
                {
                    string a = mk.Rows[j][4].ToString();
                    
                    bool bll = true;
                    bool blo = true;
                    for (int t = 0; t < a.Length && bll; t++)
                    {
                        if (a[t] != ':' && blo)
                        {
                            st1 = st1 + a[t];

                        }
                        else
                        { blo = false; }

                        if(a[t]!=':')
                            st2= st2 + a[t];
                        }
                    }

                    int hours1 = Convert.ToInt32(st1);
                    int minuts1 = Convert.ToInt32(st2);
                    
                     summinuts1 = summinuts1 + minuts1;
                    if (summinuts1 > 60)
                    {
                        int s = summinuts1 / 60;
                        int r = summinuts1 % 60;
                        sumhours1 = hours1 + s + sumhours1;
                        summinuts1 = r;
                    }
                    else
                    {
                        sumhours1 = hours1 + sumhours1;
                    }

                    string str = sumhours1 + ":" + summinuts1;

                }



        

    
       



        private void mascoret_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.hoursesDataSet.mishmarot);
            // TODO: This line of code loads data into the 'hoursesDataSet.shaot' table. You can move, or remove it, as needed.
            this.shaotTableAdapter.Fill(this.hoursesDataSet.shaot);
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);

            string spass = workeersTableAdapter.passmnhel();

            if (Form1.pass == spass)
            {
                combokod.Visible = true;
                textbox_password.Visible = false;
            }
            mm = hoursesDataSet.workeers;
            for (int i = 0; i < mm.Rows.Count; i++)
            {
                combokod.Items.Add(mm.Rows[i]["mispar oved"].ToString());
            }
                
           
        }




        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)
                textbox_password.UseSystemPasswordChar = true;
            else
                textbox_password.UseSystemPasswordChar = false;
        }

        private void txb_shem_TextChanged(object sender, EventArgs e)
        {

        }

        private void combokod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
