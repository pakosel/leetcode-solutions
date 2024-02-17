using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace ValidParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "", true },
            new object[] { ")", false },
            new object[] { "]", false },
            new object[] { "()", true },
            new object[] { "()[]{}", true },
            new object[] { "(]", false },
            new object[] { "([)]", false },
            new object[] { "{[]}", true }
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string input, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsValid(input);

            Assert.That(expected == res);
        }
    }
}