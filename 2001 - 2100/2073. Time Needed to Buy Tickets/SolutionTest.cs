using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TimeNeededToBuyTickets
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[2,3,2]", 2, 6},
            new object[] {"[5,1,1,1]", 0, 8},
            new object[] {"[90,80,65,86,84,67,99,84,23,19,44,36,89,37,3,48,50,53,45,26,78,88,15,96,72,35,55,79,18,17,30,74,11,90,86,25,36,41,11,20,99,34,81,37,67,32,47,41,90,6,7,96,13,95,33,74,5,79,48,65,51,40,22,8,96,6,80,83,37,57,57,42,22,91,79,42,74,99,67,16,94,26,85,32,60,33,27,58,27,11,57,8,58,22,5,74,26,64,21,95]", 0, 5034},
            new object[] {"[90,80,65,86,84,67,99,84,23,19,44,36,89,37,3,48,50,53,45,26,78,88,15,96,72,35,55,79,18,17,30,74,11,90,86,25,36,41,11,20,99,34,81,37,67,32,47,41,90,6,7,96,13,95,33,74,5,79,48,65,51,40,22,8,96,6,80,83,37,57,57,42,22,91,79,42,74,99,67,16,94,26,85,32,60,33,27,58,27,11,57,8,58,22,5,74,26,64,21,95]", 1, 4848},
            new object[] {"[90,80,65,86,84,67,99,84,23,19,44,36,89,37,3,48,50,53,45,26,78,88,15,96,72,35,55,79,18,17,30,74,11,90,86,25,36,41,11,20,99,34,81,37,67,32,47,41,90,6,7,96,13,95,33,74,5,79,48,65,51,40,22,8,96,6,80,83,37,57,57,42,22,91,79,42,74,99,67,16,94,26,85,32,60,33,27,58,27,11,57,8,58,22,5,74,26,64,21,95]", 11, 2945},
            new object[] {"[90,80,65,86,84,67,99,84,23,19,44,36,89,37,3,48,50,53,45,26,78,88,15,96,72,35,55,79,18,17,30,74,11,90,86,25,36,41,11,20,99,34,81,37,67,32,47,41,90,6,7,96,13,95,33,74,5,79,48,65,51,40,22,8,96,6,80,83,37,57,57,42,22,91,79,42,74,99,67,16,94,26,85,32,60,33,27,58,27,11,57,8,58,22,5,74,26,64,21,95]", 57, 4837},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string ticketsStr, int k, int expected)
        {
            var tickets = ArrayHelper.ArrayFromString<int>(ticketsStr);

            var sol = new Solution();
            var res = sol.TimeRequiredToBuy(tickets, k);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}