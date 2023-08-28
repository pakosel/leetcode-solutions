using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace ImplementStackUsingQueues
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"push", "push", "top", "pop", "empty"}, new int?[] {1,2,null,null,null}, new object[] {null,null,2,2,false} },
            new object[] {new string[] {"push", "push", "push", "push", "push", "pop", "pop", "pop", "pop", "pop"}, new int?[] {1,2,3,4,5,null,null,null,null,null}, new object[] {null,null,null,null,null,5,4,3,2,1} },
            new object[] {new string[] {"push","push","pop","top"}, new int?[] {1,2,null,null}, new object[] {null,null,2,1} },
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_2023(string[] instructions, int?[] inputs, object[] expected)
        {
            Assert.AreEqual(instructions.Length, inputs.Length);
            Assert.AreEqual(expected.Length, inputs.Length);

            var sol = new MyStack_2023();
            for(int i=0; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "push":
                        sol.Push((int)inputs[i]);
                        break;
                    case "pop":
                        Assert.AreEqual(sol.Pop(), expected[i]);
                        break;
                    case "top":
                        Assert.AreEqual(sol.Top(), expected[i]);
                        break;
                    case "empty":
                        Assert.AreEqual(sol.Empty(), expected[i]);
                        break;
                }
            }
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_v0(string[] instructions, int?[] inputs, object[] expected)
        {
            Assert.AreEqual(instructions.Length, inputs.Length);
            Assert.AreEqual(expected.Length, inputs.Length);

            var sol = new MyStack_v0();
            for(int i=0; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "push":
                        sol.Push((int)inputs[i]);
                        break;
                    case "pop":
                        Assert.AreEqual(sol.Pop(), expected[i]);
                        break;
                    case "top":
                        Assert.AreEqual(sol.Top(), expected[i]);
                        break;
                    case "empty":
                        Assert.AreEqual(sol.Empty(), expected[i]);
                        break;
                }
            }
        }

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic_v1(string[] instructions, int?[] inputs, object[] expected)
        {
            Assert.AreEqual(instructions.Length, inputs.Length);
            Assert.AreEqual(expected.Length, inputs.Length);

            var sol = new MyStack_v1();
            for(int i=0; i<instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case "push":
                        sol.Push((int)inputs[i]);
                        break;
                    case "pop":
                        Assert.AreEqual(sol.Pop(), expected[i]);
                        break;
                    case "top":
                        Assert.AreEqual(sol.Top(), expected[i]);
                        break;
                    case "empty":
                        Assert.AreEqual(sol.Empty(), expected[i]);
                        break;
                }
            }
        }
    }
}