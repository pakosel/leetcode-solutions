using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace JumpGameVI
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,-1,-2,4,-7,3]", 2, 7},
            new object[] {"[10,-5,-2,4,0,3]", 3, 17},
            new object[] {"[1,-5,-20,4,-1,3,-6,-3]", 2, 0},
            new object[] {"[-2734,-5897,7420,-2451,5012,9264,-8731,-7117,2590,-9807]", 16, 11745},
            new object[] {"[-2734,-5897,7420,-2451,5012,9264,-8731,-7117,2590,-9807]", 3, 11745},
            new object[] {"[1]", 1, 1},
            new object[] {"[1,2]", 1, 3},
            new object[] {"[1,2]", 2, 3},
            new object[] {"[1,2,3]", 1, 6},
            new object[] {"[1,2,3]", 2, 6},
            new object[] {"[1,2,3]", 3, 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int k, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxResult(nums, k);

            Assert.That(expected == res);
        }
    }
}