using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountPrefixesOfGivenString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"a","b","c","ab","bc","abc"}, "abc", 3},
            new object[] {new string[] {"a","a"}, "aa", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] words, string s, int expected)
        {
            var sol = new Solution();
            var res = sol.CountPrefixes(words, s);

            Assert.AreEqual(expected, res);
        }
    }
}