using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AddBinary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"0", "0", "0"},
            new object[] {"1", "1", "10"},
            new object[] {"11", "1", "100"},
            new object[] {"1010", "1011", "10101"},
            new object[] {"1111111111111111111111", "10101111111010110101101111111111011010110101", "10101111111010110101111111111111011010110100"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string a, string b, string expected)
        {
            var sol = new Solution();
            var res = sol.AddBinary(a, b);

            Assert.That(expected == res);
        }
    }
}