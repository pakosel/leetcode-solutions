using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreePreorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[1,2,3]", "[1,2,3]"},
            new object[] {"[1,null,2,null,3]", "[1,2,3]"},
            new object[] {"[1,2,null,3,null,4]", "[1,2,3,4]"},
            new object[] {"[1,null,2,3]", "[1,2,3]"},
            new object[] {"[1,4,3,2]", "[1,4,2,3]"},
            new object[] {"[7,5,9,4,6,8,10]", "[7,5,4,6,9,8,10]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_2022(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_2022();
            var res = sol.PreorderTraversal(root);

            CollectionAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_PreorderTraversal(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.PreorderTraversal(root);

            CollectionAssert.AreEqual(expected, res);
        }

        private static readonly object[] testCases_bfs =
        {
            new object[] {"[1,null,2,3]", "[1,2,3]"},
            new object[] {"[1,4,3,2]", "[1,4,3,2]"},
            new object[] {"[7,5,9,4,6,8,10]", "[7,5,9,4,6,8,10]"},
        };

        [Test]
        [TestCaseSource("testCases_bfs")]
        public void Test_BfsTraversal(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.BfsTraversal(root);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}