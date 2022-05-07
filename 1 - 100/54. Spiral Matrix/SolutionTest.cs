using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SpiralMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[[1]]", "[1]")]
        [TestCase("[[1,2]]", "[1,2]")]
        [TestCase("[[1],[2]]", "[1,2]")]
        [TestCase("[[7],[9],[6]]", "[7,9,6]")]
        [TestCase("[1,2,3,4,5],[6,7,8,9,10],[11,12,13,14,15],[16,17,18,19,20]", "[1,2,3,4,5,10,15,20,19,18,17,16,11,6,7,8,9,14,13,12]")]
        [TestCase("[[1,2],[4,3]]", "[1,2,3,4]")]
        [TestCase("[[1,2,3,4],[8,7,6,5]]", "[1,2,3,4,5,6,7,8]")]
        public void Test_Example(string inputArr, string expected)
        {
            var arr = inputArr.TrimStart('[').TrimEnd(']').Split("],[");
            var matrix = new int[arr.Length][];

            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                var innerInterval = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    innerInterval[j] = int.Parse(innerArr[j]);
                
                matrix[i] = innerInterval;
            }
            
            var sol = new Solution();
            var ret = sol.SpiralOrder(matrix);

            var sb = new StringBuilder();
            sb.Append("[");
            sb.Append(string.Join(",", ret));
            sb.Append("]");

            Assert.AreEqual(sb.ToString(), expected);
        }
    }
}