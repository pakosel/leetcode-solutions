using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindPolygonWithTheLargestPerimeter
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,5,5]", 15},
            new object[] {"[1,12,1,2,5,50,3]", 12},
            new object[] {"[5,5,50]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            
            var sol = new Solution();
            var res = sol.LargestPerimeter(nums);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}