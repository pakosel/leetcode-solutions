using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumNumberOfEventsThatCanBeAttendedII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2,4],[3,4,3],[2,3,1]]", 2, 7},
            new object[] {"[[1,2,4],[3,4,3],[2,3,10]]", 2, 10},
            new object[] {"[[1,1,1],[2,2,2],[3,3,3],[4,4,4]]", 3, 9},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string eventsStr, int k, int expected)
        {
            var events = ArrayHelper.MatrixFromString<int>(eventsStr);

            var sol = new Solution();
            var res = sol.MaxValue(events, k);

            Assert.That(expected == res);
        }
    }
}