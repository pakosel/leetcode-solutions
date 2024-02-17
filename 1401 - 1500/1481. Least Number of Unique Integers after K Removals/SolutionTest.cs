using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LeastNumberOfUniqueIntegersAfterRemovals
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,5,4]", 1, 1},
            new object[] {"[4,3,1,1,3,3,2]", 3, 2},
        };


        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, int k, int expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.FindLeastNumOfUniqueInts(arr, k);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}