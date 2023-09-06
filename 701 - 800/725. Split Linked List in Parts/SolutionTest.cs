using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SplitLinkedListInParts
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            // new object[] { "[]", 1, "[[]]" },
            new object[] { "[]", 3, "[[],[],[]]" },
            new object[] { "[1,2,3]", 5, "[[1],[2],[3],[],[]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10]", 3, "[[1,2,3,4],[5,6,7],[8,9,10]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10]", 8, "[[1,2],[3,4],[5],[6],[7],[8],[9],[10]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10]", 1, "[[1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10]", 4, "[[1,2,3,4,5],[6,7,8,9,10],[1,2,3,4,5],[6,7,8,9,10]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10]", 19, "[[1,2],[3],[4],[5],[6],[7],[8],[9],[10],[1],[2],[3],[4],[5],[6],[7],[8],[9],[10]]" },
            new object[] { "[1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10]", 21, "[[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[]]" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic23(string listStr, int k, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var sol = new Solution_2023();
            var res = sol.SplitListToParts(head, k);
            var expected = ListNodeHelper.BuildListArray(expectedStr);

            Assert.IsTrue(ListNodeHelper.AreEqual(expected, res));
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, int k, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var sol = new Solution();
            var res = sol.SplitListToParts(head, k);
            var expected = ListNodeHelper.BuildListArray(expectedStr);

            Assert.IsTrue(ListNodeHelper.AreEqual(expected, res));
        }
    }
}