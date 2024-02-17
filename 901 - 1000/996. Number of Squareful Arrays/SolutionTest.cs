using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NumberOfSquarefulArrays
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1]", 1},
            new object[] {"[2]", 1},
            new object[] {"[4]", 1},
            new object[] {"[2,2]", 1},
            new object[] {"[2,2,2]", 1},
            new object[] {"[1,17,8]", 2},
            new object[] {"[99,62,10,47,53,9,83,33,15,24]", 0},
            new object[] {"[75,91,39,33,39,39,69,20,43,38,48,29]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string arrStr, int expected)
        {
            var input = ArrayHelper.ArrayFromString<int>(arrStr);

            var sol = new Solution();
            var res = sol.NumSquarefulPerms(input);

            Assert.That(expected == res);
        }
    }
}