using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SeatReservationManager
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[SeatManager,reserve,reserve,unreserve,reserve,reserve,reserve,reserve,unreserve]", "[[5],[],[],[2],[],[],[],[],[5]]", "[null,1,2,null,2,3,4,5,null]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<int?>(expectedStr);
            
            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);

            var sol = new SeatManager(args[0][0]);
            var res = new int?[args.Length];
            for(int i=1; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "reserve":
                        res[i] = sol.Reserve();
                        break;
                    case "unreserve":
                        sol.Unreserve(args[i][0]);
                        break;
                }

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}