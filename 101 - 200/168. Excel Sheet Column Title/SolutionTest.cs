using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ExcelSheetColumnTitle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "A"},
            new object[] {2, "B"},
            new object[] {5, "E"},
            new object[] {16, "P"},
            new object[] {26, "Z"},
            new object[] {27, "AA"},
            new object[] {28, "AB"},
            new object[] {676, "YZ"},
            new object[] {701, "ZY"},
            new object[] {687732196, "BEVYAHH"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int colNum, string expected)
        {
            var sol = new Solution();
            var res = sol.ConvertToTitle(colNum);

            Assert.That(expected == res);
        }
    }
}