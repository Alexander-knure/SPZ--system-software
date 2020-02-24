using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{

    public class Computer
    {

        public string ComputerName { get; set; }
        public int RamCopacity { get; private set; }
        public Dictionary<string,Process> ProcessList { get; set; }
        public int CpuFrequency { get; private set; }
        public int CPUs { get; set; }
        public static string key;
        public Computer(string ComputerName,
            int RamCopacity,
            Dictionary<string,Process> ProcessList,
            int CpuFrequency,
            int CPUs)
        {
            this.ComputerName = ComputerName;
            this.RamCopacity = RamCopacity;
            this.ProcessList = ProcessList;
            this.CpuFrequency = CpuFrequency;
            this.CPUs = CPUs;
        }


        public void RamChenge(int value)
        {
            this.RamCopacity = value;
        }


        public void FrequencyAdd(int value)
        {
            this.CpuFrequency = value;
        }


        public void ProcessAdd(Process p)
        {
            ProcessList.Add(p.ProcessName,p);
        }

        public void ProcessDelete(string str)
        {

            foreach (KeyValuePair<string,Process> el in ProcessList)
            {
                if (el.Key == str)
                    key = str;
            }
            ProcessList.Remove(str);
        }

        public override string ToString()
        {
            return '"' + ComputerName + '"'+CpuFrequency+ '"'+CPUs;
        }

        public void ProcessChenge(string OriginProcessName,string ProcessName,string User,int Cpu,int Ram,string Discription,int Priority)
        {
            foreach (KeyValuePair<string,Process> el in ProcessList)
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
