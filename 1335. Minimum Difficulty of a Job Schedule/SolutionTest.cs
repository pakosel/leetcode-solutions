using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace MinimumDifficultyOfJobSchedule

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[7]", 1, 7},
            new object[] {"[7]", 2, -1},
            new object[] {"[6,5,4,3,2,1]", 2, 7},
            new object[] {"[9,9,9]", 4, -1},
            new object[] {"[1,1,1]", 3, 3},
            new object[] {"[7,1,7,1,7,1]", 3, 15},
            new object[] {"[11,111,22,222,33,333,44,444]", 6, 843},
            new object[] {"[186,398,479,206,885,423,805,112,925,656,16,932,740,292,671,360]", 4, 1803},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string arrStr, int d, int expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            var sol = new Solution();
            var res = sol.MinDifficulty(arr, d);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, int d, int expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            var sol = new Solution_Memoization();
            var res = sol.MinDifficulty(arr, d);

            Assert.AreEqual(res, expected);
        }
    }
}