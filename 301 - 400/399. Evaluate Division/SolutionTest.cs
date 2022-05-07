using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace EvaluateDivision
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[[a,b],[b,c]]", new double[] {2.0,3.0}, "[[a,c],[b,a],[a,e],[a,a],[x,x]]", new double[] {6.00000,0.50000,-1.00000,1.00000,-1.00000}},
            new object[] {"[[a,b],[b,c],[bc,cd]]", new double[] {1.5,2.5,5.0}, "[[a,c],[c,b],[bc,cd],[cd,bc]]", new double[] {3.75000,0.40000,5.00000,0.20000}},
            new object[] {"[[a,b]]", new double[] {0.5}, "[[a,b],[b,a],[a,c],[x,y]]", new double[] {0.50000,2.00000,-1.00000,-1.00000}},
            new object[] {"[[a,b],[b,c],[bc,cd],[d,c]]", new double[] {1.5,2.5,5.0,15.0}, "[[a,c],[b,a],[a,e],[a,a],[x,x],[c,a],[a,d],[ab,c]]", new double[] {3.75000,0.66667,-1.00000,1.00000,-1.00000,0.26667,0.25000,-1.00000}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string equationsStr, double[] values, string queriesStr, double[] expected)
        {
            var equations = ArrayHelper.StringMatrixFromString(equationsStr);
            var queries = ArrayHelper.StringMatrixFromString(queriesStr);

            Assert.AreEqual(equations.Length, values.Length);
            Assert.AreEqual(queries.Length, expected.Length);

            var sol = new Solution();
            var res = sol.CalcEquation(equations, values, queries);

            CollectionAssert.AreEqual(res, expected);
        }
    }
}