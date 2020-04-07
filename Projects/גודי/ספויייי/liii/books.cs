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

namespace liii
{
    public partial class books : Form
    {
        public static string pass; 
        public books()

        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.booksDataTable kr;


        private void books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);
        

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass = textBox2.Text;
            borrowing fm7 = new borrowing();
            fm7.Show();
            pass = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            kr = liDataSet.books;
            DataTable dz = new DataTable();
            dz.Columns.Add("code");
            dz.Columns.Add("name");
            dz.Columns.Add("writername");
            dz.Columns.Add("year");
            dz.Columns.Add("language");
            dz.Columns.Add("amount");
            dz.Columns.Add("type");
            dz.Columns.Add("age");
            dz.Columns.Add("msomn");
            dz.Columns.Add("raw");
            dz.Columns.Add("company");
            dz.Columns.Add("otakim");

            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    if (kr.Rows[j][k].ToString().Contains(textBox12.Text))
                    {
                        dz.Rows.Add(kr[j][0], kr[j][1], kr[j][2], kr[j][3], kr[j][4], kr[j][5], kr[j][6], kr[j][7], kr[j][8], kr[j][9], kr[j][10],kr[j][11]);
                        k = kr.Columns.Count;
                    }
                }

            }

            dataGridView1.DataSource = dz;
        }
         

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            textBox8.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            textBox9.Text = dataGridView1[8, e.RowIndex].Value.ToString();
            textBox10.Text = dataGridView1[9, e.RowIndex].Value.ToString();
            textBox11.Text = dataGridView1[10, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                textBox8.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                textBox9.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                textBox10.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                textBox11.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                textBox13.Text = dataGridView1[11, e.RowIndex].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void books_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = false;
        }
    }
}
