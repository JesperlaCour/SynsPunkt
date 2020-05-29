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
using SynsBll;
using SynsBLL;
using SynsEntity;
namespace SynsGUI
{
    public partial class UserControlPorductChoose : UserControl
    {
        //Author: Jesper
        public UserControlPOS UC_Vare1 { get; set; }
        public UserControlPorductChoose()
        {
            InitializeComponent();
            

        }
        ProductController prod = new ProductController();
        List<Product> pList;

        private void btn_search_Click(object sender, EventArgs e)
        {
            SetCmb_category();
            pList = prod.GetAllProducts(textBox1.Text);
            dataGridView1.DataSource = pList;

        }

        private void btn_showAllProd_Click(object sender, EventArgs e)
        {
            SetCmb_category();
            pList = new List<Product>();
            pList = prod.GetAllProducts("");
            dataGridView1.DataSource = pList;
        }

        private void btn_ChooseSelected_Click(object sender, EventArgs e)
        {
            int productId = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value.ToString());
            }
            
            UC_Vare1.txt_prodID.Text = productId.ToString();
            UC_Vare1.BringToFront();
        }

        private void SetCmb_category()
        {
            cmb_Category.Items.Clear();
            foreach (string item in prod.GetAllCategories())
            {
                cmb_Category.Items.Add(item);
            }
        }

        //Author: Marc
        
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<Product> pListFilter = new List<Product>();
                foreach (Product item in pList)
                {
                    if (Convert.ToInt32(cmb_Category.Text[0])-48 == item.categoryID)
                    {
                        pListFilter.Add(item);
                    }
                }
                
                dataGridView1.DataSource = pListFilter;
            }
        }
    }
}
