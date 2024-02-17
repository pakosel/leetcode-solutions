using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ImageSmoother
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,1,1],[1,0,1],[1,1,1]]", "[[0,0,0],[0,0,0],[0,0,0]]"},
            new object[] {"[[100,200,100],[200,50,200],[100,200,100]]", "[[137,141,137],[141,138,141],[137,141,137]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string imgStr, string expectedStr)
        {
            var img = ArrayHelper.MatrixFromString<int>(imgStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.ImageSmoother(img);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}