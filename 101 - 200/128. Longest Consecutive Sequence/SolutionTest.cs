using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestConsecutiveSequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[100,4,200,1,3,2]", 4},
            new object[] {"[0,3,7,2,5,8,4,6,0,1]", 9},
            new object[] {"[1,2,0,1]", 3},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.LongestConsecutive(nums);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}