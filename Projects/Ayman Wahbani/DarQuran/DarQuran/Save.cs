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
    public partial class Save : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\משתמש\Desktop\Projects\Ayman Wahbani\DarQuran\DarQuran.mdb");
        string id, fname, lname, time, date, role;
        DataTable dt = new DataTable();
        public Save(string tz, string f, string l, string t, string d, string r)
        {
            InitializeComponent();
            id = tz; fname = f; lname = l; time = t; date = d; role = r;
        }

        private void Save_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darQuranDataSet1.SaveTimeAndDate' table. You can move, or remove it, as needed.
            this.saveTimeAndDateTableAdapter1.Fill(this.darQuranDataSet1.SaveTimeAndDate);
            if (role != "مدير")
            {
                OleDbDataAdapter d = new OleDbDataAdapter("INSERT INTO `SaveTimeAndDate` (`Date`, `Time`, `ID`, `Fname`, `Lname`) VALUES ('" + date + "','" + time + "' ,'" + id + "' ,'" + fname + "' ,'" + lname + "' )", con);
                d.Fill(dt);
            }
        }
    }
}
