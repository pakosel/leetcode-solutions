using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RangeSumQuery2DImmutable
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"sumRegion"}, "[[1]]", "[0,0,0,0]", "[1]"},
            new object[] {new string[] {"sumRegion", "sumRegion", "sumRegion"}, "[[3,0,1,4,2],[5,6,3,2,1],[1,2,0,1,5],[4,1,0,1,7],[1,0,3,0,5]]", "[[2,1,4,3],[1,1,2,2],[1,2,2,4]]", "[8, 11, 12]"},
            new object[] {new string[] {"sumRegion", "sumRegion", "sumRegion"}, "[[1,2,3,4,5]]", "[0,0,0,3],[0,1,0,2],[0,2,0,4]", "[10, 5, 12]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_DP(string[] commands, string matrixStr, string argsStr, string expectedStr)
        {
            Test_Generic<NumMatrix>(m => new NumMatrix(m), commands, matrixStr, argsStr, expectedStr);
        }
        
        [Test]
        [TestCaseSource("testCases")]
        public void Test_CumulativeSum(string[] commands, string matrixStr, string argsStr, string expectedStr)
        {
            Test_Generic<NumMatrix_RowsSum>(m => new NumMatrix_RowsSum(m), commands, matrixStr, argsStr, expectedStr);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_TLE(string[] commands, string matrixStr, string argsStr, string expectedStr)
        {
            Test_Generic<NumMatrix_TLE>(m => new NumMatrix_TLE(m), commands, matrixStr, argsStr, expectedStr);
        }

        public void Test_Generic<T>(Func<int[][], T> constructor, string[] commands, string matrixStr, string argsStr, string expectedStr) where T: INumMatrix
        {
            var matrix = ArrayHelper.MatrixFromString<int>(matrixStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            Assert.That(args.Length == expected.Length);
            Assert.That(args.Length == commands.Length);

            var sol = constructor(matrix);
            var res = new int[expected.Length];
            for(int i=0; i<args.Length; i++)
                switch(commands[i])
                {
                    case "sumRegion":
                        Assert.That(4 ==args[i].Length);
                        res[i] = sol.SumRegion(args[i][0], args[i][1], args[i][2], args[i][3]);
                        break;
                }

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}