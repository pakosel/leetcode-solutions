using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace SortColors
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {2,0,2,1,1,0}, new int[] {0,0,1,1,2,2})]
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] {1}, new int[] {1})]
        [TestCase(new int[] {2,0,2,2,0,2,1,1,0,1,1,0,2,0,2,1,1,0,2,0,2,2,0,2,1,1,0,1,1,0}, new int[] {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2})]
        public void Test_Example(int[] nums, int[] expected)
        {
            var sol = new Solution();
            sol.SortColors(nums);

            Assert.That(nums.Length == expected.Length);
            for(int i=0; i<nums.Length; i++)
                Assert.That(nums[i] == expected[i]);
        }
    }
}