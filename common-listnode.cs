using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Common
{
    public class ListNodeHelper
    {
        public static ListNode BuildList(string arrStr)
        {
            var arr = ArrayHelper.ArrayFromString(arrStr);
            
            ListNode node = null;
            for(int i=arr.Length-1; i>=0; i--)
                node = new ListNode(arr[i], node);
            
            return node;
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