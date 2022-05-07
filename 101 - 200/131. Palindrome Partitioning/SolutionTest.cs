using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PalindromePartitioning
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"a", new string[][] {new string[] {"a"}} },
            new object[] {"aab", new string[][] {new string[]{"a","a","b"},new string[]{"aa","b"}} },
            new object[] {"aabaab", new string[][] {new string[]{"a","a","baab"},new string[]{"a","a","b","a","a","b"},new string[]{"a","a","b","aa","b"},new string[]{"a","aba","a","b"},new string[]{"aa","baab"},new string[]{"aa","b","a","a","b"},new string[]{"aa","b","aa","b"},new string[]{"aabaa","b"}} },
            new object[] {"axa", new string[][] {new string[]{"a","x","a"},new string[]{"axa"}} },
            new object[] {"aaaaaa", new string[][] {new string[]{"aaaaaa"},new string[]{"a","aaaaa"},new string[]{"a","a","aaaa"},new string[]{"a","a","a","aaa"},new string[]{"a","a","a","a","aa"},new string[]{"a","a","a","a","a","a"},new string[]{"a","a","a","aa","a"},new string[]{"a","a","aa","aa"},new string[]{"a","a","aa","a","a"},new string[]{"a","a","aaa","a"},new string[]{"a","aa","aaa"},new string[]{"a","aa","a","aa"},new string[]{"a","aa","a","a","a"},new string[]{"a","aa","aa","a"},new string[]{"a","aaa","aa"},new string[]{"a","aaa","a","a"},new string[]{"a","aaaa","a"},new string[]{"aa","aaaa"},new string[]{"aa","a","aaa"},new string[]{"aa","a","a","aa"},new string[]{"aa","a","a","a","a"},new string[]{"aa","a","aa","a"},new string[]{"aa","aa","aa"},new string[]{"aa","aa","a","a"},new string[]{"aa","aaa","a"},new string[]{"aaa","aaa"},new string[]{"aaa","a","aa"},new string[]{"aaa","a","a","a"},new string[]{"aaa","aa","a"},new string[]{"aaaa","aa"},new string[]{"aaaa","a","a"},new string[]{"aaaaa","a"}} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string s, string[][] expected)
        {
            var sol = new Solution();
            var res = sol.Partition(s);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}