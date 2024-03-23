using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveZeroSumConsecutiveNodesFromLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,-3,3,1]", "[3,1]"},
            new object[] {"[1,2,3,-3,4]", "[1,2,4]"},
            new object[] {"[1,2,3,-3,-2]", "[1]"},
            new object[] {"[0]", "[]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string headStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(headStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.RemoveZeroSumSublists(head);

            Assert.That(ListNodeHelper.AreEqual(res, expected), Is.EqualTo(true));
        }
    }
}