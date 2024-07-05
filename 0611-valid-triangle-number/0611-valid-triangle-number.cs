public class Solution {
    public int BinarySearch(int[] nums, int l, int r, int x) {
        while (r >= l && r < nums.Length) {
            int mid = (l + r) / 2;
            if (nums[mid] >= x)
                r = mid - 1;
            else
                l = mid + 1;
        }
        return l;
    }
    public int TriangleNumber(int[] nums) {
        int count = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            int k = i + 2;
            for (int j = i + 1; j < nums.Length - 1 && nums[i] != 0; j++) {
                k = BinarySearch(nums, k, nums.Length - 1, nums[i] + nums[j]);
                count += k - j - 1;
            }
        }
        return count;
    }
}