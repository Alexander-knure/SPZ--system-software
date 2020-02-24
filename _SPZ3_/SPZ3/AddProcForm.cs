using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ3
{
    public partial class AddProcForm : Form
    {
        
        public AddProcForm()
        {
            InitializeComponent();
        }

        public void Buttons()
        {
            ProcessUser.Enabled = !ProcessUser.Enabled;
            Cpu.Enabled = !Cpu.Enabled;
            Ram.Enabled = !Ram.Enabled;
           
            Discription.Enabled = !Discription.Enabled;
            Priority.Enabled = !Priority.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
