using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisemvowelTrolls
{
    class Kata
    {
        public static string Disemvowel(string str)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            string newString = "";
            foreach (var word in str)
            {
                if (!vowels.Contains(Char.ToLower(word)))
                {
                    newString += word;
                }
            }
            return newString;
        }
    }
}
