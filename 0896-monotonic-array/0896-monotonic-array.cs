public class Solution {
    public bool IsMonotonic(int[] nums) {
        
        if(nums.Length < 2)
            return true;
        
        int i = 0;
        bool isIncreasing;
        
        do{
            isIncreasing = nums[i+1] > nums[i] ? true : false;
        }while(i < nums.Length -2 && nums[i+1] == nums[i++]);
        
        for(; i < nums.Length - 1; i++){
            if((isIncreasing && nums[i+1] < nums[i]) || (!isIncreasing && nums[i+1] > nums[i]))
                return false;
        }
        
        return true;
    }
}