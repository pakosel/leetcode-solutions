using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FlattenNestedListIterator
{
    public class NestedIterator
    {
        int Pos;
        private List<int> _list;
        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _list = new();
            Pos = 0;
            Flatten(nestedList, _list);
        }

        private void Flatten(IList<NestedInteger> nestedList, List<int> res)
        {
            foreach (var e in nestedList)
                if (e.IsInteger())
                    res.Add(e.GetInteger());
                else
                    Flatten(e.GetList(), res);
        }

        public bool HasNext() => Pos < _list.Count();

        public int Next() => _list[Pos++];
    }
}