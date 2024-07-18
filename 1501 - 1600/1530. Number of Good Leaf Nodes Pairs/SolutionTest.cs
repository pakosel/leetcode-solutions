using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfGoodLeafNodesPairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,null,4]", 3, 1},
            new object[] {"[1,2,3,4,5,6,7]", 3, 2},
            new object[] {"[7,1,4,6,null,5,3,null,null,null,null,null,2]", 3, 1},
            new object[] {"[1,1,1,null,1]", 3, 1},
            new object[] {"[1,2]", 1, 0},
            new object[] {"[1,2,3,4,5]", 1, 0},
            new object[] {"[1,2,3,4,5]", 2, 1},
            new object[] {"[1,2,3,4,5]", 3, 3},
            new object[] {"[1,2,3,4,5]", 4, 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string treeStr, int distance, int expected)
        {
            var root = TreeNodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.CountPairs(root, distance);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}