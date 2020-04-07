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
    public partial class Form_sapakim : Form
    {
        public Form_sapakim()
        {
            InitializeComponent();
        }

        hoursesDataSet.sapakimDataTable mm;
        hoursesDataSet.sapakimDataTable mz;
        int selectedRow;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\christina hoursesfinal3\hourses.mdb");

        private void Form_sapakim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoursesDataSet.sapakim' table. You can move, or remove it, as needed.
            this.sapakimTableAdapter.Fill(this.hoursesDataSet.sapakim);
            
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shem.Visible = true;
            phone.Visible = true;
            ishkesherphone.Visible = true;
            ktovet.Visible = true;
            txb_ishkeshrphone.Visible = true;
            txb_ktovet.Visible = true;
            txb_phone.Visible = true;
            txb_shem.Visible = true;
            bt_add.Visible = true;
            up_ctovet.Visible = false;
            up_ishkesherphone.Visible = false;
            up_phone.Visible = false;
            up_shem.Visible = false;
            txbup_ctovet.Visible = false;
            txbup_ishkesherphone.Visible = false;
            txbup_phone.Visible = false;
            txbup_shem.Visible = false;
            bt_ap.Visible = false;
            de_ctovet.Visible = false;
            de_ishkesherphone.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible = false;
            txbde_ctovet.Visible = false;
            txbde_ishkesherphone.Visible = false;
            txbde_phone.Visible = false;
            txbde_shem.Visible = false;
            bt_delete.Visible = false;
            

           
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            bool bl3 = true;

            if (txb_phone.Text.Length != 11)
            {
                bl3 = false;
                label2.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }
            if (txb_ishkeshrphone.Text.Length != 11)
            {
                bl3 = false;
                label4.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }
           
            bool bl1 = true;
            if(txb_shem.Text == "")
            {
               bl1 = false;
                label1.Visible=true;
               MessageBox.Show("הזנת הערך הכרחית");
             
            }
            if (txb_phone.Text == "")
            {
                bl1 = false;
                label2.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_ktovet.Text == "")
            {
                bl1 = false;
                label3.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txb_ishkeshrphone.Text == "")
            {
                bl1 = false;
                label4.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }

           
            
            mm = hoursesDataSet.sapakim;
            string s = txb_shem.Text;
            bool bl = true;
            string ss;
            for (int j = 0; (j < mm.Rows.Count) && bl; j++)
            {
                ss = mm.Rows[j]["shem"].ToString();

                if (s.Equals(ss))
                {
                    MessageBox.Show("ספק זה קיים במערכת");
                    bl = false;
                    txb_shem.Clear();
                    txb_phone.Clear();
                    txb_ktovet.Clear();
                    txb_ishkeshrphone.Clear();

                   

                }
            }



            if (bl == true && bl1 == true && bl3 == true)
            {
                DialogResult dr = MessageBox.Show("? האם את/ה בטוח שאתה רוצה להוסיף ספק זה ", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "INSERT into sapakim(shem,[mispar telephone],ktovet,[telephone aish kesher]) VALUES('" + txb_shem.Text + "','" + txb_phone.Text + "','" + txb_ktovet.Text + "','" + txb_ishkeshrphone.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_sapakim_Load(sender, e);

                    txb_shem.Clear();
                    txb_phone.Clear();
                    txb_ktovet.Clear();
                    txb_ishkeshrphone.Clear();

                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;

                }
            }
        }
        

        private void bt_update_horses_Click(object sender, EventArgs e)
        {

            txbup_shem.Clear();
            txb_phone.Clear();
            txbup_ctovet.Clear();
            txbup_ishkesherphone.Clear();

            shem.Visible = false;
            phone.Visible = false;
            ishkesherphone.Visible = false;
            ktovet.Visible = false;
            txb_ishkeshrphone.Visible = false;
            txb_ktovet.Visible = false;
            txb_phone.Visible = false;
            txb_shem.Visible = false;
            bt_add.Visible = false;
            up_ctovet.Visible = true;
            up_ishkesherphone.Visible = true;
            up_phone.Visible = true;
            up_shem.Visible = true;
            txbup_ctovet.Visible = true;
            txbup_ishkesherphone.Visible = true;
            txbup_phone.Visible = true;
            txbup_shem.Visible = true;
            bt_ap.Visible = true;
            de_ctovet.Visible = false;
            de_ishkesherphone.Visible = false;
            de_phone.Visible = false;
            de_shem.Visible =false ;
            txbde_ctovet.Visible =false;
            txbde_ishkesherphone.Visible =false;
            txbde_phone.Visible = false;
            txbde_shem.Visible = false;
            bt_delete.Visible = false;
            
            
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txbup_shem.Text =row.Cells[0].Value.ToString();
            txbup_phone.Text = row.Cells[1].Value.ToString();
            txbup_ctovet.Text =row.Cells[2].Value.ToString();
            txbup_ishkesherphone.Text = row.Cells[3].Value.ToString();
            txbde_shem.Text = row.Cells[0].Value.ToString();
            txbde_phone.Text = row.Cells[1].Value.ToString();
            txbde_ishkesherphone.Text = row.Cells[3].Value.ToString();
            txbde_ctovet.Text = row.Cells[2].Value.ToString();

        }

         private void bt_ap_Click(object sender, EventArgs e)
        {
            bool bl2 = true;
            if (txbup_phone.Text.Length != 11)
            {
                bl2 = false;
                label12.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }
            if (txbup_ishkesherphone.Text.Length != 11)
            {
                bl2 = false;
                label14.Visible = true;
                MessageBox.Show("יש להזין 10 ספרות למספר הפלאפון");
            }

            bool bl1 = true;
            if (txbup_shem.Text == "")
            {
                bl1 = false;
                label11.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");

            }
            if (txbup_phone.Text == "")
            {
                bl1 = false;
                label12.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txbup_ctovet.Text == "")
            {
                bl1 = false;
                label13.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }
            if (txbup_ishkesherphone.Text == "")
            {
                bl1 = false;
                label14.Visible = true;
                MessageBox.Show("הזנת הערך הכרחית");
            }


            if (bl1 == true && bl2==true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update sapakim SET [telephone aish kesher]='" + txbup_ishkesherphone.Text + "', [mispar telephone]='" + txbup_phone.Text + "', ktovet='" + txbup_ctovet.Text + "' where shem='" + txbup_shem.Text + "'";

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form_sapakim_Load(sender, e);

                txbup_shem.Clear();
                txbup_phone.Clear();
                txbup_ctovet.Clear();
                txbup_ishkesherphone.Clear();
                dataGridView1.DataSource = hoursesDataSet.sapakim;
            }
        }


         private void txbup_shem_TextChanged(object sender, EventArgs e)
         {

         }

         private void bt_delete_horses_Click(object sender, EventArgs e)
         {

             txbde_ctovet.Clear();
             txbde_ishkesherphone.Clear();
             txbde_phone.Clear();
             txbde_shem.Clear();

             de_ctovet.Visible = true;
             de_ishkesherphone.Visible = true;
             de_phone.Visible = true;
             de_shem.Visible = true;
             txbde_ctovet.Visible = true;
             txbde_ishkesherphone.Visible = true;
             txbde_phone.Visible = true;
             txbde_shem.Visible = true;
             bt_delete.Visible = true;
             shem.Visible = false;
             phone.Visible = false;
             ishkesherphone.Visible = false;
             ktovet.Visible = false;
             txb_ishkeshrphone.Visible = false;
             txb_ktovet.Visible = false;
             txb_phone.Visible = false;
             txb_shem.Visible = false;
             bt_add.Visible = false;
             up_ctovet.Visible = false;
             up_ishkesherphone.Visible = false;
             up_phone.Visible = false;
             up_shem.Visible = false;
             txbup_ctovet.Visible = false;
             txbup_ishkesherphone.Visible = false;
             txbup_phone.Visible = false;
             txbup_shem.Visible = false;
             bt_ap.Visible = false;

         }

         private void bt_delete_Click(object sender, EventArgs e)
         {

             selectedRow = dataGridView1.CurrentCell.RowIndex;
             dataGridView1.Rows.RemoveAt(selectedRow);
          

             OleDbCommand cmd = new OleDbCommand();
             cmd.CommandText = "delete from sapakim where shem='" + txbde_shem.Text + "' "; 

             cmd.Connection = con;
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();
             Form_sapakim_Load(sender, e);

             txbde_ctovet.Clear();
             txbde_ishkesherphone.Clear();
             txbde_phone.Clear();
             txbde_shem.Clear();


         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
             mz = hoursesDataSet.sapakim;
             DataTable dz = new DataTable();
             dz.Columns.Add("shem");
             dz.Columns.Add("mispar telephone");
             dz.Columns.Add("ktovet");
             dz.Columns.Add("telephone aish kesher");

             for (int j = 0; j < mz.Rows.Count; j++)
             {
                 for (int k = 0; k < mz.Columns.Count; k++)
                 {
                     if (mz.Rows[j][k].ToString().Contains(textBox1.Text))
                     {
                         dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3]);
                         k = mz.Columns.Count;
                     }

                 }

             }

             dataGridView1.DataSource = dz;

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void em1_Click(object sender, EventArgs e)
         {

         }

         private void txb_ishkeshrphone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
         {

         }

         private void label14_Click(object sender, EventArgs e)
         {

         }

         private void txb_phone_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.Handled = (e.KeyChar == (char)Keys.Space))
             {
                 MessageBox.Show("לא ניתן להזין מספר פלאפון עם רווחחים");
             }
         }

         private void txbup_phone_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.Handled = (e.KeyChar == (char)Keys.Space))
             {
                 MessageBox.Show("לא ניתן להזין מספר פלאפון עם רווחחים");
             }
         }

         private void txb_ishkeshrphone_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.Handled = (e.KeyChar == (char)Keys.Space))
             {
                 MessageBox.Show("לא ניתן להזין מספר פלאפון עם רווחחים");
             }
         }

         private void txbup_ishkesherphone_KeyPress(object sender, KeyPressEventArgs e)
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
         }

         private void haba_Click_1(object sender, EventArgs e)
         {
             sapakimBindingSource.MoveNext();

         }

         private void before_Click_1(object sender, EventArgs e)
         {
             sapakimBindingSource.MovePrevious();

         }

         private void first_Click_1(object sender, EventArgs e)
         {
             sapakimBindingSource.MoveFirst();

         }

         private void last_Click_1(object sender, EventArgs e)
         {
             sapakimBindingSource.MoveLast();
         }

         private void txb_shem_KeyPress(object sender, KeyPressEventArgs e)
         {
             e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
         }

         private void txbup_shem_KeyPress(object sender, KeyPressEventArgs e)
         {
             e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
         }



    }

}
