using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PositionsInSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {5,7,7,8,8,10}, 8, new int[] {3, 4})]
        [TestCase(new int[] {5,7,7,8,8,10}, 6, new int[] {-1, -1})]
        [TestCase(new int[] {5,7,7,8,8,10}, 16, new int[] {-1, -1})]
        [TestCase(new int[] {}, 16, new int[] {-1, -1})]
        [TestCase(new int[] {5,7,7,8,8,10}, 9, new int[] {-1, -1})]
        [TestCase(new int[] {2,2}, 2, new int[] {0, 1})]
        [TestCase(new int[] {1,4}, 4, new int[] {1, 1})]
        [TestCase(new int[] {0,1,2,3,4,4,4}, 2, new int[] {2, 2})]
        public void Test_Example(int[] nums, int target, int[] expected)
        {
            var sol = new Solution();
            var ret = sol.SearchRange(nums, target);

            Assert.AreEqual(ret.Length, expected.Length);
            for(int i=0; i<ret.Length; i++)
                Assert.AreEqual(ret[i], expected[i]);
        }
    }
}