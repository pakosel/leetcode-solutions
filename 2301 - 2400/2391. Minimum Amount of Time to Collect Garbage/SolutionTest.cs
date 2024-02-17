using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MinimumAmountOfTimeToCollectGarbage
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[G,P,GP,GG]", "[2,4,3]", 21},
            new object[] {"[MMM,PGM,GP]", "[3,10]", 37},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string garbageStr, string travelStr, int expected)
        {
            var garbage = ArrayHelper.ArrayFromString<string>(garbageStr);
            var travel = ArrayHelper.ArrayFromString<int>(travelStr);
            
            var sol = new Solution();
            var res = sol.GarbageCollection(garbage, travel);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}