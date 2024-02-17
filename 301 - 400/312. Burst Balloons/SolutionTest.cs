using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BurstBalloons
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0 },
            new object[] {"[1]", 1 },
            new object[] {"[3]", 3 },
            new object[] {"[3,4]", 16 },
            new object[] {"[3,1,5,8]", 167 },
            new object[] {"[4,0,7,8,1,0]", 272 },
            new object[] {"[4,7,8,1]", 272 },
            new object[] {"[2,4,8,4,0,7,8,9,1,2,4,7,1,7,3,6]", 3304 },
            new object[] {"[0,1,0,8,7,1,9,1,1,9,12,4]", 2985 },
            new object[] {"[8,2,6,8,9,8,1,4,1,5,3,0,7,7,0,4,2,2,5]", 3630 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string arrStr, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.MaxCoins(arr);

            Assert.That(expected == res);
        }
    }
}