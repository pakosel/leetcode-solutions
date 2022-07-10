using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestPalindromeByConcatenatingTwoLetterWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"lc","cl","gg"}, 6},
            new object[] {new string[] {"ab","ty","yt","lc","cl","ab"}, 8},
            new object[] {new string[] {"cc","ll","xx"}, 2},
            new object[] {new string[] {"aa","dd","dd","aa","dd"}, 10},
            new object[] {new string[] {"aa","dd","dd","aa"}, 8},
            new object[] {new string[] {"dd","aa","bb","dd","aa","dd","bb","dd","aa","cc","bb","cc","dd","cc"}, 22},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] words, int expected)
        {
            var sol = new Solution();
            var res = sol.LongestPalindrome(words);

            Assert.AreEqual(expected, res);
        }
    }
}