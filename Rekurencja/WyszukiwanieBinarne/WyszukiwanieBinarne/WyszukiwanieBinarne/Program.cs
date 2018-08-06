using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyszukiwanieBinarne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var table = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17 };
            var indexOfFound = new BinarySearcher().searchForNumber(table, 15, 0, table.Length - 1).ToString();
            if (indexOfFound == "")
                indexOfFound = "Number not found";
            Console.WriteLine(indexOfFound);
            Console.ReadKey();
        }
    }
}
