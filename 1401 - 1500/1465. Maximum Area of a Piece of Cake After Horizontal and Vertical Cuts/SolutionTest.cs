using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumAreaOfPieceOfCakeAfterHorizontalAndVerticalCuts
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {5, 4, "[1,2,4]", "[1,3]", 4},
            new object[] {5, 4, "[3,1]", "[1]", 6},
            new object[] {5, 4, "[3]", "[3]", 9},
            new object[] {6, 3, "[5,4,1,2,3]", "[2,1]", 1},
            new object[] {1000000000, 1000000000, "[2]", "[2]", 81},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int h, int w, string horizontalCutsStr, string verticalCutsStr, int expected)
        {
            var horizontalCuts = ArrayHelper.ArrayFromString<int>(horizontalCutsStr);
            var verticalCuts = ArrayHelper.ArrayFromString<int>(verticalCutsStr);

            var sol = new Solution();
            var res = sol.MaxArea(h, w, horizontalCuts, verticalCuts);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}