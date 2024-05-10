using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KthSmallestPrimeFraction
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,5]", 3, "[2,5]"},
            new object[] {"[1,7]", 1, "[1,7]"},
            new object[] {"[1,29,47]", 1, "[1,47]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int k, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.KthSmallestPrimeFraction(arr, k);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}