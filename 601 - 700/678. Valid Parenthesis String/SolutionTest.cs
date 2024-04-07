using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidParenthesisString
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"(", false},
            new object[] {")", false},
            new object[] {"*", true},
            new object[] {"()", true},
            new object[] {"(*)", true},
            new object[] {"(*))", true},
            new object[] {"(((******))", true},
            new object[] {"(((******)))", true},
            new object[] {"(((((*(()((((*((**(((()()*)()()()*((((**)())*)*)))))))(())(()))())((*()()(((()((()*(())*(()**)()(())", false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, bool expected)
        {
            var sol = new Solution();
            var res = sol.CheckValidString(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}