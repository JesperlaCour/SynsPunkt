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
using SynsEntity;
using SynsBLL;
using SynsGUI;


namespace SynsGUI
{
    public partial class UserControlPOS : UserControl
    {
        //author: Jesper
        public UserControlPorductChoose UC_Vare2 { get; set; }

        public UserControlCustChoose UC_cust2 { get; set; }

        public UserControlOrderChoose UC_order2 { get; set; }
        public UserControlPOS()
        {
            InitializeComponent();
        }
        OrderController order = new OrderController();
        Order o;

        public void setTextBox4(int value)
        {
            txt_prodID.Text = value.ToString();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            try
            {
                order.CreateOrder(Convert.ToInt32(txt_custID.Text));
                o = order.GetLastOrder();
                txt_orderID.Text = o.ordreID.ToString();
                dataGridView1.DataSource = order.GetAllProductLines(o.ordreID);
                CustController cust = new CustController();
                Customer c = cust.GetCustomer(o.customerID);
                ShowCustInfo(c);
            }
            catch 
            {
                MessageBox.Show("Angiv gyldigt kundenummer");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addProd_Click(object sender, EventArgs e)
        {
            try
            {
                order.CreateProductLine(Convert.ToInt32(txt_orderID.Text), Convert.ToInt32(txt_prodID.Text), Convert.ToInt32(cmb_quantity.Text));
                dataGridView1.DataSource = order.GetAllProductLines(Convert.ToInt32(txt_orderID.Text));
                double pris = order.TotalPrice(Convert.ToDouble(cbb_discount.Text), Convert.ToInt32(txt_orderID.Text));
                lbl_pris.Text = $"{pris:C}";
            }
            catch {
                MessageBox.Show("Fejl i valg af varer. Tjek varenummer");
                    };
        }

        private void btn_RemoveProdLine_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    order.DeleteProductLine(Convert.ToInt32(selectedRow.Cells["ProductLineID"].Value));
                }
                dataGridView1.DataSource = order.GetAllProductLines(Convert.ToInt32(txt_orderID.Text));
                double pris = order.TotalPrice(Convert.ToDouble(cbb_discount.Text), Convert.ToInt32(txt_orderID.Text));
                lbl_pris.Text = $"{pris:C}";
            }
            catch
            {
                MessageBox.Show("Ingen varelinie valgt");
            }
        }

        private void btn_getOldOrder_Click(object sender, EventArgs e)
        {
            UC_order2.BringToFront();
        }

        private void btn_chooseProd_Click(object sender, EventArgs e)
        {
            UC_Vare2.BringToFront();
        }

        private void btn_chooseCust_Click(object sender, EventArgs e)
        {
            UC_cust2.BringToFront();
        }

        public void ShowCustInfo(Customer c) {
            try
            {
                label_name.Text = c.name;
                label_adress.Text = c.adress;
                label_zipCity.Text = $"{c.zipCode} {c.city}";
            }
            catch 
            {

            }
            
        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Er du sikker på, at du vil slette denne ordre?","",
                                     MessageBoxButtons.YesNo) ;
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    order.DeleteOrder(Convert.ToInt32(txt_orderID.Text));
                    //ResetForm();
                    this.Controls.Clear();
                    this.InitializeComponent();
                }
                catch 
                {
                    MessageBox.Show("Ingen ordre er valgt");
                }
                
                
            }
        }

        private void cbb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double pris = order.TotalPrice(Convert.ToDouble(cbb_discount.Text), Convert.ToInt32(txt_orderID.Text));
                lbl_pris.Text = $"{pris:C}";
            }
            catch 
            {

            }
            
        }

        private void btn_PayFinal_Click(object sender, EventArgs e)
        {
            DialogResult payDialog = MessageBox.Show("Du sendes nu videre til betaling", "", MessageBoxButtons.OKCancel);
            if (payDialog == DialogResult.OK)
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

    }
}
