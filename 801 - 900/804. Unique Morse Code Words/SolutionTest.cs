using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace UniqueMorseCodeWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {}, 0},
            new object[] {new string[] { "a" }, 1},
            new object[] {new string[] { "gin", "zen", "gig", "msg" }, 2},
            new object[] {new string[] { "bac", "cab", "bac" }, 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.UniqueMorseRepresentations(words);

            Assert.AreEqual(res, expected);
        }
    }
}