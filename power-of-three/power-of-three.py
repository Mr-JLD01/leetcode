class Solution:
    def isPowerOfThree(self, n: int) -> bool:
        for i in range(n):
            if 3**i > n:
                return False
            if 3**i == n:
                return True
        