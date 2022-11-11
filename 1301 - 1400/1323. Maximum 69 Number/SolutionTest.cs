using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Maximum69Number
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {6, 9},
            new object[] {9, 9},
            new object[] {96, 99},
            new object[] {69, 99},
            new object[] {66, 96},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int num, int expected)
        {
            var sol = new Solution();
            var res = sol.Maximum69Number(num);

            Assert.AreEqual(expected, res);
        }
    }
}