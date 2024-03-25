class Node:
    data: int = -1
    left = None
    right = None
    
    def __init__(self, data: int):
        self.data = data

    def Add(self, n) -> bool:
        if n.data > self.data:
            if self.right is None:
                self.right = n
                return True
            else:
                return self.right.Add(n)
        if n.data < self.data:
            if self.left is None:
                self.left = n
                return True
            else:
                return self.left.Add(n)
        if n.data == self.data:
            return False
        

class Solution:
    def findDuplicates(self, nums: List[int]) -> List[int]:
        return_list = []
        tree = Node(nums.pop())
        
        while len(nums) > 0:
            test_dupe = nums.pop()
            if not tree.Add(Node(test_dupe)):
                return_list.append(test_dupe)
        
        return return_list
    