using NUnit.Framework;

namespace SlowSums
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {4, 2, 1, 3}, 23)]
        [TestCase(new int[] {4}, 0)]
        //[TestCase(new int[] {}, 0)]
        [TestCase(new int[] {4, 3}, 7)]
        [TestCase(new int[] {4, 3, 2, 1, 1, 1, 9}, 85)]
        public void Test_Examples(int[] arr, int expected)
        {
            var ret = Solution.getTotalTime(arr);
            
            Assert.AreEqual(ret, expected);
        }
    }
}