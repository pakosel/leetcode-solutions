using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumSpeedToArriveOnTime
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,2]", 6, 1},
            new object[] {"[1,3,2]", 2.7, 3},
            new object[] {"[1,3,2]", 1.9, -1},
            new object[] {"[1,1,100000]", 2.01, 10000000},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string distStr, double hour, int expected)
        {
            var dist = ArrayHelper.ArrayFromString<int>(distStr);

            var sol = new Solution();
            var res = sol.MinSpeedOnTime(dist, hour);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}