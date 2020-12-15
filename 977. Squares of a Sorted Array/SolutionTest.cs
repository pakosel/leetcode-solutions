using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SquaresOfSortedArray
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[0]", "[0]"},
            new object[] {"[-1,0,1]", "[0,1,1]"},
            new object[] {"[-2,0,2]", "[0,4,4]"},
            new object[] {"[1,2,3,4]", "[1,4,9,16]"},
            new object[] {"[-4,-1,0,3,10]", "[0,1,9,16,100]"},
            new object[] {"[-7,-3,2,3,11]", "[4,9,9,49,121]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, string expected)
        {
            var arr = ArrayHelper.ArrayFromString(arrStr);

            var sol = new Solution();
            var res = sol.SortedSquares(arr);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString(expected));
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Naive(string arrStr, string expected)
        {
            var arr = ArrayHelper.ArrayFromString(arrStr);

            var sol = new Solution_Naive();
            var res = sol.SortedSquares(arr);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString(expected));
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Parallel(string arrStr, string expected)
        {
            var arr = ArrayHelper.ArrayFromString(arrStr);

            var sol = new Solution_Parallel();
            var res = sol.SortedSquares(arr);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString(expected));
        }
    }
}