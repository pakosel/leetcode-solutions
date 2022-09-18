using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountDaysSpentTogether
{
    public class Solution
    {
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            var dates = new (DateTime arr, DateTime leave)[2];  //[[arr1, leave1], [arr2, leave2]]

            dates[0] = (new DateTime(2022, int.Parse(arriveAlice.Split('-')[0]), int.Parse(arriveAlice.Split('-')[1])),
                       new DateTime(2022, int.Parse(leaveAlice.Split('-')[0]), int.Parse(leaveAlice.Split('-')[1])));
            dates[1] = (new DateTime(2022, int.Parse(arriveBob.Split('-')[0]), int.Parse(arriveBob.Split('-')[1])),
                       new DateTime(2022, int.Parse(leaveBob.Split('-')[0]), int.Parse(leaveBob.Split('-')[1])));
            Array.Sort(dates, (d1, d2) => d1.arr.CompareTo(d2.arr));

            var minLeave = dates[0].leave < dates[1].leave ? dates[0].leave : dates[1].leave;
            var days = (minLeave - dates[1].arr).Days + 1;
            return days > 0 ? days : 0;
        }
    }
}