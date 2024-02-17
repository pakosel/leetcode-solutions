using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ThreeSumClosest
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[-1,2,1,-4]", 1, 2 },
            new object[] { "[-1,0,1]", 1, 0 },
            new object[] { "[-1,2,1,-4,10,5,-200,150,164]", 1, 0 }
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Cases(string arrStr, int target, int expected)
        {
            var nums = ArrayHelper.ArrayFromString<int>(arrStr);
            
            var sol = new Solution();
            var res = sol.ThreeSumClosest(nums, target);

            Assert.That(expected == res);
        }
    }
}