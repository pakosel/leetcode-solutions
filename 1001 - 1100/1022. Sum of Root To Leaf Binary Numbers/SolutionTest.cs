using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumOfRootToLeafBinaryNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", 0},
            new object[] {"[1]", 1},
            new object[] {"[1,1,1]", 6},
            new object[] {"[1,0,1,0,1,0,1]", 22},
            new object[] {"[1,0,1,0,1,0,1,1,null,null,0,1,null,null,null]", 39},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);
            var sol = new Solution();
            var res = sol.SumRootToLeaf(root);

            Assert.That(expected == res);
        }
    }
}