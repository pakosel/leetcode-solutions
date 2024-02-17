using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MajorityElement
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[1,2,1]", 1},
            new object[] {"[2,2,1,1,1,2,2]", 2},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.MajorityElement(nums);

            Assert.That(expected == res);
        }
    }
}