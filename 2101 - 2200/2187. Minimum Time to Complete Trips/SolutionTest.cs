using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumTimeToCompleteTrips
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3]", 5, 3},
            new object[] {"[2]", 1, 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string timeStr, int totalTrips, long expected)
        {
            var time = ArrayHelper.ArrayFromString<int>(timeStr);

            var sol = new Solution();
            var res = sol.MinimumTime(time, totalTrips);

            Assert.That(expected == res);
        }
    }
}