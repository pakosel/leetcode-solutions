using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace OpenTheLock
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0201,0101,0102,1212,2002]", "0202", 6},
            new object[] {"[8888]", "0009", 1},
            new object[] {"[8887,8889,8878,8898,8788,8988,7888,9888]", "8888", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string deadendsStr, string target, int expected)
        {
            var deadends = ArrayHelper.ArrayFromString<string>(deadendsStr);

            var sol = new Solution();
            var res = sol.OpenLock(deadends, target);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}