using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MergeInBetweenLinkedLists
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,1,2]", 1, 2, "[2,4,6,8]", "[0,2,4,6,8]"},
            new object[] {"[0,1,2]", 1, 1, "[2,4,6,8]", "[0,2,4,6,8,2]"},
            new object[] {"[0,1,2,3,4,5]", 3, 4, "[1000000,1000001,1000002]", "[0,1,2,1000000,1000001,1000002,5]"},
            new object[] {"[0,1,2,3,4,5,6]", 2, 5, "[1000000,1000001,1000002,1000003,1000004]", "[0,1,1000000,1000001,1000002,1000003,1000004,6]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string strList1, int a, int b, string strList2, string expected)
        {
            var list1 = ListNodeHelper.BuildList(strList1);
            var list2 = ListNodeHelper.BuildList(strList2);
            var expectedList = ListNodeHelper.BuildList(expected);

            var sol = new Solution();
            var res = sol.MergeInBetween(list1, a, b, list2);

            ClassicAssert.IsTrue(ListNodeHelper.AreEqual(res, expectedList));
        }
    }
}