using System;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace IQTest
{
    public class Kata
    {
        public static int Test(string numbers)
        {
            var split = numbers.Split(" ").Select(int.Parse).ToList();
            var evenNumbers = split.Where(x => x % 2 == 0).ToList();
            var oddNumbers = split.Where(x => x % 2 != 0).ToList();
            if (evenNumbers.Count < oddNumbers.Count)
                return split.IndexOf(evenNumbers[0]) + 1;
            else
                return split.IndexOf(oddNumbers[0]) + 1;
        }
    }
}