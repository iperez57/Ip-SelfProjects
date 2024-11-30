using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    internal class isBinary
    {
        internal static bool IsBinary(string binaryInput)
        {
            foreach (char c in binaryInput)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
