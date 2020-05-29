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
using System.IO;
using SynsBLL;



namespace SynsGUI
{
    public partial class UserControlByKatAdmin : UserControl
    {

        //Author: Marc / Andreas

        ProductController prod = new ProductController();
        CustController cust = new CustController();
        DataTable dt;
        DataTable dt2;
        public UserControlByKatAdmin()
        {
            InitializeComponent();
        }

        private void btn_showCities_Click(object sender, EventArgs e)
        {
            dt = cust.GridGetCities();
            dataGridView1.DataSource = dt;
        }

        private void btn_saveCities_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                cust.GridUpdateCity(dt);
            }
            
        }

        private void btn_showCategories_Click(object sender, EventArgs e)
        {
            dt2 = prod.GridGetCategories();
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[0].ReadOnly = true;
            
        }

        private void btn_saveCategories_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                prod.GridUpdateCategories(dt2);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         Process.Start("HjælpeFil.pdf");
        }
    }
}
