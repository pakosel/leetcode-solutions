using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindModeInBinarySearchTree
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,null,2,2]", "[2]"},
            new object[] {"[0]", "[0]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tree, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(tree);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindMode(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}