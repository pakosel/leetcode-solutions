using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace RegularExpressionMatching
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "a", true },
            new object[] { "aa", "a", false },
            new object[] { "aa", "a*", true },
            new object[] { "cb", ".a", false },
            new object[] { "adceb", "a*dceb*", true },
            new object[] { "acdcb", "a*c*b", false },
            new object[] { "", "a*b*", true },
            new object[] { "", ".*", true },
            new object[] { "abcd", "a.*d", true },
            new object[] { "ab", "..", true },
            new object[] { "x", "a*b*c*xa*b*c*", true },
            new object[] { "y", "a*b*c*xa*b*c*", false },
            new object[] { "", "a*b*c*xa*b*c*", false },
            new object[] { "", "a*b*", true },
            new object[] { "abc", "abc.*", true },
            new object[] { "aasdfasdfasdfasdfas", "aasdf.*asdf.*asdf.*asdf.*s", true },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, string p, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsMatch(s, p);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}