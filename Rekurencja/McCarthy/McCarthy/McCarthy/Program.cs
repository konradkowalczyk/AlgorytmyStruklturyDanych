using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCarthy
{
    class Program
    {
        static void Main(string[] args)
        {
            double executionCounter = 0;
            var x = McCarthy(100, ref executionCounter);
            Console.WriteLine(executionCounter);
            Console.ReadKey();
        }

        public static double McCarthy(double x, ref double executionCounter)
        {
            if (x > 100)
            {
                executionCounter++;
                return (x - 10);
            }
            else
            {
                executionCounter++;
                return McCarthy(McCarthy(x + 11, ref executionCounter), ref executionCounter);
            }
        }
    }
}
