using System.Linq;

namespace ArrayDiff
{
    public class Kata
    {
        public static int[] Difference (int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}