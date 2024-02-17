using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LargestSubstringBetweenTwoEqualCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"aa", 0},
            new object[] {"abca", 2},
            new object[] {"cbzxy", -1},
            new object[] {"aabcdeba", 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxLengthBetweenEqualCharacters(s);

            Assert.That(expected == res);
        }
    }
}