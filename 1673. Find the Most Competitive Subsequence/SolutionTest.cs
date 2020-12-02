using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindTheMostCompetitiveSubsequence
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] { "[3,5,2,6]", 2, "[2,6]" },
            new object[] { "[2,4,3,3,5,4,9,6]", 4, "[2,3,3,4]" },
            new object[] { "[71,18,52,29,55,73,24,42,66,8,80,2]", 3, "[8,80,2]" },
            new object[] { "[84,10,71,23,66,61,62,64,34,41,80,25,91,43,4,75,65,13,37,41,46,90,55,8,85,61,95,71]", 24, "[10,23,61,62,34,41,80,25,91,43,4,75,65,13,37,41,46,90,55,8,85,61,95,71]" },
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string strArr, int k, string expected)
        {
            var nums = ArrayHelper.ArrayFromString(strArr);

            var sol = new Solution();
            var res = sol.MostCompetitive(nums, k);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString(expected));
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericDqueue(string strArr, int k, string expected)
        {
            var nums = ArrayHelper.ArrayFromString(strArr);

            var sol = new Solution_Dqueue();
            var res = sol.MostCompetitive(nums, k);

            CollectionAssert.AreEquivalent(res, ArrayHelper.ArrayFromString(expected));
        }
    }
}