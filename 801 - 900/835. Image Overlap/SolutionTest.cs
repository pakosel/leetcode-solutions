using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace ImageOverlap

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[0]]", "[[0]]", 0},
            new object[] {"[[0]]", "[[1]]", 0},
            new object[] {"[[1]]", "[[1]]", 1},
            new object[] {"[[1,1,0],[0,1,0],[0,1,0]]", "[[0,0,0],[0,1,1],[0,0,1]]", 3},
            new object[] {"[[1,0,0],[0,0,0],[0,0,0]]", "[[0,0,0],[0,1,0],[0,0,0]]", 1},
            new object[] {"[[0,0,0],[0,0,0],[0,0,1]]", "[[1,0,0],[0,0,0],[0,0,0]]", 1},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_GenericStr(string img1Str, string img2Str, int expected)
        {
            var img1 = ArrayHelper.MatrixFromString<int>(img1Str);
            var img2 = ArrayHelper.MatrixFromString<int>(img2Str);
            
            Assert.That(img1.Length == img2.Length);
            Assert.That(img1.Length == img1[0].Length);
            Assert.That(img2.Length == img2[0].Length);

            var sol = new Solution();
            var res = sol.LargestOverlap(img1, img2);

            Assert.That(expected == res);
        }
    }
}