using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreeInorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[1,null,2,3]", "[1,3,2]"},
            new object[] {"[1,2,3,4,5,6,7]", "[4,2,5,1,6,3,7]"},
            new object[] {"[3,1,4,null,2]", "[1,2,3,4]"},
            new object[] {"[5,3,6,2,4,null,null,1]", "[1,2,3,4,5,6]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.InorderTraversal(root);

            CollectionAssert.AreEqual(expected, res);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic2020(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution_2020();
            var res = sol.InorderTraversal(root);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}