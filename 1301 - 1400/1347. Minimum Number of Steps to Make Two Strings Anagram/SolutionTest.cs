using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfStepsToMakeTwoStringsAnagram

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"bab", "aba", 1},
            new object[] {"leetcode", "practice", 5},
            new object[] {"anagram", "mangaar", 0},
            new object[] {"aaa", "bbb", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, string t, int expected)
        {
            var sol = new Solution();
            var res = sol.MinSteps(s, t);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}