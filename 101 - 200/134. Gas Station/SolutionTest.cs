using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GasStation
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,4,5]","[3,4,5,1,2]", 3},
            new object[] {"[3,3,2]","[1,4,3]", 0},
            new object[] {"[3,2,3]","[4,3,1]", 2},
            new object[] {"[2,3,3]","[3,1,4]", 1},
            new object[] {"[1,2,3,4,5]","[1,3,5,3,3]", 3},
            new object[] {"[1]","[1]", 0},
            new object[] {"[1,5]","[4,1]", 1},
            new object[] {"[1,5]","[4,2]", 1},
            new object[] {"[5,4,3,2,1,7,2,1]","[3,4,5,1,2,3,4,3]", 0},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string gasStr, string costStr, int expected)
        {
            var gas = ArrayHelper.ArrayFromString<int>(gasStr);
            var cost = ArrayHelper.ArrayFromString<int>(costStr);

            var sol = new Solution();
            var res = sol.CanCompleteCircuit(gas, cost);

            Assert.That(expected == res);
        }
    }
}