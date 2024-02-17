using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BinaryTreeRightSideView
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[1,2,3]", "[1,3]"},
            new object[] {"[1,null,3]", "[1,3]"},
            new object[] {"[1,2,3,null,5,null,4]", "[1,3,4]"},
            new object[] {"[1,2,3,null,5,null,4,6]", "[1,3,4,6]"},
            new object[] {"[1,2,3,null,5,null,4,6,7]", "[1,3,4,7]"},
            new object[] {"[1,2,3,null,5,null,4,6,7,null,null,8]", "[1,3,4,7,8]"},
            new object[] {"[1,2,null,3,null,4,null,5,null,6,null,7,8]", "[1,2,3,4,5,6,8]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var ret = sol.RightSideView(root);

            Assert.That(ret, Is.EqualTo(expected));
        }
    }
}