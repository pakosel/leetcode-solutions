using System.Text;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Linq;
using System.Collections.Generic;
using Common;

namespace DesignCircularQueue
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCasesStr =
        {
            new object[] {"[MyCircularQueue,enQueue,enQueue,enQueue,enQueue,Rear,isFull,deQueue,enQueue,Rear]", "[[3], [1], [2], [3], [4], [], [], [], [4], []]", new object[] {null, true, true, true, false, 3, true, true, true, 4}},
        };

        [Test]
        [TestCaseSource("testCasesStr")]
        public void Test_Generic(string commandsStr, string inputsStr, object[] expected)
        {
            var commands = ArrayHelper.ArrayFromString<string>(commandsStr);
            var inputs = ArrayHelper.MatrixFromString<int>(inputsStr);
            Assert.That(commands.Length == inputs.Length);
            Assert.That(commands.Length == expected.Length);
            
            var res = new object[commands.Length];
            MyCircularQueue sol = null;
            for(int i=0; i<commands.Length; i++)
                switch(commands[i])
                {
                    case "MyCircularQueue":
                        sol = new MyCircularQueue(inputs[0][0]);
                        continue;
                    case "enQueue":
                        res[i] = sol.EnQueue(inputs[i][0]);
                        break;
                    case "deQueue":
                        res[i] = sol.DeQueue();
                        break;
                    case "Front":
                        res[i] = sol.Front();
                        break;
                    case "Rear":
                        res[i] = sol.Rear();
                        break;
                    case "isFull":
                        res[i] = sol.IsFull();
                        break;
                    case "isEmpty":
                        res[i] = sol.IsEmpty();
                        break;
                }

            CollectionAssert.AreEqual(expected, res);
        }
    }
}