using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MaximumBinaryTree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] { "[3,2,1,6,0,5]", new TreeNode(6, new TreeNode(3, null, new TreeNode(2, null, new TreeNode(1))), new TreeNode(5, new TreeNode(0))) },
            new object[] { "[1]", new TreeNode(1) },
            new object[] { "[1,2]", new TreeNode(2, new TreeNode(1)) },
            new object[] { "[1,2,3]", new TreeNode(3, new TreeNode(2, new TreeNode(1))) },
            new object[] { "[1,3,2]", new TreeNode(3, new TreeNode(1), new TreeNode(2)) },
            new object[] { "[13,2,1,6,0,5]", new TreeNode(13, null, new TreeNode(6, new TreeNode(2, null, new TreeNode(1)), new TreeNode(5, new TreeNode(0)))) },
            new object[] { "[3,4,2,1,6,0,5]", new TreeNode(6, new TreeNode(4, new TreeNode(3), new TreeNode(2, null, new TreeNode(1))), new TreeNode(5, new TreeNode(0))) },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string input, TreeNode expected)
        {
            var numsStr = input.TrimStart('[').TrimEnd(']').Split(',');
            int[] nums = new int[numsStr.Length];
            for(int i=0; i<numsStr.Length; i++)
                nums[i] = int.Parse(numsStr[i]);

            var sol = new Solution();
            var res = sol.ConstructMaximumBinaryTree(nums);

            Assert.That(CompareTreeNode(res, expected));
        }

        private bool CompareTreeNode(TreeNode node1, TreeNode node2)
        {
            if(node1 == null && node2 == null)
                return true;
            if(node1 != null && node2 != null)
            {
                return node1.val == node2.val 
                        && CompareTreeNode(node1.left, node2.left) 
                        && CompareTreeNode(node1.right, node2.right);
            }
            
            return false;
        }
    }
}