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
    public partial class Form_tsiood : Form
    {
        public Form_tsiood()
        {
            InitializeComponent();
        }

        hoursesDataSet.tsioodDataTable mm;
       
        hoursesDataSet.tsioodDataTable mz;
        int selectedRow;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void Form_tsiood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.tsiood' table. You can move, or remove it, as needed.
            this.tsioodTableAdapter.Fill(this.hoursesDataSet.tsiood);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shem.Visible = true;
            price.Visible = true;
            tarichtfoga.Visible = true;
            kod.Visible = true;
            spak.Visible = true;
            shimoosh.Visible = true;
            txb_kod.Visible = true;
            txb_price.Visible = true;
            txb_shem.Visible = true;
            txb_shimoosh.Visible = true;
            txb_spak.Visible = true;
            txb_tarichtfoga.Visible = true;
            bt_add.Visible = true;

            up_kod.Visible = false;
            up_price.Visible = false;
            up_sapak.Visible = false;
            up_shem.Visible = false;
            up_shimoosh.Visible = false;
            up_tarichtfoga.Visible = false;
            txup__tarichtfoga.Visible = false;
            txup_kod.Visible = false;
            txup_price.Visible = false;
            txup_sapak.Visible = false;
            txup_shem.Visible = false;
            txup_shimoosh.Visible = false;
            update.Visible = false;
            de_kod.Visible = false;
            de_price.Visible = false;
            de_sapak.Visible = false;
            de_shem.Visible = false;
            de_shimoosh.Visible = false;
            de_tarichtfoga.Visible = false;
            txde_kod.Visible = false;
            txde_price.Visible = false;
            txde_sapak.Visible = false;
            txde_shem.Visible = false;
            txde_shimoosh.Visible = false;
            txde_tarichtfoga.Visible = false;
            delete.Visible = false;



        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            bool bl1 = true;
            if (txb_shem.Text == "")
            {
                bl1 = false;
                label1.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txb_price.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_tarichtfoga.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_kod.Text == "")
            {
                bl1 = false;
                label4.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_spak.Text == "")
            {
                bl1 = false;
                label5.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_shimoosh.Text == "")
            {
                bl1 = false;
                label6.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            
            mm = hoursesDataSet.tsiood;
            string s = txb_shem.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["shem"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("ציוד  זה קיים במערכת");
                    bl = false;
                    txb_kod.Clear();
                    txb_price.Clear();
                    txb_shem.Clear();
                    txb_shimoosh.Clear();
                    txb_spak.Clear();
                    txb_tarichtfoga.Clear();

                }
            }



            if (bl == true && bl1==true)
            {
                DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף ציוד זה ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT into tsiood(shem,price,[tarich tfoga],kod,spak,shimoosh) VALUES('" + txb_shem.Text + "','" + txb_price.Text + "','" + txb_tarichtfoga.Text + "','" + txb_kod.Text + "','" + txb_spak.Text + "','" + txb_shimoosh.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_tsiood_Load(sender, e);

                    txb_kod.Clear();
                    txb_price.Clear();
                    txb_shem.Clear();
                    txb_shimoosh.Clear();
                    txb_spak.Clear();
                    txb_tarichtfoga.Clear();

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                }
            }
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bt_update_horses_Click(object sender, EventArgs e)
        {


            txup_shem.Clear();
            txup_price.Clear();
            txup__tarichtfoga.Clear();
            txup_kod.Clear();
            txup_sapak.Clear();
            txup_shimoosh.Clear();

            up_kod.Visible = true;
            up_price.Visible = true;
            up_sapak.Visible = true;
            up_shem.Visible = true;
            up_shimoosh.Visible = true;
            up_tarichtfoga.Visible = true;
            txup__tarichtfoga.Visible = true;
            txup_kod.Visible = true;
            txup_price.Visible = true;
            txup_sapak.Visible = true;
            txup_shem.Visible = true;
            txup_shimoosh.Visible = true;
            update.Visible = true;

            shem.Visible = false;
            price.Visible = false;
            tarichtfoga.Visible = false;
            kod.Visible = false;
            spak.Visible = false;
            shimoosh.Visible = false;
            txb_kod.Visible = false;
            txb_price.Visible = false;
            txb_shem.Visible = false;
            txb_shimoosh.Visible = false;
            txb_spak.Visible = false;
            txb_tarichtfoga.Visible = false;
            bt_add.Visible = false;
            de_kod.Visible = false;
            de_price.Visible = false;
            de_sapak.Visible = false;
            de_shem.Visible = false;
            de_shimoosh.Visible = false;
            de_tarichtfoga.Visible = false;
            txde_kod.Visible = false;
            txde_price.Visible = false;
            txde_sapak.Visible = false;
            txde_shem.Visible = false;
            txde_shimoosh.Visible = false;
            txde_tarichtfoga.Visible = false;
            delete.Visible = false;

        }

        private void bt_delete_horses_Click(object sender, EventArgs e)
        {

            txde_tarichtfoga.Clear();
            txde_shimoosh.Clear();
            txde_shem.Clear();
            txde_sapak.Clear();
            txde_price.Clear();
            txde_kod.Clear();

            up_kod.Visible = false;
            up_price.Visible = false;
            up_sapak.Visible = false;
            up_shem.Visible = false;
            up_shimoosh.Visible = false;
            up_tarichtfoga.Visible = false;
            txup__tarichtfoga.Visible = false;
            txup_kod.Visible = false;
            txup_price.Visible = false;
            txup_sapak.Visible = false;
            txup_shem.Visible = false;
            txup_shimoosh.Visible = false;
            update.Visible = false;

            shem.Visible = false;
            price.Visible = false;
            tarichtfoga.Visible = false;
            kod.Visible = false;
            spak.Visible = false;
            shimoosh.Visible = false;
            txb_kod.Visible = false;
            txb_price.Visible = false;
            txb_shem.Visible = false;
            txb_shimoosh.Visible = false;
            txb_spak.Visible = false;
            txb_tarichtfoga.Visible = false;
            bt_add.Visible = false;

            de_kod.Visible = true;
            de_price.Visible = true;
            de_sapak.Visible = true;
            de_shem.Visible = true;
            de_shimoosh.Visible = true;
            de_tarichtfoga.Visible = true;
            txde_kod.Visible = true;
            txde_price.Visible = true;
            txde_sapak.Visible = true;
            txde_shem.Visible = true;
            txde_shimoosh.Visible = true;
            txde_tarichtfoga.Visible = true;
            delete.Visible = true;

        }

        private void txb_shem_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
          
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from tsiood where shem='" + txde_shem.Text + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form_tsiood_Load(sender, e);

            txde_tarichtfoga.Clear();
            txde_shimoosh.Clear();
            txde_shem.Clear();
            txde_sapak.Clear();
            txde_price.Clear();
            txde_kod.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mz = hoursesDataSet.tsiood;
            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("price");
            dz.Columns.Add("tarich tfoga");
            dz.Columns.Add("kod");
            dz.Columns.Add("spak");
            dz.Columns.Add("shimoosh");

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5]);
                        k = mz.Columns.Count;
                    }

                }

            }

            dataGridView1.DataSource = dz;


        }

        private void update_Click(object sender, EventArgs e)
        {
            
            bool bl1 = true;
            if (txup_shem.Text == "")
            {
                bl1 = false;
                label11.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txup_price.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup__tarichtfoga.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_kod.Text == "")
            {
                bl1 = false;
                label14.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_sapak.Text == "")
            {
                bl1 = false;
                label15.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_shimoosh.Text == "")
            {
                bl1 = false;
                label16.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }


            if (bl1 == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update tsiood SET shimoosh='" + txup_shimoosh.Text + "', price='" + txup_price.Text + "', [tarich tfoga]='" + txup__tarichtfoga.Text + "', kod='" + txup_kod.Text + "', spak='" + txup_sapak.Text + "' where shem='" + txup_shem.Text + "'";

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_tsiood_Load(sender, e);

                txup_shem.Clear();
                txup_price.Clear();
                txup__tarichtfoga.Clear();
                txup_kod.Clear();
                txup_sapak.Clear();
                txup_shimoosh.Clear();

                dataGridView1.DataSource = hoursesDataSet.tsiood;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txde_kod.Text = row.Cells[3].Value.ToString();
            txde_price.Text = row.Cells[1].Value.ToString();
            txde_sapak.Text = row.Cells[4].Value.ToString();
            txde_shem.Text = row.Cells[0].Value.ToString();
            txde_shimoosh.Text = row.Cells[5].Value.ToString();
            txde_tarichtfoga.Text = row.Cells[2].Value.ToString();

            txup__tarichtfoga.Text = row.Cells[2].Value.ToString();
            txup_kod.Text = row.Cells[3].Value.ToString();
            txup_price.Text = row.Cells[1].Value.ToString();
            txup_shem.Text = row.Cells[0].Value.ToString();
            txup_sapak.Text = row.Cells[4].Value.ToString();
            txup_shimoosh.Text = row.Cells[5].Value.ToString();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        private void haba_Click(object sender, EventArgs e)
        {
            
        }

        private void first_Click(object sender, EventArgs e)
        {
        }

        private void last_Click(object sender, EventArgs e)
        {
        }

        private void before_Click(object sender, EventArgs e)
        {
        }

        private void haba_Click_1(object sender, EventArgs e)
        {
            tsioodBindingSource.MoveNext();
        }

        private void before_Click_1(object sender, EventArgs e)
        {
            tsioodBindingSource.MovePrevious();
        }

        private void first_Click_1(object sender, EventArgs e)
        {
            tsioodBindingSource.MoveFirst();

        }

        private void last_Click_1(object sender, EventArgs e)
        {
            tsioodBindingSource.MoveLast();

        }

        private void txb_shem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txup_shem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txb_spak_TextChanged(object sender, EventArgs e)
        {
        }

        private void txup_sapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txb_spak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


    }
}
