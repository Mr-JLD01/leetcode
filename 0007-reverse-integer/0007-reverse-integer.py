class Solution:
    def reverse(self, x: int) -> int:
        is_negative = x < 0
        
        num = int(str(abs(x))[::-1])
        
        if (is_negative and num > 2**31) or (num > 2**31):
            return 0
        
        if is_negative:
            return num * -1
        
        return num
        