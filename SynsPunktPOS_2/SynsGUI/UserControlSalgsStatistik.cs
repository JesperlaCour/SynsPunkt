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
using System.IO;

namespace SynsGUI
{
    public partial class UserControlSalgsStatistik : UserControl
    {

        //Author: Marc 


        public UserControlSalgsStatistik()
        {
            InitializeComponent();
            dateTimePicker_to.Value = (DateTime.Now.AddDays(1));
            dateTimePicker_from.Value = (DateTime.Now.AddDays(-14));
        }

        private void btn_showStatistic_Click(object sender, EventArgs e)
        {
            UnityController uc = new UnityController();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "temp.txt";
            uc.ShowSalesStatistics(saveFileDialog1.FileName, dateTimePicker_from.Value, dateTimePicker_to.Value);
            string content = File.ReadAllText(saveFileDialog1.FileName);
            richTextBox1.Text = content;
        }

        
        private void btn_printStatistic_Click(object sender, EventArgs e)
        {
            UnityController uc = new UnityController();
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
                uc.ShowSalesStatistics(saveFileDialog1.FileName, dateTimePicker_from.Value, dateTimePicker_to.Value);
                MessageBox.Show("Din fil er nu gemt på den valgte destination");
                
            }
            else
            {
                MessageBox.Show("Din fil blev ikke gemt. Du skal oprette en textfil og vælge den i promptvinduet.");
            }
        }

    }
}
