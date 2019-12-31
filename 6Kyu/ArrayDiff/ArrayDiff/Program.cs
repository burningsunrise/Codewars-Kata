using System;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            var returnedArray = Kata.Difference(new int[] {1, 2, 2, 2, 3}, new int[] {2});
            foreach (var item in returnedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}