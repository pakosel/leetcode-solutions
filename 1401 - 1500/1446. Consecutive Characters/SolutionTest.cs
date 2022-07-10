using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ConsecutiveCharacters

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", 1},
            new object[] {"aa", 2},
            new object[] {"leetcode", 2},
            new object[] {"abbcccddddeeeeedcba", 5},
            new object[] {"triplepillooooow", 5},
            new object[] {"hooraaaaaaaaaaay", 11},
            new object[] {"tourist", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxPower(s);

            Assert.AreEqual(expected, res);
        }
    }
}