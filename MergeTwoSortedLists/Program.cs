using System.Collections;

namespace MergeTwoSortedLists;

public class Program
{
        public static void Main()
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode merged = MergeTwoLists(l1, l2);
        while (merged != null)
        {
            Console.WriteLine(merged.val);
            merged = merged.next;
        }
    }
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode merged = new ListNode();
        ListNode head = merged;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                merged.next = list1;
                list1 = list1.next;
            }
            else
            {
                merged.next = list2;
                list2 = list2.next;
            }
            merged = merged.next;
        }
        if (list1 != null)
        {
            merged.next = list1;
        }
        else
        {
            merged.next = list2;
        }
        return head.next;
    }
}
