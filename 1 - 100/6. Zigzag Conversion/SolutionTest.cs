using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ZigzagConversion
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"ABCDEFGHIJKLMNO", 1, "ABCDEFGHIJKLMNO"},
            new object[] {"ABCDEFGHIJKLMNO", 2, "ACEGIKMOBDFHJLN"},
            new object[] {"ABCDEFGHIJKLMNO", 3, "AEIMBDFHJLNCGKO"},
            new object[] {"ABCDEFGHIJKLMNO", 44, "ABCDEFGHIJKLMNO"},
            new object[] {"PAYPALISHIRING", 3, "PAHNAPLSIIGYIR"},
            new object[] {"PAYPALISHIRING", 4, "PINALSIGYAHRPI"},
            new object[] {"A", 1, "A"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Examples(string s, int numRows, string expected)
        {
            var sol = new Solution();
            var res = sol.Convert(s, numRows);

            Assert.AreEqual(expected, res);
        }
    }
}