using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace FirstUniqueCharacterInString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"leetcode", 0},
            new object[] {"loveleetcode", 2},
            new object[] {"aabb", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(string s, int expected)
        {
            var sol = new Solution2023();
            var res = sol.FirstUniqChar(s);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.FirstUniqChar(s);

            Assert.AreEqual(expected, res);
        }
    }
}