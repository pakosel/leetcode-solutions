using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;


namespace BinaryTreeLevelOrderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[[1]]"},
            new object[] {"[3,9,20,null,null,15,7]", "[[3],[9,20],[15,7]]"},
            new object[] {"[0,2,4,1,null,3,-1,5,1,null,6,null,8]", "[[0],[2,4],[1,3,-1],[5,1,6,8]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.LevelOrder(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}