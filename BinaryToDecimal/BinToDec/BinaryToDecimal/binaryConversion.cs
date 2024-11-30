using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    internal class binaryConversion
    {
        internal static void binConv(string binaryInput)
        {
            int decimalValue = 0;
            int binaryLength = binaryInput.Length;

            for (int i = 0; i < binaryLength; i++)
            {
                
                char digit = binaryInput[binaryInput.Length - 1 - i];
                if (digit == '1')
                {
                    decimalValue += (int)Math.Pow(2, i);
                }
            }
            Console.WriteLine("Decimal Value: " + decimalValue);
        }
    }
}
