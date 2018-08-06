using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurencjaOdwracanieTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            var tablica = new int[] { 1, 2, 3,457,5,6,7,8,2319,10 };
            Odwracacz.OdwrocTablice(tablica);
            for (var i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("[" + tablica[i] + "]");
            }
            Console.ReadKey();
        }
    }
}
