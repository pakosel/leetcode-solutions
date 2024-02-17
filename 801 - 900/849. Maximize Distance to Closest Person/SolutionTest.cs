using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MaximizeDistanceToClosestPerson
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,0,0,0,1,0,1]", 2 },
            new object[] {"[1,0,0,0]", 3 },
            new object[] {"[0,1]", 1 },
            new object[] {"[1,0]", 1 },
            new object[] {"[1,0,0,1,1,1,1,1]", 1 },
            new object[] {"[1,1,1,0,1,1,0,1,0,0,1]", 1 },
            new object[] {"[0,0,0,1,0,0,0]", 3 },
            new object[] {"[0,0,0,0,1,0,0,0]", 4 },
            new object[] {"[0,0,0,1,0,0,0,0]", 4 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string seatsArr, int expected)
        {
            var seats = ArrayHelper.ArrayFromString<int>(seatsArr);

            var sol = new Solution();
            var res = sol.MaxDistToClosest(seats);

            Assert.That(expected == res);
        }
    }
}