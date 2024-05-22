/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
   public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{

    ListNode result = new ListNode();
ListNode current = result;
int carry = 0;
int sum;
while (l1 != null || l2 != null || carry != 0)
{
    if (l1 == null)
    {
        l1 = new ListNode(0);
    }

    if (l2 == null)
    {
        l2 = new ListNode(0);
    }

    sum = l1.val + l2.val + carry;
    current.next = new ListNode(sum % 10);
    l1 = l1.next;
    l2 = l2.next;
    current = current.next;
    carry = sum / 10;
    
}

return result.next;
}


}