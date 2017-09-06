using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AnalyzingNumbers
    {
        public ISortable SortBehaviour;
        public IPrintable PrintBehaviour;
        private static int _length=50;
        private double[] array = new double[_length];
        public AnalyzingNumbers()
        {
            Generate();
            SortBehaviour = new InsertSort();
            PrintBehaviour = new ConsolePrint();
        }
        private void Generate()
        {
            var random = new Random();
            for (int i = 0; i < _length; i++)
                array[i] = random.Next(0,100);
        }
        public void Sort()
        {
            array = SortBehaviour.Sort(array);
        }
        public void Print()
        {
            PrintBehaviour.Print(array);
        }
    }
}
