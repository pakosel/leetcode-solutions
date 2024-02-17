using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ContainsDuplicateII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,1]", 3, true},
            new object[] {"[1,0,1,1]", 1, true},
            new object[] {"[1,2,3,1,2,3]", 2, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Solution(string numsStr, int k, bool expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.ContainsNearbyDuplicate(nums, k);
            
            Assert.That(expected == res);
        }
    }
}