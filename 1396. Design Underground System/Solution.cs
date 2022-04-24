using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignUndergroundSystem
{
    public class UndergroundSystem
    {

        private Dictionary<string, Dictionary<string, (double sumTime, int cnt)>> Dict = new();
        private Dictionary<int, (string st, int t)> Curr = new();

        public UndergroundSystem()
        {
        }

        public void CheckIn(int id, string stationName, int t)
        {
            Curr.Add(id, (stationName, t));
        }

        public void CheckOut(int id, string stationName, int t)
        {
            var start = Curr[id];
            Curr.Remove(id);
            if (!Dict.ContainsKey(start.st))
                Dict.Add(start.st, new Dictionary<string, (double, int)>());
            if (!Dict[start.st].ContainsKey(stationName))
                Dict[start.st].Add(stationName, (0, 0));
            var tuple = Dict[start.st][stationName];
            tuple.sumTime += (t - start.t);
            tuple.cnt++;
            Dict[start.st][stationName] = tuple;
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var tuple = Dict[startStation][endStation];
            return tuple.sumTime / tuple.cnt;
        }
    }
}