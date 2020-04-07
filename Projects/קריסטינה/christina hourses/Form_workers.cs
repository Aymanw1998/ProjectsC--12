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
    public partial class Form_workers : Form
    {
        public Form_workers()
        {
            InitializeComponent();
        }

        hoursesDataSet.workeersDataTable mm;
        
        hoursesDataSet.workeersDataTable mz;
        int selectedRow;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void Form_workers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.workeers' table. You can move, or remove it, as needed.
            this.workeersTableAdapter.Fill(this.hoursesDataSet.workeers);
            
           
   
           
            
           
            

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shem.Visible = true;
            id.Visible = true;
            family.Visible = true;
            age.Visible = true;
            phone.Visible = true;
            mail.Visible = true;
            yeshoov.Visible = true;
            numworker.Visible = true;
            txb_id.Visible = true;
            txb_age.Visible = true;
            txb_family.Visible = true;
            txb_mail.Visible = true;
            txb_numworker.Visible = true;
            txb_phone.Visible = true;
            txb_shem.Visible = true;
            txb_yeshoov.Visible = true;
            bt_ok.Visible = true;

            up_family.Visible = false;
            up_gil.Visible = false;
            up_id.Visible = false;
            up_kod.Visible = false;
            up_mail.Visible = false;
            up_phone.Visible = false;
            up_shem.Visible = false;
            up_yshoov.Visible = false;
            txup_family.Visible = false;
            txup_gil.Visible = false;
            txup_id.Visible = false;
            txup_kod.Visible = false;
            txup_mail.Visible = false;
            txup_phone.Visible = false;
            txup_shem.Visible = false;
            txup_yshoov.Visible = false;
            bt_up.Visible = false;

            de_family.Visible = false;
            de_gil.Visible = false;
            de_id.Visible = false;
            de_kod.Visible = false;
            de_mail.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible = false;
            de_yshoov.Visible = false;
            txde_family.Visible = false;
            txde_gil.Visible = false;
            txde_id.Visible = false;
            txde_kod.Visible = false;
            txde_mail.Visible = false;
            txde_phone.Visible = false;
            txde_shem.Visible = false;
            txde_yshoov.Visible = false;
            bt_de.Visible = false;
        }

        private void bt_ok_Click(object sender, EventArgs e)
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
                label1.Visible = true;
                MessageBox.Show("יש להזין 9 ספרות לתעודת הזהות");
            }

            if (txb_phone.Text.Length != 11)
            {
                bl3 = false;
                label5.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }


            bool bl2 = true;
            if (!(Class1.Maail(txb_mail.Text)))
            {
                MessageBox.Show("ערך המייל אינו תקין ");
                bl2 = false;
            }


            bool bl1 = true;
            if (txb_id.Text == "")
            {
                bl1 = false;
                label1.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txb_shem.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_family.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_age.Text == "")
            {
                bl1 = false;
                label4.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_phone.Text == "")
            {
                bl1 = false;
                label5.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_mail.Text == "")
            {
                bl1 = false;
                label6.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_yeshoov.Text == "")
            {
                bl1 = false;
                label7.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_numworker.Text == "")
            {
                bl1 = false;
                label8.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }

            mm = hoursesDataSet.workeers;
            string s = txb_id.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["id"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("עובד זה קיים במערכת");
                    bl = false;

                    txb_id.Clear();
                    txb_age.Clear();
                    txb_family.Clear();
                    txb_mail.Clear();
                    txb_numworker.Clear();
                    txb_phone.Clear();
                    txb_shem.Clear();
                    txb_yeshoov.Clear();


                }
            }

            string st = txb_numworker.Text;
            bool bl4 = true;
            string hh;
            for (int j = 0; (j < mm.Rows.Count) && bl4; j++)
            {
                hh = mm.Rows[j]["mispar oved"].ToString();

                if (st.Equals(hh))
                {
                    MessageBox.Show("סיסמה זאת קיימת במערכת");
                    bl4 = false;
                }
            }

                if (bl == true && bl1 == true && bl2 == true && bl3 == true && bl11 == true && bl4 == true)
                {
                    DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף עובד זה ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into workeers(id,shem,mishpaha,gil,phone,email,yeshoov,[mispar oved]) VALUES('" + txb_id.Text + "','" + txb_shem.Text + "','" + txb_family.Text + "','" + txb_age.Text + "','" + txb_phone.Text + "','" + txb_mail.Text + "','" + txb_yeshoov.Text + "','" + txb_numworker.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Form_workers_Load(sender, e);

                        txb_id.Clear();
                        txb_age.Clear();
                        txb_family.Clear();
                        txb_mail.Clear();
                        txb_numworker.Clear();
                        txb_phone.Clear();
                        txb_shem.Clear();
                        txb_yeshoov.Clear();

                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;

                    }
                }
            }
        

        private void Form_workers_Load()
        {
            //throw new NotImplementedException();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            txde_family.Clear();
            txde_gil.Clear();
            txde_id.Clear();
            txde_kod.Clear();
            txde_mail.Clear();
            txde_phone.Clear();
            txde_shem.Clear();
            txde_yshoov.Clear();



            shem.Visible = false;
            id.Visible = false;
            family.Visible = false;
            age.Visible = false;
            phone.Visible = false;
            mail.Visible = false;
            yeshoov.Visible = false;
            numworker.Visible = false;
            txb_id.Visible = false;
            txb_age.Visible = false;
            txb_family.Visible = false;
            txb_mail.Visible = false;
            txb_numworker.Visible = false;
            txb_phone.Visible = false;
            txb_shem.Visible = false;
            txb_yeshoov.Visible = false;
            bt_ok.Visible = false;

            up_family.Visible = false;
            up_gil.Visible = false;
            up_id.Visible = false;
            up_kod.Visible = false;
            up_mail.Visible = false;
            up_phone.Visible = false;
            up_shem.Visible = false;
            up_yshoov.Visible = false;
            txup_family.Visible = false;
            txup_gil.Visible = false;
            txup_id.Visible = false;
            txup_kod.Visible = false;
            txup_mail.Visible = false;
            txup_phone.Visible = false;
            txup_shem.Visible = false;
            txup_yshoov.Visible = false;
            bt_up.Visible = false;


            de_family.Visible = true;
            de_gil.Visible = true;
            de_id.Visible = true;
            de_kod.Visible = true;
            de_mail.Visible = true;
            de_phone.Visible = true;
            de_shem.Visible = true;
            de_yshoov.Visible = true;
            txde_family.Visible = true;
            txde_gil.Visible = true;
            txde_id.Visible = true;
            txde_kod.Visible = true;
            txde_mail.Visible = true;
            txde_phone.Visible = true;
            txde_shem.Visible = true;
            txde_yshoov.Visible = true;
            bt_de.Visible = true;


        }

        private void bt_de_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "delete from workeers where id='" + txde_id.Text + "' ";

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form_workers_Load(sender, e);

            txde_family.Clear();
            txde_gil.Clear();
            txde_id.Clear();
            txde_kod.Clear();
            txde_mail.Clear();
            txde_phone.Clear();
            txde_shem.Clear();
            txde_yshoov.Clear();



            
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            txup_id.Clear();
            txup_shem.Clear();
            txup_family.Clear();
            txup_gil.Clear();
            txup_phone.Clear();
            txup_mail.Clear();
            txup_yshoov.Clear();
            txup_kod.Clear();


            shem.Visible = false;
            id.Visible = false;
            family.Visible = false;
            age.Visible = false;
            phone.Visible = false;
            mail.Visible = false;
            yeshoov.Visible = false;
            numworker.Visible = false;
            txb_id.Visible = false;
            txb_age.Visible = false;
            txb_family.Visible = false;
            txb_mail.Visible = false;
            txb_numworker.Visible = false;
            txb_phone.Visible = false;
            txb_shem.Visible = false;
            txb_yeshoov.Visible = false;
            bt_ok.Visible = false;

            up_family.Visible = true;
            up_gil.Visible = true;
            up_id.Visible = true;
            up_kod.Visible = true;
            up_mail.Visible = true;
            up_phone.Visible = true;
            up_shem.Visible = true;
            up_yshoov.Visible = true;
            txup_family.Visible = true;
            txup_gil.Visible = true;
            txup_id.Visible = true;
            txup_kod.Visible = true;
            txup_mail.Visible = true;
            txup_phone.Visible = true;
            txup_shem.Visible = true;
            txup_yshoov.Visible = true;
            bt_up.Visible = true;

            de_family.Visible = false;
            de_gil.Visible = false;
            de_id.Visible = false;
            de_kod.Visible = false;
            de_mail.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible = false;
            de_yshoov.Visible = false;
            txde_family.Visible = false;
            txde_gil.Visible = false;
            txde_id.Visible = false;
            txde_kod.Visible = false;
            txde_mail.Visible = false;
            txde_phone.Visible = false;
            txde_shem.Visible = false;
            txde_yshoov.Visible = false;
            bt_de.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mz = hoursesDataSet.workeers;
            DataTable dz = new DataTable();
            dz.Columns.Add("id");
            dz.Columns.Add("shem");
            dz.Columns.Add("mishpaha");
            dz.Columns.Add("gil");
            dz.Columns.Add("phone");
            dz.Columns.Add("email");
            dz.Columns.Add("yeshoov");
            dz.Columns.Add("mispar oved");

            for (int j = 0; j < mz.Rows.Count; j++)
            {
                for (int k = 0; k < mz.Columns.Count; k++)
                {
                    if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                    {
                        dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6], mz[j][7]);
                        k = mz.Columns.Count;
                    }

                }

            }

            dataGridView1.DataSource = dz;

        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            bool bl11 = true;
            string s2 = txb_id.Text;
            int x = s2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }
            bool bl2 = true;
            if (txup_phone.Text.Length != 11)
            {
                bl2 = false;
                label15.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }

            bool bl1 = true;
            if (txup_id.Text == "")
            {
                bl1 = false;
                label11.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txup_shem.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_family.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_gil.Text == "")
            {
                bl1 = false;
                label14.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_phone.Text == "")
            {
                bl1 = false;
                label15.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_mail.Text == "")
            {
                bl1 = false;
                label16.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_yshoov.Text == "")
            {
                bl1 = false;
                label17.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txup_kod.Text == "")
            {
                bl1 = false;
                label18.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }

            mm = hoursesDataSet.workeers;
            string st = txup_kod.Text;
            bool bl4 = true;
            string hh;
            for (int j = 0; (j < mm.Rows.Count) && bl4; j++)
            {
                hh = mm.Rows[j]["mispar oved"].ToString();

                if (st.Equals(hh))
                {
                    MessageBox.Show("סיסמה זאת קיימת במערכת");
                    bl4 = false;
                }
            }

            if (bl1 == true && bl2 == true && bl11 == true && bl4 == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update workeers SET[mispar oved]='" + txup_kod.Text + "' , shem='" + txup_shem.Text + "',mishpaha='" + txup_family.Text + "' , gil='" + txup_gil.Text + "' , phone='" + txup_phone.Text + "', email='" + txup_mail.Text + "', yeshoov='" + txup_yshoov.Text + "' where id='" + txup_id.Text + "'";

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_workers_Load(sender, e);

                txup_id.Clear();
                txup_shem.Clear();
                txup_family.Clear();
                txup_gil.Clear();
                txup_phone.Clear();
                txup_mail.Clear();
                txup_yshoov.Clear();
                txup_kod.Clear();

                dataGridView1.DataSource = hoursesDataSet.workeers;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txde_id.Text = row.Cells[0].Value.ToString();
            txde_shem.Text = row.Cells[1].Value.ToString();
            txde_family.Text = row.Cells[2].Value.ToString();
            txde_gil.Text = row.Cells[3].Value.ToString();
            txde_phone.Text = row.Cells[4].Value.ToString();
            txde_mail.Text = row.Cells[5].Value.ToString();
            txde_yshoov.Text = row.Cells[6].Value.ToString();
            txde_kod.Text = row.Cells[7].Value.ToString();

            txup_id.Text = row.Cells[0].Value.ToString();
            txup_shem.Text = row.Cells[1].Value.ToString();
            txup_family.Text = row.Cells[2].Value.ToString();
            txup_gil.Text = row.Cells[3].Value.ToString();
            txup_phone.Text = row.Cells[4].Value.ToString();
            txup_mail.Text = row.Cells[5].Value.ToString();
            txup_yshoov.Text = row.Cells[6].Value.ToString();
            txup_kod.Text = row.Cells[7].Value.ToString();
        }

      
              private void txb_id_KeyPress(object sender, KeyPressEventArgs e)

               {
                   if (e.Handled = (e.KeyChar == (char)Keys.Space))
                   {
                       MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
                   }
               }

              private void txb_id_KeyPress_1(object sender, KeyPressEventArgs e)
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

              private void first_Click(object sender, EventArgs e)
              {
                 
              }

              private void last_Click(object sender, EventArgs e)
              {
             
              }

              private void before_Click(object sender, EventArgs e)
              {
                  workeersBindingSource.MovePrevious();
              }

              private void last_Click_1(object sender, EventArgs e)
              {
                  workeersBindingSource.MoveLast();
              }

              private void first_Click_1(object sender, EventArgs e)
              {
                  workeersBindingSource.MoveFirst();
              }

              private void haba_Click_1(object sender, EventArgs e)
              {
                  workeersBindingSource.MoveNext();

              }

              private void txb_shem_KeyPress(object sender, KeyPressEventArgs e)
              {
                  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
              }

              private void txb_family_KeyPress(object sender, KeyPressEventArgs e)
              {
                  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
              }

              private void txup_shem_KeyPress(object sender, KeyPressEventArgs e)
              {
                  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
              }

              private void txup_family_KeyPress(object sender, KeyPressEventArgs e)
              {
                  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
              }

              private void txb_numworker_TextChanged(object sender, EventArgs e)
              {

              }

    
    }
}
