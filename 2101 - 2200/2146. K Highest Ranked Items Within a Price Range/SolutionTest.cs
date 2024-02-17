using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KHighestRankedItemsWithinPriceRange
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2,0,1],[1,3,0,1],[0,2,5,1]]", "[2,5]", "[0,0]", 3, "[[0,1],[1,1],[2,1]]"},
            new object[] {"[[1,2,0,1],[1,3,3,1],[0,2,5,1]]", "[2,3]", "[2,3]", 2, "[[2,1],[1,2]]"},
            new object[] {"[[1,1,1],[0,0,1],[2,3,4]]", "[2,3]", "[0,0]", 3, "[[2,1],[2,0]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string gridStr, string priceStr, string startStr, int k, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var pricing = ArrayHelper.ArrayFromString<int>(priceStr);
            var start = ArrayHelper.ArrayFromString<int>(startStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.HighestRankedKItems(grid, pricing, start, k);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}