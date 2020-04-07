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

namespace WindowsFormsApplication1
{
    public partial class formhugeem : Form
    {
       

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public formhugeem()
        {
            InitializeComponent();
        }

        razan22DataSet1.hugeem2DataTable mm;
        razan22DataSet1.hugeem2DataTable mz;

        razan22DataSet1.meamnim2DataTable mw;

       
       

        private void formhugeem_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'razan22DataSet1.meamnim2' table. You can move, or remove it, as needed.
            this.meamnim2TableAdapter.Fill(this.razan22DataSet1.meamnim2);
            // TODO: This line of code loads data into the 'razan22DataSet1.hugeem2' table. You can move, or remove it, as needed.
            this.hugeem2TableAdapter.Fill(this.razan22DataSet1.hugeem2);
            MTtzmore.Items.Clear();
            mw = razan22DataSet1.meamnim2;
            for(int i=0; i<mw.Rows.Count; i++)
            {
                MTtzmore.Items.Add(mw.Rows[i]["tz"].ToString());
            }

         
        }

        private void btnbkhu_Click(object sender, EventArgs e)
        {
            this.Close();
      
       }

        private void btnhugho_Click(object sender, EventArgs e)
        {
            
            bool bl3 = true;
            bool bl2 = true;
            bool bl11 = true;
            string st2 = MTtzmore.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן תעודת זהות ללא רווח");
                bl11 = false;
            }

