using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace MaximumLengthOfPairChain
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[][] { }, 0 },
            new object[] {new int[][] { new int[] {1,2} }, 1 },
            new object[] {new int[][] { new int[] {1,2}, new int[] {2,3}, new int[] {3,4} }, 2 },
            new object[] {new int[][] { new int[] {1,2}, new int[] {2,3}, new int[] {3,4}, new int[] {1,2}, new int[] {7,8} }, 3 },
            new object[] {new int[][] { new int[] {2,3}, new int[] {1,2}, new int[] {7,8}, new int[] {3,4}, new int[] {1,2} }, 3 },
            new object[] {new int[][] { new int[] {-6,9}, new int[] {1,6}, new int[] {8,10}, new int[] {-1,4}, new int[] {-6,-2}, new int[] {-9,8}, new int[] {-5,3}, new int[] {0,3}}, 3 },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[][] pairs, int expected)
        {
            var sol = new Solution();
            var res = sol.FindLongestChain(pairs);

            ClassicAssert.AreEqual(expected, res);
        }
    }
}