using NUnit.Framework;

namespace MaxProfit
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {5, 11, 3, 50, 60, 90}, 2, 93)]
        [TestCase(new int[] {5, 11, 3, 50, 60, 90}, 3, 93)]
        [TestCase(new int[] {1, 10}, 1, 9)]
        [TestCase(new int[] {1, 10}, 3, 9)]
        [TestCase(new int[] {3, 2, 5, 7, 1, 3, 7}, 1, 6)]
        [TestCase(new int[] {5, 11, 3, 50, 40, 90}, 2, 97)]
        [TestCase(new int[] {5, 11, 3, 50, 40, 90}, 3, 103)]
        [TestCase(new int[] {50, 25, 12, 4, 3, 10, 1, 100}, 2, 106)]
        [TestCase(new int[] {100, 99, 98, 97, 1}, 5, 0)]
        [TestCase(new int[] {1, 100, 2, 200, 3, 300, 4, 400, 5, 500}, 5, 1485)]
        [TestCase(new int[] {1, 100, 101, 200, 201, 300, 301, 400, 401, 500}, 5, 499)]
        [TestCase(new int[] {1, 25, 24, 23, 12, 36, 14, 40, 31, 41, 5}, 4, 84)]
        [TestCase(new int[] {1, 25, 24, 23, 12, 36, 14, 40, 31, 41, 5}, 2, 62)]
        public void Test_Examples(int[] prices, int k, int expected)
        {
            var ret = Solution.MaxProfitWithKTransactions(prices, k);
            
            Assert.AreEqual(ret, expected);
        }
    }
}