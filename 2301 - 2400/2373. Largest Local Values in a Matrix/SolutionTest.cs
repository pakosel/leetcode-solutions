using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LargestLocalValuesInMatrix
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[9,9,8,1],[5,6,2,6],[8,2,6,4],[6,2,2,2]]", "[[9,9],[8,6]]"},
            new object[] {"[[1,1,1,1,1],[1,1,1,1,1],[1,1,2,1,1],[1,1,1,1,1],[1,1,1,1,1]]", "[[2,2,2],[2,2,2],[2,2,2]]"},
            new object[] {"[[20,8,20,6,16,16,7,16,8,10],[12,15,13,10,20,9,6,18,17,6],[12,4,10,13,20,11,15,5,17,1],[7,10,14,14,16,5,1,7,3,11],[16,2,9,15,9,8,6,1,7,15],[18,15,18,8,12,17,19,7,7,8],[19,11,15,16,1,3,7,4,7,11],[11,6,5,14,12,18,3,20,14,6],[4,4,19,6,17,12,8,8,18,8],[19,15,14,11,11,13,12,6,16,19]]", "[[20,20,20,20,20,18,18,18],[15,15,20,20,20,18,18,18],[16,15,20,20,20,15,17,17],[18,18,18,17,19,19,19,15],[19,18,18,17,19,19,19,15],[19,18,18,18,19,20,20,20],[19,19,19,18,18,20,20,20],[19,19,19,18,18,20,20,20]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string gridStr, string expectedStr)
        {
            var grid = ArrayHelper.MatrixFromString<int>(gridStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.LargestLocal(grid);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}