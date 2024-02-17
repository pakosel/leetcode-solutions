using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CombinationSum
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[]", 7, "[[]]"},
            new object[] {"[4,2,8]", 10, "[[2,4,4],[2,2,2,4],[2,2,2,2,2],[2,8]]"},
            new object[] {"[4,8,7,3]", 10, "[[3,3,4],[3,7]]"},
            new object[] {"[20,23,25,37,33,41,27,45,30,35,44,32,46,28,29,43,34,26,42,24,39,22,38,31,48,21,36,47,49]", 68, "[[20,20,28],[20,21,27],[20,22,26],[20,23,25],[20,24,24],[20,48],[21,21,26],[21,22,25],[21,23,24],[21,47],[22,22,24],[22,23,23],[22,46],[23,45],[24,44],[25,43],[26,42],[27,41],[29,39],[30,38],[31,37],[32,36],[33,35],[34,34]]"},
            new object[] {"[2,3,6,7]", 7, "[[7],[2,2,3]]"},
            new object[] {"[3,5]", 8, "[[3,5]]"},
            new object[] {"[2,3,5]", 8, "[[3,5],[2,3,3],[2,2,2,2]]"},
            new object[] {"[2,5,8,4]", 10, "[[2,2,2,2,2],[2,2,2,4],[2,4,4],[2,8],[5,5]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string candidatesStr, int target, string expectedStr)
        {
            var candidates = ArrayHelper.ArrayFromString<int>(candidatesStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.CombinationSum(candidates, target);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}