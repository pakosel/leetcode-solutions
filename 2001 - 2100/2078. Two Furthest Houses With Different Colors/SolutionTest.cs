using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TwoFurthestHousesWithDifferentColors
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1,1,6,1,1,1]", 3},
            new object[] {"[1,8,3,8,3]", 4},
            new object[] {"[0,1]", 1},
            new object[] {"[1,2]", 1},
            new object[] {"[1,1,1,2,3,3,3,3,3]", 8},
            new object[] {"[1,1,8,3,8,3]", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string colorsStr, int expected)
        {
            var colors = ArrayHelper.ArrayFromString<int>(colorsStr);

            var sol = new Solution();
            var res = sol.MaxDistance(colors);

            Assert.That(expected == res);
        }
    }
}