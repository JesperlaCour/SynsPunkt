using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using SynsBLL;


namespace SynsGUI
{
    public partial class UserControlCustomerAdmin : UserControl
    {
        //Author: Marc / Jesper
        CustController cust = new CustController();
        DataTable dt;
        
        public UserControlCustomerAdmin()
        {
            InitializeComponent();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                cust.GridUpdateCustomers(dt);
            }
               
        }


        private void btn_showCust_Click(object sender, EventArgs e)
        {

            
            dt = cust.GridGetCustomers();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].ReadOnly = true;

        }
    }
}
