using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NQueens
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {1, "[[Q]]"},
            new object[] {2, "[]"},
            new object[] {3, "[]"},
            new object[] {4, "[[.Q..,...Q,Q...,..Q.],[..Q.,Q...,...Q,.Q..]]"},
            new object[] {5, "[[Q....,..Q..,....Q,.Q...,...Q.],[Q....,...Q.,.Q...,....Q,..Q..],[.Q...,...Q.,Q....,..Q..,....Q],[.Q...,....Q,..Q..,Q....,...Q.],[..Q..,Q....,...Q.,.Q...,....Q],[..Q..,....Q,.Q...,...Q.,Q....],[...Q.,Q....,..Q..,....Q,.Q...],[...Q.,.Q...,....Q,..Q..,Q....],[....Q,.Q...,...Q.,Q....,..Q..],[....Q,..Q..,Q....,...Q.,.Q...]]"},
            new object[] {6, "[[.Q....,...Q..,.....Q,Q.....,..Q...,....Q.],[..Q...,.....Q,.Q....,....Q.,Q.....,...Q..],[...Q..,Q.....,....Q.,.Q....,.....Q,..Q...],[....Q.,..Q...,Q.....,.....Q,...Q..,.Q....]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int n, string expectedStr)
        {
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.SolveNQueens(n);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}