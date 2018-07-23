using System.Collections.Generic;

namespace RomanNumeralConsole
{
    public class RomanNumeralConverter
    {
        public static string RomanFor(int arabic)
        {
            var roman = string.Empty;

            foreach (var arabicToRoman in ArabicToRomans)
            {
                while (arabic >= arabicToRoman.Arabic)
                {
                    roman += arabicToRoman.Roman;
                    arabic -= arabicToRoman.Arabic;
                }
            }

            return roman;
        }

        private static readonly List<ArabicToRoman> ArabicToRomans = new List<ArabicToRoman>
        {
            new ArabicToRoman(1000, "M"),
            new ArabicToRoman(900, "CM"),
            new ArabicToRoman(500, "D"),
            new ArabicToRoman(400, "CD"),
            new ArabicToRoman(100, "C"),
            new ArabicToRoman(90, "XC"),
            new ArabicToRoman(50, "L"),
            new ArabicToRoman(40, "XL"),
            new ArabicToRoman(10, "X"),
            new ArabicToRoman(9, "IX"),
            new ArabicToRoman(5, "V"),
            new ArabicToRoman(4, "IV"),
            new ArabicToRoman(1, "I")
        };

        private struct ArabicToRoman
        {
            internal readonly int Arabic;
            internal readonly string Roman;

            internal ArabicToRoman(int arabic, string roman)
            {
                Arabic = arabic;
                Roman = roman;
            }
        }
    }
}