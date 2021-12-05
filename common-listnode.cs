using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class ListNodeHelper
    {
        public static ListNode BuildList(string arrStr) => BuildList(ArrayHelper.ArrayFromString(arrStr));
        public static ListNode BuildList(int[] arr)
        {
            ListNode node = null;
            for(int i=arr.Length-1; i>=0; i--)
                node = new ListNode(arr[i], node);
            
            return node;
        }
        
        public static ListNode[] BuildListArray(string arrStr)
        {
            var arr = ArrayHelper.MatrixFromString(arrStr);
            
            var res = new ListNode[arr.Length];
            for(int i=0; i<res.Length; i++)
                res[i] = BuildList(arr[i]);
            
            return res;
        }

        public static bool AreEqual(ListNode list1, ListNode list2)
        {
            while(list1 != null && list2 != null)
            {
                if(list1.val != list2.val)
                    return false;
                list1 = list1.next;
                list2 = list2.next;
            }

            return list1 == null && list2 == null;
        }
        
        public static bool AreEqual(ListNode[] list1, ListNode[] list2)
        {
            if(list1.Length != list2.Length)
                return false;
            for(int i=0; i<list1.Length; i++)
                if(!AreEqual(list1[i], list2[i]))
                    return false;

            return true;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}