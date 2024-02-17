using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RobotBoundedInCircle
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"G", false},
            new object[] {"L", true},
            new object[] {"R", true},
            new object[] {"GGLLGG", true},
            new object[] {"GG", false},
            new object[] {"GL", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string instructions, bool expected)
        {
            var sol = new Solution();
            var res = sol.IsRobotBounded(instructions);
            
            ClassicAssert.AreEqual(expected, res);
        }
    }
}