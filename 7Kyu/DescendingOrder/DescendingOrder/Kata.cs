using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    class Kata
    {
        public static int DO(int num)
        {
            char[] numberArray = num.ToString().ToCharArray();

            Array.Sort(numberArray);
            Array.Reverse(numberArray);
            // Convert numberArray to a string then convert it to an int
            return Convert.ToInt32(new string(numberArray));
        }
    }
}
