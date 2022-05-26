using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace StreamOfCharacters
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"cd", "f", "kl"}, "[[a], [b], [c], [d], [e], [f], [g], [h], [i], [j], [k], [l]]", new bool[] {false, false, false, true, false, true, false, false, false, false, false, true}},
            new object[] {new string[] {"aa","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"aabaa","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"aabaabaaa","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"abcd","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"abcdabca","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"ab","ba","aaab","abab","baa"}, "[[a],[a],[a],[a],[a],[b],[a],[b],[a],[b],[b],[b],[a],[b],[a],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[b],[a],[a],[a]]", new bool[] {false,false,false,false,false,true,true,true,true,true,false,false,true,true,true,true,false,false,false,true,true,true,true,true,true,false,true,true,true,false}},
            new object[] {new string[] {"aa","baa","baaa","aaa","bbbb"}, "[[b],[b],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[b],[b],[b],[b],[b],[a],[b],[a],[b],[a],[a],[a],[a],[b],[a],[a],[b],[b],[b],[b],[a],[b],[b],[b],[a]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,true,true,false,false,true,false,false,false,true,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,true,true,true,true,false,false,false,false,false,true,true,true,false,false,true,false,false,false,true,false,false,false,false,false}},
            new object[] {new string[] {"aabbaa","baabb","abbaba","baabaabaaa","ababba","bbbbb","bbbabbba","bbbabbb","bbbbabbab","baaaabaaab"}, "[[b],[a],[b],[a],[a],[a],[a],[a],[b],[b],[b],[a],[a],[b],[a],[b],[a],[b],[a],[a],[b],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[a],[b],[b],[a],[a],[b],[b],[a],[b],[b],[a],[a],[a],[b],[b],[b],[a],[b],[a],[a],[b],[b],[b],[a],[b],[b],[a],[a],[b],[a],[b],[a],[b],[a],[b],[b],[a],[a],[b],[b],[a],[b],[a],[a],[b],[a],[a],[a],[a],[b],[a],[b],[b],[b],[a],[a],[b],[a],[a],[b],[a],[b],[a],[b],[a],[a],[b],[a],[b]]", new bool[] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,false,false,false,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,true,false,false,true,false,false,true,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] words, string queryArrStr, bool[] expectedArr)
        {
            var queryArr = ArrayHelper.MatrixFromString<char>(queryArrStr);
            var sol = new StreamChecker(words);
            var res = new bool[queryArr.Length];
            int i=0;
            foreach(var q in queryArr)
                res[i++] = sol.Query(q[0]);

            CollectionAssert.AreEqual(res, expectedArr);
        }
    }
}