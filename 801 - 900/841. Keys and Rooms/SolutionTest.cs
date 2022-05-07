using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace KeysAndRooms
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[1],[2],[3],[]]", true},
            new object[] {"[[],[2],[3],[1]]", false},
            new object[] {"[[1,3],[3,0,1],[2],[0]]", false},
            new object[] {"[[1,3],[3,0,1],[2],[0,2]]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string matrixStr, bool expected)
        {
            var rooms = ArrayHelper.MatrixFromString(matrixStr);
            
            var sol = new Solution();
            var res = sol.CanVisitAllRooms(rooms);

            Assert.AreEqual(res, expected);
        }
    }
}