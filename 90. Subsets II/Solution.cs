using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SubsetsII
{
    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);

            var hashset = new HashSet<string>();
            hashset.Add("");

            foreach (var num in EncodeArr(nums))
            {
                var toAdd = new List<string>();
                foreach (var el in hashset)
                    toAdd.Add(el + num);

                foreach (var newEl in toAdd)
                    if (!hashset.Contains(newEl))
                        hashset.Add(newEl);
            }

            return hashset.Select(e => DecodeString(e)).ToList();
        }

        private List<char> EncodeArr(int[] nums) => nums.Select(n => (char)('j' + n)).ToList();
        private IList<int> DecodeString(string s) => s.Select(c => c - 'j').ToList();
    }
}