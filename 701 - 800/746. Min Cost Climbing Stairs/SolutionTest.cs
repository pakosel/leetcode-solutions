using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinCostClimbingStairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[10,15,20]", 15},
            new object[] {"[1,100,1,1,1,100,1,1,100,1]", 6},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string costStr, int expected)
        {
            var cost = ArrayHelper.ArrayFromString<int>(costStr);

            var sol = new Solution();
            var res = sol.MinCostClimbingStairs(cost);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}