using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumProductOfSplittedBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4,5,6]", 110},
            new object[] {"[1,null,2,3,4,null,null,5,6]", 90},
            new object[] {"[1,1]", 1},
            new object[] {"[1,2]", 2},
            new object[] {"[1,2,null,3]", 9},
            new object[] {"[1,2,null,3,null,4]", 24},
            new object[] {"[1,2,null,3,null,5]", 30},
            new object[] {"[1,2,null,3,null,5,null,7]", 77},
            new object[] {"[5,6,6,null,null,8,6,10,null,5]", 504},
            new object[] {"[2,7,4,null,null,null,3,100,5]", 2100},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.MaxProduct(root);

            Assert.That(expected == res);
        }
    }
}