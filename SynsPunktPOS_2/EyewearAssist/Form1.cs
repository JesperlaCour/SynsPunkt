using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynsBll;
using SynsBLL;
using SynsEntity;

namespace EyewearAssist
{
    public partial class Form1 : Form
    {
        //Author: Jesper
        public Form1()
        {
            InitializeComponent();
            SetComboBoxes();
        }
        AssistController assist = new AssistController();

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Eyewear> eList = new List<Eyewear>();
                eList = assist.GetEyewear(cmb_sex.Text, cmb_shape.Text, cmb_color.Text, trackBar_length.Value,
                trackBar_price.Value-1000, trackBar_price.Value+1000);
            if (eList.Count == 0)
            {
                MessageBox.Show("ingen briller matcher søgekriterierne");
            }
                dataGridView1.DataSource = eList;
 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = $"Stellængde: {trackBar_length.Value}";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label7.Text = $"Pris: {trackBar_price.Value - 1000} - {trackBar_price.Value + 1000}";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetComboBoxes()
        {
            foreach (string item in assist.GetDistinctFromFrame("shape"))
            {
                cmb_shape.Items.Add(item);
            }
            foreach (string item in assist.GetDistinctFromFrame("sex"))
            {
                cmb_sex.Items.Add(item);
            }
            foreach (string item in assist.GetDistinctFromFrame("color")) 
            {
                cmb_color.Items.Add(item);
            }
        }

        
    }
}
