using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinarySubarraysWithSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,0,1,0,1]", 2, 4},
            new object[] {"[0,0,0,0,0]", 0, 15},
            new object[] {"[1,0,1,0,1,1,1,0,0,0,1]", 3, 12},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int goal, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.NumSubarraysWithSum(nums, goal);

            Assert.That(expected == res);
        }
    }
}