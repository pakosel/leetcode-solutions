using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace LowestCommonAncestorOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 5, 1, 3 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 5, 4, 5 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 7, 4, 2 },
            new object[] {"[3,5,1,6,2,0,8,null,null,7,4]", 7, 8, 3 },
            new object[] {"[1,2]", 1, 2, 1 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string treeStr, int p, int q, int expected)
        {
            var head = BuildTree(treeStr);

            var sol = new Solution_Stack();
            var res = sol.LowestCommonAncestor(head, p, q);

            Assert.AreEqual(res.val, expected);
        }

        private TreeNode BuildTree(string arrStr)
        {
            var arr = ParseArray(arrStr);

            TreeNode head = null;

            if(arr.Length > 0)
            {
                head = NewTreeNode(arr[0]);

                Queue<TreeNode> parents = new Queue<TreeNode>();
                parents.Enqueue(head);

                int i = 1;
                TreeNode parent = null;
                while(i < arr.Length)
                {
                    var node = NewTreeNode(arr[i]);

                    if(parent == null)
                    {
                        parent = parents.Dequeue();
                        parent.left = node;
                    }
                    else
                    {
                        parent.right = node;
                        parent = null;
                    }

                    if(node != null)
                        parents.Enqueue(node);
                    i++;
                }
            }

            return head;
        }

        private int?[] ParseArray(string arrStr)
        {
            var arrS = arrStr.TrimStart('[').TrimEnd(']').Split(",");
            int?[] arr = new int?[arrS.Length];

            for(int i=0; i<arrS.Length; i++)
                if(arrS[i] == "null")
                    arr[i] = null;
                else
                    arr[i] = int.Parse(arrS[i]);

            return arr;
        }

        private TreeNode NewTreeNode(int? val) => val != null ? new TreeNode(val ?? 0) : null;
    }
}