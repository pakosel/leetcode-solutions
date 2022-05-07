using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GroupAnagrams
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string [] {""}, new List<IList<string>> {new string [] {""}}},
            new object[] {new string [] {"a"}, new List<IList<string>> {new string [] {"a"}}},
            new object[] {new string [] {"eat","tea","tan","ate","nat","bat"}, new List<IList<string>> {new string [] {"bat"},new string [] {"tan","nat"},new string [] {"eat","tea","ate"}}},
            new object[] {new string [] {"ac","d"}, new List<IList<string>> {new string [] {"ac"},new string [] {"d"}}},
            new object[] {new string [] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"}, new List<IList<string>> {new string [] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"},new string [] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"}}},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] arr, IList<IList<string>> expected)
        {
            var sol = new Solution();
            var res = sol.GroupAnagrams(arr);

            CollectionAssert.AreEquivalent(res, expected);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Slow(string[] arr, IList<IList<string>> expected)
        {
            var sol = new Solution_Slow();
            var res = sol.GroupAnagrams(arr);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}