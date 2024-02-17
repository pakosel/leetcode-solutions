using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace CountAllPossibleRoutes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,6,8,4]", 1, 3, 5, 4},
            new object[] {"[4,3,1]", 1, 0, 6, 5},
            new object[] {"[5,2,1]", 0, 2, 3, 0},
            new object[] {"[53,78,75,86,52,81,64,66,98,96,68,71,39,49,31,25,82,58,63,69,70,6,83,20,17,28,9,94,47,43,99,88,36,21,60,65,27,77,33,57,67,45,92,26,8,72,24,22,41,91,14,61,90,85,89,13,11,79,34,95,55,84,23,3,15,56,73,2,16,35,18,54,38,37,40,48,97,80,44,19,10,76,46,87,1,50,12,30,62,93,32,29,100,59,5,51,4,42,7,74]", 1, 0, 200, 812757293},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string locationsStr, int start, int finish, int fuel, int expected)
        {
            var locations = ArrayHelper.ArrayFromString<int>(locationsStr);

            var sol = new Solution();
            var res = sol.CountRoutes(locations, start, finish, fuel);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}