using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NaryTreeLevelOrderTraversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]" },
            new object[] {"[1,null,2,null,3,null,4,null,5]", "[[1],[2],[3],[4],[5]]" },
            new object[] {"[1,null,3,2,4,null,5,6]", "[[1],[3,2,4],[5,6]]" },
            new object[] {"[1,null,2,3,4,5,null,null,6,7,null,8,null,9,10,null,null,11,null,12,null,13,null,null,14]", "[[1],[2,3,4,5],[6,7,8,9,10],[11,12,13],[14]]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string treeStr, string expectedStr)
        {
            var root = NodeHelper.BuildTree(treeStr);

            var sol = new Solution();
            var res = sol.LevelOrder(root);

            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}