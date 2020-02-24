using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPZ3
{
    public class Manager
    {
        public Dictionary<string, Computer> ComputerList { get; private set; }
        public Dictionary<string, Process> ProcessList{get ; private set;}
        public string ADMIN_NAME { get; private set; }
        public string ADMIN_PASWORD { get; private set; }

        public Manager(Dictionary<string, Computer> ComputerList,
            Dictionary<string, Process> ProcessList,
            string Name,
            string Pasword)
        {
            this.ComputerList = ComputerList;
            this.ProcessList = ProcessList;
            this.ADMIN_NAME = Name;
            this.ADMIN_PASWORD = Pasword;
        }

        public Computer AddComp(string ComputerName,
            int RamCopacity,
            Dictionary<string,Process> ProcessList,
            int CpuFrequency,
            int Cores)
        {
            Computer a = new Computer( ComputerName,  RamCopacity,  ProcessList,  CpuFrequency,  Cores);
            return a;
        }

        public void AddProc(Computer Comp,Process Proc)
        {
            Comp.ProcessAdd(Proc); 
        }

        public bool DelProc(Computer a,string str)
        {
            if (a.ProcessList.Count == 0)
                return false;
            else
            {
                a.ProcessDelete(str);
                return true;
            }
           
        }

        public void ProcessChenge(string OriginProcessName, string ProcessName, string User, int Cpu, int Ram, string Discription, int Priority)
        {
            foreach (KeyValuePair<string, Process> el in ProcessList)
            {
                if (el.Key == OriginProcessName)
                {
                    el.Value.ProcessName = ProcessName;
                    el.Value.User = User;
                    el.Value.CPU = Cpu;
                    el.Value.Ram = Ram;
                    el.Value.Discription = Discription;
                    el.Value.Priority = Priority;
                }
            }
        }

    }
}
