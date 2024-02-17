using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumDepthBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 0 },
            new object[] {"[3]", 1 },
            new object[] {"[3,9,20,null,null,15,7]", 3 },
            new object[] {"[1,null,2]", 2 },
            new object[] {"[0,2,4,1,null,3,-1,5,1,null,6,null,8,null,null,null,null,7]", 5 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(strArr);

            var sol = new Solution();
            var res = sol.MaxDepth(root);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Queue(string strArr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(strArr);

            var sol = new Solution();
            var res = sol.MaxDepth(root);

            Assert.That(expected == res);
        }
    }
}