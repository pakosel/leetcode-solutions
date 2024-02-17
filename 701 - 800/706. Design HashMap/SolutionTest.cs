using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignHashMap
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"put", "put", "get", "get", "put", "get", "remove", "get"}, "[[1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]", new int?[] {null, null, 1, -1, null, 1, null, -1}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] commands, string argsStr, int?[] expected)
        {
            var args = ArrayHelper.MatrixFromString<int>(argsStr);
            ClassicAssert.AreEqual(commands.Length, args.Length);
            ClassicAssert.AreEqual(commands.Length, expected.Length);
            int?[] res = new int?[commands.Length];

            var sol = new MyHashMap();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "put":
                        sol.Put(args[i][0], args[i][1]);
                        break;
                    case "get":
                        res[i] = sol.Get(args[i][0]);
                        break;
                    case "remove":
                        sol.Remove(args[i][0]);
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}