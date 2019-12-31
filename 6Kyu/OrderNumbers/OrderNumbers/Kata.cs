using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNumbers
{
    class Kata
    {
        public static string Order(string words)
        {
            string[] splitWords = words.Split(' ');
            string[] newOrder = new string[splitWords.Length];
            for (int i = 0; i < splitWords.Length; i++)
            {
                foreach (var wordOrNum in splitWords[i])
                {
                    if (Char.IsNumber(wordOrNum))
                    {
                        newOrder[Convert.ToInt32(wordOrNum.ToString()) - 1] = splitWords[i];
                    }  
                }
            }
            return String.Join(" ", newOrder);
        }
    }
}
