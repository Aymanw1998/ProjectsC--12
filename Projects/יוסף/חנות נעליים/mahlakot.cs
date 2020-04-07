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
    public partial class mahlakot : Form
    {
        Timer t = new Timer();

        public mahlakot()
        {
            InitializeComponent();
        }
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
            label6.Text = time;


        }




        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        int selectedRow;
        shoe_shopDataSet.mahlakotDataTable sm;
        private void mahlakot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoe_shopDataSet.mahlakot' table. You can move, or remove it, as needed.
            this.mahlakotTableAdapter.Fill(this.shoe_shopDataSet.mahlakot);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (shem.Text != ""&&ovdeem.Text!=""&&meheerot.Text!=""&&gnevot.Text!=""&&kamot.Text!="")
            {
                sm = shoe_shopDataSet.mahlakot;
                bool bl = true;
                for (int i = 0; i < sm.Rows.Count && bl; i++)
                {
                    if (shem.Text == (string)sm.Rows[i]["shem"])
                    {
                        MessageBox.Show("מחלקה קיימת");
                        bl = false;
                        MessageBox.Show("הוסף מחלקה אחר");
                    }
                }
                if (bl == true)
                {

                    DialogResult dr = MessageBox.Show("הוסף מחלקה", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into mahlakot(shem,ovdeem,meheerot,gnevot,kamot) VALUES('" + shem.Text + "','" + ovdeem.Text + "','" + meheerot.Text + "','" + gnevot.Text + "','" + kamot.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mahlakot_Load(sender, e);
                        shem.Text = "";
                        ovdeem.Text = "";
                        meheerot.Text = "";
                        gnevot.Text = "";
                        kamot.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from mahlakot where shem='" + shem.Text + "' ";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            mahlakot_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            shem.Text = row.Cells[0].Value.ToString();
            ovdeem.Text = row.Cells[1].Value.ToString();
            meheerot.Text = row.Cells[2].Value.ToString();
            gnevot.Text = row.Cells[3].Value.ToString();
            kamot.Text = row.Cells[4].Value.ToString();
            shem1.Text = row.Cells[0].Value.ToString();
            ovdeem1.Text = row.Cells[1].Value.ToString();
            meheerot1.Text = row.Cells[2].Value.ToString();
            gnevot1.Text = row.Cells[3].Value.ToString();
            kamot1.Text = row.Cells[4].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void meheerot_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (shem1.Visible == false)
            {
                shem1.Visible = true;
                ovdeem1.Visible = true;
                meheerot1.Visible = true;
                gnevot1.Visible = true;
                kamot1.Visible = true;
                button4.Text = "ביטול";
                edkon.Visible = true;
            }
            else
            {
                shem1.Visible = false;
                ovdeem1.Visible = false;
                meheerot1.Visible = false;
                gnevot1.Visible = false;
                kamot1.Visible = false;
                button4.Text = "עדכון";
                edkon.Visible = false;

            }
        }

        private void edkon_Click(object sender, EventArgs e)
        {
            if (shem1.Text != "" && ovdeem1.Text != "" && meheerot1.Text != "" && gnevot1.Text != "" && kamot1.Text != "")
            {

                bool bl1 = true;
                if (bl1 == true)
                {
                    DialogResult dr = MessageBox.Show("עדכן פרטי מחלקה", "עדכן", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update mahlakot SET shem='" + shem1.Text + "',ovdeem='" + ovdeem1.Text + "',meheerot='" + meheerot1.Text + "',gnevot='" + gnevot1.Text + "',kamot='" + kamot1.Text + "'";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mahlakot_Load(sender, e);
                        shem1.Text = "";
                        ovdeem1.Text = "";
                        meheerot1.Text = "";
                        gnevot1.Text = "";
                        kamot1.Text = "";
                    }
                    else if (dr == DialogResult.No)
                    {
                        shem1.Text = "";
                        ovdeem1.Text = "";
                        meheerot1.Text = "";
                        gnevot1.Text = "";
                        kamot1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            sm = shoe_shopDataSet.mahlakot;

            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("ovdeem");
            dz.Columns.Add("meheerot");
            dz.Columns.Add("gnevot");
            dz.Columns.Add("kamot");
            for (int j = 0; j < sm.Rows.Count; j++)
            {
                for (int k = 0; k < sm.Columns.Count; k++)
                {
                    if (sm.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(sm[j][0], sm[j][1], sm[j][2], sm[j][3], sm[j][4]);
                        k = sm.Columns.Count;
                    }
                }
            }
            dataGridView1.DataSource = dz;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shem.Text = "";
            ovdeem.Text = "";
            meheerot.Text = "";
            gnevot.Text = "";
            kamot.Text = "";
            shem1.Text = "";
            ovdeem1.Text = "";
            meheerot1.Text = "";
            gnevot1.Text = "";
            kamot1.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        }
    }
