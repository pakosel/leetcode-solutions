using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BasicCalculator
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"0", 0},
            new object[] {"-", 0},
            new object[] {"+", 0},
            new object[] {"()", 0},
            new object[] {"(-)", 0},
            new object[] {"(-)", 0},
            new object[] {"-1", -1},
            new object[] {"-(1)", -1},
            new object[] {"-(1+5)", -6},
            new object[] {"1 + 1", 2},
            new object[] {" 2-1 + 2 ", 3},
            new object[] {"(1+(4+5+2)-3)+(6+8)", 23},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.Calculate(s);

            Assert.That(expected == res);
        }
    }
}