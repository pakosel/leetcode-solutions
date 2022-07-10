using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SymmetricTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {null, true },
            new object[] {new TreeNode(1), true },
            new object[] {new TreeNode(1, new TreeNode(2), new TreeNode(2)), true },
            new object[] {new TreeNode(1, new TreeNode(2), new TreeNode(3)), false },
            new object[] {new TreeNode(1, null, new TreeNode(3)), false },
            new object[] {new TreeNode(1, new TreeNode(2), null), false },
            new object[] {new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3))), true },
            new object[] {new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3))), false },
            new object[] {new TreeNode(1, new TreeNode(2, new TreeNode(2)), new TreeNode(2, new TreeNode(2))), false },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Queue(TreeNode root, bool expected)
        {
            var sol = new Solution_Queue();
            var res = sol.IsSymmetric(root);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(TreeNode root, bool expected)
        {
            var sol = new Solution_Stack();
            var res = sol.IsSymmetric(root);

            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Recursive(TreeNode root, bool expected)
        {
            var sol = new Solution_Recursive();
            var res = sol.IsSymmetric(root);

            Assert.AreEqual(expected, res);
        }
    }
}