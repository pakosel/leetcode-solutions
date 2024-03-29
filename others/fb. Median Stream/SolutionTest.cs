using System;
using NUnit.Framework;

namespace MedianStream
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(new int[] {5, 15, 1, 3}, new int[] {5, 10, 5, 4})]
        [TestCase(new int[] {1, 2}, new int[] {1, 1})]
        public void Test_Examples(int[] arr, int[] expected)
        {
            var res = Solution.findMedian(arr);
            
            Assert.That(res, Is.EqualTo(expected));
        }
    }
}