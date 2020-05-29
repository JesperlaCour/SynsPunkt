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


namespace SynsGUI
{

    public partial class UserControlCustChoose : UserControl
    {
        //Author: Jesper
        public UserControlPOS UC_Cust1 { get; set; }
        public UserControlCustChoose()
        {
            InitializeComponent();
        }

        CustController cust = new CustController();

        private void btn_chooseSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int customerID = 0;
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    customerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value.ToString());
                }

                UC_Cust1.txt_custID.Text = customerID.ToString();
                CustController cust = new CustController();
                UC_Cust1.ShowCustInfo(cust.GetCustomer(customerID));
                this.Controls.Clear();
                this.InitializeComponent();
                UC_Cust1.BringToFront();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Customer> pList = cust.GetAllCustomer(txt_CustName.Text);

            dataGridView1.DataSource = pList;
        }

        private void btn_showAllCust_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.GetAllCustomer("");
        }

    }
}
