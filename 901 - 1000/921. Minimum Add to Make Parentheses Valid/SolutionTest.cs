using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MinimumAddParentheses
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase("()", 0)]
        [TestCase("())", 1)]
        [TestCase("(((", 3)]
        [TestCase("()))((", 4)]
        public void Test_Example(string inputStr, int expected)
        {
            var sol = new Solution();
            var ret = sol.MinAddToMakeValid(inputStr);

            Assert.That(expected == ret);
        }
    }
}