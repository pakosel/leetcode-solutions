using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace IsSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", "", true },
            new object[] { "", "abc", true },
            new object[] { "bag", "", false },
            new object[] { "aa", "aaa",true  },
            new object[] { "rabbit", "rabbbit", true },
            new object[] { "bag", "babgbag", true },
            new object[] { "abc", "ahbgdc", true },
            new object[] { "axc", "ahbgdc", false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string t, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsSubsequence(s, t);

            Assert.AreEqual(expected, res);
        }
    }
}