using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurencjaOdwracanieTablicy
{
    public static class Odwracacz
    {
        public static int[] OdwrocTablice(int[] tablica)
        {
            var indeksOstatniejLiczby = tablica.Length - 1;
            ZamienLiczbe(tablica, 0, indeksOstatniejLiczby);
            return tablica;
        }

        public static void ZamienLiczbe(int[] tablica, int indeksPierwszaLiczba, int IndeksDrugaLiczba)
        {
            if (indeksPierwszaLiczba < IndeksDrugaLiczba)
            {
                int temp1 = tablica[indeksPierwszaLiczba];
                tablica[indeksPierwszaLiczba] = tablica[IndeksDrugaLiczba];
                tablica[IndeksDrugaLiczba] = temp1;

                ZamienLiczbe(tablica, indeksPierwszaLiczba + 1, IndeksDrugaLiczba - 1);
            }   
        }
    }
}
