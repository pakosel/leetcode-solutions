using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CategorizeBoxAccordingToCriteria
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1000, 35, 700, 300, "Heavy"},
            new object[] {200, 50, 800, 50, "Neither"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int length, int width, int height, int mass, string expected)
        {
            var sol = new Solution();
            var res = sol.CategorizeBox(length, width, height, mass);

            Assert.AreEqual(expected, res);
        }
    }
}