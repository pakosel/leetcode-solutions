using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MinimumCostToMoveChips
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 0},
            new object[] {"[1,2,3]", 1},
            new object[] {"[2,2,2,3,3]", 2},
            new object[] {"[1,1000000000]", 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            Assert.That(arr.Length > 0);

            var sol = new Solution();
            var res = sol.MinCostToMoveChips(arr);

            Assert.That(expected == res);
        }
    }
}