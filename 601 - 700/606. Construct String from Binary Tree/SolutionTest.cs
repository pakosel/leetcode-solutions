using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ConstructStringFromBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4]", "1(2(4))(3)"},
            new object[] {"[1,2,3,null,4]", "1(2()(4))(3)"},
            new object[] {"[1]", "1"},
            new object[] {"[1,2]", "1(2)"},
            new object[] {"[1,null,2]", "1()(2)"},
            new object[] {"[1,2,3,4,5]", "1(2(4)(5))(3)"},
            new object[] {"[1,2,3,4,5,6]", "1(2(4)(5))(3(6))"},
            new object[] {"[1,2,3,4,5,6,7]", "1(2(4)(5))(3(6)(7))"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string treeStr, string expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.Tree2str(root);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}