using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Triangle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[2],[3,4],[6,5,7],[4,1,8,3]]", 11},
            new object[] {"[[-10]]", -10},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(string triangleStr, int expected)
        {
            var triangle = ArrayHelper.MatrixFromString<int>(triangleStr);

            var sol = new Solution();
            var res = sol.MinimumTotal(triangle);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}