using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RussianDollEnvelopes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[]]", 0 },
            new object[] {"[[1,1]]", 1 },
            new object[] {"[[1,1],[1,1],[1,1]]", 1 },
            new object[] {"[[5,4],[6,4],[6,7],[2,3]]", 3 },
            new object[] {"[[2,100],[3,200],[4,300],[5,500],[5,400],[5,250],[6,370],[6,360],[7,380]]", 5 },
            new object[] {"[[46,89],[50,53],[52,68],[72,45],[77,81]]", 3 },
            new object[] {"[[1,2],[2,3],[3,4],[3,5],[4,5],[5,5],[5,6],[6,7],[7,8]]", 7 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_DP(string envelopesStr, int expected)
        {
            var envelopes = ArrayHelper.MatrixFromString<int>(envelopesStr);

            var sol = new Solution_DP();
            var res = sol.MaxEnvelopes(envelopes);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Memoization(string envelopesStr, int expected)
        {
            var envelopes = ArrayHelper.MatrixFromString<int>(envelopesStr);

            var sol = new Solution_Memo();
            var res = sol.MaxEnvelopes(envelopes);

            Assert.That(expected == res);
        }
    }
}