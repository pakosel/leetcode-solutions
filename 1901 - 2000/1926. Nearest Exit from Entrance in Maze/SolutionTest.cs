using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace NearestExitFromEntranceInMaze
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[+,+,.,+],[.,.,.,+],[+,+,+,.]]", "[1,2]", 1},
            new object[] {"[[+,+,+],[.,.,.],[+,+,+]]", "[1,0]", 2},
            new object[] {"[[.,+]]", "[0,0]", -1},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string mazeStr, string entranceStr, int expected)
        {
            var maze = ArrayHelper.MatrixFromString<char>(mazeStr);
            var entrance = ArrayHelper.ArrayFromString<int>(entranceStr);

            var sol = new Solution();
            var res = sol.NearestExit(maze, entrance);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}