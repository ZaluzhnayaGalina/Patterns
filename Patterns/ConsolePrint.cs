using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ConsolePrint : IPrintable
    {
        public void Print(IList<double> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
