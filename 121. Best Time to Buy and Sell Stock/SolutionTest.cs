using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace BestTimeToBuyStock
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {7,1,5,3,6,4}, 5)]
        [TestCase(new int[] {7,6,4,3,1}, 0)]
        public void Test_Example(int[] prices, int expected)
        {
            var sol = new Solution();
            var ret = sol.MaxProfit(prices);

            Assert.AreEqual(ret, expected);
        }
    }
}