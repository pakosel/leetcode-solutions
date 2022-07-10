using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EvenOddTree
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,10,4,3,null,7,9,12,8,6,null,null,2]", true},
            new object[] {"[5,4,2,3,3,7]", false},
            new object[] {"[5,9,1,3,5,7]", false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, bool expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.IsEvenOddTree(root);

            Assert.AreEqual(expected, res);
        }
    }
}