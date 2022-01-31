using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KeepMultiplyingFoundValuesByTwo
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,3,6,1,12]", 3, 24},
            new object[] {"[2,7,9]", 4, 4},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int orignal, int expected)
        {
            var nums = ArrayHelper.ArrayFromString(numsStr);
            
            var sol = new Solution();
            var res = sol.FindFinalValue(nums, orignal);

            Assert.AreEqual(res, expected);
        }
    }
}