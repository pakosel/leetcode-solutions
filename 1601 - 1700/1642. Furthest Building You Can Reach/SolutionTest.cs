using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FurthestBuildingYouCanReach
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4,2,7,6,9,14,12]", 5, 1, 4},
            new object[] {"[4,12,2,7,3,18,20,3,19]", 10, 2, 7},
            new object[] {"[14,3,19,3]", 17, 0, 3},
            new object[] {"[7,1,100,101,102,104,200]", 10, 1, 5},
            new object[] {"[7,1,100,101,102,104,200]", 10, 2, 6},
            new object[] {"[7,1,100,101,102,104,200]", 1000, 7, 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string heightsStr, int bricks, int ladders, int expected)
        {
            var heights = ArrayHelper.ArrayFromString<int>(heightsStr);

            var sol = new Solution();
            var res = sol.FurthestBuilding(heights, bricks, ladders);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}