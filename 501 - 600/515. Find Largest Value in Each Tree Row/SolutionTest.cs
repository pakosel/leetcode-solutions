using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindLargestValueInEachTreeRow
{
    [TestFixture]
    public class MaximumBinaryTree
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[1,3,2,5,3,null,9]", "[1,3,9]"},
            new object[] {"[1,2,3]", "[1,3]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tree, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(tree);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.LargestValues(root);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}