using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace BaseballGame
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"1"}, 1},
            new object[] {new string[] {"1","1","+"}, 4},
            new object[] {new string[] {"1", "D"}, 3},
            new object[] {new string[] {"1","7","C"}, 1},
            new object[] {new string[] {"5","2","C","D","+"}, 30},
            new object[] {new string[] {"5","-2","4","C","D","9","+","+"}, 27},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string[] ops, int expected)
        {
            var sol = new SolutionStack();
            var res = sol.CalPoints(ops);

            Assert.AreEqual(res, expected);
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_List(string[] ops, int expected)
        {
            var sol = new SolutionList();
            var res = sol.CalPoints(ops);

            Assert.AreEqual(res, expected);
        }
    }
}