using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using System;

namespace MinimumCostForTickets
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,4,6,7,8,20]", "[2,7,15]", 11},
            new object[] {"[1,2,3,4,5,6,7,8,9,10,30,31]", "[2,7,15]", 17},
            new object[] {"[3,5,6,8,9,10,11,12,13,14,15,16,20,21,23,25,26,27,29,30,33,34,35,36,38,39,40,42,45,46,47,48,49,51,53,54,56,57,58,59,60,61,63,64,67,68,69,70,72,74,77,78,79,80,81,82,83,84,85,88,91,92,93,96]", "[3,17,57]", 170},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string daysStr, string costsStr, int expected)
        {
            var days = ArrayHelper.ArrayFromString<int>(daysStr);
            var costs = ArrayHelper.ArrayFromString<int>(costsStr);

            var sol = new Solution();
            var res = sol.MincostTickets(days, costs);

            Assert.That(expected == res);
        }
    }
}