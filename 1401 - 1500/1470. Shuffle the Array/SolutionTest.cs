using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ShuffleTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,5]", 1, "[2,5]"},
            new object[] {"[2,5,1,3,4,7]", 3, "[2,3,5,4,1,7]"},
            new object[] {"[1,2,3,4,4,3,2,1]", 4, "[1,4,2,3,3,2,4,1]"},
            new object[] {"[1,1,2,2]", 2, "[1,2,1,2]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int n, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            Assert.That(nums.Length == 2*n);
            Assert.That(expected.Length == 2*n);

            var sol = new Solution();
            var res = sol.Shuffle(nums, n);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}