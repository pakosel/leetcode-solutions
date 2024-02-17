using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ExecutionOfAllSuffixInstructionsStayingInGrid
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, "[0,1]", "RRDDLU", "[1,5,4,3,1,0]"},
            new object[] {2, "[1,1]", "LURD", "[4,1,0,0]"},
            new object[] {1, "[0,0]", "LRUD", "[0,0,0,0]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string startPosStr, string s, string expectedStr)
        {
            var startPos = ArrayHelper.ArrayFromString<int>(startPosStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ExecuteInstructions(n, startPos, s);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}