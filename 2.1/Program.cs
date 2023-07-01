using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valueA = 3; double valueB = 3; double valueE = 1.5;
            double valueC = valueA + valueB + valueE;

            double valueD = 7.5; double valueI = 3;
            double valueJ = valueD / valueI;
           
            Console.WriteLine( valueC);
            Console.WriteLine(valueJ);

            Console.ReadKey();
            

        }
    }
}
