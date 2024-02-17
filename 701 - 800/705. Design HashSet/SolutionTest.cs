using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignHashSet
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"add", "add", "contains", "contains", "add", "contains", "remove", "contains"}, new int[] {1,2,1,3,2,2,2,2}, new bool?[] {null, null, true, false, null, true, null, false}},
            new object[] {new string[] {"add","add","contains","contains","add","contains","remove","contains","remove","add","contains"}, new int[] {1,2,1,3,2,2,2,2,5,5,5}, new bool?[] {null, null, true, false, null, true, null, false, null, null, true}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] commands, int[] args, bool?[] expected)
        {
            ClassicAssert.AreEqual(commands.Length, args.Length);
            ClassicAssert.AreEqual(commands.Length, expected.Length);
            bool?[] res = new bool?[commands.Length];

            var sol = new MyHashSet();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "add":
                        sol.Add(args[i]);
                        break;
                    case "remove":
                        sol.Remove(args[i]);
                        break;
                    case "contains":
                        res[i] = sol.Contains(args[i]);
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}