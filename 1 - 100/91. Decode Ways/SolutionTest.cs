using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DecodeWays
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"0", 0},
            new object[] {"00", 0},
            new object[] {"10", 1},
            new object[] {"210", 1},
            new object[] {"99909", 0},
            new object[] {"22", 2},
            new object[] {"222", 3},
            new object[] {"22222", 8},
            new object[] {"12", 2},
            new object[] {"226", 3},
            new object[] {"06", 0},
            new object[] {"221357", 5},
            new object[] {"2213571", 5},
            new object[] {"22135711", 10},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.NumDecodings(s);

            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericMemo(string s, int expected)
        {
            var sol = new Solution_Memoization();
            var res = sol.NumDecodings(s);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}