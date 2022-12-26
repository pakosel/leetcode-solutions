using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestSubsequenceWithLimitedSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4,5,2,1]", "[3,10,21]", "[2,3,4]"},
            new object[] {"[2,3,4,5]", "[1]", "[0]"},
            new object[] {"[4]", "[4]", "[1]"},
            new object[] {"[4]", "[3]", "[0]"},
            new object[] {"[4]", "[5]", "[1]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string numsStr, string queriesStr, string expectedStr)
        {
            var nums = ArrayHelper.ArrayFromString<int>(numsStr);
            var queries = ArrayHelper.ArrayFromString<int>(queriesStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            Assert.AreEqual(queries.Length, expected.Length);
            
            var sol = new Solution();
            var res = sol.AnswerQueries(nums, queries);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}