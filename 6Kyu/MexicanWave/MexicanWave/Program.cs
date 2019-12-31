using System;

namespace MexicanWave
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = Kata.Wave("hello");
            foreach (var item in kata)
                Console.WriteLine(item);
        }
    }
}