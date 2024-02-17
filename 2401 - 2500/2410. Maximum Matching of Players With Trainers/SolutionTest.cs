using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumMatchingOfPlayersWithTrainers
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4,7,9]","[8,2,5,8]",2},
            new object[] {"[1,1,1]","[10]",1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string playersStr, string trainersStr, int expected)
        {
            var players = ArrayHelper.ArrayFromString<int>(playersStr);
            var trainers = ArrayHelper.ArrayFromString<int>(trainersStr);
            
            var sol = new Solution();
            var res = sol.MatchPlayersAndTrainers(players, trainers);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}