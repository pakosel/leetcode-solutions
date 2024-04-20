using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumOddBinaryNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"010", "001"},
            new object[] {"0101", "1001"},
            new object[] {"110010101000101001010010", "111111111000000000000001"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.MaximumOddBinaryNumber(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}