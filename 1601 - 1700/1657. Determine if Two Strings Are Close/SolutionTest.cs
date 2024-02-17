using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DetermineIfTwoStringsAreClose
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"abc", "bca", true},
            new object[] {"a", "aa", false},
            new object[] {"cabbba", "abbccc", true},
            new object[] {"aaab", "xxyy", false},
            new object[] {"abcd", "xxyy", false},
            new object[] {"uau", "ssx", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string word1, string word2, bool expected)
        {
            var sol = new Solution();
            var res = sol.CloseStrings(word1, word2);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}