            if (shemhug.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (more.Text == "")
            {
                bl2 = false;
                label3.Visible = true;
               
            }
            else
                label3.Visible = false;


            if (MTtzmore.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;

            if (yamim.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (mispar.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;

            if (misparshioreem.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (comboBox1.Text == "")
            {
                bl2 = false;
                label7.Visible = true;

            }
            else

                label7.Visible = false;


            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }
            bool bl266 = true;
            bool bl26 = true;

            if (bl2 == true)
            {

                if (MTtzmore.Text.Length != 9)
                {
                    bl3 = false;
                    MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
                }

                

                string s266 = misparshioreem.Text;
                if (double.Parse(s266) != 2)
                {
                    bl266 = false;
                    MessageBox.Show("הקש מספר שיעורים שווה 2 שיעורים");
                }



               
                string s26 = mispar.Text;
                if (double.Parse(s26) > 25 || double.Parse(s26)<0)
                {
                    bl26 = false;
                    MessageBox.Show("הקש מספר משתתפים בין 0-26");
                }
            }
            if (bl2 == true && bl3 == true && bl11==true && bl26==true && bl266==true)
            {

                mm = razan22DataSet1.hugeem2;


                string s = shemhug.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["shem"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("חוג זה קיים");
                        bl = false;


                    }

                }


                

                if (bl == true)
                {

                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into hugeem2(shem,mispar,more,tzmore,yamim,shuoreem,shaoot) VALUES('" + shemhug.Text + "' , '" + mispar.Text + "' , '" + more.Text + "' , '" + MTtzmore.Text + "' , '" + yamim.Text + "' , '" + misparshioreem.Text + "' , '" + comboBox1.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formhugeem_Load(sender, e);

                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                        button7.Visible = true;
                        shemhug2.Enabled = false;
                        mispar.Enabled = false;
                        more.Enabled = false;
                        MTtzmore.Enabled = false;
                        yamim.Enabled = false;
                        misparshioreem.Enabled = false;
                        comboBox1.Enabled = false;
            

                    }

                     if (dr == DialogResult.No)
                     {
                         button7.Visible = true;
                         shemhug2.Enabled = false;
                         mispar.Enabled = false;
                         more.Enabled = false;
                         MTtzmore.Enabled = false;
                         yamim.Enabled = false;
                         misparshioreem.Enabled = false;
                         comboBox1.Enabled = false;

                         shemhug2.Clear();
                         mispar.Clear();
                         more.Clear();
                         MTtzmore.Text = "";
                         yamim.Text="";
                         misparshioreem.Clear();
                         
                         comboBox1.Text = "";

                     }

                    

                }


            }

            shemhug2.Visible = true;

          


            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void hugeem2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnhugmh_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (shemhug.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן שם חוג למחיקה");
            }
            if (blb == true)
            {
                mm = razan22DataSet1.hugeem2;


                string s = shemhug.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["shem"].ToString();

                    if (s.Equals(ss))
                    {
                        bl = false;
                        blb2 = true;
                            DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה למחוק?", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dr == DialogResult.Yes)
                            {
                                
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "Delete from hugeem2 where shem = '" + shemhug.Text + "' ";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();



                                formhugeem_Load(sender, e);
                                MessageBox.Show("!מחיקה בוצעה בהצלחה");
                        
                            }

                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן שם חוג קיים למחיקה");
            }

            shemhug2.Visible = true;

            
        }
        private void btnhugidk_Click(object sender, EventArgs e)
        {
            
            bool bl11 = true;
            string st2 = MTtzmore.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            
                {
                    MessageBox.Show("הזן תעודת זהות ללא רווח");
                    bl11 = false;
                }

                bool bl2 = true;

                if (more.Text == "")
                {
                    bl2 = false;
                    label3.Visible = true;

                }
                else
                    label3.Visible = false;


                if (MTtzmore.Text == "")
                {
                    bl2 = false;
                    label2.Visible = true;

                }
                else
                    label2.Visible = false;

                if (yamim.Text == "")
                {
                    bl2 = false;
                    label4.Visible = true;

                }
                else

                    label4.Visible = false;

                if (mispar.Text == "")
                {
                    bl2 = false;
                    label5.Visible = true;

                }
                else

                    label5.Visible = false;

                if (misparshioreem.Text == "")
                {
                    bl2 = false;
                    label6.Visible = true;

                }
                else

                    label6.Visible = false;

                if (comboBox1.Text == "")
                {
                    bl2 = false;
                    label7.Visible = true;

                }
                else

                    label7.Visible = false;



                if (bl2 == false)
                {

                    MessageBox.Show("הזן ערך בשדה חובה");

                }

                bool bl3 = true;
                if (MTtzmore.Text.Length != 9)
                {
                    bl3 = false;
                    MessageBox.Show("הזן תעודת זהות באורך 9 ספרות");
                }

                bool blb2 = true;
                bool blb = true;
                if (shemhug.Text == "")
                {
                    blb = false;
                    MessageBox.Show("הזן שם חוג לעדכון");
                }
                bool bl26 = true;
                string s26 = mispar.Text;
               
                if (double.Parse(s26) > 25 || double.Parse(s26) < 0)
                {
                    bl26 = false;
                    MessageBox.Show("הקש מספר משתתפים בין 0-26");
                }
                bool bl266 = true;

                string s266 = misparshioreem.Text;
                if (double.Parse(s266) > 2)
                {
                    bl266 = false;
                    MessageBox.Show("הקש מספר שיעורים שווה 2 שיעורים");
                }



                if (blb == true && bl11 == true && bl3 == true && bl2==true && bl26==true && bl266==true)
                {
                    mm = razan22DataSet1.hugeem2;


                    string s = shemhug.Text;
                    bool bl = true;
                    string ss;



                    for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                    {
                        ss = mm.Rows[j]["shem"].ToString();

                        if (s.Equals(ss))
                        {
                            bl = false;
                            blb2 = true;
                            DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה לעדכן?", "עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dr == DialogResult.Yes)
                            {
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "Update hugeem2 SET mispar =  '" + mispar.Text + "' , more = '" + more.Text + "' , tzmore = '" + MTtzmore.Text + "' , shuoreem = '" + misparshioreem.Text + "' , shaoot = '" + comboBox1.Text + "' where shem='" + shemhug.Text + "' ";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();



                                formhugeem_Load(sender, e);
                                MessageBox.Show("!שינויים בוצעו בהצלחה");
                                button5.Visible = true;
                                shemhug2.Enabled = false;
                                mispar.Enabled = false;
                                more.Enabled = false;
                                MTtzmore.Enabled = false;
                                yamim.Enabled = false;
                                misparshioreem.Enabled = false;
                                comboBox1.Enabled = false;


                            }

                            if (dr == DialogResult.No)
                            {
                                button5.Visible = true;
                                shemhug2.Enabled = false;
                                mispar.Enabled = false;
                                more.Enabled = false;
                                MTtzmore.Enabled = false;
                                yamim.Enabled = false;
                                misparshioreem.Enabled = false;
                                comboBox1.Enabled = false;

                                shemhug2.Clear();
                                mispar.Clear();
                                more.Clear();
                                MTtzmore.Text = "";
                                yamim.Text = "";
                                misparshioreem.Clear();
                               
                                comboBox1.Text = "";

                            }



                        }
                        else
                            blb2 = false;

                    }

                    if (blb2 == false)
                        MessageBox.Show("הזן שם חוג קיים לעדכון");
                }

                shemhug2.Visible = true;
     
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void tbhugeem_TextChanged(object sender, EventArgs e)
        {
            if (tbhugeem.Text.Length == 0)
            {
                formhugeem_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.hugeem2 ;
            }
            else
            {
                mz = razan22DataSet1.hugeem2;
                DataTable dz = new DataTable();
                dz.Columns.Add("shem");
                dz.Columns.Add("mispar");
                dz.Columns.Add("more");
                dz.Columns.Add("tzmore");
                dz.Columns.Add("yamim");
                dz.Columns.Add("shuoreem");
                dz.Columns.Add("shaoot");

                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbhugeem.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5], mz[j][6]);
                            k = mz.Columns.Count;

                        }

                    }


                }


