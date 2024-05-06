using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveNodesFromLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,2,13,3,8]", "[13,8]"},
            new object[] {"[1,1,1,1]", "[1,1,1,1]"},
            new object[] {"[5,2,13,3,8,20]", "[20]"},
            new object[] {"[1,2,3]", "[3]"},
            new object[] {"[1,2,4,3,4]", "[4,4]"},
            new object[] {"[1,2,4,3,4,1]", "[4,4,1]"},
            new object[] {"[3,2,1]", "[3,2,1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.RemoveNodes(head);

            Assert.That(ListNodeHelper.AreEqual(res, expected), Is.True);
        }
    }
}