using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathCrossing
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"NES", false},
            new object[] {"NESWW", true},
            new object[] {"N", false},
            new object[] {"NESW", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string path, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsPathCrossing(path);

            Assert.AreEqual(expected, res);
        }
    }
}