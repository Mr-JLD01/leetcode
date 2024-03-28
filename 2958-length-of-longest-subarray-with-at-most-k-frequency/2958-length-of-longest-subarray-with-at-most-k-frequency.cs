public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        int ans = 0, start = -1;
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        for (int end = 0; end < nums.Length; end++) {
            if(!frequency.TryAdd(nums[end], 1))
                frequency[nums[end]]++;
            while (frequency[nums[end]] > k) {
                start++;
                frequency[nums[start]]--;
            }
            ans = Math.Max(ans, end - start);
        }
        
        return ans;
    }
}