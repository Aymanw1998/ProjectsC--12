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
    public partial class manui : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\razan\Desktop\Razan2\razan22.mdb");
        public manui()
        {
            InitializeComponent();
        }

        razan22DataSet1.hugeem2DataTable mn;
        razan22DataSet1.mitamneem2DataTable ms;
        private void manui_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razan22DataSet1.mitamneem2' table. You can move, or remove it, as needed.
            this.mitamneem2TableAdapter.Fill(this.razan22DataSet1.mitamneem2);
            int count2 = 0;
            DateTime date1 = DateTime.Today;
            mn = razan22DataSet1.hugeem2;
            ms = razan22DataSet1.mitamneem2;
            for (int i = 0; i < ms.Rows.Count; i++)
            {

                DateTime date2 = Convert.ToDateTime(ms.Rows[i]["tokef"].ToString());

                int result = DateTime.Compare(date1, date2);

                if (result<0)
                {
                    count2++;
                    this.dataGridView1.CurrentCell = null;
                    this.dataGridView1.Rows[i].Visible = false; 
                }
               

            }

            if (count2 == ms.Rows.Count)
            {
                button3.Visible = true;
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            string s1 = maskedTextBox2.Text;
            string s2 = s1.Substring(6);
            int s3 = Convert.ToInt32(s2);
            int s4 = s3 + 1;
            string s5 = Convert.ToString(s4);
            string s6 = s1.Substring(0, 6);
            string snew = s6 + s5;

            OleDbCommand cmd3 = new OleDbCommand();
            cmd3.CommandText = "Update mitamneem2 SET tokef = '" + snew + "' where tz = '" + maskedTextBox1.Text + "'";
            cmd3.Connection = con;
            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();

            manui_Load(sender, e);

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.CommandText = "Delete from mitamneem2 where tz = '" + maskedTextBox1.Text + "' ";
            cmd2.Connection = con;
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

            manui_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formtrainees frmtra = new formtrainees();
            frmtra.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tz_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tz_MaskChanged(object sender, EventArgs e)
        {
             
        }

        private void tz_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tz_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool bl = true;
            ms = razan22DataSet1.mitamneem2;
            for (int i = 0; i < ms.Rows.Count&&bl; i++)
            {
                if (tz.Text != ms.Rows[i]["tz"].ToString())
                {
                    bl = true;

                }
                else
                    bl = false;
            }

            if(bl==true)
            button3.Visible = true;

        }
    }
}
