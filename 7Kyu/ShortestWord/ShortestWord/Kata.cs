using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestWord
{
    class Kata
    {
        public static int FindShort(string s)
        {
            int shortest = int.MaxValue;
            foreach(var word in s.Split(' '))
            {
                if (word.Length < shortest)
                {
                    shortest = word.Length;
                }
            }
            return shortest;
        }
    }
}
