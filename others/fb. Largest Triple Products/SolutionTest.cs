using NUnit.Framework;

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
            var res = Solution.findMaxProduct(nums);
            Assert.That(res, Is.EqualTo(expected));
        }
    }
}