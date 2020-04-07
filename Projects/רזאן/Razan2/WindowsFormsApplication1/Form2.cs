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
    public partial class Form2 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");

        public Form2()
        {
            InitializeComponent();
        }

        razan22DataSet1.orderDataTable mm;
        
        razan22DataSet1.mahshireem2DataTable mw;
        razan22DataSet1.sapakim2DataTable mn;
        

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.sapakim2' table. You can move, or remove it, as needed.
            this.sapakim2TableAdapter.Fill(this.razan22DataSet1.sapakim2);
            // TODO: This line of code loads data into the 'razan22DataSet1.mahshireem2' table. You can move, or remove it, as needed.
            this.mahshireem2TableAdapter.Fill(this.razan22DataSet1.mahshireem2);
            // TODO: This line of code loads data into the 'razan22DataSet1.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.razan22DataSet1.order);

            motsar2.Items.Clear();
            mw = razan22DataSet1.mahshireem2;
            for (int i = 0; i < mw.Rows.Count; i++)
            {
                motsar2.Items.Add(mw.Rows[i]["cod"].ToString());
            }
            comboBox1.Items.Clear();
            mn = razan22DataSet1.sapakim2;
            for (int i = 0; i < mn.Rows.Count; i++)
            {
                comboBox1.Items.Add(mn.Rows[i]["sapak"].ToString());
            }


            DateTime date3 = DateTime.Today;
            DateTime date4 = date3.AddDays(7);

            mm = razan22DataSet1.order;
           

            for (int i = 0; i < mm.Rows.Count; i++)
            {

                DateTime date2 = Convert.ToDateTime(mm.Rows[i]["tarikh"].ToString());

                int result = DateTime.Compare(date4, date2);

                if (result < 0 )
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }


            }

        }

        private void tbhugeem_TextChanged(object sender, EventArgs e)
        {
            if (tbhugeem.Text.Length == 0)
            {
                Form2_Load(sender, e);
                dataGridView1.DataSource = razan22DataSet1.sapakim2;
            }

            else
            {

                mm = razan22DataSet1.order;
                DataTable dz = new DataTable();
                dz.Columns.Add("mispar");
                dz.Columns.Add("sapak");
                dz.Columns.Add("telsapak");
                dz.Columns.Add("kamot");
                dz.Columns.Add("motsar");
                dz.Columns.Add("mehir");
                dz.Columns.Add("tarikh");



                for (int j = 0; j < mm.Rows.Count; j++)
                {
                    for (int k = 0; k < mm.Columns.Count; k++)
                    {
                        if (mm.Rows[j][k].ToString().Contains(tbhugeem.Text))
                        {
                            dz.Rows.Add(mm[j][0], mm[j][1], mm[j][2], mm[j][3], mm[j][4], mm[j][5], mm[j][6]);

                            k = mm.Columns.Count;

                        }

                    }


                }

                dataGridView1.DataSource = dz;
            }
        }

        private void tel2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kamot2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motsar2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tarikh2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hazmana2_TextChanged(object sender, EventArgs e)
        {
            shemhug.Text = hazmana2.Text;
        }

        private void tarikh_Click(object sender, EventArgs e)
        {

        }

        private void mehir_Click(object sender, EventArgs e)
        {

        }

        private void motsar_Click(object sender, EventArgs e)
        {

        }

        private void kamot_Click(object sender, EventArgs e)
        {

        }

        private void tel_Click(object sender, EventArgs e)
        {

        }

        private void sapak_Click(object sender, EventArgs e)
        {

        }

        private void hazmana_Click(object sender, EventArgs e)
        {

        }

        private void mehir2_TextChanged(object sender, EventArgs e)
        {

        }

        private void shemhug_TextChanged(object sender, EventArgs e)
        {

        }

        private void sapak2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblshugeem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.MoveFirst();

        }

        private void bcsapak_Click(object sender, EventArgs e)
        {
            this.Close();
            formmenahel menback1 = new formmenahel();
            menback1.Show();
        }

        private void btnbksu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            hazmana2.Enabled = true;
            shemhug.Enabled = true;
            comboBox1.Enabled = true;
          
            kamot2.Enabled = true;
            motsar2.Enabled = true;
            mehir2.Enabled = true;
            tarikh2.Enabled = true;
            hazmana2.Clear();
            comboBox1.Text = "";
           
            kamot2.Clear();
            motsar2.Text = "";
            mehir2.Clear();
            tarikh2.Clear();
 
        
        }

        private void btnhugho_Click(object sender, EventArgs e)
        {

            bool bl2 = true;
            bool bl11 = true;
       


            if (comboBox1.Text=="")
            {
                bl2 = false;
                label5.Visible = true;

            }
            else
                label5.Visible = false;


            if (kamot2.Text == "")
            {
                bl2 = false;
                label2.Visible = true;

            }
            else

                label2.Visible = false;

            if (motsar2.Text == "")
            {
                bl2 = false;
                label4.Visible = true;

            }
            else

                label4.Visible = false;

            if (mehir2.Text == "")
            {
                bl2 = false;
                label6.Visible = true;

            }
            else

                label6.Visible = false;

            if (tarikh2.Text == "")
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
            bool bl20 = true;
            if (bl2 == true)
            {



                DateTime d1 = DateTime.Today;
                DateTime d2 = Convert.ToDateTime(tarikh2.Text);
               
                int result = DateTime.Compare(d1, d2);
                if (result != 0)
                {
                    MessageBox.Show("הזן תאריך היום");
                    bl20 = false;
                }
            }
            if (bl11 == true &&  bl2 == true && bl20==true)
            {

                mm = razan22DataSet1.order;


                string s = shemhug.Text;
                bool bl = true;
                string ss;



                for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                {
                    ss = mm.Rows[j]["mispar"].ToString();

                    if (s.Equals(ss))
                    {

                        MessageBox.Show("הזמנה זו קיימת ");
                        bl = false;

                    }

                }



                if (bl == true)
                {
                    
                    DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה להוסיף?", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        int r = dataGridView1.RowCount;
                        

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "INSERT into [order](mispar,sapak,kamot,motsar,mehir,tarikh) VALUES('"+Convert.ToString(r)+"','"+comboBox1.Text+"','"+kamot2.Text+"','"+motsar2.Text+"','"+mehir2.Text+"','"+tarikh2.Text+"')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Form2_Load(sender, e);
                        MessageBox.Show("!הוספה בוצעה בהצלחה");

                      
                        button7.Visible = true;
                        hazmana2.Enabled = true;

                        comboBox1.Enabled = true;
                        
                        kamot2.Enabled = true;
                        motsar2.Enabled = true;
                        mehir2.Enabled = true;
                        tarikh2.Enabled = true;


                    }


                    if (dr == DialogResult.No)
                    {
                        button7.Visible = true;
                        hazmana2.Enabled = true;
                        shemhug.Enabled = true;
                        comboBox1.Enabled = true;
                        
                        kamot2.Enabled = true;
                        motsar2.Enabled = true;
                        mehir2.Enabled = true;
                        tarikh2.Enabled = true;
                        hazmana2.Clear();
                        comboBox1.Text = "";
                        shemhug.Clear();
                        kamot2.Clear();
                        motsar2.Text = "";
                        mehir2.Clear();
                        tarikh2.Clear();
                    }

                }



            }

            hazmana2.Visible = true;
        }

        private void btnhugidk_Click(object sender, EventArgs e)
        {
             DateTime date3 = DateTime.Today;
             DateTime date4 = date3.AddDays(7);
             DateTime date2=Convert.ToDateTime(tarikh2.Text);
                

                int result = DateTime.Compare(date4, date2);
                if (result > 0)
                {

                    bool bl2 = true;
                    bool bl11 = true;
                    string st2 = shemhug.Text;
                    int x = st2.IndexOf(' ');
                    if (x != -1)
                    {
                        MessageBox.Show("הזן מספר הזמנה ללא רווח");
                        bl11 = false;
                    }



                    if (shemhug.Text == "")
                    {
                        bl2 = false;
                        label1.Visible = true;

                    }
                    else
                        label1.Visible = false;


                    if (comboBox1.Text == "")
                    {
                        bl2 = false;
                        label5.Visible = true;

                    }
                    else
                        label5.Visible = false;





                    if (kamot2.Text == "")
                    {
                        bl2 = false;
                        label2.Visible = true;

                    }
                    else

                        label2.Visible = false;

                    if (motsar2.Text == "")
                    {
                        bl2 = false;
                        label4.Visible = true;

                    }
                    else

                        label4.Visible = false;

                    if (mehir2.Text == "")
                    {
                        bl2 = false;
                        label6.Visible = true;

                    }
                    else

                        label6.Visible = false;

                    if (tarikh2.Text == "")
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


                    bool blb2 = true;
                    bool blb = true;
                    if (shemhug.Text == "")
                    {
                        blb = false;
                        MessageBox.Show("הזן מספר הזמנה לעדכון");
                    }


                    if (bl11 == true && bl2 == true && blb == true)
                    {

                        mm = razan22DataSet1.order;


                        string s = shemhug.Text;
                        bool bl = true;
                        string ss;


                        for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                        {
                            ss = mm.Rows[j]["mispar"].ToString();

                            if (s.Equals(ss))
                            {
                                bl = false;
                                blb2 = true;

                                DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה לעדכן?", "עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (dr == DialogResult.Yes)
                                {



                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.CommandText = "Update [order] SET  sapak='" + comboBox1.Text + "'  , kamot='" + kamot2.Text + "' , motsar='" + motsar2.Text + "',mehir='" + mehir2.Text + "' , tarikh='" + tarikh2.Text + "' where mispar='" + shemhug.Text + "' ";
                                    cmd.Connection = con;
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();



                                    Form2_Load(sender, e);
                                    MessageBox.Show("!שינויים בוצעו בהצלחה");

                                    button5.Visible = true;
                                    hazmana2.Enabled = false;

                                    comboBox1.Enabled = false;


                                    kamot2.Enabled = false;
                                    motsar2.Enabled = false;
                                    mehir2.Enabled = false;
                                    tarikh2.Enabled = false;
                                }

                                else
                                {
                                    button5.Visible = true;
                                    hazmana2.Enabled = false;

                                    comboBox1.Enabled = false;


                                    kamot2.Enabled = false;
                                    motsar2.Enabled = false;
                                    mehir2.Enabled = false;
                                    tarikh2.Enabled = false;
                                    hazmana2.Clear();
                                    comboBox1.Text = "";

                                    shemhug.Clear();
                                    kamot2.Clear();
                                    motsar2.Text = "";
                                    mehir2.Clear();
                                    tarikh2.Clear();

                                }
                            }

                            else
                                blb2 = false;

                        }

                        if (blb2 == false)
                            MessageBox.Show("הזן מספר הזמנה קיימת לעדכון");
                    }

                    hazmana2.Visible = true;
                }
                else
                {
                    MessageBox.Show("לא ניתן לעדכן פרטי הזמנה שכבר סופקה");
                }


        }

        private void btnhugmh_Click(object sender, EventArgs e)
        {
            DateTime date3 = DateTime.Today;
             DateTime date4 = date3.AddDays(7);
             DateTime date2=Convert.ToDateTime(tarikh2.Text);
                

                int result = DateTime.Compare(date4, date2);
                if (result > 0)
                {

                    bool blb2 = true;
                    bool blb = true;
                    if (shemhug.Text == "")
                    {
                        blb = false;
                        MessageBox.Show("הזן מספר הזמנה למחיקה");
                    }

                    if (blb == true)
                    {
                        mm = razan22DataSet1.order;


                        string s = shemhug.Text;
                        bool bl = true;
                        string ss;



                        for (int j = 0; (j < mm.Rows.Count) && bl; j++)
                        {
                            ss = mm.Rows[j]["mispar"].ToString();

                            if (s.Equals(ss))
                            {
                                bl = false;
                                blb2 = true;
                                DialogResult dr = MessageBox.Show("האם אתה בטוח שאתה רוצה למחוק?", "מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (dr == DialogResult.Yes)
                                {

                                    OleDbCommand cmd = new OleDbCommand();
                                    cmd.CommandText = "Delete from [order] where mispar = '" + shemhug.Text + "' ";
                                    cmd.Connection = con;
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();


                                    Form2_Load(sender, e);
                                    MessageBox.Show("!מחיקה בוצעה בהצלחה");
                                }
                            }

                            else
                                blb2 = false;

                        }

                        if (blb2 == false)
                            MessageBox.Show("הזן מספר הזמנה קיימת למחיקה");
                    }

                    hazmana2.Visible = true;
                }
                else
                {
                    MessageBox.Show("לא ניתן למחוק הזמנה שכבר סופקה");
                }
        }

        private void hazmana2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tarikh2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarikh2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void mehir2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void kamot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            hazmana2.Enabled = true;
            comboBox1.Enabled = true;
            shemhug.Enabled = true;
            kamot2.Enabled = true;
            motsar2.Enabled = true;
            mehir2.Enabled = true;
            tarikh2.Enabled = false;

        }

        private void sapak2_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void motsar2_TextChanged(object sender, EventArgs e)
        {
            mw = razan22DataSet1.mahshireem2;
            if (kamot2.Text != "" && motsar2.Text != "" && Convert.ToInt32( motsar2.SelectedIndex)>-1)
            {
                int ss24 = Convert.ToInt32(mw.Rows[motsar2.SelectedIndex]["mehir"].ToString());
                int ss244 = Convert.ToInt32(kamot2.Text);
                int ss245 = ss24 * ss244;
                string snew = Convert.ToString(ss245);
                mehir2.Text = snew;
            }
        }

        private void hazmana2_Click(object sender, EventArgs e)
        {
            hazmana2.Visible = false;
            shemhug.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hazmana2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kamot2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            motsar2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mehir2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tarikh2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }


    }
}
