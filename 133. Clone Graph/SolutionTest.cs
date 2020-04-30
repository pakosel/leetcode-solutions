using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CloneGraph
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("[]")]
        [TestCase("[[]]")]
        [TestCase("[[2],[1]]")]
        [TestCase("[[2,4],[1,3],[2,4],[1,3]]")]
        public void Test_Example(string inputArr)
        {
            var arr = inputArr.TrimStart('[').TrimEnd(']').Split("],[");
            var nodes = new Node[arr.Length];
            for(int i=0; i<arr.Length; i++)
                nodes[i] = new Node(i);

            for(int i=0; i<arr.Length; i++)
            {
                var innerArr = arr[i].TrimStart('[').TrimEnd(']').Split(',');
                for(int j=0; j<innerArr.Length; j++)
                    nodes[i].neighbors.Add(nodes[j]);
            }

            var sol = new Solution();
            var ret = sol.CloneGraph(nodes[0]);

            HashSet<Node> visited = new HashSet<Node>();
            var nodesAreEqual = NodesAreEqual(nodes[0], ret, visited);

            Assert.AreEqual(nodesAreEqual, true);
        }

        private bool NodesAreEqual(Node n1, Node n2, HashSet<Node> visited)
        {
            if(visited.Contains(n1))
                return true;

            visited.Add(n1);

            if(n1.val != n2.val || n1.neighbors.Count != n2.neighbors.Count)
                return false;
            for(int i=0; i<n1.neighbors.Count; i++)
                if(!NodesAreEqual(n1.neighbors[i], n2.neighbors[i], visited))
                    return false;

            return true;
        }
    }
}