using Guna.UI.WinForms;
using Restaurant_Management_App.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public string billType= "", billStatus = "";
        public int mainID = 0;

        public string cusPhone = "";
        public string cusName = "";
        public string driverName = "";
        public string tableName = "";
        public string waiterName = "";
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string today =DateTime.Now.ToShortDateString();
            string qry = "Set dateformat dmy;" +
                "Select mainID,tableName,waiterName,orderType,orderStatus,total from Orders where orderDate = '"+today+"'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvwaiter);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvstatus);
            lb.Items.Add(dgvtotal);
            MainClass_.loadData(qry, gunaDataGridView1, lb);    
        }
        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.Rows.Count > 0)
            {
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    if(gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Chưa hoàn thành")
                    {
                        gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Selected = false;
                        gunaDataGridView1.ClearSelection();
                        MessageBox.Show("Đơn này đang được chế biến");
                    }
                    else if (gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Đã thanh toán")
                    {
                        gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Selected = false;
                        gunaDataGridView1.ClearSelection();
                        MessageBox.Show("Đơn đã được thanh toán");
                    }
                    else if(gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Đang chờ")
                    {
                        mainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                        string qry = "";
                        MainClass_.conn.Open();
                        if (gunaDataGridView1.CurrentRow.Cells["dgvtype"].Value.ToString() == "Ăn tại bàn")
                        {
                            qry= @"SELECT Orders.waiterName, Orders.tableName " +
                           "FROM Orders " +
                           "WHERE Orders.mainID = @mainID";
                            using (SqlCommand cmd = new SqlCommand(qry, MainClass_.conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@mainID", mainID);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        waiterName = reader["waiterName"].ToString();
                                        tableName = reader["tableName"].ToString();
                                    }
                                }
                            }
                        }
                        else if (gunaDataGridView1.CurrentRow.Cells["dgvtype"].Value.ToString() == "Mang đi")
                        {
                            qry = @"SELECT Orders.cusName, Orders.cusPhone " +
                           "FROM Orders " +
                           "WHERE Orders.mainID = @mainID";
                            using (SqlCommand cmd = new SqlCommand(qry, MainClass_.conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@mainID", mainID);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        cusName = reader["cusName"].ToString();
                                        cusPhone = reader["cusPhone"].ToString();
                                    }
                                }
                            }
                        }
                        else
                        {
                            qry = @"SELECT Orders.cusName, Orders.cusPhone, Staff.staffName " +
                           "FROM Orders " +
                           "JOIN Staff ON Staff.staffID = Orders.driverID " +
                           "WHERE Orders.mainID = @mainID";
                            using (SqlCommand cmd = new SqlCommand(qry, MainClass_.conn))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@mainID", mainID);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        cusName = reader["cusName"].ToString();
                                        cusPhone = reader["cusPhone"].ToString();
                                        driverName = reader["staffName"].ToString();
                                    }
                                }
                            }
                        }
                       

                        

                        MainClass_.conn.Close();
                        billType = gunaDataGridView1.CurrentRow.Cells["dgvtype"].Value.ToString();
                        billStatus = gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        mainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                        billType = gunaDataGridView1.CurrentRow.Cells["dgvtype"].Value.ToString();
                        billStatus = gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString();
                        this.Close();
                    }

                   
                }
                if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    if (gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Chưa hoàn thành"|| gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Đang chờ"|| gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Value.ToString() == "Đã hoàn thành")
                    {
                        gunaDataGridView1.CurrentRow.Cells["dgvstatus"].Selected = false;
                        gunaDataGridView1.ClearSelection();
                        MessageBox.Show("Vui lòng thanh toán trước khi in hóa đơn");
                    }
                    else
                    {
                        mainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                        string qry = @"Select * from Orders join Details on Orders.mainID=Details.mainID join Product on Product.productID=Details.productID where Orders.mainID= " + mainID + "";
                        SqlCommand cmd = new SqlCommand(qry, MainClass_.conn);
                        MainClass_.conn.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        MainClass_.conn.Close();
                        frmPrint frm = new frmPrint();
                        Receipt cr = new Receipt();
                        cr.SetDataSource(dt);
                        frm.crystalReportViewer1.ReportSource = cr;
                        frm.crystalReportViewer1.Refresh();
                        frm.Show();
                    } 
                }
            }
        }


    }
}
