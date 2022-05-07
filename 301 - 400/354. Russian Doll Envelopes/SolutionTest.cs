using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RussianDollEnvelopes
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[][] { }, 0 },
            new object[] {new int[][] { new int[] {1,1} }, 1 },
            new object[] {new int[][] {new int[] {5,4}, new int[] {6,4}, new int[] {6,7}, new int[] {2,3}}, 3 },
            new object[] {new int[][] {new int[] {2,100}, new int[] {3,200}, new int[] {4,300}, new int[] {5,500}, new int[] {5,400}, new int[] {5,250}, new int[] {6,370}, new int[] {6,360}, new int[] {7,380}}, 5 },
            new object[] {new int[][] {new int[] {46,89}, new int[] {50,53}, new int[] {52,68}, new int[] {72,45}, new int[] {77,81}}, 3 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[][] envelopes, int expected)
        {
            var sol = new Solution();
            var res = sol.MaxEnvelopes(envelopes);

            Assert.AreEqual(res, expected);
        }
    }
}