using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberComplement
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 1, 0},
            new object[] { 2, 1},
            new object[] { 3, 0},
            new object[] { 4, 3},
            new object[] { 5, 2},
            new object[] { 121, 6},
            new object[] { 122, 5},
            new object[] { 123, 4},
            new object[] { 124, 3},
            new object[] { 125, 2},
            new object[] { 126, 1},
            new object[] { 127, 0},
            new object[] { 128, 127},
            new object[] { 129, 126},
            new object[] { 130, 125},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int num, int expected)
        {
            var sol = new Solution();
            var res = sol.FindComplement(num);

            Assert.That(expected == res);
        }
    }
}