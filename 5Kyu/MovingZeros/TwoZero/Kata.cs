using System;
using System.Linq;

namespace TwoZero
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var withoutZeroes = arr.Where(x => x != 0);
            var count = arr.Count(x => x == 0);
            var zeroList = Enumerable.Range(0, count).Select(x => 0).ToList();
            return withoutZeroes.Concat(zeroList).ToArray();
        }
    }
}