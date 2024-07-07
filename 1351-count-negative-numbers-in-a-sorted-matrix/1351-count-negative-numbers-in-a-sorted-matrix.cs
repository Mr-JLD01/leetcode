public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        int mid = 0;
        
        while (left <= right) {
            mid = left + (right - left) / 2;
            
            if (nums[mid] == target) {
                return mid;
            } 
            else if (nums[mid] > target) {
                left = mid + 1;   
            } 
            else {
                right = mid - 1;
            }
        }
        
        if(nums[mid] < target){
            return mid;
        }
        else{
            return mid + 1;
        }
    }
    
    public int CountNegatives(int[][] grid) {
        int numNeg = 0;
        
        foreach(int[] arr in grid){
            int findZero = SearchInsert(arr, 0);
            
            Console.WriteLine(findZero);
            while(findZero < arr.Length-1 && !(arr[findZero]<0)){
                findZero++;
            }
            
            if( findZero < arr.Length && arr[findZero] < 0){
                numNeg += arr.Length - findZero;
            }
        }
        
        
        return numNeg;
    }
}