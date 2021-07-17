class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        mList = self.listMerge(nums1, nums2)
        return float(mList[len(mList)//2]) if len(mList) % 2 != 0 else ((mList[len(mList)//2] + mList[len(mList)//2 - 1]) / 2)
    def listMerge(self, l1, l2):
        merged = []
        i1, i2 = 0, 0
        while i1 != len(l1) and i2 != len(l2):
            if l1[i1] > l2[i2]:
                merged.append(l2[i2])
                i2 += 1
            elif l2[i2] > l1[i1]:
                merged.append(l1[i1])
                i1 += 1
            else:
                merged.append(l1[i1])
                merged.append(l2[i2])
                i1 += 1
                i2 += 1
        if i1 != len(l1):
            for j in range(i1,len(l1)):
                merged.append(l1[j])
        elif i2 != len(l2):
            for j in range(i2,len(l2)):
                merged.append(l2[j])
        return merged