using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

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
            var ret = Solution.findMedian(arr);
            Console.Out.WriteLine(string.Join(',', ret));
            
            ClassicAssert.AreEqual(ret, expected);
        }
    }
}