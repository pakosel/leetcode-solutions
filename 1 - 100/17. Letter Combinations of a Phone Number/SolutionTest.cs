using System;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;

namespace LetterCombinationsPhoneNumber
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"", new string[] {}},
            new object[] {"2", new string[] {"a", "b", "c"}},
            new object[] {"23", new string[] {"ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"}},
            new object[] {"234", new string[] {"adg","adh","adi","aeg","aeh","aei","afg","afh","afi","bdg","bdh","bdi","beg","beh","bei","bfg","bfh","bfi","cdg","cdh","cdi","ceg","ceh","cei","cfg","cfh","cfi"}},
            new object[] {"9752", new string[] {"wpja","wpjb","wpjc","wpka","wpkb","wpkc","wpla","wplb","wplc","wqja","wqjb","wqjc","wqka","wqkb","wqkc","wqla","wqlb","wqlc","wrja","wrjb","wrjc","wrka","wrkb","wrkc","wrla","wrlb","wrlc","wsja","wsjb","wsjc","wska","wskb","wskc","wsla","wslb","wslc","xpja","xpjb","xpjc","xpka","xpkb","xpkc","xpla","xplb","xplc","xqja","xqjb","xqjc","xqka","xqkb","xqkc","xqla","xqlb","xqlc","xrja","xrjb","xrjc","xrka","xrkb","xrkc","xrla","xrlb","xrlc","xsja","xsjb","xsjc","xska","xskb","xskc","xsla","xslb","xslc","ypja","ypjb","ypjc","ypka","ypkb","ypkc","ypla","yplb","yplc","yqja","yqjb","yqjc","yqka","yqkb","yqkc","yqla","yqlb","yqlc","yrja","yrjb","yrjc","yrka","yrkb","yrkc","yrla","yrlb","yrlc","ysja","ysjb","ysjc","yska","yskb","yskc","ysla","yslb","yslc","zpja","zpjb","zpjc","zpka","zpkb","zpkc","zpla","zplb","zplc","zqja","zqjb","zqjc","zqka","zqkb","zqkc","zqla","zqlb","zqlc","zrja","zrjb","zrjc","zrka","zrkb","zrkc","zrla","zrlb","zrlc","zsja","zsjb","zsjc","zska","zskb","zskc","zsla","zslb","zslc"}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string digits, IList<string> expected)
        {
            var sol = new Solution();
            var res = sol.LetterCombinations(digits);

            CollectionAssert.AreEquivalent(res, expected);
        }
    }
}