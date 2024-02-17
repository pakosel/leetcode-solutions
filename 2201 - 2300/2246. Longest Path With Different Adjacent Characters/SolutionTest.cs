using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestPathWithDifferentAdjacentCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[-1,0,0,1,1,2]", "abacbe", 3},
            new object[] {"[-1,0,0,0]", "aabc", 3},
            new object[] {"[-1,2,0,1,1,0]", "abacbe", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string parentStr, string s, int expected)
        {
            var parent = ArrayHelper.ArrayFromString<int>(parentStr);

            var sol = new Solution();
            var res = sol.LongestPath(parent, s);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}