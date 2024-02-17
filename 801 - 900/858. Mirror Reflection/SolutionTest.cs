using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MirrorReflection
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {2, 0, 0},
            new object[] {2, 1, 2},
            new object[] {2, 2, 1},
            new object[] {4, 1, 2},
            new object[] {4, 2, 2},
            new object[] {4, 3, 2},
            new object[] {4, 4, 1},
            new object[] {5, 1, 1},
            new object[] {5, 2, 0},
            new object[] {5, 3, 1},
            new object[] {5, 4, 0},
            new object[] {5, 5, 1},
            new object[] {6, 1, 2},
            new object[] {6, 2, 1},
            new object[] {6, 3, 2},
            new object[] {6, 4, 0},
            new object[] {6, 5, 2},
            new object[] {6, 6, 1},
            new object[] {7, 0, 0},
            new object[] {7, 1, 1},
            new object[] {7, 2, 0},
            new object[] {7, 3, 1},
            new object[] {7, 4, 0},
            new object[] {7, 5, 1},
            new object[] {7, 6, 0},
            new object[] {7, 7, 1},
            new object[] {458, 446, 1},
            new object[] {458, 12, 0},
            new object[] {888, 256, 0},
            new object[] {888, 632, 1},
            new object[] {888, 248, 1},
            new object[] {888, 640, 0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(int p, int q, int expected)
        {
            var sol = new Solution();
            var res = sol.MirrorReflection(p, q);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}