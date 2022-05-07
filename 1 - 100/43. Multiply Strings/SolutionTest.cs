using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MultiplyStrings
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { "2", "3", "6" },
            new object[] { "123", "456", "56088" },
            new object[] { "9133", "0", "0" },
            new object[] { "0", "0", "0" },
            new object[] { "350", "12", "4200" },
            new object[] { "999", "999", "998001" },
            new object[] { "989873243548979", "65468549873211321665499", "64805565813443788842189334499860975521" },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Cases(string num1, string num2, string expected)
        {
            var sol = new Solution();
            var res = sol.Multiply(num1, num2);

            Assert.AreEqual(res, expected);
        }
    }
}