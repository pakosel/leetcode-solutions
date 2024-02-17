using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SwappingNodesInLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1]", 1, "[1]"},
            new object[] {"[1,2,3,4,5]", 3, "[1,2,3,4,5]"},
            new object[] {"[1,2,3,4,5]", 1, "[5,2,3,4,1]"},
            new object[] {"[1,2,3,4,5]", 5, "[5,2,3,4,1]"},
            new object[] {"[1,2,3,4,5]", 2, "[1,4,3,2,5]"},
            new object[] {"[7,9,6,6,7,8,3,0,9,5]", 5, "[7,9,6,6,8,7,3,0,9,5]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string listStr, int k, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.SwapNodes(head, k);

            Assert.That(ListNodeHelper.AreEqual(res, expected));
        }
    }
}