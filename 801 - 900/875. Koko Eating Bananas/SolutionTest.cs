using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KokoEatingBananas
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1, 1},
            new object[] {"[3,6,7,11]", 8, 4},
            new object[] {"[30,11,23,4,20]", 5, 30},
            new object[] {"[30,11,23,4,20]", 6, 23},
            new object[] {"[10]", 100, 1},
            new object[] {"[1,1,1,1]", 8, 1},
            new object[] {"[1,1,1,1]", 4, 1},
            new object[] {"[2,2,2,2]", 8, 1},
            new object[] {"[1,2,3,499999999,500000000]", 5, 500000000},
            new object[] {"[332484035,524908576,855865114,632922376,222257295,690155293,112677673,679580077,337406589,290818316,877337160,901728858,679284947,688210097,692137887,718203285,629455728,941802184]", 823855818, 14},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int h, int expected)
        {
            var piles = ArrayHelper.ArrayFromString<int>(strArr);

            var sol = new Solution();
            var res = sol.MinEatingSpeed(piles, h);

            Assert.That(expected == res);
        }
    }
}