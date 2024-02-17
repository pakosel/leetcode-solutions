using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace HouseRobber2
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1}, 1)]
        [TestCase(new int[] {1,2}, 2)]
        [TestCase(new int[] {2,3,2}, 3)]
        [TestCase(new int[] {1,2,3,1}, 4)]
        [TestCase(new int[] {2,7,9,3,1}, 11)]
        [TestCase(new int[] {3,2,5,2,6,11,10}, 21)]
        [TestCase(new int[] {2,1,1,2}, 3)]
        [TestCase(new int[] {4,1,2}, 4)]
        public void Test_Example(int[] prices, int expected)
        {
            var sol = new Solution();
            var ret = sol.Rob(prices);

            Assert.That(expected == ret);
        }
    }
}