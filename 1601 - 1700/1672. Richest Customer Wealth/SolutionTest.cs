using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace RichestCustomerWealth
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[[1,2,3],[3,2,1]]" , 6},
            new object[] {"[[1,5],[7,3],[3,5]]" , 10},
            new object[] {"[[2,8,7],[7,1,3],[1,9,5]]" , 17},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string accountsStr, int expected)
        {
            var accounts = ArrayHelper.MatrixFromString<int>(accountsStr);

            var sol = new Solution();
            var res = sol.MaximumWealth(accounts);

            Assert.That(expected == res);
        }
   }
}