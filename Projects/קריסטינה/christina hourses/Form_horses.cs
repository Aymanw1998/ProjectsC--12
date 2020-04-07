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
    public partial class next : Form
    {
        public next()
        {
            InitializeComponent();
        }

        hoursesDataSet.horsesDataTable mm;
        hoursesDataSet.horsesDataTable mz;
        int selectedRow;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");
   
        private void Form_horses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.horses' table. You can move, or remove it, as needed.
            this.horsesTableAdapter.Fill(this.hoursesDataSet.horses);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mz = hoursesDataSet.horses;
            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("color");
            dz.Columns.Add("gil");
            dz.Columns.Add("male/female");
            dz.Columns.Add("ptsiaot");
            dz.Columns.Add("notes");

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3] , mz[j][4],  mz[j][5]);
                        k = mz.Columns.Count;
                    }

                }

            }

            dataGridView1.DataSource = dz;


        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shem.Visible = true;
            color.Visible = true;
            age.Visible = true;
            malefe.Visible = true;
            ptsiaot.Visible = true;
            notes.Visible = true;
            txb_age.Visible = true;
            txb_color.Visible = true;
            txb_notes.Visible = true;
            txb_ptsiaot.Visible = true;
            txb_shem.Visible = true;
            comb_malefe.Visible = true;
            bt_add.Visible = true;

            up_color.Visible = false;
            up_gil.Visible = false;
            up_min.Visible = false;
            up_notes.Visible = false;
            up_ptsiot.Visible = false;
            up_shem.Visible = false;
            txup_color.Visible = false;
            txup_gil.Visible = false;
            txup_notes.Visible = false;
            txup_ptsiot.Visible = false;
            txup_shem.Visible = false;
            cbup_min.Visible = false;
            bt_up.Visible = false;

            de_color.Visible = false;
            de_gil.Visible = false;
            de_min.Visible = false;
            de_notes.Visible = false;
            de_ptsiot.Visible = false;
            de_shem.Visible = false;
            txde_color.Visible = false;
            txde_gil.Visible = false;
            txde_notes.Visible = false;
            txde_ptsiot.Visible = false;
            txde_shem.Visible = false;
            cbde_min.Visible = false;
            bt_de.Visible = false;
           

        }

        private void comb_malefe_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (txb_color.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_age.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (comb_malefe.Text == "")
            {
                bl1 = false;
                label4.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_ptsiaot.Text == "")
            {
                bl1 = false;
                label5.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_notes.Text == "")
            {
                bl1 = false;
                label6.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            } 

            mm = hoursesDataSet.horses;
            string s = txb_shem.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["shem"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("סוס זה קיים במערכת");
                    bl = false;
                    txb_age.Clear();
                    txb_color.Clear();
                    txb_notes.Clear();
                    txb_ptsiaot.Clear();
                    txb_shem.Clear();
                    comb_malefe.Text = "";

                }
            }



            if (bl == true && bl1 == true)
            {
                DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף סוס זה ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT into horses(shem,color,gil,[male/female],ptsiaot,notes) VALUES('" + txb_shem.Text + "','" + txb_color.Text + "','" + txb_age.Text + "','" + comb_malefe.Text + "','" + txb_ptsiaot.Text + "','" + txb_notes.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_horses_Load(sender, e);

                    txb_age.Clear();
                    txb_color.Clear();
                    txb_notes.Clear();
                    txb_ptsiaot.Clear();
                    txb_shem.Clear();
                    comb_malefe.Text = "";


                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                }
            }

        }

        private void txb_shem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_update_horses_Click(object sender, EventArgs e)
        {
            txup_color.Clear();
            txup_gil.Clear();
            txup_notes.Clear();
            txup_ptsiot.Clear();
            cbup_min.Text = "";
            txup_shem.Clear();


            shem.Visible = false;
            color.Visible = false;
            age.Visible = false;
            malefe.Visible = false;
            ptsiaot.Visible = false;
            notes.Visible = false;
            txb_age.Visible = false;
            txb_color.Visible = false;
            txb_notes.Visible = false;
            txb_ptsiaot.Visible = false;
            txb_shem.Visible = false;
            comb_malefe.Visible = false;
            bt_add.Visible = false;


            up_color.Visible = true;
            up_gil.Visible = true;
            up_min.Visible = true;
            up_notes.Visible = true;
            up_ptsiot.Visible = true;
            up_shem.Visible = true;
            txup_color.Visible = true;
            txup_gil.Visible = true;
            txup_notes.Visible = true;
            txup_ptsiot.Visible = true;
            txup_shem.Visible = true;
            cbup_min.Visible = true;
            bt_up.Visible = true;

            de_color.Visible = false;
            de_gil.Visible = false;
            de_min.Visible = false;
            de_notes.Visible = false;
            de_ptsiot.Visible = false;
            de_shem.Visible = false;
            txde_color.Visible = false;
            txde_gil.Visible = false;
            txde_notes.Visible = false;
            txde_ptsiot.Visible = false;
            cbde_min.Visible = false;
            txde_shem.Visible = false;
            bt_de.Visible = false;
           
        }

        private void bt_delete_horses_Click(object sender, EventArgs e)
        {
            txde_color.Clear();
            txde_gil.Clear();
            txde_notes.Clear();
            txde_ptsiot.Clear();
            txde_shem.Clear();
            cbde_min.Text = ""; 

            shem.Visible = false;
            color.Visible = false;
            age.Visible = false;
            malefe.Visible = false;
            ptsiaot.Visible = false;
            notes.Visible = false;
            txb_age.Visible = false;
            txb_color.Visible = false;
            txb_notes.Visible = false;
            txb_ptsiaot.Visible = false;
            txb_shem.Visible = false;
            comb_malefe.Visible = false;
            bt_add.Visible = false;

            up_color.Visible = false;
            up_gil.Visible = false;
            up_min.Visible = false;
            up_notes.Visible = false;
            up_ptsiot.Visible = false;
            up_shem.Visible = false;
            txup_color.Visible = false;
            txup_gil.Visible = false;
            txup_notes.Visible = false;
            txup_ptsiot.Visible = false;
            cbup_min.Visible = false;
            txup_shem.Visible = false;
            bt_up.Visible = false;

            de_color.Visible = true;
            de_gil.Visible = true;
            de_min.Visible = true;
            de_notes.Visible = true;
            de_ptsiot.Visible = true;
            de_shem.Visible = true;
            txde_color.Visible = true;
            txde_gil.Visible = true;
            txde_notes.Visible = true;
            txde_ptsiot.Visible = true;
            txde_shem.Visible = true;
            cbde_min.Visible = true;
            bt_de.Visible = true;


        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            bool bl1 = true;
            if (txup_shem.Text == "")
            {
                bl1 = false;
                label11.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txup_color.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_gil.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (cbup_min.Text == "")
            {
                bl1 = false;
                label14.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_ptsiot.Text == "")
            {
                bl1 = false;
                label15.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_notes.Text == "")
            {
                bl1 = false;
                label16.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }


            if (bl1 == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update horses SET notes='" + txup_notes.Text + "',color='" + txup_color.Text + "',gil='" + txup_gil.Text + "' ,[male/female]='" + cbup_min.Text + "',ptsiaot='" + txup_ptsiot.Text + "' where [shem]='" + txup_shem.Text + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_horses_Load(sender, e);

                txup_color.Clear();
                txup_gil.Clear();
                txup_notes.Clear();
                txup_ptsiot.Clear();
                cbup_min.Text = "";
                txup_shem.Clear();

                dataGridView1.DataSource = hoursesDataSet.horses;
            }
        }

        private void bt_de_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from horses where shem='" + txde_shem.Text + "' ";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form_horses_Load(sender, e);

            txde_color.Clear();
            txde_gil.Clear();
            txde_notes.Clear();
            txde_ptsiot.Clear();
            txde_shem.Clear();
            cbde_min.Text = ""; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            txup_shem.Text = row.Cells[0].Value.ToString();
            txup_color.Text = row.Cells[1].Value.ToString();
            txup_gil.Text = row.Cells[2].Value.ToString();
            cbup_min.Text = row.Cells[3].Value.ToString();
            txup_ptsiot.Text = row.Cells[4].Value.ToString();
            txup_notes.Text = row.Cells[5].Value.ToString();


            txde_shem.Text = row.Cells[0].Value.ToString();
            txde_color.Text = row.Cells[1].Value.ToString();
            txde_gil.Text = row.Cells[2].Value.ToString();
            cbde_min.Text = row.Cells[3].Value.ToString();
            txde_ptsiot.Text = row.Cells[4].Value.ToString();
            txde_notes.Text = row.Cells[5].Value.ToString();
        }

        private void haba_Click(object sender, EventArgs e)
        {
            horsesBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            horsesBindingSource.MovePrevious();
        }

        private void first_Click(object sender, EventArgs e)
        {
            horsesBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            horsesBindingSource.MoveLast();
        }

        private void txb_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txup_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
