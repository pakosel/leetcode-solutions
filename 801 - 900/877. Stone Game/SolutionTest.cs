using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace StoneGame
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[1,2]", true},
            new object[] {"[4,1,2,4]", true},
            new object[] {"[5,3,4,5]", true},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Memoization(string arrStr, bool expected)
        {
            var arr = arrStr.TrimStart('[').TrimEnd(']').Split(",")
                .Select(s => int.Parse(s)).ToArray();

            Assert.That(arr.Length > 0);

            var sol = new Solution_Memoization();
            var res = sol.StoneGame(arr);

            Assert.That(expected == res);
        }
    }
}