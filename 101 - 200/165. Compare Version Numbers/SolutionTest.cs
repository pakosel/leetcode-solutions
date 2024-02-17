using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CompareVersionNumbers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"1", "2", -1},
            new object[] {"1.1.1", "1.01", 1},
            new object[] {"1.1.0", "1.01", 0},
            new object[] {"1.1", "1.01.1", -1},
            new object[] {"1.1", "1.01.0", 0},
            new object[] {"1.01" ,"1.001", 0},
            new object[] {"1.0", "1.0.0", 0},
            new object[] {"0.1", "1.1", -1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string version1, string version2, int expected)
        {
            var sol = new Solution();
            var res = sol.CompareVersion(version1, version2);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}