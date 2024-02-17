using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SumOfEvenNumbersAfterQueries
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2,3,4]", "[[1,0],[-3,1],[-4,0],[2,3]]", "[8,6,2,4]"},
            new object[] {"[1]", "[[4,0]]", "[0]"},
            new object[] {"[1,2,3,4]", "[[1,0],[-3,1],[-4,0],[2,3],[1,0],[-3,1],[-4,0],[2,3]]", "[8,6,2,4,6,2,2,4]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string queriesStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var queries = ArrayHelper.MatrixFromString<int>(queriesStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SumEvenAfterQueries(nums, queries);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}