using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SubsetsII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[0]", "[[],[0]]"},
            new object[] {"[1,2,2]", "[[],[1],[1,2],[1,2,2],[2],[2,2]]"},
            new object[] {"[2,2,10,-10,8,-9]", "[[],[-10],[-9],[-10,-9],[2],[-10,2],[-9,2],[-10,-9,2],[2,2],[-10,2,2],[-9,2,2],[-10,-9,2,2],[8],[-10,8],[-9,8],[-10,-9,8],[2,8],[-10,2,8],[-9,2,8],[-10,-9,2,8],[2,2,8],[-10,2,2,8],[-9,2,2,8],[-10,-9,2,2,8],[10],[-10,10],[-9,10],[-10,-9,10],[2,10],[-10,2,10],[-9,2,10],[-10,-9,2,10],[2,2,10],[-10,2,2,10],[-9,2,2,10],[-10,-9,2,2,10],[8,10],[-10,8,10],[-9,8,10],[-10,-9,8,10],[2,8,10],[-10,2,8,10],[-9,2,8,10],[-10,-9,2,8,10],[2,2,8,10],[-10,2,2,8,10],[-9,2,2,8,10],[-10,-9,2,2,8,10]]"}
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string arrStrIn, string arrStrOut)
        {
            var expected = ArrayHelper.MatrixFromString<int>(arrStrOut);

            var nums = ArrayHelper.ArrayFromString<int>(arrStrIn);

            var sol = new Solution();
            var res = sol.SubsetsWithDup(nums);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}