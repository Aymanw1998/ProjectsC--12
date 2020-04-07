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
    public partial class shoes : Form
    {
        Timer t = new Timer();

        public shoes()
        {
            InitializeComponent();
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
            label10.Text = time;


        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        shoe_shopDataSet.shoesDataTable ss;
        int selectedRow;

        private void shoes_Load(object sender, EventArgs e)
        {

            this.shoesTableAdapter.Fill(this.shoe_shopDataSet.shoes);
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (degem.Text.Length == 10 && firma.Text != "" && mehir.Text != "" && mida.Text != "" && color.Text != "" && kamot.Text != "" && mhlaka.Text != "" && spak.Text!="")
            {
                ss = shoe_shopDataSet.shoes;
                bool bl = true;
                for (int i = 0; i < ss.Rows.Count && bl; i++)
                {
                    if (degem.Text == (string)ss.Rows[i]["degem"])
                    {
                        MessageBox.Show("נעל קיימת");
                        bl = false;
                        MessageBox.Show("הוסף נעל אחרת");
                    }
                }
                if (bl == true)
                {
                    DialogResult dr = MessageBox.Show("הוסף נעל", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into shoes(degem,firma,mehir,mida,color,kamot,mhlaka,spak) VALUES('" + degem.Text + "','" + firma.Text + "','" + mehir.Text + "','" + mida.Text + "','" + color.Text + "','" + kamot.Text + "','" + mhlaka.Text + "','" + spak.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        shoes_Load(sender, e);
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
                             
            DialogResult dr = MessageBox.Show("מחק נעל", "מחק", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from shoes where degem='" + degem.Text + "' ";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                shoes_Load(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ss = shoe_shopDataSet.shoes;
            DataTable dz = new DataTable();
            dz.Columns.Add("degem");
            dz.Columns.Add("firma");
            dz.Columns.Add("mehir");
            dz.Columns.Add("mida");
            dz.Columns.Add("color");
            dz.Columns.Add("kamot");
            dz.Columns.Add("mhlaka");
            dz.Columns.Add("spak");
            for (int j = 0; j < ss.Rows.Count; j++)
            {
                for (int k = 0; k < ss.Columns.Count; k++)
                {
                    if (ss.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(ss[j][0], ss[j][1], ss[j][2], ss[j][3], ss[j][4], ss[j][5], ss[j][6], ss[j][7]);
                        k = ss.Columns.Count;
                    }
                }
            }
            dataGridView1.DataSource = dz;
        }

        private void mehir_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            degem.Text = row.Cells[0].Value.ToString();
            firma.Text = row.Cells[1].Value.ToString();
            mehir.Text = row.Cells[2].Value.ToString();
            mida.Text = row.Cells[3].Value.ToString();
            color.Text = row.Cells[4].Value.ToString();
            kamot.Text = row.Cells[5].Value.ToString();
            mhlaka.Text = row.Cells[6].Value.ToString();
            spak.Text = row.Cells[7].Value.ToString();
            degem1.Text = row.Cells[0].Value.ToString();
            firma1.Text = row.Cells[1].Value.ToString();
            mehir1.Text = row.Cells[2].Value.ToString();
            mida1.Text = row.Cells[3].Value.ToString();
            color1.Text = row.Cells[4].Value.ToString();
            kamot1.Text = row.Cells[5].Value.ToString();
            mhlaka1.Text = row.Cells[6].Value.ToString();
            spak1.Text = row.Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            degem.Text = "";
            firma.Text = "";
            mehir.Text = "";
            mida.Text = "";
            color.Text = "";
            kamot.Text = "";
            mhlaka.Text = "";
            spak.Text = "";
            degem1.Text = "";
            firma1.Text = "";
            mehir1.Text = "";
            mida1.Text = "";
            color1.Text = "";
            kamot1.Text = "";
            mhlaka1.Text = "";
            spak1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (firma.SelectedText==("אחר")
            //{
            //    firma.Visible = false;
            //}
        }

        private void firma_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (degem1.Visible == false)
            {
                degem1.Visible = true;
                firma1.Visible = true;
                mehir1.Visible = true;
                mida1.Visible = true;
                color1.Visible = true;
                kamot1.Visible = true;
                mhlaka1.Visible = true;
                spak1.Visible = true;
                button5.Visible = true;
                button4.Text = "ביטול";
            }
            else
            {
                degem1.Visible = false;
                firma1.Visible = false;
                mehir1.Visible = false;
                mida1.Visible = false;
                color1.Visible = false;
                kamot1.Visible = false;
                mhlaka1.Visible = false;
                spak1.Visible = false;
                button5.Visible = false;
                button4.Text = "עדכון";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (degem1.Text.Length == 10 && firma1.Text != "" && mehir1.Text != "" && mida1.Text != "" && color1.Text != "" && kamot1.Text != "" && mhlaka1.Text != "" && spak1.Text != "")
            {
                DialogResult dr = MessageBox.Show("עדכן פרטי נעל", "עדכן", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Update shoes SET firma='" + firma1.Text + "',mehir='" + mehir1.Text + "',color='" + color1.Text + "',kamot='" + kamot1.Text + "',mhlaka='" + mhlaka1.Text + "',spak='" + spak1.Text + "'";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    shoes_Load(sender, e);
                    degem1.Text = "";
                    firma1.Text = "";
                    mehir1.Text = "";
                    mida1.Text = "";
                    color1.Text = "";
                    kamot1.Text = "";
                    mhlaka1.Text = "";
                    spak1.Text = "";
                }
                else if (dr == DialogResult.No)
                {
                    degem1.Text = "";
                    firma1.Text = "";
                    mehir1.Text = "";
                    mida1.Text = "";
                    color1.Text = "";
                    kamot1.Text = "";
                    mhlaka1.Text = "";
                    spak1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void degem1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
