using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumValueToGetPositiveStepByStepSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 1},
            new object[] {"[-1]", 2},
            new object[] {"[-100]", 101},
            new object[] {"[100]", 1},
            new object[] {"[-3,2,-3,4,2]", 5},
            new object[] {"[1,2]", 1},
            new object[] {"[1,-2,-3]", 5},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrayStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(arrayStr);

            var sol = new Solution();
            var ret = sol.MinStartValue(nums);

            Assert.That(expected == ret);
        }
    }
}