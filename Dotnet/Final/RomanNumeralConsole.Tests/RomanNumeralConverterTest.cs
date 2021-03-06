using NUnit.Framework;

namespace RomanNumeralConsole.Tests
{
    public class RomanNumeralConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(7, "VII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(17, "XVII")]
        [TestCase(30, "XXX")]
        [TestCase(38, "XXXVIII")]
        [TestCase(479, "CDLXXIX")]
        [TestCase(3999, "MMMCMXCIX")]
        public void Convert_arabic_numbers_into_their_respective_roman_numeral(int arabic, string romanAsserted)
        {
            var roman = RomanNumeralConverter.RomanFor(arabic);
            Assert.AreEqual(roman, romanAsserted, $"Arabic conversion should be {romanAsserted} instead of {roman}");
        }
    }
}
