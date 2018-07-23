using System;

namespace RomanNumeralConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int arabic = 1;
            Console.WriteLine($"Convert  arabic number '{arabic}' to numeral number : {RomanNumeralConverter.RomanFor(1)}");
            Console.ReadKey();
        }
    }
}
