using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KthDistinctStringInAnArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[d,b,c,b,c,a]", 2, "a"},
            new object[] {"[aaa,aa,a]", 1, "aaa"},
            new object[] {"[a,b,a]", 3, ""},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, int k, string expected)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);

            var sol = new Solution();
            var res = sol.KthDistinct(arr, k);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}