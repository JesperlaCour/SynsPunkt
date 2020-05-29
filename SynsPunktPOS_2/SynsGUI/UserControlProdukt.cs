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
using System.Runtime.CompilerServices;
using System.IO;

namespace SynsGUI
{
    public partial class UserControlProdukt : UserControl
    {

        //Author: Marc / Andreas / Jesper
        ProductController prod = new ProductController();
        public UserControlProdukt()
        {
            InitializeComponent();
            
        }
        List<Product> pList = new List<Product>();

        private void btn_showAllProd_Click(object sender, EventArgs e)
        {
            FillCategoryBox();
            ProductController prod = new ProductController();
            pList = prod.GetAllProducts("");

            dataGridView1.DataSource = pList;
        }

        private void btn_searchModelName_Click(object sender, EventArgs e)
        {
            FillCategoryBox();
            ProductController prod = new ProductController();
            pList = prod.GetAllProducts(textBox1.Text);
            dataGridView1.DataSource = pList;

        }

        private void btn_CreateProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_CrCatID.Text[0] == '2' || cmb_CrCatID.Text[0] == '6')
                {
                    try
                    {
                        int categoryID2 = Convert.ToInt32(cmb_CrCatID.Text[0].ToString());
                        prod.CreateEyewear(
                            txt_CrManu.Text, txt_CrModel.Text, Convert.ToDouble(txt_CrPrice.Text), categoryID2,
                            cmb_CrSex.Text, cmb_CrShape.Text, cmb_CrColor.Text, Convert.ToInt32(trackBar_Length.Value));

                        MessageBox.Show("Produkt oprettet");
                        ClearCreateData();
                    }
                    catch
                    {
                        MessageBox.Show("Alle felter skal udfyldes");
                    }

                }
                else
                {
                    try
                    {
                        int categoryID = Convert.ToInt32(cmb_CrCatID.Text[0].ToString());
                        prod.CreateProduct(txt_CrManu.Text, txt_CrModel.Text, Convert.ToDouble(txt_CrPrice.Text), categoryID);
                        MessageBox.Show("Produkt oprettet");
                        ClearCreateData();
                    }
                    catch
                    {
                        MessageBox.Show("Alle felter skal udfyldes");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Alle felter skal udfyldes");
            }
        }

        private void ClearCreateData()
        {
            txt_CrManu.Clear();
            txt_CrModel.Clear();
            txt_CrPrice.Clear();
            cmb_CrCatID.SelectedIndex = -1;
            cmb_CrSex.SelectedIndex = -1;
            cmb_CrShape.SelectedIndex = -1;
            cmb_CrColor.SelectedIndex = -1;
            trackBar_Length.Value = 100;
            label17.Text = "Stel 100mm";
        }


        private void btn_UpdateProd_Click(object sender, EventArgs e)
        {
            ProductController prod = new ProductController();

            try
            {
                prod.UpdateProduct(Convert.ToInt32(txt_productID.Text), txt_UpManu.Text, txt_UpModel.Text, Convert.ToDouble(txt_UpPrice.Text));
                txt_productID.Clear();
                txt_UpManu.Clear();
                txt_UpModel.Clear();
                txt_UpPrice.Clear();
                txt_UpCategory.Clear();
            }
            catch
            {
                MessageBox.Show("Oplysninger ikke udfyldt korrekt");
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PrintProd_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FileName = ".txt";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UnityController unityControl = new UnityController();
                unityControl.PrintProducts(saveFileDialog1.FileName);
                MessageBox.Show("Din fil er nu gemt på den valgte destination");
            }
            else
            {
                MessageBox.Show("Din fil blev ikke gemt. Du skal oprette en textfil og vælge den i promptvinduet.");
            }

        }

        private void btn_SearchUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p;
                if (dataGridView1.SelectedCells.Count > 0 && txt_productID.Text == "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    p = prod.GetProduct(Convert.ToInt32(selectedRow.Cells["productID"].Value.ToString()));
                    txt_productID.Text = p.productID.ToString();

                }
                else
                {
                    p = prod.GetProduct(Convert.ToInt32(txt_productID.Text));

                }
                txt_UpManu.Text = p.manufactor;
                txt_UpModel.Text = p.modelName;
                txt_UpPrice.Text = p.price.ToString();
                txt_UpCategory.Text = p.catName;

            }
            catch
            {
                MessageBox.Show("Intet produkt valgt");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label17.Text = $"Stel {trackBar_Length.Value}mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CrCatID.Text == "")
            {
                tableLayoutPanel4.Visible = false;
            }
            else if (cmb_CrCatID.Text[0] == '2' || cmb_CrCatID.Text[0] == '6')
            {
                tableLayoutPanel4.Visible = true;
            }
            else
                tableLayoutPanel4.Visible = false;
        }

        private void FillCategoryBox()
        {
            cmb_CrCatID.Items.Clear();
            cmb_category.Items.Clear();
            foreach (string item in prod.GetAllCategories())
            {
                cmb_CrCatID.Items.Add(item);
            }
            foreach (string item in prod.GetAllCategories())
            {
                cmb_category.Items.Add(item);
            }

        }


        private void cmb_category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<Product> pListFilter = new List<Product>();
                foreach (Product item in pList)
                {
                    if (Convert.ToInt32(cmb_category.Text[0]) - 48 == item.categoryID)
                    {
                        pListFilter.Add(item);
                    }
                }

                dataGridView1.DataSource = pListFilter;
            }
        }
    }
    
}
