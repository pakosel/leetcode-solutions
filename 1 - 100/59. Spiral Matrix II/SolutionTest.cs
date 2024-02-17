using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SpiralMatrixII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {1, "[[1]]"},
            new object[] {2, "[[1,2],[4,3]]"},
            new object[] {3, "[[1,2,3],[8,9,4],[7,6,5]]"},
            new object[] {6, "[[1,2,3,4,5,6],[20,21,22,23,24,7],[19,32,33,34,25,8],[18,31,36,35,26,9],[17,30,29,28,27,10],[16,15,14,13,12,11]]"},
            new object[] {11, "[[1,2,3,4,5,6,7,8,9,10,11],[40,41,42,43,44,45,46,47,48,49,12],[39,72,73,74,75,76,77,78,79,50,13],[38,71,96,97,98,99,100,101,80,51,14],[37,70,95,112,113,114,115,102,81,52,15],[36,69,94,111,120,121,116,103,82,53,16],[35,68,93,110,119,118,117,104,83,54,17],[34,67,92,109,108,107,106,105,84,55,18],[33,66,91,90,89,88,87,86,85,56,19],[32,65,64,63,62,61,60,59,58,57,20],[31,30,29,28,27,26,25,24,23,22,21]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int n, string expected)
        {
            var sol = new Solution();
            var res = sol.GenerateMatrix(n);

            Assert.That(ArrayHelper.MatrixToString(res) == expected);
        }
    }
}