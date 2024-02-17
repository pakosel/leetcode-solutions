using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DestinationCity
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[London,New York],[New York,Lima],[Lima,Sao Paulo]]", "Sao Paulo"},
            new object[] {"[[B,C],[D,B],[C,A]]", "A"},
            new object[] {"[[A,Z]]", "Z"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pathsStr, string expected)
        {
            var paths = ArrayHelper.MatrixFromString<string>(pathsStr, contentWithSpace: true);

            var sol = new Solution();
            var res = sol.DestCity(paths);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}