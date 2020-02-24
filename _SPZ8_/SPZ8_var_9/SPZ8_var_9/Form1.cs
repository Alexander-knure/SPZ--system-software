using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SPZ8_var_9
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        { 
           var result= Registry.GetValue(
                "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0",
                "ProcessorNameString", "");

            CPUtextBox.Text =  result.ToString();
        }

        private void btnBIOS_Click(object sender, EventArgs e)
        {
            
            var result = Registry.GetValue(
                "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS"
,               "BIOSVendor", "");
            var result2 = Registry.GetValue(
              "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS"
,             "BIOSVersion", "");
            BIOStextBox.Text = "Производитель:" + result.ToString()+"\nВерсия:"+result2.ToString();
        }
    }
}
