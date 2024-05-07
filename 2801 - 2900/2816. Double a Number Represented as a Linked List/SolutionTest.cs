using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DoubleNumberRepresentedAsLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,8,9]", "[3,7,8]"},
            new object[] {"[9,9,9]", "[1,9,9,8]"},
            new object[] {"[1,0,0,0,0]", "[2,0,0,0,0]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.DoubleIt(head);

            Assert.That(ListNodeHelper.AreEqual(res, expected), Is.True);
        }
    }
}