using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CanPlaceFlowers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", 1, true},
            new object[] {"[1]", 1, false},
            new object[] {"[1,0,0,0,1]", 1, true},
            new object[] {"[1,0,0,0,1]", 2, false},
            new object[] {"[1,0,0,0,1,0,0]", 2, true},
            
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2023(string arrStr, int n, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution_2023();
            var res = sol.CanPlaceFlowers(arr, n);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, int n, bool expected)
        {
            var arr = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.CanPlaceFlowers(arr, n);

            Assert.That(expected == res);
        }
    }
}