class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        copy = nums.copy()
        copy.sort()
        start, end = 0, len(nums)-1
        while end > start:
            if copy[start] + copy[end] == target:
                break
            elif copy[start] + copy[end] > target:
                end -= 1
            else:
                start += 1
        i, j = 0, len(nums)-1
        while nums[i] != copy[start]:
            i += 1
        while nums[j] != copy[end]:
            j -= 1
        return[i, j]