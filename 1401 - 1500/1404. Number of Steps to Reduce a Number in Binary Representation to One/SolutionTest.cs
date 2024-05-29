using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfStepsToReduceNumberInBinaryRepresentationToOne
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"1101", 6},
            new object[] {"10", 1},
            new object[] {"1", 0},
            new object[] {"11", 3},
            new object[] {"11", 3},
            new object[] {"111", 4},
            new object[] {"110", 4},
            new object[] {"101", 5},
            new object[] {"11011101111110111011111010110111010110111101110111110101101111011101111101011011110111011111010110111101110111111011101111101011011101011011110111011111010110111101110111110101101111011101111110111011111010110111010110111101110111110101101111011101111101011011110111011111010110111101110111110101101111011101111110111011111010110111010110111101110111110101101111011101111101011011110111110111011111101110111110101101110101101111011101111101011011110111011111010110111101110111110101101101111101011011", 626},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string s, int expected)
        {
            var sol = new Solution();
            var res = sol.NumSteps(s);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}