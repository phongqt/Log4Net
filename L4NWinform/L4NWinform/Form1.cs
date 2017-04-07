using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace L4NWinform
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("ErrorLog");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Debug("Debug logging");
            log.Info("Info logging");
            log.Warn("Warn logging");
            log.Error("Error logging");
            log.Fatal("Fatal logging");

            //This is where we call the logger from a different class
            //OtherClass.TestLogger();

            try
            {
                throw new System.IO.FileNotFoundException();
            }
            catch (Exception ex)
            {
                log.Debug("Debug error logging", ex);
                log.Info("Info error logging", ex);
                log.Warn("Warn error logging", ex);
                log.Error("Error error logging", ex);
                log.Fatal("Fatal error logging", ex);
            }
        }
    }
}
