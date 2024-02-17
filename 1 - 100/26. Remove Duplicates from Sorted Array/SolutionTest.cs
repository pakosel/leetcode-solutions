using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveDuplicatesFromSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,1,2]", "[1,2]", 2},
            new object[] {"[0,0,1,1,1,2,2,3,3,4]", "[0,1,2,3,4]", 5},
            new object[] {"[1]", "[1]", 1},
            new object[] {"[1,1]", "[1]", 1},
            new object[] {"[1,1,1]", "[1]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, string expectedStr, int k)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.RemoveDuplicates(nums);

            ClassicAssert.AreEqual(res, expected.Length);
            for(int i=0; i<k; i++)
                ClassicAssert.AreEqual(nums[i], expected[i]);
        }
    }
}