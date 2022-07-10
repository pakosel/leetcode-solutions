using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AllElementsInTwoBinarySearchTrees
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", "[]","[]"},
            new object[] {"[2,1,4]", "[1,0,3]","[0,1,1,2,3,4]"},
            new object[] {"[]", "[1,0,3]","[0,1,3]"},
            new object[] {"[1,null,8]", "[8,1]","[1,1,8,8]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string root1Str, string root2Str, string expectedStr)
        {
            var root1 = TreeNodeHelper.BuildTree(root1Str);
            var root2 = TreeNodeHelper.BuildTree(root2Str);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr).ToList();

            var sol = new Solution();
            var res = sol.GetAllElements(root1, root2);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}