using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathSumII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "[]", 1, "[]" },
            new object[] { "[2]", 1, "[]" },
            new object[] { "[2]", 2, "[[2]]" },
            new object[] { "[5,4,8,11,null,13,4,7,2,null,null,5,1]", 22, "[[5,4,11,2],[5,8,4,5]]" },
            new object[] { "[1,2,3]", 5, "[]" },
            new object[] { "[1,2,3]", 4, "[[1,3]]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string strArray, int target, string expectedStr)
        {
            var root = TreeNodeHelper.BuildTree(strArray);

            var sol = new Solution();
            var res = sol.PathSum(root, target);

            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}