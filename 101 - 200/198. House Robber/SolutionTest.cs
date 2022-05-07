using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace HouseRobber
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1}, 1)]
        [TestCase(new int[] {1,2,3,1}, 4)]
        [TestCase(new int[] {2,7,9,3,1}, 12)]
        [TestCase(new int[] {3,2,5,2,6,11}, 19)]
        [TestCase(new int[] {3,2,5,2,6,11,10}, 24)]
        [TestCase(new int[] {2,1,1,2}, 4)]
        public void Test_Example(int[] prices, int expected)
        {
            var sol = new Solution();
            var ret = sol.Rob(prices);

            Assert.AreEqual(ret, expected);
        }
    }
}