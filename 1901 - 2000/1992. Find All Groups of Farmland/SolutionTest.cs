using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindAllGroupsOfFarmland
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,0,0],[0,1,1],[0,1,1]]", "[[0,0,0,0],[1,1,2,2]]"},
            new object[] {"[[1,1],[1,1]]", "[[0,0,1,1]]"},
            new object[] {"[[0]]", "[]"},
            new object[] {"[[0,0,0],[1,0,1],[1,0,1]]", "[[1,0,2,0],[1,2,2,2]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string landStr, string expectedStr)
        {
            var land = ArrayHelper.MatrixFromString<int>(landStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.FindFarmland(land);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}