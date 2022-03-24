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
            var first = 0;
            var last = people.Length - 1;

            var res = 0;
            while (first <= last)
            {
                if (people[last] + people[first] <= limit)
                    first++;
                last--;
                res++;
            }
            return res;
        }
    }
}