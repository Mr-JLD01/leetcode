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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1.val == 0)
            return l2;
        if(l2.val == 0)
            return l1;
        
        ListNode rev1 = new ListNode(l1.val, null);
        ListNode rev2 = new ListNode(l2.val, null);
        
        l1 = l1.next;
        l2 = l2.next;
        
        ListNode temp = null;
        
        while(l1 != null || l2 != null){
            if(l1 != null){
                temp = rev1;
                rev1 = new ListNode(l1.val, temp);
                l1 = l1.next;
            }
             if(l2 != null){
                temp = rev2;
                rev2 = new ListNode(l2.val, temp);
                l2 = l2.next;
            }
        }
        
        int carryOver = 0;
        int result;
        ListNode returnNode = null;
        
        while(rev1 != null && rev2 != null){
            result = rev1.val + rev2.val + carryOver;
            carryOver = result/10 > 0 ? 1 : 0;
            rev1 = rev1.next;
            rev2 = rev2.next;
            
            temp = returnNode;
            returnNode = new ListNode(result%10, temp);
        }
        
        while(rev1 != null){
            result = rev1.val + carryOver;
            carryOver = result/10 > 0 ? 1 : 0;
            rev1 = rev1.next;
            
            temp = returnNode;
            returnNode = new ListNode(result%10, temp);
        }
        
        while(rev2 != null){
            result = rev2.val + carryOver;
            carryOver = result/10 > 0 ? 1 : 0;
            rev2 = rev2.next;
            
            temp = returnNode;
            returnNode = new ListNode(result%10, temp);
        }
        
        if(carryOver > 0){
            temp = returnNode;
            returnNode = new ListNode(carryOver, temp);
        }
        
        return returnNode;
        
    }
}