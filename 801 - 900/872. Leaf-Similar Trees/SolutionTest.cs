using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LeafSimilarTrees
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[3,5,1,6,2,9,8,null,null,7,4]", "[3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]", true},
            new object[] {"[1,2,3]", "[1,3,2]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr1, string treeStr2, bool expected)
        {
            var root1 = TreeNodeHelper.BuildTree(treeStr1);
            var root2 = TreeNodeHelper.BuildTree(treeStr2);

            var sol = new Solution();
            var res = sol.LeafSimilar(root1, root2);

            Assert.AreEqual(expected, res);
        }
    }
}