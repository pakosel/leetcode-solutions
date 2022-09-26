using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SatisfiabilityOfEqualityEquations
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[a==b,b!=a]", false},
            new object[] {"[b==a,a==b]", true},
            new object[] {"[a==b,b!=a,b==d,b==c,c!=d]", false},
            new object[] {"[b==b,b==e,e==c,d!=e]", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string equationsStr, bool expected)
        {
            var equations = ArrayHelper.ArrayFromString<string>(equationsStr);
            
            var sol = new Solution();
            var res = sol.EquationsPossible(equations);

            Assert.AreEqual(expected, res);
        }
    }
}