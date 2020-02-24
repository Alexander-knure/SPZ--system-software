using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{
    public class Process
    {
        public string ProcessName { get; set; }
        public string User { get;  set; }
        public int CPU { get;  set; }
        public int Ram { get; set; }
        public string Location { get; set; }
        public string Discription { get; set; }
        public int Priority { get; set; }


        //CONSTRUCTOR
        public Process(
            string ProcessName,
            string User,
            int CPU,
            int Ram,
            string Location,
            string Discription,
            int Priority
            )
        {
            this.ProcessName = ProcessName;
            this.User = User;
            this.CPU = CPU;
            this.Ram = Ram;
            this.Location = Location;
            this.Discription = Discription;
            this.Priority = Priority;
        }

        Process(Process process)
        {
            this.ProcessName = process.ProcessName;
            this.User = process.User;
            this.CPU = process.CPU;
            this.Location = process.Location;
            this.Discription = process.Discription;
            this.Priority = process.Priority;
        }

        public static Process operator ++(Process process)
        {
            Process proc = new Process(process.ProcessName,
            process.User,
            process.CPU,
            process.Ram,
            process.Location,
            process.Discription,
            process.Priority);
            if (process.Priority == 0 && process.Priority < 5)
                process.Priority++; 
            return proc;
        }

        public static Process operator -(Process process)
        {
            Process proc = new Process(process.ProcessName,
            process.User,
            process.CPU,
            process.Ram,
            process.Location,
            process.Discription,
            process.Priority);
            if (process.Priority == 0 && process.Priority < 5)
                process.Priority--;
            return proc;
        }
    }
}
