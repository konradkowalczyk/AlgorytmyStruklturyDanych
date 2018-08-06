using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarnaReprezentacja
{
    public static class BinaryConverter
    {
        public static string ConvertInt(int numberToConvert)
        {
            var result = "";
            while (numberToConvert != 0)
            {
                var partialBinaryDigit = numberToConvert % 2;
                numberToConvert = numberToConvert / 2;

                result = partialBinaryDigit + result;
            }
            return result;
        }
    }
}

