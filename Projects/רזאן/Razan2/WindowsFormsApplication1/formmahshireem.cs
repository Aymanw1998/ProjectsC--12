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
    public partial class formmahshireem : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public formmahshireem()
        {
            InitializeComponent();
        }
        razan22DataSet1.mahshireem2DataTable mm;
        razan22DataSet1.mahshireem2DataTable mz;
        razan22DataSet1.sapakim2DataTable mw;


        private void formmahshireem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.sapakim2' table. You can move, or remove it, as needed.
            this.sapakim2TableAdapter.Fill(this.razan22DataSet1.sapakim2);
            // TODO: This line of code loads data into the 'razan22DataSet1.mahshireem2' table. You can move, or remove it, as needed.
            this.mahshireem2TableAdapter.Fill(this.razan22DataSet1.mahshireem2);
            sapak.Items.Clear();
            mw = razan22DataSet1.sapakim2;
            for (int i = 0; i < mw.Rows.Count; i++)
            {
                sapak.Items.Add(mw.Rows[i]["sapak"].ToString());
            }
            
            
           
            
        }

        private void btnbkab_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmahho_Click(object sender, EventArgs e)
        {
            bool bl3 = true;
            bool bl2 = true;
            bool bl11 = true;
            string st2 = maskedTextBox1.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן קוד מכשיר ללא רווח");
                bl11 = false;
            }


            bool bl13 = true;
            string st3 = mehir.Text;
            int y = st3.IndexOf(' ');
            if (y != -1)
            {
                MessageBox.Show("הזן מחיר מכשיר ללא רווח");
                bl13 = false;
            }


            if (codmahshir.Text == "")
            {
                bl2 = false;
                label1.Visible = true;

            }
            else
                label1.Visible = false;


            if (shemmahshir.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;

            if (sapak.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else
                label4.Visible = false;

            if (degem.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else
                label5.Visible = false;

            if (mehir.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;


            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            if (bl2 == true)
            {


                if (codmahshir.Text.Length != 3)
                {
                    bl3 = false;
                    MessageBox.Show("הזן קוד מכשיר בארוך 3 ספרות");
                }
            }
            
            if (bl2 == true && bl3 == true && bl11==true && bl13==true)
            {


                mm = razan22DataSet1.mahshireem2;


                string s = codmahshir.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["cod"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("מכשיר זה קיים");
                        bl = false;
                        

                    }

                }

                

                if (bl == true)
                {
                    
                        
                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    int r = Convert.ToInt32(sapak.SelectedIndex);
                    if (dr == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into mahshireem2(cod,shem,sapak,degem,mehir) VALUES('" + codmahshir.Text + "' , '" + shemmahshir.Text + "' , '" + sapak.Text + "' , '" + degem.Text + "' , '" + mehir.Text + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formmahshireem_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                        mw = razan22DataSet1.sapakim2;
                        if (Convert.ToInt32(r) > -1)
                        {
                            int ss24 = Convert.ToInt32(mw.Rows[r]["mispar"].ToString());
                            int ss244 = ss24 + 1;
                            OleDbCommand cmd2 = new OleDbCommand();
                            cmd2.CommandText = "Update sapakim2 SET mispar =  '" + ss244 + "'  where sapak='" + mw.Rows[r]["sapak"].ToString() + "' ";
                            cmd2.Connection = con;
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }

                        button5.Visible = true;
                        maskedTextBox1.Enabled = false;
                        codmahshir.Enabled = false;
                        shemmahshir.Enabled = false;
                        sapak.Enabled = false;
                        degem.Enabled = false;
                        mehir.Enabled = false;

                        
                    }


                    if (dr == DialogResult.No)
                    {
                        button5.Visible = true;
                        maskedTextBox1.Enabled = false;
                        
                        shemmahshir.Enabled = false;
                        sapak.Enabled = false;
                        degem.Enabled = false;
                        mehir.Enabled = false;
                       
                    }
             

                    
                    
                }
               
            }

            maskedTextBox1.Visible = true;
       
        }

        private void btnmahmh_Click(object sender, EventArgs e)
        {
            bool blb2 = true;
            bool blb = true;
            if (codmahshir.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן קוד מכשיר למחיקה");
            }

            if (blb == true)
            {

                mm = razan22DataSet1.mahshireem2;


                string s = codmahshir.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["cod"].ToString();

                    if (s.Equals(ss))
                    {
                        bl = false;
                        blb2 = true;

                        DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה למחוק?", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {


                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "Delete from mahshireem2 where cod = '" + codmahshir.Text + "' ";
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();



                            formmahshireem_Load(sender, e);
                            MessageBox.Show("!מחיקה בוצעה בהצלחה");
                        }
                    }

                    else
                        blb2 = false;
                }

                if (blb2 == false)
                    MessageBox.Show("הזן קוד מכשיר קיים למחיקה");
            }

            maskedTextBox1.Visible = true;
        }

        private void btnmahidk_Click(object sender, EventArgs e)
        {
            bool bl11 = true;
            string st2 = codmahshir.Text;
            int x = st2.IndexOf(' ');
            if (x != -1)
            {
                MessageBox.Show("הזן קוד מכשיר ללא רווח");
                bl11 = false;
            }


            bool bl13 = true;
            string st3 = mehir.Text;
            int y = st3.IndexOf(' ');
            if (y != -1)
            {
                MessageBox.Show("הזן מחיר מכשיר ללא רווח");
                bl13 = false;
            }

            bool bl2 = true;


            if (shemmahshir.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else
                label2.Visible = false;

            if (sapak.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else
                label4.Visible = false;

            if (degem.Text == "")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else
                label5.Visible = false;

            if (mehir.Text == "")
            {
                bl2 = false;
                label3.Visible = true;

            }
            else
                label3.Visible = false;


            if (bl2 == false)
            {
                MessageBox.Show("הזן ערך בשדה חובה");
            }

            bool bl3 = true;

            if (codmahshir.Text.Length != 3)
            {
                bl3 = false;
                MessageBox.Show("הזן קוד מכשיר בארוך 3 ספרות");
            }

            bool blb2 = true;
            bool blb = true;
            if (codmahshir.Text == "")
            {
                blb = false;
                MessageBox.Show("הזן קוד מכשיר לעדכון");
            }



            if (bl2 == true && bl3 == true && bl11==true && blb==true && bl13==true)
            {
                mm = razan22DataSet1.mahshireem2;


                string s = codmahshir.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["cod"].ToString();

                    if (s.Equals(ss))
                    {
                        bl = false;
                        blb2 = true;
               
                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה לעדכן?", "עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    int r = sapak.SelectedIndex;
                    if (dr == DialogResult.Yes)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update mahshireem2 SET shem = '" + shemmahshir.Text + "' , sapak = '" + sapak.Text + "' , degem = '" + degem.Text + "' , mehir = '" + mehir.Text + "' where cod = '" + codmahshir.Text + "'";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        formmahshireem_Load(sender, e);
                        MessageBox.Show("!שינויים בוצעו בהצלחה");


                        mw = razan22DataSet1.sapakim2;
                        if (Convert.ToInt32(r) > -1)
                        {
                            int ss24 = Convert.ToInt32(mw.Rows[r]["mispar"].ToString());
                            int ss244 = ss24 + 1;
                            OleDbCommand cmd2 = new OleDbCommand();
                            cmd2.CommandText = "Update sapakim2 SET mispar =  '" + ss244 + "'  where sapak='" + mw.Rows[r]["sapak"].ToString() + "' ";
                            cmd2.Connection = con;
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();
                        }

                        button6.Visible = true;
                        maskedTextBox1.Enabled = false;

                        shemmahshir.Enabled = false;
                        sapak.Enabled = false;
                        degem.Enabled = false;
                        mehir.Enabled = false;
               
                   }


                        if(dr==DialogResult.No)
                        {
                            button6.Visible = true;
                            maskedTextBox1.Enabled = false;

                            shemmahshir.Enabled = false;
                            sapak.Enabled = false;
                            degem.Enabled = false;
                            mehir.Enabled = false;
                            maskedTextBox1.Clear();
                            
                            shemmahshir.Clear();
                            sapak.Text = "";
                            degem.Clear();
                            mehir.Clear();
                        }



                    }

                    else
                        blb2 = false;

                }

                if (blb2 == false)
                    MessageBox.Show("הזן קוד מכשיר קיים לעדכון");
            }

            maskedTextBox1.Visible = true;
           

        }

        private void tbmachines_TextChanged(object sender, EventArgs e)
        {
            if (tbmachines.Text.Length == 0)
            {
                formmahshireem_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.mahshireem2;
            }
            else
            {

                mz = razan22DataSet1.mahshireem2;
                DataTable dz = new DataTable();
                dz.Columns.Add("cod");
                dz.Columns.Add("shem");
                dz.Columns.Add("sapak");
                dz.Columns.Add("degem");
                dz.Columns.Add("mehir");

                for (int j = 0; j < mz.Rows.Count; j++)
                {
                    for (int k = 0; k < mz.Columns.Count; k++)
                    {
                        if (mz.Rows[j][k].ToString().Contains(tbmachines.Text))
                        {
                            dz.Rows.Add(mz[j][0], mz[j][1], mz[j][2], mz[j][3], mz[j][4]);

                            k = mz.Columns.Count;



                        }

                    }


                }

                dataGridView1.DataSource = dz;

            }
            
        
        }

        private void codmahshir_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            codmahshir.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            codmahshir.Text = maskedTextBox1.Text;

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין קוד מכשיר עם רווחים");
            }
        }

        private void shemmahshir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sapak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void codmahshir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין קוד מכשיר עם רווחים");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mahshireem2BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mahshireem2BindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mahshireem2BindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mahshireem2BindingSource.MovePrevious();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            shemmahshir.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sapak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            degem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mehir.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
       
        }

        private void mehir_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mehir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("לא ניתן להזין מחיר מכשיר עם רווחים");
            }
        }

        private void lblmah_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            maskedTextBox1.Enabled = true;
            codmahshir.Enabled = true;
            shemmahshir.Enabled = true;
            sapak.Enabled = true;
            degem.Enabled = true;
            mehir.Enabled = true;
            maskedTextBox1.Clear();
            codmahshir.Clear();
            shemmahshir.Clear();
            sapak.Text = "";
            degem.Clear();
            mehir.Clear();
       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            maskedTextBox1.Enabled = true;
            shemmahshir.Enabled = true;
            sapak.Enabled = true;
            degem.Enabled = true;
            mehir.Enabled = true;
            codmahshir.Enabled = true;

        }


    }
}





   
    

