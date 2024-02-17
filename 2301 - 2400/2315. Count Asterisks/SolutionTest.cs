using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountAsterisks
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"l|*e*et|c**o|*de|", 2},
            new object[] {"iamprogrammer", 0},
            new object[] {"yo|uar|e**|b|e***au|tifu|l", 5},
            new object[] {"*", 1},
            new object[] {"||", 0},
            new object[] {"|*|", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.CountAsterisks(s);

            Assert.That(expected == res);
        }
    }
}