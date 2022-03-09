using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RemoveDuplicatesFromSortedListII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", "[]"},
            new object[] {"[1,2,3,3,4,4,5]", "[1,2,5]"},
            new object[] {"[1,1,1,2,3]", "[2,3]"},
            new object[] {"[1]", "[1]"},
            new object[] {"[0]", "[0]"},
            new object[] {"[1,1]", "[]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string listStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.DeleteDuplicates(head);

            Assert.IsTrue(ListNodeHelper.AreEqual(res, expected));
        }
    }
}