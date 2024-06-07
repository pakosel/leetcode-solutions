using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace HandOfStraights
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[1,2,3,6,2,3,4,7,8]", 3, true},
            new object[] {"[1,2,3,4,5]", 4, false},
            new object[] {"[1,1,2,2,3,3]", 2, false},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string hadndStr, int groupSize, bool expected)
        {
            var hand = ArrayHelper.ArrayFromString<int>(hadndStr);
            
            var sol = new Solution();
            var res = sol.IsNStraightHand(hand, groupSize);

            Assert.That(expected, Is.EqualTo(res));
        }
    }
}