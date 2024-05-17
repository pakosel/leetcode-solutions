using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EvaluateBooleanBinaryTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,1,3,null,null,0,1]", true},
            new object[] {"[0]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.EvaluateTree(root);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}