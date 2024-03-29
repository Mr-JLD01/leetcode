public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int maxElement = nums.Max();
        List<int> indexesOfMaxElements = new List<int>();
        long ans = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == maxElement) {
                indexesOfMaxElements.Add(i);
            }

            int freq = indexesOfMaxElements.Count;
            if (freq >= k) {
                ans += indexesOfMaxElements[freq - k] + 1;
            }
        }

        return ans;
    }
}