using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BreakPalindrome
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", ""},
            new object[] {"x", ""},
            new object[] {"abccba", "aaccba"},
            new object[] {"aa", "ab"},
            new object[] {"aaa", "aab"},
            new object[] {"aaaa", "aaab"},
            new object[] {"aaaaa", "aaaab"},
            new object[] {"aba", "abb"},
            new object[] {"abba", "aaba"},
            new object[] {"aabaa", "aabab"},
            new object[] {"fgasdfsdfsdfxcvcxfdsfdsfdsagf", "agasdfsdfsdfxcvcxfdsfdsfdsagf"},
            new object[] {"piowjsefajhksdafoyweqrjkbsdvbnsbdzvaioaaaoiavzdbsnbvdsbkjrqewyofadskhjafesjwoip", "aiowjsefajhksdafoyweqrjkbsdvbnsbdzvaioaaaoiavzdbsnbvdsbkjrqewyofadskhjafesjwoip"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string palindrome, string expected)
        {
            var sol = new Solution();
            var res = sol.BreakPalindrome(palindrome);

            Assert.AreEqual(expected, res);
        }
    }
}