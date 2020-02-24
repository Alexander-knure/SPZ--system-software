using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _SPZ6_
{
    [Serializable]
    public class Factory
    {
        public enum Mode
        {
            Awaiting,
            Buying,
            Producing,
            Selling
        }
        public Mode CurrentMode { get; set; }
        public int Manufactories { get; set; }
        public float MoneyCount { get; set; }
        public int MaterialsCount { get; set; }
        public int ProductionCount { get; set; }
        public float Volume { get; set; }
        private static float kVolume;
        public Condition c;
        private static object locker = new object();

        public delegate void dMode(string s);
        public event dMode Notify;

        public Factory()
        {
            CurrentMode = Mode.Awaiting;
            MoneyCount = 1000;
            Manufactories = 1;
            MaterialsCount = 0;
            ProductionCount = 0;
            kVolume = 20;
            Volume = 0;
            c = new Condition();
    }
    public Factory( int moneyCount, int materialsCount, int manufactories, int productionCount)
        {
            if(moneyCount > 0)
                MoneyCount = moneyCount;
            if (materialsCount > 0)
                MaterialsCount = materialsCount;
            if (manufactories > 0)
                Manufactories = manufactories;
            if (productionCount > 0)
                ProductionCount = productionCount;
            CurrentMode = Mode.Awaiting;
            c = new Condition();

            kVolume = c.CountBuyingMaterials/5;
            if (MaterialsCount > 0 && MaterialsCount / kVolume < 100)
            {
                Volume = MaterialsCount/ kVolume;
            }
            if (MaterialsCount == 0)
            {
                Volume = 0;
            }
        }
        public void BuyMaterials()
        {
            lock (locker)
            {
                CurrentMode = Factory.Mode.Buying;
                if (MoneyCount >= c.CostBuyingMaterials)
                {
                    Thread.Sleep(c.Sleep / Manufactories);
                    MoneyCount -= c.CostBuyingMaterials;
                    MaterialsCount += c.CountBuyingMaterials;
                    if (MaterialsCount * Manufactories / kVolume <= 100)
                        Volume = MaterialsCount / kVolume;
                }
                else
                {
                    Notify?.Invoke("You entered a time less than 0!");
                }
            }
            CurrentMode = Factory.Mode.Awaiting;
        }
        public void Produce()
        {
            lock (locker)
            {
                CurrentMode = Factory.Mode.Producing;
                if (MoneyCount >= c.CostProduce && MaterialsCount >= c.CountProduceMaterials)
                {
                    Thread.Sleep(c.Sleep / Manufactories);

                    MoneyCount -= c.CostProduce;
                    MaterialsCount -= c.CountProduceMaterials;
                    ProductionCount += c.CountProduceProduction;

                    Volume = MaterialsCount / kVolume;

                }
                else
                {
                    Notify?.Invoke("The factory hasn`t enough money or materials!");
                }
            }
            CurrentMode = Factory.Mode.Awaiting;
        }
        public void SellProduction()
        {
            lock (locker)
            {
                CurrentMode = Factory.Mode.Selling;
                if (ProductionCount >= c.CountSellingProduction)
                {
                    Thread.Sleep(c.Sleep / Manufactories);

                    ProductionCount -= c.CountSellingProduction;
                    MoneyCount += c.CostProduction;
                }

                if (ProductionCount > 0)
                {
                    Thread.Sleep(c.Sleep / Manufactories);

                    MoneyCount += ProductionCount * (c.CostProduction / c.CountSellingProduction);
                    ProductionCount = 0;
                }
                else
                {
                    Notify?.Invoke("The factory hasn`t enough productions for selling!");
                }
            }
            CurrentMode = Factory.Mode.Awaiting;
        }
        public void BuyManufactory()
        {
            lock (locker)
            {
                CurrentMode = Factory.Mode.Buying;
                if (MoneyCount >= c.CostManufactory)
                {
                    Thread.Sleep(c.Sleep / Manufactories);
                    MoneyCount -= c.CostManufactory;
                    Manufactories++;
                    kVolume = 20 * Manufactories;
                    Volume = MaterialsCount / kVolume;

                    c.Sleep /= Manufactories;
                    c.CostManufactory += 500;
                }
                else
                {
                    Notify?.Invoke("The factory hasn`t enough money!");
                }
            }
            CurrentMode = Factory.Mode.Awaiting;
        }
    }
}
