using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreePostorderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[-1]", "[-1]"},
            new object[] {"[2,4,5,null,8]", "[8,4,5,2]"},
            new object[] {"[1,2]", "[2,1]"},
            new object[] {"[1,null,2]", "[2,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var tree = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var ret = sol.PostorderTraversal(tree);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            CollectionAssert.AreEquivalent(ret, expected);
        }
    }
}