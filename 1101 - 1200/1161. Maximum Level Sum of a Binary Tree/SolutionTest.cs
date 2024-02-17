using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumLevelSumOfBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,7,0,7,-8,null,null]", 2},
            new object[] {"[1,7,0,7,0,null,null]", 2},
            new object[] {"[989,null,10250,98693,-89388,null,null,null,-32127]", 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.MaxLevelSum(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}