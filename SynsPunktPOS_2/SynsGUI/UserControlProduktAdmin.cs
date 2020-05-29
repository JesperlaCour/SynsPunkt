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
    public partial class UserControlProduktAdmin : UserControl
    {

        //Author: Marc / Andreas

        ProductController prod = new ProductController();
        DataTable dt;

        public UserControlProduktAdmin()
        {
            InitializeComponent();
        }

        private void btn_showProd_Click(object sender, EventArgs e)
        {
            dt = prod.GridGetProducts();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                prod.GridUpdateProducts(dt);
            }
            
        }


        private void btn_Choose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                
                dt = prod.GridGetFrameSpec(Convert.ToInt32(selectedRow.Cells["productID"].Value.ToString()));
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[4].ReadOnly = true;

            }
            else
                MessageBox.Show("Intet produkt valgt");
                 
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt != null)
                {
                    prod.GridUpdateFrameSpec(dt);
                }
                
            }
            catch
            {
                MessageBox.Show("Fejl i produktID. Tjek om valgte produkt er en brille");
            }
            
            

        }
    }
}
