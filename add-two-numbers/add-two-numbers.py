# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        carryOver = False
        sum = ListNode()
        copy = sum
        self.loopTwoItems(carryOver, copy, l1, l2)
        return sum
    def loopTwoItems(self, cO, s: ListNode, node1, node2):
        while node1 is not None or node2 is not None:
            sum = cO + (node1.val if node1 is not None else 0) + (node2.val if node2 is not None else 0)
            s.val = sum % 10
            if sum >= 10:
                cO = True
            else:
                cO = False
            if node1 is not None:
                node1 = node1.next
            if node2 is not None:
                node2 = node2.next
            if node1 is not None or node2 is not None:
                s.next = ListNode()
                s = s.next
        if cO:
            s.next = ListNode(1)