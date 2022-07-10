using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace IteratorForCombination

{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"next", "hasNext", "next", "hasNext", "next", "hasNext"}, "abc", 2, new object[] {"ab",true,"ac",true,"bc",false}},
            new object[] {new string[] {"hasNext","next","hasNext","hasNext","next","next","hasNext","hasNext","hasNext","hasNext"}, "chp", 1, new object[] {true,"c",true,true,"h","p",false,false,false,false}},
            new object[] {new string[] {"next","hasNext","next","hasNext","next","hasNext","next","hasNext","next","hasNext","next","hasNext"}, "abcd", 2, new object[] {"ab",true,"ac",true,"ad",true,"bc",true,"bd",true,"cd",false}},
            new object[] {new string[] {"next","hasNext","next","hasNext","next","hasNext","next","hasNext","next","hasNext","next","hasNext"}, "abcde", 3, new object[] {"abc",true,"abd",true,"abe",true,"acd",true,"ace",true,"ade",true}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string[] operations, string characters, int combinationLength, object[] expected)
        {
            var sol = new CombinationIterator(characters, combinationLength);
            object[] res = new object[operations.Length];

            int idx = 0;
            foreach (var op in operations)
                switch (op)
                {
                    case "next":
                        res[idx++] = sol.Next();
                        break;
                    case "hasNext":
                        res[idx++] = sol.HasNext();
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}