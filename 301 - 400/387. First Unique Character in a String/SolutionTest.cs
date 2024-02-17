using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
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
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.FirstUniqChar(s);

            Assert.That(expected == res);
        }
    }
}