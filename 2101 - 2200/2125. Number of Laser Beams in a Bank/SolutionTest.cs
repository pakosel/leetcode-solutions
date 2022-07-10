using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfLaserBeamsInBank
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"011001","000000","010100","001000"}, 8},  
            new object[] {new string[] {"000","111","000"}, 0},  
            new object[] {new string[] {"000"}, 0},  
            new object[] {new string[] {"1"}, 0},  
            new object[] {new string[] {"1", "1"}, 1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] bank, int expected)
        {
            var sol = new Solution();
            var res = sol.NumberOfBeams(bank);

            Assert.AreEqual(expected, res);
        }
    }
}