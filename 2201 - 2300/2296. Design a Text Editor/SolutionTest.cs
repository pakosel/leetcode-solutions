using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignTextEditor
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {new string[] {"addText", "deleteText", "addText", "cursorRight", "cursorLeft", "deleteText", "cursorLeft", "cursorRight"}, "[[leetcode], [4], [practice], [3], [8], [10], [2], [6]]", new object[] {null, 4, null, "etpractice", "leet", 4, "", "practi"}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string[] commands, string argsStr, object[] expected)
        {
            var args = ArrayHelper.MatrixFromString<object>(argsStr, true);
            Assert.That(commands.Length == args.Length);
            Assert.That(commands.Length == expected.Length);
            var res = new object[commands.Length];

            var sol = new TextEditor();
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "addText":
                        sol.AddText((string)(args[i][0]));
                        res[i] = null;
                        break;
                    case "deleteText":
                        res[i] = sol.DeleteText(int.Parse((string)(args[i][0])));
                        break;
                    case "cursorLeft":
                        res[i] = sol.CursorLeft(int.Parse((string)(args[i][0])));
                        break;
                    case "cursorRight":
                        res[i] = sol.CursorRight(int.Parse((string)(args[i][0])));
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}