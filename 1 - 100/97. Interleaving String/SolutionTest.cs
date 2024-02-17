using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace InterleavingString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"aabcc", "dbbca", "aadbbcbcac", true},
            new object[] {"aabcc", "dbbca", "aadbbbaccc", false},
            new object[] {"", "", "", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string s1, string s2, string s3, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsInterleave(s1, s2, s3);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}