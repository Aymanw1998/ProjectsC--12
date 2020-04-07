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
    public partial class formsapakim : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public formsapakim()
        {
            InitializeComponent();
        }

        
        razan22DataSet1.sapakim2DataTable mm;
        razan22DataSet1.sapakim2DataTable mz;

        private void formsapakim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.sapakim2' table. You can move, or remove it, as needed.
            this.sapakim2TableAdapter.Fill(this.razan22DataSet1.sapakim2);
           

        }

        private void btnbksu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bcsapak_Click(object sender, EventArgs e)
        {
            this.Close();
            formmenahel menback1 = new formmenahel();
            menback1.Show();

        }

        private void tbsauppliers_TextChanged(object sender, EventArgs e)
        {
            if (tbsuppliers.Text.Length == 0)
            {
                formsapakim_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.sapakim2;
            }

            else
            {

                mz = razan22DataSet1.sapakim2;
                DataTable dz = new DataTable();
                dz.Columns.Add("sapak");
                dz.Columns.Add("tel");
                dz.Columns.Add("ktovet");
                dz.Columns.Add("mail");
                dz.Columns.Add("yeshuv");
                dz.Columns.Add("mispar");


                
                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbsuppliers.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4], mz[j][5]);

                            k = mz.Columns.Count;

                        }

                    }


                }

                dataGridView1.DataSource = dz;
            }
        }
        private void lblssuppliers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsapidk_Click(object sender, EventArgs e)
        {

            bool bl111 = true;
            string st22 = maskedTextBox1.Text;
            int xx = st22.IndexOf(' ');
            if (xx != -1)
            {
                MessageBox.Show("הזן מספר פלאפון ללא רווח");
                bl111 = false;
            }

            bool bl11 = true;
            string st2 = shemsapak.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן שם ספק ללא רווח");
                bl11 = false;
            }
            bool bl2 = true;

            if (shemsapak.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (maskedTextBox1.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (ktovetsapak.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (yeshuvsapak.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (missapak.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;



            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            bool bl3 = true;
            if (maskedTextBox1.Text.Length != 11)
            {
                bl3 = false;
                MessageBox.Show("הזן מספר פלאפון חוקי");
            }

           
            bool blb2 = true;
            bool blb = true;
            if (shemsapak.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן שם ספק לעדכון");
            }

         
            bool bl100 = true;
            string sv = maskedTextBox1.Text;
            if (sv[0] != '0' || sv[1] != '5')
            {
                MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                bl100 = false;
            }

         
       


                if (bl11 == true && bl100 == true && bl2 == true && bl3 == true && blb == true && bl111 == true)
                {

                    mm = razan22DataSet1.sapakim2;


                    string s = shemsapak.Text;
                    bool bl = true;
                    string ss;



                    for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                    {
                        ss = mm.Rows[j]["sapak"].ToString();

                        if (s.Equals(ss))
                        {
                            bl = false;
                            blb2 = true;

                            DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה לעדכן?", "עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dr == DialogResult.Yes)
                            {

                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "Update sapakim2 SET tel='" + maskedTextBox1.Text + "' , ktovet='" + ktovetsapak.Text + "' , yeshuv='" + yeshuvsapak.Text + "' , mispar='" + missapak.Text + "' where sapak='" + shemsapak.Text + "' ";
                                cmd.Connection = con;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();



                                formsapakim_Load(sender, e);
                                MessageBox.Show("!שינויים בוצעו בהצלחה");
                                button5.Visible = false;
                                shemsapak2.Enabled = true;
                                maskedTextBox1.Enabled = true;
                                ktovetsapak.Enabled = true;
                               
                                yeshuvsapak.Enabled = true;
                                missapak.Enabled = true;


                                shemsapak.Enabled = true;

                            }


                            else
                            {
                                button5.Visible = false;
                                shemsapak2.Enabled = true;
                                maskedTextBox1.Enabled = true;
                                ktovetsapak.Enabled = true;
                                
                                yeshuvsapak.Enabled = true;
                                missapak.Enabled = true;
                                shemsapak2.Clear();
                                maskedTextBox1.Clear();
                                ktovetsapak.Clear();
                                
                                yeshuvsapak.Clear();
                                missapak.Clear();
                                shemsapak.Clear();

                                shemsapak.Enabled = true;

                            }
                        }

                        else
                            blb2 = false;

                    }

                    if (blb2 == false)
                        MessageBox.Show("הזן שם ספק קיים לעדכון");
                }

             shemsapak2.Visible = true;

        }

        private void btnsapma_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (shemsapak.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן שם ספק למחיקה");
            }

            if (blb == true)
            {
                mm = razan22DataSet1.sapakim2;


                string s = shemsapak.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["sapak"].ToString();

                    if (s.Equals(ss))
                    {
                        bl = false;
                        blb2 = true;
                        DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה למחוק?", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {

                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "Delete from sapakim2 where sapak = '" + shemsapak.Text + "' ";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();


                            formsapakim_Load(sender, e);
                            MessageBox.Show("!מחיקה בוצעה בהצלחה");
                        }
                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן שם ספק קיים למחיקה");
            }

            shemsapak2.Visible = true;
        }

        private void btnsapho_Click(object sender, EventArgs e)
        {
            
            bool bl2 = true;
            bool bl11 = true;
            string st2 = shemsapak.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן שם ספק ללא רווח");
                bl11 = false;
            }

            

            if (shemsapak.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (maskedTextBox1.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;


            if (ktovetsapak.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;



            if (yeshuvsapak.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (missapak.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else

                label5.Visible = false;



            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            bool bl3 = true;
            bool bl111 = true;
            bool bl100 = true;

            if (bl2 == true)
            {


                if (maskedTextBox1.Text.Length != 11)
                {
                    bl3 = false;
                    MessageBox.Show("הזן מספר פלאפון תקין");
                }

                
                string sv = maskedTextBox1.Text;
                if (sv[0] != '0' || sv[1] != '5')
                {
                    MessageBox.Show("מספר הפלאפון חייב להתחיל בקידומת 05");
                    bl100 = false;
                }

                
                string st22 = maskedTextBox1.Text;
                int xx = st22.IndexOf(' ');
                if (xx != -1)
                {
                    MessageBox.Show("הזן מספר פלאפון ללא רווח");
                    bl111 = false;
                }
            }
            if(bl11==true && bl100==true&& bl2==true && bl3==true && bl111==true)
            {

                mm = razan22DataSet1.sapakim2;


                string s = shemsapak.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["sapak"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("ספק זה קיים");
                        bl = false;
                        


                    }

                }




                if (bl == true)
                {


                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into sapakim2 (sapak,tel,ktovet,yeshuv,mispar) VALUES('" + shemsapak.Text + "' , '" + maskedTextBox1.Text + "' , '" + ktovetsapak.Text + "' , , '" + yeshuvsapak.Text + "' , '" + missapak.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formsapakim_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");
                        button6.Visible = true;
                        shemsapak2.Enabled = false;

                        maskedTextBox1.Enabled = false;
                        ktovetsapak.Enabled = false;
                       
                        yeshuvsapak.Enabled = false;
                        missapak.Enabled = false;

                        shemsapak.Enabled = false;
                       

                    }


                    if (dr == DialogResult.No)
                    {
                        button6.Visible = true;
                        shemsapak2.Enabled = false;

                        maskedTextBox1.Enabled = false;
                        ktovetsapak.Enabled = false;
                        
                        yeshuvsapak.Enabled = false;
                        missapak.Enabled = false;
                      
                        shemsapak.Enabled = false;
                    }

                }

                

            }
            shemsapak2.Visible = true;
        }

        private void lblS_Click(object sender, EventArgs e)
        {

        }

        private void formsapakim_Click(object sender, EventArgs e)
        {

        }

        private void shemsapak2_Click(object sender, EventArgs e)
        {
            shemsapak2.Visible = false;
            shemsapak.Focus();
        }

        private void shemsapak2_TextChanged(object sender, EventArgs e)
        {
            shemsapak.Text = shemsapak2.Text;

        }

        private void shemsapak2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void shemsapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ktovetsapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void yeshuvsapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void missapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sapakim2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sapakim2BindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sapakim2BindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sapakim2BindingSource.MoveNext();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            shemsapak2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ktovetsapak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            yeshuvsapak.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            missapak.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            shemsapak2.Enabled = true;
            maskedTextBox1.Enabled = true;
            ktovetsapak.Enabled = true;
            
            yeshuvsapak.Enabled = true;
            missapak.Enabled = true;
         
            
            shemsapak.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            shemsapak2.Enabled = true;
            shemsapak.Enabled = true;
            maskedTextBox1.Enabled = true;
            ktovetsapak.Enabled = true;
           
            yeshuvsapak.Enabled = true;
            missapak.Enabled = true;
           
            shemsapak.Enabled = true;
            shemsapak2.Clear();
            maskedTextBox1.Clear();
            ktovetsapak.Clear();
            
            yeshuvsapak.Clear();
            missapak.Clear();

        }

        private void hazmana_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 haz = new Form2();
            haz.Show();
        }

        private void missapak_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmailsapak_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
