using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOf1Bits
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {0b00000000000000000000000000000000u, 0},
            new object[] {0b00000000000000000000000000001011u, 3},
            new object[] {0b00000000000000000000000010000000u, 1},
            new object[] {0b10000000000000000000000000000000u, 1},
            new object[] {0b11111111111111111111111111111101u, 31},
            new object[] {0b11111111111111111111111111111111u, 32},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(uint n, int expected)
        {
            var sol = new Solution();
            var res = sol.HammingWeight(n);

            Assert.That(expected == res);
        }
    }
}