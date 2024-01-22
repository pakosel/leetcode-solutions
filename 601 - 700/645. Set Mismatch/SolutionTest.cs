using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SetMismatch
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,2,4]", "[2,3]"},
            new object[] {"[1,1]", "[1,2]"},
            new object[] {"[1,2,3,4,4]", "[4,5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic24(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_2024();
            var res = sol.FindErrorNums(nums);

            CollectionAssert.AreEquivalent(expected, res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindErrorNums(nums);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}