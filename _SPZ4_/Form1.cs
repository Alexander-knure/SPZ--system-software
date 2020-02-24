using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _SPZ4_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
 
        public string text;
        public double min = 0, max = 0;
        public List<double> numbers = new List<double>();
        public int maxIdx, minIdx;

        private void click_Open(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "txt files|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                text = File.ReadAllText(filename);
                textBox1.Text = text;
                var strNumbers = text.Split(new char[] { ' ', ',' });


                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                foreach (var element in strNumbers)
                {
                    if (double.TryParse(element, out double Result))
                    {
                        numbers.Add(Result);
                    }

                }

               // numbers.Min();
               // numbers.Max();
                for(int i = 0; i < numbers.Count; i++)
                {
                    if (min > numbers[i])
                    {
                        minIdx = i;
                        min = numbers[i];
                    }
                    else if (max < numbers[i])
                    {
                        maxIdx = i;
                        max = numbers[i];
                    }
                }

                lbOutMin.Text = min.ToString();
                lbOutMax.Text = max.ToString();
                numbers.ToList();
            }
        }

        private void click_Save(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.Filter = "txt files|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = save.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("The file saved");
        }

        private void click_Swap(object sender, EventArgs e)
        {
            foreach (var el in numbers)
            {
                if (el == min)
                    minIdx = numbers.IndexOf(el);

                if (el == max)
                    maxIdx = numbers.IndexOf(el);
            }

            numbers[maxIdx] = min;
            numbers[minIdx] = max;
            string combindedString = string.Join(", ", numbers.ToArray());
            textBox1.Text = combindedString;
        }
    }
}
