using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace PartitionEqualSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {1,5,11,5}, true)]
        [TestCase(new int[] {1,2,3,5}, false)]
        [TestCase(new int[] {1,2,3,4,5,6,7}, true)]
        [TestCase(new int[] {2,3,5,7,10}, false)]
        [TestCase(new int[] {1,2,4,5,10}, true)]
        [TestCase(new int[] {1,2,5}, false)]
        [TestCase(new int[] {1,4,5}, true)]
        [TestCase(new int[] {2,2,3,5}, false)]
        [TestCase(new int[] {28,63,95,30,39,16,36,44,37,100,61,73,32,71,100,2,37,60,23,71,53,70,69,82,97,43,16,33,29,5,97,32,29,78,93,59,37,88,89,79,75,9,74,32,81,12,34,13,16,15,16,40,90,70,17,78,54,81,18,92,75,74,59,18,66,62,55,19,2,67,30,25,64,84,25,76,98,59,74,87,5,93,97,68,20,58,55,73,74,97,49,71,42,26,8,87,99,1,16,79}, true)]
        [TestCase(new int[] {7,36,41,74,96,24,73,65,15,47,75,92,68,25,58,11,26,55,5,16,96,92,47,96,24,42,20,92,92,1,72,20,54,2,18,80,50,37,13,11,23,80,82,72,55,95,56,91,39,90,83,91,44,41,18,48,96,97,45,4,70,36,40,27,34,25,38,27,7,80,69,87,30,99,72,96,64,59,72,74,15,66,80,63,33,28,50,26,54,46,3,81,48,84,97,85,51,41,14,19}, true)]
        public void Test_Example(int[] nums, bool expected)
        {
            var sol = new Solution();
            var ret = sol.CanPartition(nums);

            Assert.AreEqual(ret, expected);
        }
    }
}