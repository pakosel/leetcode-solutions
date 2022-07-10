using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace HammingDistance
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { 1, 4, 2 },
            new object[] { 3, 1, 1 },
            new object[] { 7, 37, 2 },
            new object[] { 12649875, 897351843, 15 },
            new object[] { 1398101, 2796202, 22 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int x, int y, int expected)
        {
            var sol = new Solution();
            var res = sol.HammingDistance(x, y);

            Assert.AreEqual(expected, res);
        }
    }
}