using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SmallestStringStartingFromLeaf
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,1,2,3,4,3,4]", "dba"},
            new object[] {"[25,1,3,1,3,0,2]", "adz"},
            new object[] {"[2,2,1,null,1,0,null,0]", "abc"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, string expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.SmallestFromLeaf(root);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}