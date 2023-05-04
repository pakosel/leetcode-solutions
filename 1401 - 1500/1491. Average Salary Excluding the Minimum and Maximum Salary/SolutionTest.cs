using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[4000,3000,1000,2000]", 2500.00000},
            new object[] {"[1000,2000,3000]", 2000.00000},
            new object[] {"[65360, 282697, 613849, 365113, 616513, 893147, 168476, 245288, 425076, 705594, 381106, 666314, 255436, 320776, 908456, 698977, 682052, 497960, 65567, 258943, 713136, 587887, 688963, 247133, 748398, 971090, 504539, 298511, 30904, 310589, 902053, 922624, 633173, 73017, 988830, 180120, 733203, 987484, 670167, 955583, 509388, 246597, 473665, 955186, 122784, 315517, 142035, 998241, 764349, 889023, 269004, 439229, 989320, 964537, 631988, 20580, 746582, 571656, 703286, 477183, 99174, 654832, 718544, 933764, 726229, 443834, 457677, 820219, 54149, 71747, 213099, 692066, 685112, 28060, 440614, 182963, 481606, 42710, 378285, 981186, 178654, 107871, 344341, 294148, 568203, 243935, 853778, 71612, 26938, 803886, 970787, 931658, 109882, 585505, 910471, 488056, 273711, 278352, 13397, 870773]", 505249.42857},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericLinq(string salaryStr, double expected)
        {
            var salary = ArrayHelper.ArrayFromString<int>(salaryStr);

            var sol = new SolutionLinq();
            var res = sol.Average(salary);
            res = Math.Round(res, 5);

            Assert.AreEqual(expected, res);
        }        
        
        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string salaryStr, double expected)
        {
            var salary = ArrayHelper.ArrayFromString<int>(salaryStr);

            var sol = new Solution();
            var res = sol.Average(salary);
            res = Math.Round(res, 5);

            Assert.AreEqual(expected, res);
        }
    }
}