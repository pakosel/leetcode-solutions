using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SearchInsertPosition
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 0, 0},
            new object[] {"[1]", 1, 0},
            new object[] {"[1]", 2, 1},
            new object[] {"[1,3,5,6]", 5, 2},
            new object[] {"[1,3,5,6]", 2, 1},
            new object[] {"[1,3,5,6]", 7, 4},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int target, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.SearchInsert(nums, target);

            Assert.That(expected == res);
        }
    }
}