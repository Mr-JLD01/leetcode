public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k<=1)
            return 0;
        
        int num_subarrays = 0;
        int product = 1;
        
       for(int l = 0, r = 0; r < nums.Length; r++){
           product *= nums[r];
           
           while(product >= k){
             product /= nums[l++];  
           }
           
           num_subarrays += r - l + 1;
       }
        
        return num_subarrays;
    }
}