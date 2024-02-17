using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace JumpGameVII
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"011010", 2, 3, true},
            new object[] {"01101110", 2, 3, false},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic_DP(string s, int minJump, int maxJump, bool expected)
        {
            var sol = new Solution_DP();
            var res = sol.CanReach(s, minJump, maxJump);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic_Queue(string s, int minJump, int maxJump, bool expected)
        {
            var sol = new Solution_Queue();
            var res = sol.CanReach(s, minJump, maxJump);

            Assert.That(expected == res);
        }
    }
}