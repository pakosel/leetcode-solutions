using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DecodeString

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"a", "a"},
            new object[] {"a2[b]", "abb"},
            new object[] {"1[abc]", "abc"},
            new object[] {"3[abc]", "abcabcabc"},
            new object[] {"3[a]2[bc]", "aaabcbc"},
            new object[] {"3[a2[c]]", "accaccacc"},
            new object[] {"2[abc]3[cd]ef", "abcabccdcdcdef"},
            new object[] {"abc3[cd]xyz", "abccdcdcdxyz"},
            new object[] {"a2[3[c]]", "acccccc"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, string expected)
        {
            var sol = new Solution();
            var res = sol.DecodeString(s);

            Assert.AreEqual(res, expected);
        }       
    }
}