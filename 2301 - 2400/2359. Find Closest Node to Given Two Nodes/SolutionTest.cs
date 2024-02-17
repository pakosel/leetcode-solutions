using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindClosestNodeToGivenTwoNodes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,2,3,-1]", 0, 1, 2},
            new object[] {"[1,2,-1]", 0, 2, 2},
            new object[] {"[1,2,0]", 0, 2, 0},
            new object[] {"[2,2,3,0]", 2, 1, 2},
            new object[] {"[4,4,8,-1,9,8,4,4,1,1]", 5, 6, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string edgesStr, int node1, int node2, int expected)
        {
            var edges = ArrayHelper.ArrayFromString<int>(edgesStr);
            
            var sol = new Solution();
            var res = sol.ClosestMeetingNode(edges, node1, node2);

            Assert.That(expected == res);
        }
    }
}