using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace InsertInterval
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[[1,3],[6,9]]", new int[] {2,5}, "[[1,5],[6,9]]")]
        [TestCase("[[1,2],[3,5],[6,7],[8,10],[12,16]]", new int[] {4,8}, "[[1,2],[3,10],[12,16]]")]
        [TestCase("[[1,5]]", new int[] {1,7}, "[[1,7]]")]
        [TestCase("[[1,5]]", new int[] {6,8}, "[[1,5],[6,8]]")]
        [TestCase("[[1,5]]", new int[] {5,8}, "[[1,8]]")]
        [TestCase("[[1,5]]", new int[] {2,3}, "[[1,5]]")]
        [TestCase("[[1,5]]", new int[] {0,3}, "[[0,5]]")]
        [TestCase("[[1,5]]", new int[] {0,0}, "[[0,0],[1,5]]")]
        public void Test_Example(string inputArr, int[] newInterval, string expected)
        {
            var arr = inputArr.TrimStart('[').TrimEnd(']').Split("],[");
            var intervals = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                var innerInterval = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    innerInterval[j] = int.Parse(innerArr[j]);

                intervals[i] = innerInterval;
            }

            var sol = new Solution();
            var ret = sol.Insert(intervals, newInterval);

            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            sb.Append(string.Join(',', ret.Select(it => "[" + string.Join(',', it) + "]")));
            sb.Append(']');
            
            Assert.AreEqual(sb.ToString(), expected);
        }
    }
}