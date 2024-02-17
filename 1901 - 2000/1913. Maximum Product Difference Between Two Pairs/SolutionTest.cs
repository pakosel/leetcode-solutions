using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumProductDifferenceBetweenTwoPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4]", 10},
            new object[] {"[4,3,2,1]", 10},
            new object[] {"[4,4,4,4]", 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MaxProductDifference(nums);

            Assert.That(expected == res);
        }
    }
}