using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumbersAtMostNGivenDigitSet
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"1","3","7"}, 1, 1},
            new object[] {new string[] {"1","3","7"}, 6, 2},
            new object[] {new string[] {"1","3","7"}, 7, 3},
            new object[] {new string[] {"1","3","7"}, 9, 3},
            new object[] {new string[] {"1","3","7"}, 10, 3},
            new object[] {new string[] {"1","3","7"}, 11, 4},
            new object[] {new string[] {"1","3","7"}, 100, 12},
            new object[] {new string[] {"1","3","7"}, 101, 12},
            new object[] {new string[] {"1","3","7"}, 110, 12},
            new object[] {new string[] {"1","3","7"}, 113, 14},
            new object[] {new string[] {"1","3","7"}, 11037, 120},
            new object[] {new string[] {"1","3","7"}, 99999999, 9840},
            new object[] {new string[] {"1","3","4","5","7","8"}, 199999999, 3695154},
            new object[] {new string[] {"1","3","4","5","7","8"}, 999999999, 12093234},
            new object[] {new string[] {"1","3","5","7"}, 100, 20},
            new object[] {new string[] {"1","5","7","8"}, 10212, 340},
            
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] digits, int n, int expected)
        {
            var sol = new Solution();
            var res = sol.AtMostNGivenDigitSet(digits, n);
            
            Assert.AreEqual(res, expected);
        }
    }
}