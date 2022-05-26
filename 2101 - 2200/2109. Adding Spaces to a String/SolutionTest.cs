using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AddingSpacesToString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"LeetcodeHelpsMeLearn", "[8,13,15]", "Leetcode Helps Me Learn"},
            new object[] {"icodeinpython", "[1,5,7,9]", "i code in py thon"},
            new object[] {"spacing", "[0,1,2,3,4,5,6]", " s p a c i n g"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string s, string spacesStr, string expected)
        {
            var spaces = ArrayHelper.ArrayFromString<int>(spacesStr);

            var sol = new Solution();
            var res = sol.AddSpaces(s, spaces);

            Assert.AreEqual(res, expected);
        }
    }
}