using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SpecialArrayWithXelementsGreaterThanOrEqualX
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,5]", 2},
            new object[] {"[0,0]", -1},
            new object[] {"[0,4,3,0,4]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.SpecialArray(nums);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}