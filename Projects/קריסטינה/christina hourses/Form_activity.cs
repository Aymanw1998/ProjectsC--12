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
    public partial class Form_activity : Form
    {
        public Form_activity()
        {
            InitializeComponent();
        }

        int selectedRow;
        hoursesDataSet.activityDataTable mm;
        hoursesDataSet.activityDataTable mz;

        hoursesDataSet.lakohotDataTable dm;
        hoursesDataSet.workeersDataTable dw;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void Form_activity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.lakohot' table. You can move, or remove it, as needed.
            this.lakohotTableAdapter.Fill(this.hoursesDataSet.lakohot);
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);
           
            // TODO: This line of code loads data into the 'hoursesDataSet.activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.hoursesDataSet.activity);

            dw = hoursesDataSet.workeers;

            for (int i = 0; i < dw.Rows.Count; i++)
            {
                txb_worker.Items.Add(dw.Rows[i]["shem"].ToString());
            }
            for (int i = 0; i < dw.Rows.Count; i++)
            {
                txup_worker2.Items.Add(dw.Rows[i]["shem"].ToString());
            }
            //comboBox1.Items.Add(dw.Rows[1][1].ToString());

            dm = hoursesDataSet.lakohot;

            for (int i = 0; i < dm.Rows.Count; i++)
            {
                txb_talmid2.Items.Add(dm.Rows[i]["shem"].ToString());
            }

            for (int i = 0; i < dm.Rows.Count; i++)
            {
                txup_talmidim2.Items.Add(dm.Rows[i]["shem"].ToString());
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tarich.Visible = true;
            shem.Visible = true;
            activityday.Visible = true;
            biginnighour.Visible = true;
            endinghour.Visible = true;
            worker.Visible = true;
            tvahgilaim.Visible = true;
            combo.Visible = true;
            txb_biginnighour.Visible = true;
            txb_endinghour.Visible = true;
            txb_talmid2.Visible = true;
            txb_shem.Visible = true;
            txb_worker.Visible = true;
            bt_add.Visible = true;
            txb_tarich.Visible = true;


            up_tarich.Visible = false;
            up_activityday.Visible = false;
            up_biginninghour.Visible = false;
            up_endinghour.Visible = false;
            up_gilaim.Visible = false;
            up_shem.Visible = false;
            up_worker.Visible = false;
            txup_biginnighour.Visible = false;
            comboup.Visible = false;
            txup_endinghour.Visible = false;
            txup_talmidim2.Visible = false;
            txup_shem.Visible = false;
            txup_worker2.Visible = false;
            bt_up.Visible = false;
            txup_tarich.Visible = false;
         


            de_tarich.Visible = false;
            de_biginninghour.Visible = false;
            de_day.Visible = false;
            de_endinghour.Visible = false;
            de_gilaim.Visible = false;
            de_shem.Visible = false;
            de_worker.Visible = false;
            txde_bigginighour.Visible = false;
            txde_day.Visible = false;
            txde_endinghour.Visible = false;
            txde_gilaim.Visible = false;
            txde_shem.Visible = false;
            txde_worker.Visible = false;
            bt_de.Visible = false;
            txde_tarich.Visible = false;

            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;

        }

        private void vendinghour_TextChanged(object sender, EventArgs e)
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
            if (combo.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_biginnighour.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_endinghour.Text == "")
            {
                bl1 = false;
                label4.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_worker.Text == "")
            {
                bl1 = false;
                label5.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_talmid2.Text == "")
            {
                bl1 = false;
                label6.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            } 


            mm = hoursesDataSet.activity;
            string s = txb_shem.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["shem"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("פעילות זאת קיימת במערכת במערכת");
                    bl = false;
                    combo.Text = "";
                    txb_biginnighour.Clear();
                    txb_endinghour.Clear();
                    txb_talmid2.Text="";
                    txb_shem.Clear();
                    txb_worker.Text = "";
                    txb_tarich.Clear();




                }
            }



            if (bl == true && bl1==true)
            {
                DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף פעילות זו ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT into activity(shem,[day],[beginig hour],[ending hour],worker,[tvah gilaim],tarich) VALUES('" + txb_shem.Text + "','" + combo.Text + "','" + txb_biginnighour.Text + "','" + txb_endinghour.Text + "','" + txb_worker.Text + "','" + txb_talmid2.Text + "','" + txb_tarich.Text + "')";
                    //
                    //
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_activity_Load(sender, e);

                    combo.Text="";
                    txb_biginnighour.Clear();
                    txb_endinghour.Clear();
                    txb_talmid2.Text="";
                    txb_shem.Clear();
                    txb_worker.Text ="";

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                }
            }
        }

        private void bt_update_horses_Click(object sender, EventArgs e)
        {

            txup_shem.Clear();
            comboup.Text="";
            txup_biginnighour.Clear();
            txup_endinghour.Clear();
            txup_worker2.Text = "";
            txup_talmidim2.Text = "";

            tarich.Visible = false;
            shem.Visible = false;
            activityday.Visible = false;
            biginnighour.Visible = false;
            endinghour.Visible = false;
            worker.Visible = false;
            tvahgilaim.Visible = false;
            combo.Visible = false;
            txb_biginnighour.Visible = false;
            txb_endinghour.Visible = false;
            txb_talmid2.Visible = false;
            txb_shem.Visible = false;
            txb_worker.Visible = false;
            bt_add.Visible = false;
            txb_tarich.Visible = false;

            up_tarich.Visible = true;
            up_activityday.Visible = true;
            up_biginninghour.Visible = true;
            up_endinghour.Visible = true;
            up_gilaim.Visible = true;
            up_shem.Visible = true;
            up_worker.Visible = true;
            txup_biginnighour.Visible = true;
            comboup.Visible = true;
            txup_endinghour.Visible = true;
            txup_talmidim2.Visible = true;
            txup_shem.Visible = true;
            txup_worker2.Visible = true;
            bt_up.Visible = true;
            txup_tarich.Visible = true;

            de_tarich.Visible = false;
            de_biginninghour.Visible = false;
            de_day.Visible = false;
            de_endinghour.Visible = false;
            de_gilaim.Visible = false;
            de_shem.Visible = false;
            de_worker.Visible = false;
            txde_bigginighour.Visible = false;
            txde_day.Visible = false;
            txde_endinghour.Visible = false;
            txde_gilaim.Visible = false;
            txde_shem.Visible = false;
            txde_worker.Visible = false;
            bt_de.Visible = false;
            txde_tarich.Visible = false;

            monthCalendar1.Visible = false;
            monthCalendar2.Visible = true;


        }

        private void bt_delete_horses_Click(object sender, EventArgs e)
        {

            txde_bigginighour.Clear();
            txde_day.Clear();
            txde_endinghour.Clear();
            txde_gilaim.Clear();
            txde_shem.Clear();
            txde_worker.Clear();

            
            tarich.Visible = false;
            shem.Visible = false;
            activityday.Visible = false;
            biginnighour.Visible = false;
            endinghour.Visible = false;
            worker.Visible = false;
            tvahgilaim.Visible = false;
            combo.Visible = false;
            txb_biginnighour.Visible = false;
            txb_endinghour.Visible = false;
            txb_talmid2.Visible = false;
            txb_shem.Visible = false;
            txb_worker.Visible = false;
            bt_add.Visible = false;
            txb_tarich.Visible = false;
           


            de_tarich.Visible = true;
            de_biginninghour.Visible = true;
            de_day.Visible = true;
            de_endinghour.Visible = true;
            de_gilaim.Visible = true;
            de_shem.Visible = true;
            de_worker.Visible = true;
            txde_bigginighour.Visible = true;
            txde_day.Visible = true;
            txde_endinghour.Visible = true;
            txde_gilaim.Visible = true;
            txde_shem.Visible = true;
            txde_worker.Visible = true;
            bt_de.Visible = true;
            txde_tarich.Visible = true;

            up_tarich.Visible = false;
            up_activityday.Visible = false;
            up_biginninghour.Visible = false;
            up_endinghour.Visible = false;
            up_gilaim.Visible = false;
            up_shem.Visible = false;
            up_worker.Visible = false;
            txup_biginnighour.Visible = false;
            comboup.Visible = false;
            txup_endinghour.Visible = false;
            txup_talmidim2.Visible = false;
            txup_shem.Visible = false;
            txup_worker2.Visible = false;
            bt_up.Visible = false;
            txup_tarich.Visible = false;

            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mz = hoursesDataSet.activity;
            DataTable dz = new DataTable();
            dz.Columns.Add("shem");
            dz.Columns.Add("day");
            dz.Columns.Add("beginig hour");
            dz.Columns.Add("ending hour");
            dz.Columns.Add("worker");
            dz.Columns.Add("tvah gilaim");

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3] , mz[j][4], mz[j][5] );
                        k = mz.Columns.Count;
                    }

                }

            }

            dataGridView1.DataSource = dz;


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
            if (comboup.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_biginnighour.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_endinghour.Text == "")
            {
                bl1 = false;
                label14.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_worker2.Text == "")
            {
                bl1 = false;
                label15.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_talmidim2.Text == "")
            {
                bl1 = false;
                label16.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }


            if (bl1 == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update activity SET [tvah gilaim]='" + txup_talmidim2.Text + "' , [day]='" + comboup.Text + "', [beginig hour]='" + txup_biginnighour.Text + "' , [ending hour]='" + txup_endinghour.Text + "', [worker]='" + txup_worker2.Text + "'  where shem='" + txup_shem.Text + "'";

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_activity_Load(sender, e);

                txup_shem.Clear();
                comboup.Text="";
                txup_biginnighour.Clear();
                txup_endinghour.Clear();
                txup_worker2.Text = "";
                txup_talmidim2.Text = "";

                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;

                dataGridView1.DataSource = hoursesDataSet.activity;

            }



        }

        private void bt_de_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from activity where shem='" + txde_shem.Text + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form_activity_Load(sender, e);

            txde_bigginighour.Clear();
            txde_day.Clear();
            txde_endinghour.Clear();
            txde_gilaim.Clear();
            txde_shem.Clear();
            txde_worker.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            txde_shem.Text = row.Cells[0].Value.ToString();
            txde_day.Text = row.Cells[1].Value.ToString();
            txde_bigginighour.Text = row.Cells[2].Value.ToString();
            txde_endinghour.Text = row.Cells[3].Value.ToString();
            txde_worker.Text = row.Cells[4].Value.ToString();
            txde_gilaim.Text = row.Cells[6].Value.ToString();
            txde_tarich.Text = row.Cells[5].Value.ToString();

            txup_shem.Text = row.Cells[0].Value.ToString();
            comboup.Text = row.Cells[1].Value.ToString();
            txup_biginnighour.Text = row.Cells[2].Value.ToString();
            txup_endinghour.Text = row.Cells[3].Value.ToString();
            txup_worker2.Text = row.Cells[4].Value.ToString();
            txup_talmidim2.Text = row.Cells[5].Value.ToString();
            txup_tarich.Text = row.Cells[5].Value.ToString();
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
            activityBindingSource.MoveNext();

        }

        private void before_Click_1(object sender, EventArgs e)
        {
            activityBindingSource.MovePrevious();

        }

        private void first_Click_1(object sender, EventArgs e)
        {
            activityBindingSource.MoveFirst();

        }

        private void last_Click_1(object sender, EventArgs e)
        {
            activityBindingSource.MoveLast();

        }

        private void txb_gil_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void txb_shem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txup_shem_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txb_worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txup_worker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txb_shem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_worker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
