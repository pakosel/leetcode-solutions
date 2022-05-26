using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CloneGraph
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]"},
            new object[] {"[[]]"},
            new object[] {"[[2],[1]]"},
            new object[] {"[[2,4],[1,3],[2,4],[1,3]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(string inputArr)
        {
            var nodes = BuildGraph(inputArr);
            var node = nodes.Length > 0 ? nodes[0] : null;

            var sol = new Solution_Recursive();
            var ret = sol.CloneGraph(node);

            var nodesAreEqual = NodesAreEqual(node, ret);

            if(node != null)
                Assert.AreNotEqual(node, ret);
            Assert.AreEqual(nodesAreEqual, true);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string inputArr)
        {
            var nodes = BuildGraph(inputArr);
            var node = nodes.Length > 0 ? nodes[0] : null;

            var sol = new Solution();
            var ret = sol.CloneGraph(node);

            var nodesAreEqual = NodesAreEqual(node, ret);

            if(node != null)
                Assert.AreNotEqual(node, ret);
            Assert.AreEqual(nodesAreEqual, true);
        }

        private Node[] BuildGraph(string inputArr)
        {
            var arr = ArrayHelper.MatrixFromString<int>(inputArr);

            var nodes = new Node[arr.Length];
            for(int i=0; i<arr.Length; i++)
                nodes[i] = new Node(i);

            for(int i=0; i<arr.Length; i++)
                for(int j=0; j<arr[i].Length; j++)
                    nodes[i].neighbors.Add(nodes[j]);

            return nodes;
        }

        private bool NodesAreEqual(Node n1, Node n2, HashSet<Node> visited = null)
        {
            if(n1 == null)
                return n2 == null;
            if(visited == null)
                visited = new HashSet<Node>();
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