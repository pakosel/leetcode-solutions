using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberAfterDoubleReversal
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {0, true},           
            new object[] {1, true},           
            new object[] {526, true},           
            new object[] {10, false},           
            new object[] {1800, false},           
            new object[] {87936, true},           
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(int num, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsSameAfterReversals(num);

            Assert.AreEqual(expected, res);
        }
    }
}