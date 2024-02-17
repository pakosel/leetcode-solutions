using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KnightDialer
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, 10},
            new object[] {2, 20},
            new object[] {3, 46},
            new object[] {4, 104},
            new object[] {5, 240},
            new object[] {6, 544},
            new object[] {3131, 136006598}
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, int expected)
        {
            var sol = new Solution();
            var res = sol.KnightDialer(n);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}