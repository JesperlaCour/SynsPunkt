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
using SynsEntity;


namespace SynsGUI
{
    public partial class UserControlCustomer : UserControl
    {
        //Author: Jesper

        public UserControlCustomer()
        {
            InitializeComponent();
        }

        
        private void btn_ShowAllCustomers(object sender, EventArgs e)
        {
            CustController cust = new CustController();
            List<Customer> cList;
            cList = cust.GetAllCustomer("");
            dataGridView1.DataSource = cList;
        }

        private void btn_CrCust_Click(object sender, EventArgs e)
        {
            
            try
            {
                CustController cust = new CustController();
                cust.OpretKunde(txt_CrName.Text, txt_CrAdress.Text, Convert.ToInt32(txt_CrZip.Text));
                txt_CrName.Clear();
                txt_CrAdress.Clear();
                txt_CrZip.Clear();
                MessageBox.Show("Kunde oprettet");
            }
            catch
            {
                MessageBox.Show("Alle felter skal udfyldes");
                
            }

        }


        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            CustController cust = new CustController();
            List<Customer> cList = new List<Customer>();
            cList = cust.GetAllCustomer($"{txt_searchName.Text}");

            dataGridView1.DataSource = cList;
        }

        private void btn_saveCustChanges_Click(object sender, EventArgs e)
        {
            try
            {
                CustController cust = new CustController();
                cust.UpdateCustomer(Convert.ToInt32(txt_custID.Text), txt_updateName.Text, txt_updateAdress.Text, Convert.ToInt32(txt_updateZip.Text));
                txt_custID.Clear();
                txt_updateName.Clear();
                txt_updateAdress.Clear();
                txt_updateZip.Clear();
            }
            catch 
            {
                MessageBox.Show("Oplysninger ikke udfyldt korrekt");
            }
            
        }

        private void btn_UpdateShow_Click(object sender, EventArgs e)
        {
            try
            {
                CustController cust = new CustController();
                Customer c;
                if (dataGridView1.SelectedCells.Count > 0 && txt_custID.Text == "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    c = cust.GetCustomer(Convert.ToInt32(selectedRow.Cells["CustomerID"].Value.ToString()));
                    txt_custID.Text = c.customerID.ToString();

                }
                else
                {
                    c = cust.GetCustomer(Convert.ToInt32(txt_custID.Text));
                    
                }


                txt_updateName.Text = c.name;
                txt_updateAdress.Text = c.adress;
                txt_updateZip.Text = c.zipCode.ToString();
            }
            catch 
            {

            }
           
        }

    }
}
