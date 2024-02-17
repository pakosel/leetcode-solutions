using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignFrontMiddleBackQueue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] { new string []{"FrontMiddleBackQueue","popFront","popMiddle","popBack"}, "[[0],[],[],[]]", new int?[] {null,-1,-1,-1}},
            new object[] { new string []{"FrontMiddleBackQueue","pushMiddle","pushMiddle","popFront","popMiddle"}, "[[0],[1],[2],[],[]]", new int?[] {null,null,null,1,2}},
            new object[] { new string []{"FrontMiddleBackQueue","pushMiddle","pushMiddle","popMiddle","popMiddle"}, "[[0],[1],[2],[],[]]", new int?[] {null,null,null,1,2}},
            new object[] { new string []{"FrontMiddleBackQueue","pushFront","pushBack","pushMiddle","pushMiddle","popFront","popMiddle","popMiddle","popBack","popFront"}, "[[0],[1],[2],[3],[4],[],[],[],[],[]]", new int?[] {null,null,null,null,null,1,3,4,2,-1}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_GenericStr(string[] commands, string argsStr, int?[] expected)
        {
            var argsMatrix = ArrayHelper.MatrixFromString<int>(argsStr);
            // System.Console.WriteLine(argsMatrix.Length);

            var sol = new FrontMiddleBackQueue();
            int?[] res = new int?[argsMatrix.Length];
            for(int i=0; i<commands.Length; i++)
            {
                int? arg = null;
                if(argsMatrix[i].Length > 0)
                    arg = argsMatrix[i][0];
                
                res[i] = ExecuteOperation(commands[i], sol, arg);
            }

            CollectionAssert.AreEquivalent(res, expected);
        }

        private int? ExecuteOperation(string operation, FrontMiddleBackQueue queue, int? arg)
        {
            int? res = null;
            switch(operation)
            {
                case "FrontMiddleBackQueue":
                    break;
                case "pushFront":
                    queue.PushFront((int)arg);
                    break;
                case "pushBack":
                    queue.PushBack((int)arg);
                    break;
                case "pushMiddle":
                    queue.PushMiddle((int)arg);
                    break;
                case "popFront":
                    res = queue.PopFront();
                    break;
                case "popMiddle":
                    res = queue.PopMiddle();
                    break;
                case "popBack":
                    res = queue.PopBack();
                    break;
            }

            return res;
        }
    }
}