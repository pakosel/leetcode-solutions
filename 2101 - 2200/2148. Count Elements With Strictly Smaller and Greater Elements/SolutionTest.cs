using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountElementsWithStrictlySmallerAndGreaterElements
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[11,7,2,15]", 2},
            new object[] {"[-3,3,3,90]", 2},
            new object[] {"[-2,0,34,99,13,1234]", 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.CountElements(nums);

            Assert.That(expected == res);
        }
    }
}