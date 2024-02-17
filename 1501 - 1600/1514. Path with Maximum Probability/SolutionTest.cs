using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PathWithMaximumProbability
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {3, "[[0,1],[1,2],[0,2]]", new double[] {0.5,0.5,0.2}, 0, 2, 0.25000},
            new object[] {3, "[[0,1],[1,2],[0,2]]", new double[] {0.5,0.5,0.3}, 0, 2, 0.30000},
            new object[] {3, "[[0,1]]", new double[] {0.5}, 0, 2, 0.00000},
            new object[] {500, "[[193,229],[133,212],[224,465]]", new double[] {0.91,0.78,0.64}, 4, 364, 0.0},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(int n, string edgesStr, double[] succProb, int start, int end, double expected)
        {
            var edges = ArrayHelper.MatrixFromString<int>(edgesStr);
            
            ClassicAssert.AreEqual(edges.Length, succProb.Length);

            var sol = new Solution();
            var res = sol.MaxProbability(n, edges, succProb, start, end);

            Assert.That(expected == res);
        }
    }
}