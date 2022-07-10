using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ValidSudoku
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new char[][] {new char[] {'5','3','.','.','7','.','.','.','.'}, new char[] {'6','.','.','1','9','5','.','.','.'}, new char[] {'.','9','8','.','.','.','.','6','.'}, new char[] {'8','.','.','.','6','.','.','.','3'}, new char[] {'4','.','.','8','.','3','.','.','1'}, new char[] {'7','.','.','.','2','.','.','.','6'}, new char[] {'.','6','.','.','.','.','2','8','.'}, new char[] {'.','.','.','4','1','9','.','.','5'}, new char[] {'.','.','.','.','8','.','.','7','9'}}, true},
            new object[] {new char[][] {new char[] {'8','3','.','.','7','.','.','.','.'},new char[]{'6','.','.','1','9','5','.','.','.'},new char[]{'.','9','8','.','.','.','.','6','.'},new char[]{'8','.','.','.','6','.','.','.','3'},new char[]{'4','.','.','8','.','3','.','.','1'},new char[]{'7','.','.','.','2','.','.','.','6'},new char[]{'.','6','.','.','.','.','2','8','.'},new char[]{'.','.','.','4','1','9','.','.','5'},new char[]{'.','.','.','.','8','.','.','7','9'}}, false}
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(char[][] board, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsValidSudoku(board);

            Assert.AreEqual(expected, res);
        }
    }
}