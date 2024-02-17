using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KidsWithTheGreatestNumberOfCandies
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,5,1,3]", 3, "[true,true,true,false,true]"},
            new object[] {"[4,2,1,1,2]", 1, "[true,false,false,false,false]"},
            new object[] {"[12,1,12]", 10, "[true,false,true]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string candiesStr, int extraCandies, string expectedStr)
        {
            var candies = ArrayHelper.ArrayFromString<int>(candiesStr);
            var expected = ArrayHelper.ArrayFromString<bool>(expectedStr);

            var sol = new Solution();
            var res = sol.KidsWithCandies(candies, extraCandies);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}