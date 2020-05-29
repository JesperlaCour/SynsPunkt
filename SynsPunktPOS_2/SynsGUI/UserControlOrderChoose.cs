using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SynsBLL;
using SynsEntity;

namespace SynsGUI
{
    public partial class UserControlOrderChoose : UserControl
    {
        //Author: Jesper

        public UserControlPOS UC_Order1 { get; set; }

        OrderController order = new OrderController();
        public UserControlOrderChoose()
        {
            
            InitializeComponent();
        }

        private void btn_showAllCust_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.GetAllOrders("");
        }

        private void btn_OrderSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.GetAllOrders(txt_custName.ToString());
        }

        private void btn_OrderChoose_Click(object sender, EventArgs e)
        {
            int orderID;
            int customerID;

            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                orderID = Convert.ToInt32(selectedRow.Cells["OrdreID"].Value);
                customerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
                CustController cust = new CustController();
                UC_Order1.ShowCustInfo(cust.GetCustomer(customerID));
                UC_Order1.txt_orderID.Text = orderID.ToString();

                UC_Order1.dataGridView1.DataSource = order.GetAllProductLines(orderID);
                this.Controls.Clear();
                this.InitializeComponent();
                UC_Order1.BringToFront();
                UC_Order1.cbb_discount.Text = "0";
                double pris = order.TotalPrice(Convert.ToDouble(UC_Order1.cbb_discount.Text), Convert.ToInt32(orderID));
                UC_Order1.lbl_pris.Text = $"{pris:C}";

            }
            else
                MessageBox.Show("Ingen ordre valgt");
            
            
        }

    }
}
