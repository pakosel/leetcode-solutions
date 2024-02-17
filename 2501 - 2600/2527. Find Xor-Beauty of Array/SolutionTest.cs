using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindXorBeautyOfArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,4]", 5},
            new object[] {"[15,45,20,2,34,35,5,44,32,30]", 34},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.XorBeauty(nums);

            Assert.That(expected == res);
        }
    }
}