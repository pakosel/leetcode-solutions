using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumNestingDepthOfTheParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"(1+(2*3)+((8)/4))+1", 3},
            new object[] {"(1)+((2))+(((3)))", 3},
            new object[] {"(1+(2*3)+((8+(1+2*(1+1)))/4))+1", 5},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxDepth(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}