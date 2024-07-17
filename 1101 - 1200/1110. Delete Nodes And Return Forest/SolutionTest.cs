using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;
using NUnit.Framework.Legacy;

namespace DeleteNodesAndReturnForest
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]", "[]"},
            new object[] {"[1,2,3,4,5,6,7]", "[3,5]", "[[1,2,null,4],[6],[7]]"},
            new object[] {"[1,2,4,null,3]", "[3]", "[[1,2,4]]"},
            new object[] {"[1,2,null,4,3]", "[2,3]", "[[1],[4]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string toDelStr, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var toDel = ArrayHelper.ArrayFromString<int>(toDelStr);

            //trim starting [[ and ending ]] from expectedStr, then spit it by "],[" to get the array of strings
            //each string pass as argument to TreeNodeHelper.BuildTree and return as a list of TreeNode elements
            var expected = expectedStr.StartsWith("[[") ?
                            expectedStr[2..^2].Split(new string[] {"],["}, StringSplitOptions.None).Select(s => TreeNodeHelper.BuildTree($"[{s}]")).ToList() :
                            new List<TreeNode>();

            var sol = new Solution();
            var res = sol.DelNodes(root, toDel);
            
            Assert.That(res.Count == expected.Count);
            for (int i = 0; i < res.Count; i++)
                Assert.That(TreeNodeHelper.CompareTreeNode(res[i], expected[i]));
        }
    }
}