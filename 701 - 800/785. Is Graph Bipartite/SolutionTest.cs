using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IsGraphBipartite
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[]]", true},
            new object[] {"[[1,2,3],[0,2],[0,1,3],[0,2]]", false},
            new object[] {"[[1,3],[0,2],[1,3],[0,2]]", true},
            new object[] {"[[1],[0,3],[3],[1,2]]", true},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string graphStr, bool expected)
        {
            var graph = ArrayHelper.MatrixFromString<int>(graphStr);

            var sol = new Solution();
            var res = sol.IsBipartite(graph);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}