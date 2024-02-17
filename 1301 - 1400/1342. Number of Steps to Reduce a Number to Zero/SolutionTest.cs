using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfStepsToReduceNumberToZero
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {0, 0},
            new object[] {14, 6},
            new object[] {8, 4},
            new object[] {123, 12},
            new object[] {69233, 24},
            new object[] {10586, 20},
            new object[] {36826, 25},
            new object[] {93453, 25},
            new object[] {64, 7},
            new object[] {82551, 25},
            new object[] {48137, 22},
            new object[] {66232, 22},
            new object[] {3339, 17},
            new object[] {24029, 25},
            new object[] {1000000, 26},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int num, int expected)
        {
            var sol = new Solution();
            var res = sol.NumberOfSteps(num);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}