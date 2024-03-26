public class Solution {
    public int FirstMissingPositive(int[] nums) {
        bool isOnePresent = false;
        int i;
        
        for(i = 0; i < nums.Length; i++){
            if(nums[i] == 1)
                isOnePresent = true;
            if(nums[i] < 1)
                nums[i] = 1;
        }
        
        if(isOnePresent == false)
            return 1;
        
        for(i = 0; i < nums.Length; i++){            
            if(Math.Abs(nums[i]) > nums.Length)
                continue;

            if(nums[Math.Abs(nums[i])-1] > 0)
                nums[Math.Abs(nums[i])-1] *= -1;
        }
        
        for(i = 0; i < nums.Length; i++){
            if(nums[i] > 0)
                return i+1;
        }

        return nums.Length + 1;
    }
}