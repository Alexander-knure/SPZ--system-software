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
    public partial class Form1 : Form
    {
        public static DataTable table = new DataTable();

        public Manager manager;
        public Process proc;
        public string element;
        public static string a, b;
        int index;
        public Form1()
        {
            InitializeComponent();

            

            Authentication authentication = new Authentication();
            authentication.ShowDialog();
            a = authentication.name.Text;
            b = authentication.password.Text;
            manager = new Manager(new Dictionary<string, Computer> (),
                new Dictionary<string, Process>(),
                "dart",
                "ewars");

          //  if (a == manager.ADMIN_NAME && b == manager.ADMIN_PASWORD)
                AddComp.Enabled = !AddComp.Enabled;
            
        }
        public void ButtonActivity()
        {
            
            DeleteProc.Enabled = !DeleteProc.Enabled;
            ChangeProcess.Enabled = !ChangeProcess.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            ChangeComp.Enabled=!ChangeComp.Enabled;
            DeleteComp.Enabled = !DeleteComp.Enabled;
        }


        private void AddComp_Click(object sender, EventArgs e)
        {
            if (CurrentPC.Items.Count == 0)
            {
                AddProc.Enabled = !AddProc.Enabled;
                ButtonActivity();
            }
            CompAddForm fm1 = new CompAddForm();
            fm1.ShowDialog();

             var comp = manager.AddComp(fm1.textBox1.Text,
                (int)fm1.numericUpDown1.Value,
                new Dictionary<string, Process>(),
                (int)fm1.numericUpDown2.Value,
                (int)fm1.numericUpDown2.Value);

            AddProcForm apf = new AddProcForm();
            apf.ShowDialog();

            proc = new Process(apf.ProcessName.Text,
                apf.ProcessUser.Text,
                (int)apf.Cpu.Value,
                (int)apf.Ram.Value,
                comp.ComputerName,
                apf.Discription.Text,
                (int)apf.Priority.Value);

            comp.ProcessList.Add (proc.ProcessName,proc);

            manager.ComputerList.Add(comp.ComputerName, comp);
            manager.ProcessList.Add(proc.ProcessName,proc);
           
            CurrentPC.Items.Add(comp);
            CurrentPC.SelectedIndex = CurrentPC.Items.Count - 1;

            table.Rows.Add(proc.ProcessName,proc.Priority,proc.CPU,proc.Ram,proc.Discription,proc.Location);
            dataGridView1.DataSource = table;
        }
        private void DeleteComp_Click(object sender, EventArgs e)
        {
            int previosIndex = CurrentPC.SelectedIndex;

            foreach (string key in manager.ComputerList.Keys)
            {
                if (key == ((Computer)CurrentPC.SelectedItem).ComputerName)
                    element = key;  
            }
            CurrentPC.Items.RemoveAt(CurrentPC.SelectedIndex);
            manager.ComputerList.Remove(element);

            if (CurrentPC.Items.Count == 0)
            {
                ButtonActivity();
                AddProc.Enabled = !AddProc.Enabled;
                CurrentPC.Text = "";
            }
            else if (previosIndex > 0)
                CurrentPC.SelectedIndex = previosIndex - 1;
            else
                CurrentPC.SelectedIndex = 0;

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr["Location"].ToString() == element)
                    dr.Delete();
            }
            dataGridView1.DataSource = table;
        }

        private void ChangeComp_Click(object sender, EventArgs e)
        {
            CompAddForm fm2 = new CompAddForm();
            fm2.ShowDialog();

            foreach (KeyValuePair<string, Computer> key in manager.ComputerList)
            {
                if (key.Key == ((Computer)CurrentPC.SelectedItem).ComputerName)
                {
                    key.Value.ComputerName = fm2.textBox1.Text;
                    key.Value.RamChenge((int)fm2.numericUpDown1.Value);
                    key.Value.FrequencyAdd((int)fm2.numericUpDown2.Value);
                    key.Value.CPUs = (int)fm2.numericUpDown3.Value;
                }
            }

            var pc = (Computer)CurrentPC.SelectedItem;
            var oldItem = CurrentPC.SelectedIndex;
            pc.ComputerName = fm2.textBox1.Text;
            pc.RamChenge((int)fm2.numericUpDown1.Value);
            pc.FrequencyAdd((int)fm2.numericUpDown2.Value);
            pc.CPUs = (int)fm2.numericUpDown3.Value;


            CurrentPC.Items[oldItem] = pc;
            this.Refresh();
            CurrentPC.Refresh();
        }
        private void AddProc_Click(object sender, EventArgs e)
        {
            AddProcForm fm3 = new AddProcForm();
            fm3.ShowDialog();

             proc = new Process(fm3.ProcessName.Text,
                fm3.ProcessUser.Text,
                (int)fm3.Cpu.Value,
                (int)fm3.Ram.Value,
                ((Computer)CurrentPC.SelectedItem).ComputerName,
                fm3.Discription.Text,
                (int)fm3.Priority.Value);

            manager.AddProc((Computer)CurrentPC.SelectedItem,proc);
      
            table.Rows.Add(proc.ProcessName, proc.Priority, proc.CPU, proc.Ram, proc.Discription, proc.Location);
        }

        private void DeleteProc_Click(object sender, EventArgs e)
        {
            AddProcForm fm4 = new AddProcForm();
            fm4.Buttons();
            fm4.ShowDialog();

            
            foreach(KeyValuePair<string,Process> proc in manager.ProcessList)
            {
                if (proc.Key == fm4.ProcessName.Text)
                {
                    element = proc.Key;
                }
            }

            manager.DelProc((Computer)CurrentPC.SelectedItem, element);

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr["Process"].ToString() == fm4.ProcessName.Text)
                    dr.Delete();
            }
            dataGridView1.DataSource = table;
        }

        private void ChangeProcess_Click(object sender, EventArgs e)
        {
            AddProcForm fm5 = new AddProcForm();
            fm5.Buttons();
            fm5.ShowDialog();

            AddProcForm fm6 = new AddProcForm();
            fm6.ShowDialog();

            foreach (KeyValuePair<string, Process> proc in manager.ProcessList)
            {
                if (proc.Key == fm5.ProcessName.Text)
                {
                    proc.Value.ProcessName = fm6.ProcessName.Text;
                    proc.Value.User = fm6.ProcessUser.Text;
                    proc.Value.CPU = (int)fm6.Cpu.Value;
                    proc.Value.Ram = (int)fm6.Ram.Value;
                    proc.Value.Discription = fm6.Discription.Text;
                    proc.Value.Priority = (int)fm6.Priority.Value;
                }

            }

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = table.Rows[i];
                if (dr["Process"].ToString() == fm5.ProcessName.Text)
                {
                    dr["Process"] = fm6.ProcessName.Text;
                    dr["Priority"] = (int)fm6.Priority.Value;
                    dr["Cpu"]= (int)fm6.Cpu.Value;
                    dr["Ram"]= (int)fm6.Ram.Value;
                    dr["Discription"]= fm6.Discription.Text;
                }
            }
            dataGridView1.DataSource = table;
        }

        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow newDataRow = dataGridView1.Rows[e.RowIndex];
            AddProcForm a = new AddProcForm();
            a.ShowDialog();

            foreach (KeyValuePair<string, Process> proc in manager.ProcessList)
            {
                if (proc.Key == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    proc.Value.ProcessName = a.ProcessName.Text;
                    proc.Value.User = a.ProcessUser.Text;
                    proc.Value.CPU = (int)a.Cpu.Value;
                    proc.Value.Ram = (int)a.Ram.Value;
                    proc.Value.Discription = a.Discription.Text;
                    proc.Value.Priority = (int)a.Priority.Value;
                }

            }

            newDataRow.Cells[0].Value = a.ProcessName.Text;
            newDataRow.Cells[1].Value = a.Priority.Value;
            newDataRow.Cells[2].Value = a.Cpu.Value;
            newDataRow.Cells[3].Value = a.Ram.Value;
            newDataRow.Cells[4].Value = a.Discription.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            table.Columns.Add("Process", typeof(string));
            table.Columns.Add("Priority", typeof(int));
            table.Columns.Add("Cpu", typeof(int));
            table.Columns.Add("Ram", typeof(int));
            table.Columns.Add("Discription", typeof(string));
            table.Columns.Add("Location", typeof(string));

            

            dataGridView1.DataSource = table;
        }
    }
}
