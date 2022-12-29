using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SingleThreadedCPU
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1000000000,1000000000]]", "[0]"},
            new object[] {"[[1,2],[2,4],[3,2],[4,1]]", "[0,2,3,1]"},
            new object[] {"[[7,10],[7,12],[7,5],[7,4],[7,2]]", "[4,3,2,0,1]"},
            new object[] {"[[19,13],[16,9],[21,10],[32,25],[37,4],[49,24],[2,15],[38,41],[37,34],[33,6],[45,4],[18,18],[46,39],[12,24]]", "[6,1,2,9,4,10,0,11,5,13,3,8,12,7]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string tasksStr, string expectedStr)
        {
            var tasks = ArrayHelper.MatrixFromString<int>(tasksStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.GetOrder(tasks);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}