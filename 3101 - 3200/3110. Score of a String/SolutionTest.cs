using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ScoreOfString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"aa", 0},
            new object[] {"ab", 1},
            new object[] {"ba", 1},
            new object[] {"hello", 13},
            new object[] {"zaz", 50},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.ScoreOfString(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}