using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumTwinSumOfLinkedList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,4,2,1]", 6},
            new object[] {"[4,2,2,3]", 7},
            new object[] {"[1,100000]", 100001},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string listStr, int expected)
        {
            var head = ListNodeHelper.BuildList(listStr);

            var sol = new Solution();
            var res = sol.PairSum(head);

            Assert.That(expected == res);
        }
    }
}