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
    public partial class Form_lekohot : Form
    {
        public Form_lekohot()
        {
            InitializeComponent();
        }


        hoursesDataSet.lakohotDataTable mm;
        hoursesDataSet.lakohotDataTable mz;
        int selectedRow;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void Form_lekohot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.lakohot' table. You can move, or remove it, as needed.
            this.lakohotTableAdapter.Fill(this.hoursesDataSet.lakohot);
           
           

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shem.Visible = true;
            phone.Visible = true;
            id.Visible = true;
            txb_id.Visible = true;
            txb_phone.Visible = true;
            txb_shem.Visible=true;
            bt_add.Visible = true;

            up_id.Visible = false;
            up_phone.Visible = false;
            up_shem.Visible = false;
            txup_shem.Visible = false;
            txup_phone.Visible = false;
            txup_id.Visible = false;
            bt_de.Visible = false;

            de_id.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible = false;
            txde_id.Visible = false;
            txde_phone.Visible = false;
            txde_shem.Visible = false;
            bt_up.Visible = false;




        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            bool bl11 = true;
            string s2 = txb_id.Text;
            int x = s2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }

            bool bl3 = true;
            if (txb_id.Text.Length != 9)
            {
                bl3 = false;
                MessageBox.Show("יש להזין 9 ספרות לתעודת הזהות");
            }

            if (txb_phone.Text.Length != 11)
            {
                bl3 = false;
                label2.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }


            bool bl1 = true;
            if (txb_shem.Text == "")
            {
                bl1 = false;
                label1.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txb_phone.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_id.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            

            mm = hoursesDataSet.lakohot;
            string s = txb_id.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["id"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("לקוח זה קיים במערכת");
                    bl = false;
                    txb_id.Clear();
                    txb_phone.Clear();
                    txb_shem.Clear();
                }
            }



            if (bl == true && bl1 == true && bl3 == true && bl11 == true)
            {
                DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף לקוח זה ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT into lakohot(shem,phone,id) VALUES('" + txb_shem.Text + "','" + txb_phone.Text + "','" + txb_id.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_lekohot_Load(sender, e);

                    txb_id.Clear();
                    txb_phone.Clear();
                    txb_shem.Clear();

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;



                }
            }

        }

        private void bt_delete_horses_Click(object sender, EventArgs e)
        {

            txde_id.Clear();
            txde_phone.Clear();
            txde_shem.Clear();

            shem.Visible = false;
            phone.Visible = false;
            id.Visible = false;
            txb_id.Visible = false;
            txb_phone.Visible = false;
            txb_shem.Visible = false;
            bt_add.Visible = false;

            up_id.Visible = false;
            up_phone.Visible = false;
            up_shem.Visible = false;
            txup_id.Visible = false;
            txup_phone.Visible = false;
            txup_shem.Visible = false;
            bt_up.Visible = false;

            de_id.Visible = true;
            de_phone.Visible = true;
            de_shem.Visible = true;
            txde_id.Visible = true;
            txde_phone.Visible = true;
            txde_shem.Visible = true;
            bt_de.Visible = true;


        }

        private void bt_de_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from lakohot where id='" + txde_id.Text + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form_lekohot_Load(sender, e);

            txde_id.Clear();
            txde_phone.Clear();
            txde_shem.Clear();


        }

        private void bt_update_horses_Click(object sender, EventArgs e)
        {
            txup_shem.Clear();
            txup_phone.Clear();
            txup_id.Clear(); 

            shem.Visible = false;
            phone.Visible = false;
            id.Visible = false;
            txb_id.Visible = false;
            txb_phone.Visible = false;
            txb_shem.Visible = false;
            bt_add.Visible = false;

            de_id.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible = false;
            txde_id.Visible = false;
            txde_phone.Visible = false;
            txde_shem.Visible = false;
            bt_de.Visible = false;

            up_id.Visible = true;
            up_phone.Visible = true;
            up_shem.Visible = true;
            txup_id.Visible = true;
            txup_phone.Visible = true;
            txup_shem.Visible = true;
            bt_up.Visible = true;


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mz = hoursesDataSet.lakohot;
            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("phone");
            dz.Columns.Add("id");
           

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2]);
                        k = mz.Columns.Count;
                    }

                }

            }

            dataGridView1.DataSource = dz;
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            bool bl3 = true;
            if (txup_id.Text.Length != 9)
            {
                bl3 = false;
                MessageBox.Show("יש להזין 9 ספרות לתעודת הזהות");
            }

            if (txup_phone.Text.Length != 11)
            {
                bl3 = false;
                label12.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }


            bool bl1 = true;
            if (txup_shem.Text == "")
            {
                bl1 = false;
                label11.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txup_phone.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_id.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }




            if (bl3 == true && bl1 == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update lakohot SET shem='" + txup_shem.Text + "', phone='" + txup_phone.Text + "' where id='" + txup_id.Text + "'";

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_lekohot_Load(sender, e);

                txup_shem.Clear();
                txup_phone.Clear();
                txup_id.Clear();

                dataGridView1.DataSource = hoursesDataSet.lakohot;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txup_shem.Text = row.Cells[0].Value.ToString();
            txup_phone.Text = row.Cells[1].Value.ToString();
            txup_id.Text = row.Cells[2].Value.ToString();

            txde_shem.Text = row.Cells[0].Value.ToString();
            txde_phone.Text = row.Cells[1].Value.ToString();
            txde_id.Text = row.Cells[2].Value.ToString();
        }

        private void txb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחחים");
            }
        }

        private void txup_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחחים");
            }
        }

        private void txb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין מספר פלאפון עם רווחחים");
            }
        }

        private void txup_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין מספר פלאפון עם רווחחים");
            }
        }
        private void haba_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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
            lakohotBindingSource.MovePrevious();
        }

        private void haba_Click_1(object sender, EventArgs e)
        {
            lakohotBindingSource.MoveNext();

        }

        private void first_Click_1(object sender, EventArgs e)
        {
            lakohotBindingSource.MoveFirst();

        }

        private void last_Click_1(object sender, EventArgs e)
        {
            lakohotBindingSource.MoveLast();

        }

        private void txb_id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txb_shem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txup_shem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
