using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace _SPZ6_
{


    public class Condition
    {
        //Timer
        int sleep;
        //Money
        float costBuyingMaterials;
        float costProduce;
        float costManufactory;
        float costProduction;
        //Other
        int countBuyingMaterials;
        int countProduceMaterials;
        int countProduceProduction;
        int countSellingProduction;
        public int Sleep { get{ return sleep;}set {sleep = 5000; } }
        //For buying
        public float CostBuyingMaterials{ get { return costBuyingMaterials; } set { costBuyingMaterials = 150; } }
        public int CountBuyingMaterials { get { return countBuyingMaterials; } set { countBuyingMaterials = 100; } }
        //For add manufactory
        public float CostManufactory { get { return costManufactory; } set { } }
        //For produce
        public float CostProduce { get { return costProduce; } set { costProduce = 100; } }
        public int CountProduceMaterials { get { return countProduceMaterials; } set { countProduceMaterials = 100; } }
        public int CountProduceProduction { get { return countProduceProduction; } set { countProduceProduction = 50; } }
        //For selling
        public int CountSellingProduction { get { return countSellingProduction; } set { countSellingProduction = 50; } }
        public float CostProduction { get { return costProduction; } set { costProduction = 2000; } }

        public Condition()
        {
            sleep = 5000;
            costBuyingMaterials = 150;
            costProduce = 100;
            costManufactory = 500;
            costProduction = 2000;
            countBuyingMaterials = 100;
            countProduceMaterials = 100;
            countProduceProduction = 50;
            countSellingProduction = 50;
        }
    }
}
