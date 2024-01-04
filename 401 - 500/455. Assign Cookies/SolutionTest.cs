using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AssignCookies
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3]", "[1,1]", 1},
            new object[] {"[1,2]", "[1,2,3]", 2},
            new object[] {"[1,2,3]", "[]", 0},
            new object[] {"[1,2,3]", "[5,1]", 2},
            new object[] {"[1,2,33]", "[11]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gStr, string sStr, int expected)
        {
            var g = ArrayHelper.ArrayFromString<int>(gStr);
            var s = ArrayHelper.ArrayFromString<int>(sStr);

            var sol = new Solution();
            var res = sol.FindContentChildren(g, s);

            Assert.AreEqual(expected, res);
        }
    }
}