using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LargestOddNumberInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"52", "5"},
            new object[] {"4206", ""},
            new object[] {"35427", "35427"},
            new object[] {"24682468246837924683572468", "2468246824683792468357"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string num, string expected)
        {
            var sol = new Solution();
            var res = sol.LargestOddNumber(num);

            Assert.AreEqual(expected, res);
        }
    }
}