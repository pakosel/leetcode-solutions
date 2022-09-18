using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountDaysSpentTogether
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"08-15","08-18","08-16","08-19", 3},
            new object[] {"10-01","10-31","11-01","12-31", 0},
            new object[] {"09-01","10-19","06-19","10-20", 49},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob, int expected)
        {
            var sol = new Solution();
            var res = sol.CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);

            Assert.AreEqual(expected, res);
        }
    }
}