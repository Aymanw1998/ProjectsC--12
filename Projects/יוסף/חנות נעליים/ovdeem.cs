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
    public partial class ovdeem : Form
    {
        Timer t = new Timer();

        public ovdeem()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\חנות נעליים\shoe shop.mdb");
        int selectedRow;
        shoe_shopDataSet.ovdimDataTable so;

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
        private void ovdeem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoe_shopDataSet.mishmarot' table. You can move, or remove it, as needed.
            this.mishmarotTableAdapter.Fill(this.shoe_shopDataSet.mishmarot);
            // TODO: This line of code loads data into the 'shoe_shopDataSet.ovdim' table. You can move, or remove it, as needed.
            this.ovdimTableAdapter.Fill(this.shoe_shopDataSet.ovdim);
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tz.Text.Length == 9 && shem.Text != "" && meshpaha.Text != "" && gil.Text != "" && bday.Text != "" && maskoret.Text != "" && mespar.Text.Length != 10 && ktovet.Text!="")
            {
                so = shoe_shopDataSet.ovdim;
                bool bl = true;
                for (int i = 0; i < so.Rows.Count && bl; i++)   
                {
                    if (tz.Text == (string)so.Rows[i]["tz"])    
                    {           
                        MessageBox.Show("עובד קיים");           
                        bl = false;
                        MessageBox.Show("הוסף עובד אחר");
                      }     
                }

                for (int i = 0; i < so.Rows.Count && bl; i++)
                {
                    if (password.Text == (string)so.Rows[i]["password"])
                    {
                        MessageBox.Show("קוד עובד לא חוקי");
                        bl = false;
                        MessageBox.Show("החלף קוד עובד");
                    }
                }


                if (bl == true)       
                {           
                    DialogResult dr = MessageBox.Show("הוסף עובד", "הוסף", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);         
                    if (dr == DialogResult.Yes)
                    {   
                        OleDbCommand cmd = new OleDbCommand();     
                        cmd.CommandText = "INSERT into ovdim(tz,shem,meshpaha,gil,bday,maskoret,mespar,ktovet,[password]) VALUES('" + tz.Text + "','" + shem.Text + "','" + meshpaha.Text + "','" + gil.Text + "','" + bday.Text + "','" + maskoret.Text + "','" + mespar.Text + "','" + ktovet.Text + "','" + password.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ovdeem_Load(sender, e);
                        tz.Text = "";
                        shem.Text = "";
                        meshpaha.Text = "";
                        gil.Text = "";
                        bday.Text = "";
                        maskoret.Text = "";
                        mespar.Text = "";
                        ktovet.Text = "";
                        password.Text = "";
                       } 
                }     
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void tz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            tz.Text = row.Cells[0].Value.ToString();
            shem.Text = row.Cells[1].Value.ToString();
            meshpaha.Text = row.Cells[2].Value.ToString();
            gil.Text = row.Cells[3].Value.ToString();
            bday.Text = row.Cells[4].Value.ToString();
            maskoret.Text = row.Cells[5].Value.ToString();
            mespar.Text = row.Cells[9].Value.ToString();
            ktovet.Text = row.Cells[11].Value.ToString();
            password.Text = row.Cells[12].Value.ToString();
            tz1.Text = row.Cells[0].Value.ToString();
            shem1.Text = row.Cells[1].Value.ToString();
            meshpaha1.Text = row.Cells[2].Value.ToString();
            gil1.Text = row.Cells[3].Value.ToString();
            bday1.Text = row.Cells[4].Value.ToString();
            maskoret1.Text = row.Cells[5].Value.ToString();
            mespar1.Text = row.Cells[9].Value.ToString();
            ktovet1.Text = row.Cells[11].Value.ToString();
            password1.Text = row.Cells[12].Value.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
             DialogResult dr = MessageBox.Show("מחק לקוח", "מחק", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (dr == DialogResult.Yes)
             {
                 OleDbCommand cmd = new OleDbCommand();
                 cmd.CommandText = "delete from ovdim where tz='" + tz.Text + "' ";
                 cmd.Connection = con;
                 con.Open();
                 cmd.ExecuteNonQuery();
                 con.Close();
                 ovdeem_Load(sender, e);
             }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskoret_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mespar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            so = shoe_shopDataSet.ovdim;

            DataTable dz = new DataTable();
            dz.Columns.Add("tz");
            dz.Columns.Add("shem");
            dz.Columns.Add("meshpaha");
            dz.Columns.Add("gil");
            dz.Columns.Add("bday");
            dz.Columns.Add("maskoret");
            dz.Columns.Add("mespar");
            dz.Columns.Add("ktovet");
            dz.Columns.Add("password");
            for (int j = 0; j < so.Rows.Count; j++)
            {
                for (int k = 0; k < so.Columns.Count; k++)
                {
                    if (so.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(so[j][0], so[j][1], so[j][2], so[j][3], so[j][4], so[j][5], so[j][6], so[j][7], so[j][8]);
                        k = so.Columns.Count;

                    }

                }

            }

            dataGridView1.DataSource = dz;
        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tz.Text = "";
            shem.Text = "";
            meshpaha.Text = "";
            gil.Text = "";
            bday.Text = "";
            maskoret.Text = "";
            mespar.Text = "";
            ktovet.Text = "";
            password.Text = ""; 
            tz1.Text = "";
            shem1.Text = "";
            meshpaha1.Text = "";
            gil1.Text = "";
            bday1.Text = "";
            maskoret1.Text = "";
            mespar1.Text = "";
            ktovet1.Text = "";
            password1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tz1.Visible == false)
            {
                tz1.Visible = true;
                shem1.Visible = true;
                meshpaha1.Visible = true;
                gil1.Visible = true;
                bday1.Visible = true;
                ktovet1.Visible = true;
                maskoret1.Visible = true;
                password1.Visible = true;
                mespar1.Visible = true;
                edkon.Visible = true;
                button2.Text = "ביטול";
            }
            else
            {
                tz1.Visible = false;
                shem1.Visible = false;
                meshpaha1.Visible = false;
                gil1.Visible = false;
                bday1.Visible = false;
                ktovet1.Visible = false;
                maskoret1.Visible = false;
                password1.Visible = false;
                mespar1.Visible = false;
                edkon.Visible = false;
                button2.Text = "עדכון";

            }

        }

        private void edkon_Click(object sender, EventArgs e)
        {
            if (tz1.Text.Length == 9 && shem1.Text != "" && meshpaha1.Text != "" && gil1.Text != "" && bday1.Text != "" && maskoret1.Text != "" && mespar1.Text.Length != 10 && ktovet1.Text != "")
            {
                bool bl1 = true;


                if (bl1 == true)
                {

                    DialogResult dr = MessageBox.Show("עדכן פרטי לקוח", "עדכן", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {


                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update ovdim SET shem='" + shem1.Text + "',meshpaha='" + meshpaha1.Text + "',gil='" + gil1.Text + "',bday='" + bday1.Text + "',maskoret='" + maskoret1.Text + "',mespar='" + mespar1.Text + "',ktovet='" + ktovet1.Text + "',[password]='" + password1.Text + "'where [tz]='" + tz.Text + "'";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ovdeem_Load(sender, e);
                        tz1.Text = "";
                        shem1.Text = "";
                        meshpaha1.Text = "";
                        gil1.Text = "";
                        bday1.Text = "";
                        maskoret1.Text = "";
                        mespar1.Text = "";
                        ktovet1.Text = "";
                        password1.Text = "";
                    }
                    else if (dr == DialogResult.No)
                    {
                        tz1.Text = "";
                        shem1.Text = "";
                        meshpaha1.Text = "";
                        gil1.Text = "";
                        bday1.Text = "";
                        maskoret1.Text = "";
                        mespar1.Text = "";
                        ktovet1.Text = "";
                        password1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("אל תשאיר נתונים ריקים");

            }
        }

        private void shem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void shem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void shem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void shem1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void meshpaha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void meshpaha1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gil_TextChanged(object sender, EventArgs e)
        {

        }

        private void tz_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                shem.Focus();
            }
        }

        private void shem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                meshpaha.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                tz.Focus();
            }

        }

        private void meshpaha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                gil.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                shem.Focus();
            }

        }

        private void gil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                bday.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                meshpaha.Focus();
            }

        }

        private void bday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                maskoret.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                gil.Focus();
            }

        }

        private void maskoret_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                mespar.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                bday.Focus();
            }

        }

        private void mespar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                ktovet.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                maskoret.Focus();
            }

        }

        private void ktovet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                password.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                mespar.Focus();
            }

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                ktovet.Focus();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
