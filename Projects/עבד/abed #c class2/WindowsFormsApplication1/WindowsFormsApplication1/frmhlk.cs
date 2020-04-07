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
    public partial class frmhlk : Form
    {
        public frmhlk()
        {
            InitializeComponent();
           
        }
        abedDataSet.hazmnt_lakDataTable mlk;
        abedDataSet.sokhanimDataTable sk;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data SourceD:\abed #c class2\WindowsFormsApplication1");
        
        private void frmhlk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abedDataSet.sokhanim' table. You can move, or remove it, as needed.
            this.sokhanimTableAdapter.Fill(this.abedDataSet.sokhanim);
            // TODO: This line of code loads data into the 'abedDataSet.hazmnt_lak' table. You can move, or remove it, as needed.
            this.hazmnt_lakTableAdapter.Fill(this.abedDataSet.hazmnt_lak);
            sk = abedDataSet.sokhanim;
            for (int i = 0; i < sk.Rows.Count; i++)
            {
                comboBox1.Items.Add(sk.Rows[i]["shem sokhen"].ToString());
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // DataTable dz = new DataTable();
            //dz.Columns.Add("mispar heshbonit");
            //dz.Columns.Add("code");
            //dz.Columns.Add("shem mot");
            //dz.Columns.Add("cama nmchar");
            //dz.Columns.Add("mikom");
            //dz.Columns.Add("cmot");
            //dz.Columns.Add("shem sokhen");
            //dz.Rows.Add("'+textBox2.text+'", "' +textBox4.text+'" , "'+textBox5.text+'", "'+textBox7.text+'","' +textBox8.text+'", "'+textBox9.text+'");

            dataGridView2.Rows.Add(textBox4.Text, "aaa");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mlk = abedDataSet.hazmnt_lak;
            DialogResult dr = MessageBox.Show("האם רוצה להוסיף", "הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //for (int j = 0; j < dataGridView2.Rows.Count; j++)
            //{

                 //mlk.Addhazmnt_lakRow(;

                hazmnt_lakTableAdapter.Update(mlk);
  
                //OleDbCommand cmd = new OleDbCommand();
                //cmd.CommandText = "INSERT Into hazmnt_lak ([mispar heshbonit],code,[shem mot],[cama nmchar],[mikom],cmot,[shem sokhen]) Values('" dz[j] "','" + textBox9.Text + "','" + ms2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                //cmd.Connection = con;
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //frmhlk_Load(sender, e);
            //}

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
           
    }
}
