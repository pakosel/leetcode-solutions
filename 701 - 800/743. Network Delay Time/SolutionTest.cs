using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace NetworkDelayTime
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[[1]]", 1, 1, 0)]
        [TestCase("[[2,1,1],[2,3,1],[3,4,1]]", 4, 2, 2)]
        [TestCase("[[3,5,78],[2,1,1],[1,3,0],[4,3,59],[5,3,85],[5,2,22],[2,4,23],[1,4,43],[4,5,75],[5,1,15],[1,5,91],[4,1,16],[3,2,98],[3,4,22],[5,4,31],[1,2,0],[2,5,4],[4,2,51],[3,1,36],[2,3,59]]", 5, 5, 31)]
        [TestCase("[[2,4,10],[5,2,38],[3,4,33],[4,2,76],[3,2,64],[1,5,54],[1,4,98],[2,3,61],[2,1,0],[3,5,77],[5,1,34],[3,1,79],[5,3,2],[1,2,59],[4,3,46],[5,4,44],[2,5,89],[4,5,21],[1,3,86],[4,1,95]]", 5, 1, 69)]
        public void Test_Example(string inputArr, int N, int K, int expected)
        {
            var arr = inputArr.TrimStart('[').TrimEnd(']').Split("],[");
            var nodes = new int[arr.Length][];
            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                var innerInterval = new int[innerArr.Length];
                for(int j=0; j<innerArr.Length; j++)
                    innerInterval[j] = int.Parse(innerArr[j]);

                nodes[i] = innerInterval;
            }

            
            var sol = new Solution();
            var ret = sol.NetworkDelayTime(nodes, N, K);

            Assert.AreEqual(ret, expected);
        }
    }
}