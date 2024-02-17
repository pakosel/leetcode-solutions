using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MinimumPathSum
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[[1]]", 1)]
        [TestCase("[[1,3,1],[1,5,1],[4,2,1]]", 7)]
        [TestCase("[[1,3,1],[1,5,3,1,2],[4,2,1]]", 9)]
        public void Test_Example(string inputArr, int expected)
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
            var ret = sol.MinPathSum(intervals);

            ClassicAssert.AreEqual(ret, expected);
        }
    }
}