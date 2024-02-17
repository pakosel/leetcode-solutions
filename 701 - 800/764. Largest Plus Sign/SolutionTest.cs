using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LargestPlusSign
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] { 1, "[]", 1 },
            new object[] { 1, "[[0,0]]", 0 },
            new object[] { 5, "[[4,2]]", 2 },
            new object[] { 5, "[[3,0],[3,3]]", 3 },
            new object[] { 5, "[[4,2],[1,1],[1,3],[3,3],[3,1],[2,2]]", 1 },
            new object[] { 5, "[[0,0],[0,1],[0,4],[1,0],[1,1],[1,2],[2,0],[2,1],[2,2],[2,3],[2,4],[3,0],[4,0],[4,1],[4,3],[4,4]]", 1 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string minesStr, int expected)
        {
            var mines = ArrayHelper.MatrixFromString<int>(minesStr);

            var sol = new Solution();
            var res = sol.OrderOfLargestPlusSign(n, mines);
            
            ClassicAssert.AreEqual(expected, res);
        }
    }
}