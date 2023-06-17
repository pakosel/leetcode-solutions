using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SnapshotArray
{
    public class SnapshotArray
    {
        Dictionary<int, int>[] arr;
        int snap;
        public SnapshotArray(int length)
        {
            arr = new Dictionary<int, int>[length];
            snap = 0;
        }

        public void Set(int index, int val)
        {
            if (arr[index] == null)
                arr[index] = new Dictionary<int, int>();
            arr[index][snap] = val;
        }

        public int Snap()
        {
            return snap++;
        }

        public int Get(int index, int snap_id)
        {
            if (index >= arr.Length || arr[index] == null)
                return 0;
            while (snap_id > 0 && !arr[index].ContainsKey(snap_id))
                snap_id--;
            return arr[index].ContainsKey(snap_id) ? arr[index][snap_id] : 0;
        }
    }
}