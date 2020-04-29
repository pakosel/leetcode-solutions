using NUnit.Framework;

namespace BalancedSplit
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1,5,7,1}, true)]
        [TestCase(new int[] {12,7,6,7,6}, false)]
        [TestCase(new int[] {1,2,3,5}, false)]
        [TestCase(new int[] {3,3,3,4,5}, true)]
        [TestCase(new int[] {3,3,3,3,6}, false)]
        [TestCase(new int[] {-5,0,3,3,5}, false)]
        [TestCase(new int[] {-1,0,1}, false)]
        public void Test_Examples(int[] nums, bool expected)
        {
            var ret = Solution.balancedSplitExists(nums);
            
            Assert.AreEqual(ret, expected);
        }
    }
}