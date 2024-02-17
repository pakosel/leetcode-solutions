using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace WildcardMatching
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "a", "a", true },
            new object[] { "aa", "a", false },
            new object[] { "aa", "*", true },
            new object[] { "cb", "?a", false },
            new object[] { "adceb", "*a*b", true },
            new object[] { "acdcb", "a*c?b", false },
            new object[] { "a", "a*", true },
            new object[] { "a", "*", true },
            new object[] { "a", "?", true },
            new object[] { "ab", "?", false },
            new object[] { "ab", "??", true },
            new object[] { "ab", "?*", true },
            new object[] { "babaaababaabababbbbbbaabaabbabababbaababbaaabbbaaab", "***bba**a*bbba**aab**b", false },
            new object[] { "abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb", "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb", false },
            new object[] { "bbaaaabababaaabaabbabaabababaaabbaaaababbbbbbbbbaabbaababbaababbabbaabbbabababbababbaaaabaababaabbababbaabbabaaabaabaabaabbabbaaaababaaaabababbbbbabbabbbababbabbabbabbabbbbababaabaaababbaaabaabbbbbaaa", "bb*a*bbbb**ab***b**aba*aa**b*a*ab*aa**baaaab***ab*a*****bb*ab*a*ab****a**ab**a*a***bab*b**b*bb***abbabb", false },
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