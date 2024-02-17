using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RotateList
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0,1,2]", 4, "[2,0,1]"},
            new object[] {"[1,2,3,4,5]", 0, "[1,2,3,4,5]"},
            new object[] {"[1,2,3,4,5]", 1, "[5,1,2,3,4]"},
            new object[] {"[1,2,3,4,5]", 2, "[4,5,1,2,3]"},
            new object[] {"[1,2,3,4,5]", 3, "[3,4,5,1,2]"},
            new object[] {"[1,2,3,4,5]", 4, "[2,3,4,5,1]"},
            new object[] {"[1,2,3,4,5]", 5, "[1,2,3,4,5]"},
            new object[] {"[1,2,3,4,5]", 6, "[5,1,2,3,4]"},
            new object[] {"[1,2,3,4,5]", 111, "[5,1,2,3,4]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string listStr, int k, string expectedStr)
        {
            var head = ListNodeHelper.BuildList(listStr);
            var expected = ListNodeHelper.BuildList(expectedStr);

            var sol = new Solution();
            var res = sol.RotateRight(head, k);

            Assert.That(ListNodeHelper.AreEqual(res, expected));
        }
    }
}