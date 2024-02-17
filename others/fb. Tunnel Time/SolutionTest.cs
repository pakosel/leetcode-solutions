using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TunnelTime
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {10, 2, "[1,6]", "[3,7]", 7, 22},
            new object[] {50, 3, "[39,19,28]", "[49,27,35]", 15, 35},
            new object[] {3, 1, "[1]", "[2]", 1, 2},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(long C, int N, string aStr, string bStr, long K, long expected)
        {
            var A = ArrayHelper.ArrayFromString<long>(aStr);
            var B = ArrayHelper.ArrayFromString<long>(bStr);
            Assert.That(A.Length == B.Length);

            var sol = new Solution();
            var res = sol.getSecondsElapsed(C, N, A, B, K);

            Assert.That(expected == res);
        }
    }
}