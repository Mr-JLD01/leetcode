public class Solution {
    public int BinarySearch(int[] nums, int target){
        int left = 0, right = nums.Length - 1;
        int mid = 0;
        
        while (left <= right) {
            mid = left + (right - left) / 2;
            
            if (nums[mid] == target) {
                return mid;
            } 
            else if (nums[mid] < target) {
                left = mid + 1;   
            } 
            else {
                right = mid - 1;
            }
        }
        
        return -1;
    }
    
    public int[] SearchRange(int[] nums, int target) {
        
        if(nums.Length == 0)
            return [-1,-1];
        
        int present = BinarySearch(nums, target);
        
        if(present == -1)
            return [-1,-1];
        
        int left = present;
        int right = present;
        
        while(left > 0 && nums[left-1] == target){
            left--;
        }
        while(right < nums.Length-1 && nums[right+1] == target){
            right++;
        }
        
        return [left, right];
    }
}