using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveLinkedListElements
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,6,3,4,5,6]", 6, "[1,2,3,4,5]"},
            new object[] {"[]", 1, "[]"},
            new object[] {"[7,7,7,7]", 7, "[]"},
            new object[] {"[1,2,2,1]", 2, "[1,1]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string inputs, int val, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(inputs);
            var sol = new Solution();
            var res = sol.RemoveElements(head, val);

            var expected = ListNodeHelper.BuildList(expectedStr);

            Assert.That(ListNodeHelper.AreEqual(res, expected));
        }
    }
}