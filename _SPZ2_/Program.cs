using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_var4
{
    class Factory : IComparable
    {
        private string Name;
        private int Workers;
        private int Manufactures;
        private float sWorker;
        private float sMaster;
        private int Masters = 0;
        private float ProfitFromWorker;
        private float ProfitFromMaster;
        public float GeneralProfit
        {
            get { return this.ProfitFromWorker * this.Workers + this.ProfitFromMaster * this.Masters; }
        }
       

        //Construction
        Factory(string _Name, int _Workers, int _Manufactures, float _sWorker,
            float _sMaster, float ProfitFromWorker, float ProfitFromMaster)
        {                                                                                                                           
            this.Name = _Name;
            this.Workers = _Workers;
            this.Manufactures = _Manufactures;
            this.sWorker = _sWorker;
            this.sMaster = _sMaster;
            if (Workers % 10 > 0)
                this.Masters++;
            this.Masters = Workers / 10;
        }

        public int HireWorker(int quantity)
        {
            if (quantity > 0)
                this.Workers += quantity;
            this.Masters = this.Workers / 10;
            if (Workers % 10 > 0)
                this.Masters++;
            return this.Workers;
        }
        public int RetireWorker(int quantity)
        {
            if (quantity > 0 && quantity <= this.Workers)
            {
                this.Workers -= quantity;
                this.Masters = this.Workers / 10;
                if (Workers % 10 > 0)
                        this.Masters++;
                return this.Workers;
            }
            else
                //Exception
                return -1;
            
        }
        public int HireMaster(int quantity)
        {
            if(quantity > 0)
            {
                this.Masters += quantity;
            }
    
            return this.Masters;
        }
        public int RetireMaster(int quantity)
        {
            if (quantity > 0 && quantity <= this.Masters)
            {
                this.Masters -= quantity;
            }
            return this.Masters;
        }
        //Copy construction
        Factory(Factory obj)
        {
        this.Name = obj.Name;
        this.Workers = obj.Workers;
        this.Manufactures = obj.Manufactures;
        this.sWorker = obj.sWorker;
        this.sMaster = obj.sMaster;
        this.Masters = obj.Masters;
        this.ProfitFromWorker = obj.ProfitFromWorker;
        this.ProfitFromMaster = obj.ProfitFromMaster;
       }
        public int CompareTo(Factory f)
        {
            if (GeneralProfit > f.GeneralProfit)
                return 1;
            else if (GeneralProfit == f.GeneralProfit)
                return 0;
            else
                return -1;
        }

        public static Factory operator+(Factory f1, Factory f2)
        {
            Factory fRes = new Factory(f1.Name,
                f1.Workers + f2.Workers,
                f1.Manufactures + f2.Manufactures,
               (f1.sWorker + f2.sWorker) / 2,
               (f1.sMaster + f2.sMaster) / 2, 
               (f1.ProfitFromWorker+f2.ProfitFromWorker)/2,
               (f1.ProfitFromMaster + f2.ProfitFromMaster) /2);

            return fRes;
        }
    }
    static class Program
    {
        //•	реалізувати розширюючий метод, який визначає прибуток, 
        //шо отримується від вкладення деякої суми у розвиток заводу 
        //(на наймання співробітників).
        public static float ExGeneralProfit(this Factory f)
        {
            return f.
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
