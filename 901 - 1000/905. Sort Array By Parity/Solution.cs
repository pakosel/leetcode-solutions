using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortArrayByParity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var odd = new List<int>();
            var even = new List<int>();
            foreach (var n in nums)
                if (n % 2 == 0)
                    even.Add(n);
                else
                    odd.Add(n);
            even.AddRange(odd);
            return even.ToArray();
        }
    }

    public class Solution_Linq
    {
        public int[] SortArrayByParity(int[] nums)
            => nums.Where(n => n % 2 == 0).Concat(nums.Where(n => n % 2 != 0)).ToArray();
    }

    public class Solution_InPlace
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var lst = nums.ToList();
            var ins = 0;
            var i = 0;
            while (i < lst.Count())
            {
                if (lst[i] % 2 == 0)
                {
                    lst.Insert(ins++, lst[i++]);
                    lst.RemoveAt(i);
                }
                else
                    i++;
            }
            return lst.ToArray();
        }
    }

    public class Solution_2pass
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var res = new int[nums.Length];
            var ins = 0;
            foreach (var n in nums)
                if (n % 2 == 0)
                    res[ins++] = n;
            foreach (var n in nums)
                if (n % 2 != 0)
                    res[ins++] = n;

            return res;
        }
    }
}