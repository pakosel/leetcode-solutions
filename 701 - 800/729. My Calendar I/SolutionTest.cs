using System;
using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace MyCalendarI
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {"[MyCalendar,book,book,book]", "[[], [10, 20], [15, 25], [20, 30]]", "[null, true, false, true]"},
            new object[] {"[MyCalendar,book,book,book,book,book]", "[[],[10,20],[15,25],[20,30],[11,12],[29,300000]]", "[null,true,false,true,false,false]"},
            new object[] {"[MyCalendar,book,book,book,book,book,book,book,book,book,book]", "[[],[47,50],[33,41],[39,45],[33,42],[25,32],[26,35],[19,25],[3,8],[8,13],[18,27]]", "[null,true,true,false,false,true,false,true,true,true,false]"},
            new object[] {"[MyCalendar,book,book,book,book,book]", "[[],[37,50],[33,50],[4,17],[35,48],[8,25]]", "[null,true,false,true,false,false]"},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string commandsStr, string inputStr, string expectedStr)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var inputs = ArrayHelper.MatrixFromString<int>(inputStr);
            var expected = ArrayHelper.ArrayFromString<bool?>(expectedStr);
            Assert.AreEqual(commands.Length, inputs.Length);
            Assert.AreEqual(commands.Length, expected.Length);
            
            MyCalendar sol = null;
            var res = new bool?[commands.Length];

            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "MyCalendar":
                        sol = new MyCalendar();
                        break;
                    case "book":
                        res[i] = sol.Book(inputs[i][0], inputs[i][1]);
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}