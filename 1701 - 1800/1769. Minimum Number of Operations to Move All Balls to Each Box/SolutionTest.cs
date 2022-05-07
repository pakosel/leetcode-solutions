using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"0", "[0]"},
            new object[] {"1", "[0]"},
            new object[] {"00", "[0,0]"},
            new object[] {"11", "[1,1]"},
            new object[] {"10", "[0,1]"},
            new object[] {"01", "[1,0]"},
            new object[] {"110", "[1,1,3]"},
            new object[] {"001011", "[11,8,5,4,3,4]"},
            new object[] {"10111001110", "[33,28,23,20,19,20,21,22,25,30,37]"},
            new object[] {"101111111111111111111", "[209,191,173,157,143,131,121,113,107,103,101,101,103,107,113,121,131,143,157,173,191]"},
            new object[] {"111111111111111111", "[153,137,123,111,101,93,87,83,81,81,83,87,93,101,111,123,137,153]"},
            new object[] {"101010101010101010101010101010101010101", "[380,362,344,328,312,298,284,272,260,250,240,232,224,218,212,208,204,202,200,200,200,202,204,208,212,218,224,232,240,250,260,272,284,298,312,328,344,362,380]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string boxes, string expectedStr)
        {
            var sol = new Solution();
            var res = sol.MinOperations(boxes);
            var expected = ArrayHelper.ArrayFromString(expectedStr);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}