using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RobotCollisions
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[5,4,3,2,1]", "[2,17,9,15,10]", "RRRRR", "[2,17,9,15,10]"},
            new object[] {"[3,5,2,6]", "[10,10,15,12]", "RLRL", "[14]"},
            new object[] {"[1,2,5,6]", "[10,10,11,11]", "RLRL", "[]"},
            new object[] {"[3,5,2,6]", "[10,17,15,12]", "RLRL", "[15,12]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string positionsStr, string healthsStr, string directions, string expectedStr)
        {
            var positions = ArrayHelper.ArrayFromString<int>(positionsStr);
            var healths = ArrayHelper.ArrayFromString<int>(healthsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.SurvivedRobotsHealths(positions, healths, directions);
            
            Assert.That(expected, Is.EqualTo(res));
        }
    }
}