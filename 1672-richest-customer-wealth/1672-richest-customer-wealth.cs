public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richest = 0;
        int sum = 0;
        
        foreach(int[] customer in accounts){
            sum = 0;
            foreach(int balance in customer){
                sum += balance;
            }
            if(sum > richest){
                richest = sum;
            }
        }
        
        return richest;
        
    }
}