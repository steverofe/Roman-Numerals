using Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roman_Numerals
{
    [TestClass]
    public class RomanNumeralTests
    {

        RomanNumeralConverter _converter = new RomanNumeralConverter();

        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        [DataRow(10, "X")]
        [DataRow(11, "XI")]
        [DataRow(12, "XII")]
        [DataRow(13, "XIII")]
        [DataRow(14, "XIV")]
        [DataRow(15, "XV")]
        [DataRow(16, "XVI")]
        [DataRow(17, "XVII")]
        [DataRow(18, "XVIII")]
        [DataRow(19, "XIX")]
        [DataRow(20, "XX")]
        [DataRow(21, "XXI")]
        [DataRow(29, "XXIX")]
        [DataRow(30, "XXX")]
        [DataRow(33, "XXXIII")]
        [DataRow(40, "XL")]
        [DataRow(44, "XLIV")]
        [DataRow(49, "XLIX")]
        [DataRow(50, "L")]
        [DataRow(51, "LI")]
        [DataRow(55, "LV")]
        [DataRow(60, "LX")]
        [DataRow(66, "LXVI")]
        [DataRow(70, "LXX")]
        [DataRow(77, "LXXVII")]
        [DataRow(80, "LXXX")]
        [DataRow(88, "LXXXVIII")]
        [DataRow(90, "XC")]
        [DataRow(91, "XCI")]
        [DataRow(92, "XCII")]
        [DataRow(93, "XCIII")]
        [DataRow(94, "XCIV")]
        [DataRow(95, "XCV")]
        [DataRow(96, "XCVI")]
        [DataRow(97, "XCVII")]
        [DataRow(98, "XCVIII")]
        [DataRow(99, "XCIX")]
        [DataRow(100, "C")]
        [DataRow(200, "CC")]
        [DataRow(300, "CCC")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(600, "DC")]
        [DataRow(700, "DCC")]
        [DataRow(800, "DCCC")]
        [DataRow(900, "CM")]
        [DataRow(1000, "M")]
        [DataRow(1490, "MCDXC")]
        [DataRow(1480, "MCDLXXX")]
        [DataRow(1580, "MDLXXX")]
        [DataRow(1590, "MDXC")]
        [DataRow(1594, "MDXCIV")]
        [DataRow(1294, "MCCXCIV")]
        [DataRow(1990, "MCMXC")]
        [DataRow(1991, "MCMXCI")]
        [DataRow(1992, "MCMXCII")]
        [DataRow(1993, "MCMXCIII")]
        [DataRow(1994, "MCMXCIV")]
        [DataRow(1995, "MCMXCV")]
        [DataRow(1996, "MCMXCVI")]
        [DataRow(1997, "MCMXCVII")]
        [DataRow(1998, "MCMXCVIII")]
        [DataRow(1999, "MCMXCIX")]
        [DataRow(2000, "MM")]
        [DataTestMethod]
        public void GivenIntegerReturnsCorrectRomanNumeral(int numberToConvert, string RomanNumeral)
        {
            var actual = _converter.ConvertIntegerToRomanNumeral(numberToConvert);
            Assert.AreEqual(RomanNumeral, actual);
        }
    }
}

