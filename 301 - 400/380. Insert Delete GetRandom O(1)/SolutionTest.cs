using System.Text;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace InsertDeleteGetRandom
{
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] testCases =
        {
            new object[] {new string[] {"insert","insert","insert","getRandom","remove","getRandom"}, new int?[] {1,1,2,null,1,null}, new object[] {true,false,true,1,true,2}},
            new object[] {new string[] {"insert","remove","insert","getRandom"}, new int?[] {1,2,2,null}, new object[] {true,false,true,1}},
            new object[] {new string[] {"insert","remove","insert","getRandom","remove","insert","getRandom"}, new int?[] {1,2,2,null,1,2,null}, new object[] {true,false,true,1,true,false,2}},
            new object[] {new string[] {"insert","insert","getRandom","getRandom","insert","remove","getRandom","getRandom","insert","remove"}, new int?[] {3,3,null,null,1,3,null,null,0,0}, new object[] {true,false,3,3,true,true,1,1,true,true}},
            new object[] {new string[] {"insert","remove","insert","remove","getRandom","getRandom","getRandom","getRandom","getRandom","getRandom","getRandom","getRandom","getRandom","getRandom"}, new int?[] {0,0,-1,0,null,null,null,null,null,null,null,null,null,null}, new object[] {true,true,true,false,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}},
            new object[] {new string[] {"insert","insert","remove","insert","remove","getRandom"}, new int?[] {0,1,0,2,1,null}, new object[] {true,true,true,true,true,2}},
            new object[] {new string[] {"insert","remove","insert","insert","getRandom","remove","insert","getRandom"}, new int?[] {1,2,2,2,null,1,2,null}, new object[] {true,false,true,false,2,true,false,2}},
            new object[] {new string[] {"insert","remove","insert","getRandom","remove","insert","getRandom"}, new int?[] {1,2,2,null,1,2,null}, new object[] {true,false,true,2,true,false,2}},
        };

        [Test]
        [TestCaseSource("testCases")]
        public void Test_Generic(string[] operations, int?[] inputs, object[] expected)
        {
            var set = new RandomizedSet();
            var ret = true;
            var retI = 0;

            for(int i=0; i<operations.Length; i++)
                switch(operations[i])
                {
                    case "insert":
                        ret = set.Insert((int)inputs[i]);
                        Assert.That(ret == (bool)expected[i]);
                        break;
                    case "remove":
                        ret = set.Remove((int)inputs[i]);
                        Assert.That(ret == (bool)expected[i]);
                        break;
                    case "getRandom":
                        retI = set.GetRandom();
                        // Assert.That(retI == retI);
                        break;
                }
        }
    }
}