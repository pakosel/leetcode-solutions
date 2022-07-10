using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace SimplifyPath
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"/home/", "/home"},
            new object[] {"/../", "/"},
            new object[] {"/home//foo/", "/home/foo"},
            new object[] {"/a/./b/../../c/", "/c"},
            new object[] {"/foo/.../bar/../../", "/foo"},
            new object[] {"/foo/.../bar/../..", "/foo"},
            new object[] {"/foo/.../bar/../../..", "/"},
            new object[] {"/foo/.../bar/../../../..", "/"},
            new object[] {"/foo..", "/foo.."},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string path, string expected)
        {
            var sol = new Solution();
            var res = sol.SimplifyPath(path);

            Assert.AreEqual(expected, res);
        }
    }
}