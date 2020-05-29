using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynsEntity;
using SynsPersistence;

namespace EyewearAssist
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool success = false;
            while (success == false)
            {
                StartProcess();
            }

            void StartProcess()
            {
                Application.Run(new Login());

                try
                {
                    Sql_Connection sqlcon = new Sql_Connection();
                    sqlcon.VerifyConnection();
                    success = true;
                    Application.Run(new Form1());
                }
                catch
                {
                    DialogResult confirmResult = MessageBox.Show("\tFejl i password\t", "",
                                     MessageBoxButtons.RetryCancel);
                    if (confirmResult == DialogResult.Cancel)
                    {
                        success = true;
                    }
                }


            }
        }
    }
}
