using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

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
        [TestCase(new int[] {65,66,63,46,68,103,3,84,65,98,18,100}, 5019)]
        public void Test_Examples(int[] arr, int expected)
        {
            var ret = Solution.getTotalTime(arr);
            
            ClassicAssert.AreEqual(ret, expected);
        }

        [Test]
        [TestCase(new int[] {4, 2, 1, 3}, 23)]
        [TestCase(new int[] {4}, 0)]
        //[TestCase(new int[] {}, 0)]
        [TestCase(new int[] {4, 3}, 7)]
        [TestCase(new int[] {4, 3, 2, 1, 1, 1, 9}, 85)]
        [TestCase(new int[] {65,66,63,46,68,103,3,84,65,98,18,100}, 5019)]
        public void Test_Naive(int[] arr, int expected)
        {
            var ret = Solution.getTotalTime_naive(arr);
            
            ClassicAssert.AreEqual(ret, expected);
        }

        [Test]
        public void Test_Random()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            var len = rnd.Next(5, 30);
            int[] arr = new int[len];
            for(int i=0; i<len; i++)
                arr[i] = rnd.Next(1, 107);
            
            var naiveVal = Solution.getTotalTime_naive(arr);
            var betterVal = Solution.getTotalTime_naive(arr);

            //dump test data
            /*string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (var writer = new System.IO.StreamWriter(System.IO.Path.Combine(docPath, "testData.txt")))
            {
                writer.WriteLine("[" + string.Join(',', arr) + "]");
                writer.WriteLine($"{naiveVal} == {betterVal}");
            }*/
            
            ClassicAssert.AreEqual(naiveVal, betterVal);
        }
    }
}