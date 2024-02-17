using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TwoCityScheduling
{
    [TestFixture]
    public class MaximumDifferenceBetweenNodeAncestor
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[10,20],[30,200],[400,50],[30,20]]", 110},
            new object[] {"[[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]", 1859},
            new object[] {"[[515,563],[451,713],[537,709],[343,819],[855,779],[457,60],[650,359],[631,42]]", 3086},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string costsStr, int expected)
        {
            var costs = ArrayHelper.MatrixFromString<int>(costsStr);

            var sol = new Solution();
            var res = sol.TwoCitySchedCost(costs);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}