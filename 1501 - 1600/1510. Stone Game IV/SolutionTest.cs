using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace StoneGameIV
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, true},
            new object[] {2, false},
            new object[] {3, true},
            new object[] {4, true},
            new object[] {5, false},
            new object[] {6, true},
            new object[] {7, false},
            new object[] {8, true},
            new object[] {9, true},
            new object[] {10, false},
            new object[] {11, true},
            new object[] {12, false},
            new object[] {17, false},
            new object[] {18, true},
            new object[] {21, true},
            new object[] {27, true},
            new object[] {28, true},
            new object[] {30, true},
            new object[] {31, true},
            new object[] {68765, true},
            new object[] {68764, true},
            new object[] {68767, true},
            new object[] {87432, false},
            new object[] {84762, true},
            new object[] {95432, true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, bool expected)
        {
            var sol = new Solution();
            var res = sol.WinnerSquareGame(n);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}