using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace LargestTripleProduct
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5}, new int[] {-1, -1, 6, 24, 60})]
        [TestCase(new int[] {2, 1, 2, 1, 2}, new int[] {-1, -1, 4, 4, 8})]
        public void Test_Examples(int[] nums, int[] expected)
        {
            var ret = Solution.findMaxProduct(nums);
            ClassicAssert.AreEqual(ret, expected);
        }
    }
}