public class Solution {
    public void MoveZeroes(int[] nums) {
        int numZeroes = 0;
        int temp;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                numZeroes++;
            }
            else if(numZeroes > 0){
                temp = nums[i];
                nums[i] = nums[i-numZeroes];
                nums[i-numZeroes] = temp;
            }
        }
    }
}