using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Restaurant_Management_App.Reports
{
    public partial class frmRP : Form
    {
        public frmRP()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string qry = @" select *
                            from Orders o, Product p, Details d, Category c
                            where o.mainID = d.mainID and d.productID = p.productID and p.catID = c.CatID";
            MainClass_.conn.Open();
            SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            MainClass_.conn.Close();
            frmPrint frm = new frmPrint();
            finalReport cr = new finalReport();
            string filterFormula = "DateValue({Report;1.orderDate}) >= #" + ngaybd.Value.Month.ToString() + "/" + ngaybd.Value.Day.ToString() + "/" + ngaybd.Value.Year.ToString() + "#" + " and DateValue({Report;1.orderDate}) <= #" + ngaykt.Value.Month.ToString() + "/" + ngaykt.Value.Day.ToString() + "/" + ngaykt.Value.Year.ToString() + "#";
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.SelectionFormula = filterFormula;
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
