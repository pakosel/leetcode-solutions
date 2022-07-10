using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CopyListWithRandomPointer
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[7,null],[13,0],[11,4],[10,2],[1,0]]", "[[7,null],[13,0],[11,4],[10,2],[1,0]]"},
            new object[] {"[[1,1],[2,1]]", "[[1,1],[2,1]]"},
            new object[] {"[[3,null],[3,0],[3,null]]", "[[3,null],[3,0],[3,null]]"},
            new object[] {"[]", "[]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, string expectedStr)
        {
            var arr = ArrayHelper.MatrixFromString<int?>(listStr);
            var arrExp = ArrayHelper.MatrixFromString<int?>(expectedStr);
            var head = BuildNodeList(arr);
            var expected = BuildNodeList(arrExp);

            var sol = new Solution();
            var res = sol.CopyRandomList(head);

            while(res != null && expected != null)
            {
                Assert.AreNotEqual(res, expected);
                Assert.AreEqual(res.val, expected.val);
                if(res.random != null || expected.random != null)
                {
                    Assert.AreNotEqual(res.random, expected.random);
                    Assert.AreEqual(res.random?.val, expected.random?.val);
                }
                res = res.next;
                expected = expected.next;
            }
            Assert.AreEqual(expected, res);
        }

        private Node BuildNodeList(int?[][] arr)
        {
            if(arr.Length == 0)
                return null;
            var nodes = new List<Node>();
            var res = new Node((int)arr[0][0]);
            nodes.Add(res);
            var curr = res;
            foreach(var pair in arr.Skip(1))
            {
                curr.next = new Node((int)pair[0]);
                curr = curr.next;
                nodes.Add(curr);
            }

            for(int i=0; i<arr.Length; i++)
                if(arr[i][1] != null)
                    nodes[i].random = nodes[(int)arr[i][1]];

            return res;
        }
    }
}