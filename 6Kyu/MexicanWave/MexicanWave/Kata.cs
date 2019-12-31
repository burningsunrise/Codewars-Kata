using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace MexicanWave
{
    public class Kata
    {
        public static List<string> Wave(string str)
        {
            var waveList = new List<string>();
            var split = str.ToCharArray();
            for (var i = 0; i < str.Length; i++)
            {
                if (i > 0)
                    split[i - 1] = char.ToLower(split[i - 1]);
                split[i] = char.ToUpper(split[i]);
                var joined = string.Join("", split);
                if (split[i] != ' ')
                    waveList.Add(joined);
            }
            return waveList;
        }
    }
}