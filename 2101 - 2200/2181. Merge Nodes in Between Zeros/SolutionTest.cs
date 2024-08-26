using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MergeNodesInBetweenZeros
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0,3,1,0,4,5,2,0]", "[4,11]"},
            new object[] {"[0,1,0,3,0,2,2,0]", "[1,3,4]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string headStr, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(headStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.MergeNodes(head);

            Assert.That(ListNodeHelper.AreEqual(expected, res), Is.True);
        }
    }
}