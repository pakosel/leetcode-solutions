using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace PalindromePairs
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[abcd,dcba,lls,s,sssll,llss,,a,aa]", "[[1,0],[0,1],[3,2],[2,4],[5,4],[3,6],[6,3],[7,6],[6,7],[8,6],[6,8],[8,7],[7,8]]"},
            new object[] {"[a,aa]", "[[1,0],[0,1]]"},
            new object[] {"[axzx,a]", "[[0,1]]"},
            new object[] {"[a,axzx]", "[[1,0]]"},
            new object[] {"[atr,rtaxzx]", "[[1,0]]"},
            new object[] {"[abcd,dcba,lls,s,sssll]", "[[1,0],[0,1],[3,2],[2,4]]"},
            new object[] {"[bat,tab,cat]", "[[1,0],[0,1]]"},
            new object[] {"[a,]", "[[1,0],[0,1]]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Stack(string wordsStr, string expectedStr)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            var expected = ArrayHelper.MatrixFromString<int>(expectedStr);

            var sol = new Solution();
            var res = sol.PalindromePairs(words);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}