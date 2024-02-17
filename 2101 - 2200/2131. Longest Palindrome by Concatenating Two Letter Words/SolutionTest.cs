using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace LongestPalindromeByConcatenatingTwoLetterWords
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[lc,cl,gg]", 6},
            new object[] {"[ab,ty,yt,lc,cl,ab]", 8},
            new object[] {"[cc,ll,xx]", 2},
            new object[] {"[aa,dd,dd,aa,dd]", 10},
            new object[] {"[aa,dd,dd,aa]", 8},
            new object[] {"[dd,aa,bb,dd,aa,dd,bb,dd,aa,cc,bb,cc,dd,cc]", 22},
            new object[] {"[ab,ty,yt,lc,cl,ab,bc,bc]", 8},
            new object[] {"[ll,lb,bb,bx,xx,lx,xx,lx,ll,xb,bx,lb,bb,lb,bl,bb,bx,xl,lb,xx]", 26},
            new object[] {"[ll,ll,bb,bb,bb]", 10},
            new object[] {"[ll,ll,bb]", 6},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2022(string wordsStr, int expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution2022();
            var res = sol.LongestPalindrome(words);

            Assert.That(expected == res);
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string wordsStr, int expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);
            
            var sol = new Solution();
            var res = sol.LongestPalindrome(words);

            Assert.That(expected == res);
        }
    }
}