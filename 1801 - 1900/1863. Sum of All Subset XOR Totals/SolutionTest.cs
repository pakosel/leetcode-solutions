using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumOfAllSubsetXorTotals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3]", 6},
            new object[] {"[5,1,6]", 28},
            new object[] {"[3,4,5,6,7,8]", 480},
            new object[] {"[3,4,5,6,7,8,13,11,19,20,18,1]", 63488},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);

            var sol = new Solution();
            var res = sol.SubsetXORSum(nums);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}