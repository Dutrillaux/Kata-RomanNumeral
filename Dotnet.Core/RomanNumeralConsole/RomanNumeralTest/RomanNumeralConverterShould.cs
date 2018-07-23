using NUnit.Framework;
using RomanNumeralConsole;

namespace RomanNumeralTest
{
    public class RomanNumeralConverterShould
    {
        [Test]
        public void Convert_arabic_numbers_into_their_respective_roman_numeral()
        {
            const string assertedRoman = "I";
            var roman = RomanNumeralConverter.RomanFor(1);
            Assert.AreEqual(roman, assertedRoman, $"Arabic conversion should be {assertedRoman} instead of {roman}");
        }
    }
}
