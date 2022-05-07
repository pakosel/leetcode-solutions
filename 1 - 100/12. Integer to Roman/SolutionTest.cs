using NUnit.Framework;

namespace IntegerToRoman
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(58, "LVIII")]
        [TestCase(1994, "MCMXCIV")]
        public void Test_Examples(int num, string expected)
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(num);
            
            Assert.AreEqual(ret, expected);
        }

        [Test]
        [TestCase(40, "XL")]
        [TestCase(44, "XLIV")]
        [TestCase(90, "XC")]
        [TestCase(400, "CD")]
        [TestCase(2000, "MM")]
        public void Test_Special(int num, string expected)
        {
            var sol = new Solution();
            var ret = sol.IntToRoman(num);
            
            Assert.AreEqual(ret, expected);
        }
    }
}