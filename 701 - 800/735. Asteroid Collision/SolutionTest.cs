using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AsteroidCollision
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[5,10,-5]", "[5,10]"},
            new object[] {"[8,-8]", "[]"},
            new object[] {"[10,2,-5]", "[10]"},
            new object[] {"[1,2,3,10,-10,-5]", "[-5]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string asteroidsStr, string expectedStr)
        {
            var asteroids = ArrayHelper.ArrayFromString<int>(asteroidsStr);
            var expected = ArrayHelper.ArrayFromString<int>(expectedStr);
            
            var sol = new Solution();
            var res = sol.AsteroidCollision(asteroids);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}