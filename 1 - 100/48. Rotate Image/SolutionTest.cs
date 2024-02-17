using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace RotateImage
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new int[][] { new int[] { } },
                          new int[][] { new int[] { } },
                        },
            new object[] {new int[][] { new int[] { 1 } },
                          new int[][] { new int[] { 1 } },
                        },
            new object[] {new int[][] { new int[] { 1, 2},
                                        new int[] { 3, 4}}, 
                          new int[][] { new int[] { 3, 1},
                                        new int[] { 4, 2}}, 
                        },
            new object[] {new int[][] { new int[] { 1, 2, 3},
                                        new int[] { 4, 5, 6},
                                        new int[] { 7, 8, 9}}, 
                          new int[][] { new int[] { 7, 4, 1},
                                        new int[] { 8, 5, 2},
                                        new int[] { 9, 6, 3}}, 
                        },
            new object[] {new int[][] { new int[] { 1, 2, 3, 4},
                                        new int[] { 5, 6, 7, 8},
                                        new int[] { 9,10,11,12},
                                        new int[] {13,14,15,16}}, 
                          new int[][] { new int[] {13, 9, 5, 1},
                                        new int[] {14,10, 6, 2},
                                        new int[] {15,11, 7, 3},
                                        new int[] {16,12, 8, 4}}, 
                        },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(int[][] matrix, int[][] expected)
        {
            var sol = new Solution();
            sol.Rotate(matrix);

            Assert.That(matrix, Is.EqualTo(expected));
        }
    }
}