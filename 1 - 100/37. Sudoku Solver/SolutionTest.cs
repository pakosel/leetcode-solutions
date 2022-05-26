using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SudokuSolver
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[['5','3','.','.','7','.','.','.','.'],['6','.','.','1','9','5','.','.','.'],['.','9','8','.','.','.','.','6','.'],['8','.','.','.','6','.','.','.','3'],['4','.','.','8','.','3','.','.','1'],['7','.','.','.','2','.','.','.','6'],['.','6','.','.','.','.','2','8','.'],['.','.','.','4','1','9','.','.','5'],['.','.','.','.','8','.','.','7','9']]", "[['5','3','4','6','7','8','9','1','2'],['6','7','2','1','9','5','3','4','8'],['1','9','8','3','4','2','5','6','7'],['8','5','9','7','6','1','4','2','3'],['4','2','6','8','5','3','7','9','1'],['7','1','3','9','2','4','8','5','6'],['9','6','1','5','3','7','2','8','4'],['2','8','7','4','1','9','6','3','5'],['3','4','5','2','8','6','1','7','9']]"},
            new object[] {"[['.','.','1','.','.','.','7','.','.'],['.','.','.','.','1','.','4','8','5'],['8','4','.','6','.','.','.','3','.'],['5','.','.','1','9','.','.','.','.'],['.','.','3','5','.','.','.','.','6'],['.','.','.','.','.','.','5','.','.'],['.','5','9','3','.','.','6','4','.'],['1','8','.','7','2','.','.','.','3'],['3','.','.','.','.','.','.','.','.']]", "[['2','3','1','4','5','8','7','6','9'],['6','9','7','2','1','3','4','8','5'],['8','4','5','6','7','9','2','3','1'],['5','6','8','1','9','7','3','2','4'],['9','7','3','5','4','2','8','1','6'],['4','1','2','8','3','6','5','9','7'],['7','5','9','3','8','1','6','4','2'],['1','8','6','7','2','4','9','5','3'],['3','2','4','9','6','5','1','7','8']]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string boardStr, string expectedStr)
        {
            var board = ArrayHelper.MatrixFromString<char>(boardStr);
            var expected = ArrayHelper.MatrixFromString<char>(expectedStr);

            var sol = new Solution();
            sol.SolveSudoku(board);

            CollectionAssert.AreEqual(board, expected);
        }
    }
}