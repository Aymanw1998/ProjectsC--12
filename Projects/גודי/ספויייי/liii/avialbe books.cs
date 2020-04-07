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
    public partial class avialbe_books : Form
    {
        public avialbe_books()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\li.mdb");
        liDataSet.booksDataTable kr;


        private void avialbe_books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.liDataSet.books);
            kr = liDataSet.books;
            DataTable dd = new DataTable();
            dd.Columns.Add("code");
            dd.Columns.Add("name");
            dd.Columns.Add("writername");
            dd.Columns.Add("year");
            dd.Columns.Add("language");
            dd.Columns.Add("amount");
            dd.Columns.Add("type");
            dd.Columns.Add("age");
            dd.Columns.Add("msomn");
            dd.Columns.Add("raw");
            dd.Columns.Add("company");
            for (int j = 0; j < kr.Rows.Count; j++)
            {
                for (int k = 0; k < kr.Columns.Count; k++)
                {
                    if (kr.Rows[j]["amount"].ToString()!="0")
                    {
                        
                        dd.Rows.Add(kr[j][0], kr[j][1], kr[j][2], kr[j][3], kr[j][4], kr[j][5], kr[j][6], kr[j][7], kr[j][8], kr[j][9], kr[j][10]);
                        k = kr.Columns.Count;
                    }
                }

            }
            dataGridView1.DataSource = dd;

           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void avialbe_books_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
