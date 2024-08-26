using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SortArrayByIncreasingFrequency
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,1,2,2,2,3]", "[3,1,1,2,2,2]"},
            new object[] {"[2,3,1,3,2]", "[1,3,3,2,2]"},
            new object[] {"[-1,1,-6,4,5,-6,1,4,1]", "[5,-1,4,4,-6,-6,1,1,1]"},
            new object[] {"[-100,100,2,2,2,3]", "[100,3,-100,2,2,2]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FrequencySort(nums);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}