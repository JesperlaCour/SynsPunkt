using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SynsEntity;

namespace SynsGUI
{
    public partial class Form1 : Form
    {
        //Author: Andreas
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            userControlForside1.BringToFront();
            userControlPOS1.UC_Vare2 = userControlPorductChoose1;
            userControlPOS1.UC_cust2 = userControlCustChoose1;
            userControlPOS1.UC_order2 = userControlOrderChoose1;
            userControlPorductChoose1.UC_Vare1 = userControlPOS1;
            userControlCustChoose1.UC_Cust1 = userControlPOS1;
            userControlOrderChoose1.UC_Order1 = userControlPOS1;
            label1.Text = Credentials.butiksNavn;
        }

        private void customizeDesign()
        {
            panelOrdrerSubmenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelOrdrerSubmenu.Visible == true)
                panelOrdrerSubmenu.Visible = false;
            if (panelAdminSubMenu.Visible == true)
                panelAdminSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnOrdrer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOrdrerSubmenu);
        }
        #region OrdrerSubMenu
        private void btn_OrderControl_Click(object sender, EventArgs e)
        {
            userControlPOS1.BringToFront();
            hideSubMenu();
        }

       
        private void btn_salesStatistic_Click(object sender, EventArgs e)
        {
            userControlSalgsStatistik1.BringToFront();
            hideSubMenu();
        }
        #endregion  


        private void btnKunde_Click(object sender, EventArgs e)
        {
            userControlMedarbejder1.BringToFront();
            hideSubMenu();
        }


        private void btnProdukter_Click(object sender, EventArgs e)
        {
            userControlProdukt1.BringToFront();
            hideSubMenu();
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdminSubMenu);
            
        }


        private void btn_custAdmin_Click_1(object sender, EventArgs e)
        {
            userControlAdministration1.BringToFront();
            hideSubMenu();
        }

        private void btn_prodAdmin_Click_1(object sender, EventArgs e)
        {
            userControlProduktAdmin1.BringToFront();
            hideSubMenu();
        }

        private void btn_CityCatAdmin_Click_1(object sender, EventArgs e)
        {
            userControlByKatAdmin1.BringToFront();
            hideSubMenu();
        }

        private void btn_help_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Help_pdf.pdf");
            }
            catch
            {

            }
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            userControlForside1.BringToFront();
            
        }

        private void btn_Logo2_Click_1(object sender, EventArgs e)
        {
            userControlForside1.BringToFront();
        }

        private void link_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                try
                {
                    Process.Start("Help_pdf.pdf");
                }
                catch
                {

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://erdetøltid.dk/");
        }
    }
}
