using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace GroupAnagrams
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[]", "[[]]"},
            new object[] {"[a]", "[[a]]"},
            new object[] {"[eat,tea,tan,ate,nat,bat]", "[[eat,tea,ate],[tan,nat],[bat]]"},
            new object[] {"[ac,d]", "[[ac],[d]]"},
            new object[] {"[aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa,aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa]", "[[aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa],[aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa]]"},
            new object[] {"[eat,tea,tan,ate,nat,bat,ac,bd,aac,bbd,aacc,bbdd,acc,bdd]", "[[eat,tea,ate],[tan,nat],[bat],[ac],[bd],[aac],[bbd],[aacc],[bbdd],[acc],[bdd]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic2022(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution_2022();
            var res = sol.GroupAnagrams(arr);

            Assert.That(res, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.GroupAnagrams(arr);

            Assert.That(res, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Slow(string arrStr, string expectedStr)
        {
            var arr = ArrayHelper.ArrayFromString<string>(arrStr);
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution_Slow();
            var res = sol.GroupAnagrams(arr);

            Assert.That(res, Is.EquivalentTo(expected));
        }
    }
}