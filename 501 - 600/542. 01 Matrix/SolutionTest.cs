using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace Matrix01
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0,0,0],[0,1,0],[0,0,0]]", "[[0,0,0],[0,1,0],[0,0,0]]"},
            new object[] {"[[0,0,0],[0,1,0],[1,1,1]]", "[[0,0,0],[0,1,0],[1,2,1]]"},
            new object[] {"[[1,0,0],[0,0,0],[0,0,0]]", "[[1,0,0],[0,0,0],[0,0,0]]"},
            new object[] {"[[0,0,0],[0,0,0],[0,0,1]]", "[[0,0,0],[0,0,0],[0,0,1]]"},
            new object[] {"[[0,0,1],[0,0,0],[0,0,0]]", "[[0,0,1],[0,0,0],[0,0,0]]"},
            new object[] {"[[0,0,0],[1,0,0],[0,0,0]]", "[[0,0,0],[1,0,0],[0,0,0]]"},
            new object[] {"[[0,0,0],[0,0,0],[1,0,0]]", "[[0,0,0],[0,0,0],[1,0,0]]"},
            new object[] {"[[1,1,1],[1,1,1],[1,1,0]]", "[[4,3,2],[3,2,1],[2,1,0]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string matStr, string expectedStr)
        {
            var mat = ArrayHelper.MatrixFromString<int>(matStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.UpdateMatrix(mat);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}