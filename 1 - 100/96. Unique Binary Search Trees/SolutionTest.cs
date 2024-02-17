using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace UniqueBinarySearchTrees
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 1, 1 },
            new object[] { 2, 2 },
            new object[] { 3, 5 },
            new object[] { 4, 14 },
            new object[] { 5, 42 },
            new object[] { 13, 742900 },
            new object[] { 19, 1767263190 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int input, int expected)
        {
            var sol = new Solution();
            var res = sol.NumTrees(input);

            Assert.That(expected == res);
        }
    }
}