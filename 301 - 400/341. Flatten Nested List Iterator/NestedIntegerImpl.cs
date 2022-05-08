using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FlattenNestedListIterator
{
    public class NestedIntegerImpl : NestedInteger
    {
        private List<NestedInteger> _list;
        private bool _isInteger;
        private int _integer;
        public NestedIntegerImpl(int integer)
        {
            _isInteger = true;
            _integer = integer;
        }

        public NestedIntegerImpl(IList<NestedInteger> list)
        {
            _isInteger = false;
            _list = new();
            foreach(var e in list)
                _list.Add(e);
        }

        public NestedIntegerImpl(IList<int> list)
        {
            _isInteger = false;
            _list = new();
            foreach(var e in list)
                _list.Add(new NestedIntegerImpl(e));
        }

        public bool IsInteger() => _isInteger;

        public int GetInteger() => _integer;

        public IList<NestedInteger> GetList() => _list;

        public static IList<NestedInteger> BuildListFromString(string str)
        {
            var pos = 0;
            return BuildListFromString(str, ref pos);
        }
        
        private static IList<NestedInteger> BuildListFromString(string str, ref int pos)
        {
            pos++;    //skip '['
            var list = new List<NestedInteger>();
            var curr = "";
            var end = false;
            while(pos < str.Length && !end)
            {
                switch(str[pos])
                {
                    case ',':
                        list.Add(new NestedIntegerImpl(int.Parse(curr)));
                        curr = "";
                        break;
                    case '[':
                        list.Add(new NestedIntegerImpl(BuildListFromString(str, ref pos)));
                        break;
                    case ']':
                        if(curr != "")
                        {
                            list.Add(new NestedIntegerImpl(int.Parse(curr)));
                            curr = "";
                        }
                        end = true;
                        break;
                    default:
                        curr += str[pos];
                        break;
                }
                pos++;
            }

            return list;
        }
    }
}