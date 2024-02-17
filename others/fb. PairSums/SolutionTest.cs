using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace PairSums
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 3}, 6, 2)]
        [TestCase(new int[] {1, 5, 3, 3, 3}, 6, 4)]
        [TestCase(new int[] {}, 1, 0)]
        [TestCase(new int[] {1}, 3, 0)]
        [TestCase(new int[] {1}, 1, 0)]
        [TestCase(new int[] {1, 7}, 8, 1)]
        public void Test_Examples(int[] arr, int k, int expected)
        {
            var ret = Solution.numberOfWays(arr, k);
            
            ClassicAssert.AreEqual(ret, expected);
        }
    }
}