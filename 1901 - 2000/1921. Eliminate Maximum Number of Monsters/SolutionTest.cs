using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EliminateMaximumNumberOfMonsters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,3,4]", "[1,1,1]", 3},
            new object[] {"[1,1,2,3]", "[1,1,1,1]", 1},
            new object[] {"[3,2,4]", "[5,3,2]", 1},
            new object[] {"[4,2,3]", "[2,1,1]", 3},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string distStr, string speedStr, int expected)
        {
            var dist = ArrayHelper.ArrayFromString<int>(distStr);
            var speed = ArrayHelper.ArrayFromString<int>(speedStr);

            var sol = new Solution();
            var res = sol.EliminateMaximum(dist, speed);

            Assert.AreEqual(expected, res);
        }
    }
}