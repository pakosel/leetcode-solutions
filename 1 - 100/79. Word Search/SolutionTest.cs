using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace WordSearch
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[A,B,C,E],[S,F,C,S],[A,D,E,E]]", "ABCCED", true},
            new object[] {"[[A,B,C,E],[S,F,C,S],[A,D,E,E]]", "SEE", true},
            new object[] {"[[A,B,C,E],[S,F,C,S],[A,D,E,E]]", "ABCB", false},
            new object[] {"[[A,B,C,E,C,E],[S,F,C,S,C,S],[A,D,E,E,E,E],[A,B,C,E,C,E],[S,F,C,S,C,S],[A,D,E,E,E,E]]", "EECSECESEECCEEE", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string boardStr, string word, bool expected)
        {
            var board = ArrayHelper.MatrixFromString<char>(boardStr);

            var sol = new Solution();
            var res = sol.Exist(board, word);

            Assert.That(expected == res);
        }
    }
}