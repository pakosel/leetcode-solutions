using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EvaluateReversePolishNotation
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[2,1,-,3,*]", 3},
            new object[] {"[2,1,+,3,*]", 9},
            new object[] {"[4,13,5,/,+]", 6},
            new object[] {"[10,6,9,3,+,-11,*,/,*,17,+,5,+]", 22},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string tokensStr, int expected)
        {
            var tokens = ArrayHelper.ArrayFromString<string>(tokensStr);

            var sol = new Solution();
            var res = sol.EvalRPN(tokens);

            Assert.That(expected == res);
        }
    }
}