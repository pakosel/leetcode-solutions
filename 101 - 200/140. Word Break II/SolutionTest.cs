using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace WordBreakII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"catsanddog", new string[] {"cat", "cats", "and", "sand", "dog"}, new string[] {"cats and dog", "cat sand dog"}},
            new object[] {"pineapplepenapple", new string[] {"apple", "pen", "applepen", "pine", "pineapple"}, new string[] {"pine apple pen apple","pineapple pen apple","pine applepen apple"}},
            new object[] {"catsandog", new string[] {"cats", "dog", "sand", "and", "cat"}, new string[] {}},
            new object[] {"a", new string[] {}, new string[] {}},
            new object[] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new string[] {"a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa"}, new string[] {}},
            new object[] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new string[] {"aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa","ba"}, new string[] {}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, IList<string> wordDict, IList<string> expected)
        {
            var sol = new Solution();
            var res = sol.WordBreak(s, wordDict);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}