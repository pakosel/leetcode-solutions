using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace LargestRectangleHistogram
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { new int[] {}, 0 },
            new object[] { new int[] {1}, 1 },
            new object[] { new int[] {1,2,4,5,3,4}, 12 },
            new object[] { new int[] {2,3,1,0,3,4}, 6 },
            new object[] { new int[] {2,0,0,0,5}, 5 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[] heights, int expected)
        {
            var sol = new Solution();
            var res = sol.LargestRectangleArea(heights);

            Assert.That(expected == res);
        }
    }
}