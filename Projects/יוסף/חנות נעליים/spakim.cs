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

namespace חנות_נעליים
{
    public partial class spakim : Form
    {
        Timer t = new Timer();




        public spakim()
        {
            InitializeComponent();
        }
        int selectedRow;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        shoe_shopDataSet.sapakeemDataTable sp;

        private void clock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }
        private void t_tick(object seder, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;

            }
            else
            {
                time += mm;
            }

            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;

            }
            else
            {
                time += ss;
            }
            label2.Text = time;
        }

        private void spakim_Load(object sender, EventArgs e)
        {
            this.sapakeemTableAdapter.Fill(this.shoe_shopDataSet.sapakeem);
            this.sapakeemTableAdapter.Fill(this.shoe_shopDataSet.sapakeem);

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_shem.Text != "" && tb_telphon.Text != "" && tb_email.Text != "" && tb_ktovet.Text != "")
            {
                sp = shoe_shopDataSet.sapakeem;
                bool bl = true;
                for (int i = 0; i < sp.Rows.Count && bl; i++)
                {
                    if (tb_shem.Text == (string)sp.Rows[i]["shem"])
                    {
                        MessageBox.Show("ספק קיים");
                        bl = false;
                        MessageBox.Show("הוסף ספק אחר");
                    }
                }
                if (bl == true)
                {
                    DialogResult dr = MessageBox.Show("הוסף ספק", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into sapakeem(shem,telphon,Email,ktovet) VALUES('" + tb_shem.Text + "','" + tb_telphon.Text + "','" + tb_email.Text + "','" + tb_ktovet.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        spakim_Load(sender, e);
                        tb_shem.Text = "";
                        tb_telphon.Text = "";
                        tb_email.Text = "";
                        tb_ktovet.Text = "";

                    }

                }
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void tb_telphon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("מחק ספק", "מחק", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from sapakeem where shem='" + tb_shem.Text + "' ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }
        }

        private void tb_shem_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_shem1.Text != "" && tb_telphon1.Text != "" && tb_email1.Text != "" && tb_ktovet1.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Update sapakeem SET telphon='" + tb_telphon1.Text + "',Email='" + tb_email1.Text + "',ktovet='" + tb_ktovet1.Text + "'where [shem]='" + tb_shem.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                spakim_Load(sender, e);
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            tb_shem.Text = row.Cells[0].Value.ToString();
            tb_telphon.Text = row.Cells[1].Value.ToString();
            tb_email.Text = row.Cells[2].Value.ToString();
            tb_ktovet.Text = row.Cells[3].Value.ToString();
            tb_shem1.Text = row.Cells[0].Value.ToString();
            tb_telphon1.Text = row.Cells[1].Value.ToString();
            tb_email1.Text = row.Cells[2].Value.ToString();
            tb_ktovet1.Text = row.Cells[3].Value.ToString();







        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_shem1.Visible == false)
            {
                tb_shem1.Visible = true;
                tb_telphon1.Visible = true;
                tb_email1.Visible = true;
                tb_ktovet1.Visible = true;
                edkon.Visible = true;
                button4.Text = "ביטול";
            }
            else
            {
                tb_shem1.Visible = false;
                tb_telphon1.Visible = false;
                tb_email1.Visible = false;
                tb_ktovet1.Visible = false;
                edkon.Visible = false;
                button4.Text = "עדכון";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            sp = shoe_shopDataSet.sapakeem;

            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("telphon");
            dz.Columns.Add("email");
            dz.Columns.Add("ktovet");
            for (int j = 0; j < sp.Rows.Count; j++)
            {
                for (int k = 0; k < sp.Columns.Count; k++)
                {
                    if (sp.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(sp[j][0], sp[j][1], sp[j][2], sp[j][3]);
                        k = sp.Columns.Count;

                    }

                }

            }

            dataGridView1.DataSource = dz;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
        }

        }
    }
