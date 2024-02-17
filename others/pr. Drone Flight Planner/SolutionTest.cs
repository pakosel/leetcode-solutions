using System;
using System.Text;
using NUnit.Framework;

namespace DroneFlightPlanner
{
    [TestFixture]
    public class SolutionTest
    {

        private static readonly object[] testCases =
        {
            new object[] {new int[,] {{0, 2, 10}, {3, 5, 0}, {9, 20, 6}, {10, 12, 15}, {10, 10, 8} }, 5},
            new object[] {new int[,] {{0, 1, 19}}, 0},
            new object[] {new int[,] {{0, 2, 10}, {10, 10, 8}}, 0},
            new object[] {new int[,] {{0, 2, 6}, {10, 10, 20}}, 14},
            new object[] {new int[,] {{0, 2, 2}, {3, 5, 38}, {9, 20, 6}, {10, 12, 15}, {10, 10, 8}}, 36},
            new object[] {new int[,] {{0, 2, 10}, {3, 5, 9}, {9, 20, 6}, {10, 12, 2}, {10, 10, 10}, {10,10,2}}, 0}
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(int[,] route, int expected)
        {
            var ret = Solution.CalcDroneMinEnergy(route);

            Assert.That(expected == ret);
        }
    }
}