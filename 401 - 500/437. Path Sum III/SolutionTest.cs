using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathSumIII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[0]", 2, 0 },
            new object[] { "[2]", 2, 1 },
            new object[] { "[2,2,2]", 2, 3 },
            new object[] { "[10,5,-3,3,2,null,11,3,-2,null,1]", 8, 3 },
            new object[] { "[5,4,8,11,null,13,4,7,2,null,null,5,1]", 22, 3 },
            new object[] { "[1,null,2,null,3,null,4,null,5]", 3, 2 },
            new object[] { "[1,-2,-3,1,3,-2,null,-1]", -1, 4 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArray, int target, int expected)
        {
            var root = TreeNodeHelper.BuildTree(strArray);

            var sol = new Solution();
            var res = sol.PathSum(root, target);

            Assert.That(expected == res);
        }
    }
}