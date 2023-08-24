using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace TextJustification
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[This,is,an,example,of,text,justification.]", 16, new string[] {"This    is    an","example  of text","justification.  "}},
            new object[] {"[What,must,be,acknowledgment,shall,be]", 16, new string[] {"What   must   be","acknowledgment  ","shall be        "}},
            new object[] {"[Science,is,what,we,understand,well,enough,to,explain,to,a,computer.,Art,is,everything,else,we,do]", 20, new string[] {"Science  is  what we","understand      well","enough to explain to","a  computer.  Art is","everything  else  we","do                  "}},
            new object[] {"[What]", 16, new string[] {"What            "}},
            new object[] {"[abcd]", 4, new string[] {"abcd"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string wordsStr, int maxWidth, IList<string> expected)
        {
            var words = ArrayHelper.ArrayFromString<string>(wordsStr);

            var sol = new Solution();
            var res = sol.FullJustify(words, maxWidth);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}