using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EarliestPossibleDayOfFullBloom
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,4,3]", "[2,3,1]", 9},
            new object[] {"[1,2,3,2]", "[2,1,2,1]", 9},
            new object[] {"[1]", "[1]", 2},
            new object[] {"[988,725,459,596,553,944,179,638,630,636,794,363,714,242,822,971,31,366,996,179,757,580,157,588,225,574,383,294,915,769,167,742,279,473,762,766,941,172,118,824,354,559,488,936,392,817,253,284,8,294,439,295,134,43,153,74,44,119,808,637,92,375,76,738,81,240,87,195,766,383,684,947,646,24,99,680,560,981,501,189,717,983,559,708,35,880,943,807,150,355,735,989,473,198,135,778,436,373,479,653]", "[996,874,860,20,766,189,540,600,888,794,117,504,651,19,39,161,995,205,383,245,388,849,912,15,382,343,601,539,981,430,368,231,882,866,271,148,760,565,812,79,31,273,767,490,561,765,705,238,523,716,949,623,210,422,127,144,430,480,146,543,533,613,852,442,795,492,596,987,392,397,832,347,523,809,529,140,471,181,453,658,209,642,386,302,226,504,311,834,185,303,599,658,361,117,64,669,509,879,510,568]", 49188},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string plantTimeStr, string growTimeStr, int expected)
        {
            var plantTime = ArrayHelper.ArrayFromString<int>(plantTimeStr);
            var growTime = ArrayHelper.ArrayFromString<int>(growTimeStr);

            var sol = new Solution();
            var res = sol.EarliestFullBloom(plantTime, growTime);

            Assert.AreEqual(expected, res);
        }
    }
}