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
namespace DarQuran
{
    public partial class BetKasef : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        DataTable dt = new DataTable();
        DataTable dtd = new DataTable();
        DarQuranDataSet.BetHKisifDataTable mo;
        public BetKasef()
        {
            InitializeComponent();
            OleDbDataAdapter d = new OleDbDataAdapter("Select * From Daymonth", con);
            d.Fill(dt);           
            OleDbCommand cmdUpdate = new OleDbCommand();
             string month= DateTime.Now.Month.ToString();
            if(dt.Rows[0][0].ToString()=="")
            {
                
               
                cmdUpdate.CommandText = "UPDATE Daymonth SET monthD='"+month+"' ";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();
                con.Close();
                this.daymonthTableAdapter.Fill(this.darQuranDataSet.Daymonth);
                daymonthTableAdapter.Update(darQuranDataSet.Daymonth);
                cmdUpdate.CommandText = "UPDATE BetHKisif SET  [tshlom yesh] = '" + 0 + "', [tashlomnotar]='" + 100 + "'";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();

                con.Close();

                this.betHKisifTableAdapter.Fill(this.darQuranDataSet.BetHKisif);
                betHKisifTableAdapter.Update(darQuranDataSet.BetHKisif);
                dataGridView1.Refresh();
            }
            else if (dt.Rows[0][0].ToString()!=month)
            {
                string ss = dt.Rows[0][0].ToString();
                cmdUpdate.CommandText = "UPDATE Daymonth SET monthD='" + month + "' ";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();
                con.Close();
                this.daymonthTableAdapter.Fill(this.darQuranDataSet.Daymonth);
                daymonthTableAdapter.Update(darQuranDataSet.Daymonth);
                OleDbDataAdapter da = new OleDbDataAdapter("Select tashlomnotar From BetHKisif", con);
                da.Fill(dt);
                int x = int.Parse(dt.Rows[0][0].ToString());
                int y = Convert.ToInt16(x) - Convert.ToInt16(ss);
                int xy = x * y;
                cmdUpdate.CommandText = "UPDATE BetHKisif SET  [tashlomnotar]='" + xy+100 + "'";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();
                con.Close();
                this.betHKisifTableAdapter.Fill(this.darQuranDataSet.BetHKisif);
                betHKisifTableAdapter.Update(darQuranDataSet.BetHKisif);
                dataGridView1.Refresh();
            }
           
        }

        private void BetKasef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet1.Daymonth' table. You can move, or remove it, as needed.
            this.daymonthTableAdapter.Fill(this.darQuranDataSet.Daymonth);
            // TODO: This line of code loads data into the 'darQuranDataSet1.BetHKisif' table. You can move, or remove it, as needed.
            this.betHKisifTableAdapter.Fill(this.darQuranDataSet.BetHKisif);
            mo = this.darQuranDataSet.BetHKisif;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            NT.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            FN.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            panel1.Visible = true;
        }

        private void math_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdUpdate = new OleDbCommand();
            if(money.Text!="")
            {
               // if()
                int x=int.Parse(money.Text);
                MessageBox.Show(x.ToString());
                int y=int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString());
                MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString());
                int yy=int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());
                MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString());
                //OleDbDataAdapter d = new OleDbDataAdapter("UPDATE BetHKisif SET  [tshlom yesh] = '" + (x + y).ToString() + "', [tashlomnotar]='" +(yy - x).ToString() + "'", con);
                cmdUpdate.CommandText = "UPDATE BetHKisif SET  [tshlom yesh] = '" + (x + y).ToString() + "', [tashlomnotar]='" +(yy - x).ToString() + "'";
                cmdUpdate.Connection = con;
                con.Open();
                cmdUpdate.ExecuteNonQuery();

                con.Close();

                this.betHKisifTableAdapter.Fill(this.darQuranDataSet.BetHKisif);
                betHKisifTableAdapter.Update(darQuranDataSet.BetHKisif);
                dataGridView1.Refresh();
                
            }
            else
            {
                MessageBox.Show("ادخال المبلغ");
                money.Focus();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Visible = true;
            DataTable dz = new DataTable();
            dz.Columns.Add("رقم الهوية");
            dz.Columns.Add("الاسم الشخصي");
            dz.Columns.Add("اسم العائلة");
            dz.Columns.Add("المبلغ المدفوع");
            dz.Columns.Add("تاريخ المتبقي للدفع");


            for (int j = 0; j < mo.Rows.Count; j++)
            {
                for (int k = 0; k < mo.Columns.Count; k++)
                {
                    if (mo.Rows[j][k].ToString().Contains(textBoxSearch.Text))
                    {

                        dz.Rows.Add(mo[j][0], mo[j][1], mo[j][2], mo[j][3], mo[j][4]);
                        k = mo.Columns.Count;

                    }
                }
            }

            dataGridViewSearch.DataSource = dz;
            if (textBoxSearch.Text == "")
                dataGridViewSearch.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
