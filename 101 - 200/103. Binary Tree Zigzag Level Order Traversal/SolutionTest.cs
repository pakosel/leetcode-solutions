using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;


namespace BinaryTreeZigzagLevelOrderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[[1]]"},
            new object[] {"[3,9,20,null,null,15,7]", "[[3],[20,9],[15,7]]"},
            new object[] {"[1,2,3,4,null,null,5]", "[[1],[3,2],[4,5]]"},
            new object[] {"[1,2,3,4,44,5,55]", "[[1],[3,2],[4,44,5,55]]"},
            new object[] {"[0,2,4,1,null,3,-1,5,1,null,6,null,8]", "[[0],[4,2],[1,3,-1],[8,6,1,5]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ZigzagLevelOrder(root);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}