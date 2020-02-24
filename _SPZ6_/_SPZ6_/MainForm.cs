using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace _SPZ6_
{
    public partial class MainForm : Form
    {
        public Factory factory;
        private static object locker = new object();
        //  public Thread MainThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateInfo()
        {
            tbMoney.Text = factory.MoneyCount.ToString() + '₴';
            tbMaterials.Text = factory.MaterialsCount.ToString() + " units";
            tbProduction.Text = factory.ProductionCount.ToString() + " units";
            tbManufactories.Text = factory.Manufactories.ToString();
            tbVolume.Text = factory.Volume.ToString() + '%';
            lbMODE.Text = "Mode: " + factory.CurrentMode.ToString();
        }
        private static void DisplayMessage(string s)
        {
           MessageBox.Show(s,
           "Message error",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Serialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Factory));
            using (FileStream fs = new FileStream("Factory.xml", FileMode.Create))
            {
                formatter.Serialize(fs, factory);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            factory = new Factory(1000, 200, 1, 20);
            MainTimer.Start();
            factory.Notify += DisplayMessage;

            UpdateInfo();

            lbCostBuyingMaterials.Text += factory.c.CostBuyingMaterials.ToString();
            lbCountMaterials.Text += factory.c.CountProduceMaterials.ToString();

            lbCostManufactory.Text += factory.c.CostManufactory.ToString();

            lbCostProduce.Text += factory.c.CostProduce.ToString();
            lbCostBuyingMaterialsProduce.Text += factory.c.CountProduceMaterials.ToString();
            lbCountProduce.Text += factory.c.CountProduceProduction.ToString();

            lbCostProduction.Text += factory.c.CostProduction.ToString();
            lbCountProduction.Text += factory.c.CountSellingProduction.ToString();

             Serialize();
        }

        private void btBuyMaterials_Click(object sender, EventArgs e)
        {
            try
            {
                // Background thread
            
               Thread bThread = new Thread(factory.BuyMaterials);
               bThread.IsBackground = true;
               bThread.Start();
                //Without join - error in data (money < 0) - fixed (used lock in class)
              // bThread.Join();

             //   Task task = new Task(factory.BuyMaterials);
             //   if (factory.MoneyCount >= factory.c.CostBuyingMaterials)
             //   {
             //       //Task.WaitAll(task);
             //       task.Start();
             //   }

               // // ThreadPool.QueueUserWorkItem(factory.BuyMaterials); //need Object stateInfo in func
                Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBuyManufactory_Click(object sender, EventArgs e)
        {
            try
            { 
                //Background thread
                 Thread bMThread = new Thread(factory.BuyManufactory);
                 bMThread.IsBackground = true;
                 bMThread.Start();
                // bMThread.Join();
                 Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        
        private void btProduce_Click(object sender, EventArgs e)
        {
            try { 
                //Background thread
                 Thread pThread = new Thread(factory.Produce);
                 pThread.IsBackground = true;
                 pThread.Start();
                // pThread.Join();
                 Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btSellProduction_Click(object sender, EventArgs e)
        {
            try { 
                //Background thread
                 Thread sThread = new Thread(factory.SellProduction);
                 sThread.IsBackground = true;
                 sThread.Start();
                 //sThread.Join();
                 Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MainTimer_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                Thread serializeThread = new Thread(Serialize);
                serializeThread.IsBackground = true;
                serializeThread.Start();
            }
            UpdateInfo();
        }

    }
}
