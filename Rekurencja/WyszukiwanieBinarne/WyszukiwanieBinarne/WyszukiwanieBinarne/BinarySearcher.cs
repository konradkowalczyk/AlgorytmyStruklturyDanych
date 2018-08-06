using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyszukiwanieBinarne
{
    public class BinarySearcher
    {
        public int? searchForNumber(int[] table, int desiredNumber, int leftBorder, int rightBorder)
        {
            while (leftBorder != rightBorder)
            {
                var checkedPosition = (int)Math.Ceiling((double)(leftBorder + rightBorder) / 2);
                if (table[checkedPosition] == desiredNumber)
                    return checkedPosition;
                else if (table[checkedPosition] > desiredNumber && leftBorder != rightBorder)
                {
                    rightBorder = checkedPosition; 
                }
                else if (leftBorder != rightBorder)
                {
                    leftBorder = checkedPosition;
                }
            }
            return null;

        }
    }
}
