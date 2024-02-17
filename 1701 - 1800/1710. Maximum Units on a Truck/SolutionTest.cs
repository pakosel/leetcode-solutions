using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximumUnitsOnTruck
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,3],[2,2],[3,1]]", 4, 8},
            new object[] {"[[5,10],[2,5],[4,7],[3,9]]", 10, 91},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string boxTypesStr, int truckSize, int expected)
        {
            var boxTypes = ArrayHelper.MatrixFromString<int>(boxTypesStr);

            var sol = new Solution();
            var res = sol.MaximumUnits(boxTypes, truckSize);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}