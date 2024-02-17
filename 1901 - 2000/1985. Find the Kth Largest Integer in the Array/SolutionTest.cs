using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheKthLargestIntegerInTheArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"3","6","7","10"}, 4, "3"},
            new object[] {new string[] {"2","21","12","1"}, 3, "2"},
            new object[] {new string[] {"0","0"}, 2, "0"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] nums, int k, string expected)
        {
            var sol = new Solution();
            var res = sol.KthLargestNumber(nums, k);

            Assert.That(expected == res);
        }
    }
}