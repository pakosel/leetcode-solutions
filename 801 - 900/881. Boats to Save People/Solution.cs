using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BoatsToSavePeople
{
    public class Solution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int left = 0, right = people.Length - 1, res = 0;
            while (left <= right)
            {
                if (people[left] + people[right--] <= limit)
                    left++;
                res++;
            }
            return res;
        }
    }
}