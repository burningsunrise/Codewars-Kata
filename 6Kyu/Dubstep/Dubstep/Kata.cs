using System;
using System.Linq;

namespace Dubstep
{
    public class Kata
    {
        public static string SongDecoder(string input)
        {
            var split = input.Split("WUB");
            split = split.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return string.Join(" ", split);
        }
    }
}