                dataGridView1.DataSource = dz;
            }

        }

        

        private void shemhug2_TextChanged(object sender, EventArgs e)
        {
            shemhug.Text = shemhug2.Text;
        }

        private void shemhug2_Click(object sender, EventArgs e)
        {
            shemhug2.Visible = false;
            shemhug.Focus();
        }

        private void shemhug_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MTtzmore_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         
        }

        private void MTtzmore_Validating(object sender, CancelEventArgs e)
        {

        }

        private void shemhug2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void shemhug2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void shemhug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void more_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MTtzmore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=(e.KeyChar==(char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין תעודת זהות עם רווחים");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lblhug_Click(object sender, EventArgs e)
        {

        }

        private void misparshioreem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=46 && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hugeem2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hugeem2BindingSource.MoveLast();
        }

        private void mispar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            shemhug2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mispar.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            more.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MTtzmore.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            yamim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            misparshioreem.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hugeem2BindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hugeem2BindingSource.MovePrevious();
        }

        private void shemhug2_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            shemhug2.Enabled = true;
            mispar.Enabled = true;
            more.Enabled = true;
            MTtzmore.Enabled = true;
            yamim.Enabled = true;
            misparshioreem.Enabled = true;
            comboBox1.Enabled = true;
            shemhug.Enabled = true;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void tbhugeem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbhugeem_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            shemhug.Enabled = true;
            shemhug2.Enabled = true;
            mispar.Enabled = true;
            more.Enabled = true;
            MTtzmore.Enabled = true;
            yamim.Enabled = true;
            misparshioreem.Enabled = true;
            comboBox1.Enabled = true;
            shemhug.Clear();
            shemhug2.Clear();
            mispar.Clear();
            more.Clear();
            MTtzmore.Text = "";
            yamim.Text = "";
            misparshioreem.Clear();
            comboBox1.Text = "";
      

        }

        private void more_TextChanged(object sender, EventArgs e)
        {

        }

        private void misparshioreem_TextChanged(object sender, EventArgs e)
        {

        }

        private void misparshioreem_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void MTtzmore_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(MTtzmore.SelectedIndex)>-1)
            more.Text = mw.Rows[MTtzmore.SelectedIndex]["shem"].ToString();
        }

        private void MTtzmore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

