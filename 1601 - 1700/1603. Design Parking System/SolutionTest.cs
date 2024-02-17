using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignParkingSystem
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[ParkingSystem,addCar,addCar,addCar,addCar]", "[[1,1,0],[1],[2],[3],[1]]", "[false,true,true,false,false]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string commandsStr, string argsStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            var expected = ArrayHelper.ArrayFromString<bool>(expectedStr);
            
            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);

            var sol = new ParkingSystem(args[0][0], args[0][1], args[0][2]);
            var res = new bool[args.Length];
            for(int i=1; i<commands.Length; i++)
                res[i] = sol.AddCar(args[i][0]);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}