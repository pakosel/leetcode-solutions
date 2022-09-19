using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace FindDuplicateFileInSystem
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[root/a 1.txt(abcd) 2.txt(efgh),root/c 3.txt(abcd),root/c/d 4.txt(efgh),root 4.txt(efgh)]", "[[root/a/1.txt,root/c/3.txt],[root/a/2.txt,root/c/d/4.txt,root/4.txt]]"},
            new object[] {"[root/a 1.txt(abcd) 2.txt(efgh),root/c 3.txt(abcd),root/c/d 4.txt(efgh)]", "[[root/a/1.txt,root/c/3.txt],[root/a/2.txt,root/c/d/4.txt]]"},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string pathsStr, string expectedStr)
        {
            var paths = ArrayHelper.ArrayFromString<string>(pathsStr);
            var expected = ArrayHelper.MatrixFromString<string>(expectedStr);

            var sol = new Solution();
            var res = sol.FindDuplicate(paths);

            CollectionAssert.AreEquivalent(expected, res);
        }
    }
}