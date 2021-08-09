using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AddStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "0", "0", "0" },
            new object[] { "1", "9", "10" },
            new object[] { "11", "123", "134" },
            new object[] { "456", "77", "533" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Cases(string num1, string num2, string expected)
        {
            var sol = new Solution();
            var res = sol.AddStrings(num1, num2);

            Assert.AreEqual(res, expected);
        }
    }
}