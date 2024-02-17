using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Dict = System.Collections.Generic.Dictionary<string, object>;

namespace FlattenDictionary
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            //testcase #1
            new object[] {
                new Dict() { { "Key1", "1" },
                             { "Key2", new Dict() {
                                        { "a", "2" },
                                        { "b", "3" },
                                        { "c", new Dict() {
                                                { "d", "3" },
                                                { "e", "1" } } } } }
                            },
                new Dictionary<string, string>() {{"Key1","1"},{"Key2.a","2"},{"Key2.b","3"},{"Key2.c.d","3"},{"Key2.c.e","1"}}
            },
            //testcase #2
            new object[] {
                new Dict() { {"Key", new Dict() { {"a","2"}, {"b","3"} }} },
                new Dictionary<string, string>() {{"Key.a","2"},{"Key.b","3"}}
            },
            //testcase #3
            new object[] {
                new Dict() { { "Key1", "1" },
                             { "Key2", new Dict() {
                                        { "a", "2" },
                                        { "b", "3" },
                                        { "c", new Dict() {
                                                { "d", "3" },
                                                { "e", new Dict() { {"f","4"} } } } } } }
                            },
                new Dictionary<string, string>() {{"Key1","1"},{"Key2.a","2"},{"Key2.b","3"},{"Key2.c.d","3"},{"Key2.c.e.f","4"}}
            },
            //testcase #4
            new object[] {
                new Dict() {{"", new Dict() {{"a","1"}}},
                            {"b","3"}},
                new Dictionary<string, string>() {{"a","1"},{"b","3"}}
            },
            //testcase #5
            new object[] {
                new Dict() {{"a", new Dict() {{"b", new Dict() {{"c", new Dict() {{"d", new Dict() {{"e", new Dict() {{"f", new Dict() {{"","awesome"}}}}}}}}}}}}}},
                new Dictionary<string, string>() {{"a.b.c.d.e.f","awesome"}}
            },
            //testcase #6
            new object[] {
                new Dict() {{"a","1"}},
                new Dictionary<string, string> {{"a","1"}}
            },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Example(Dictionary<string, object> dict, Dictionary<string, string> expected)
        {
            var res = Solution.FlattenDictionary(dict);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}