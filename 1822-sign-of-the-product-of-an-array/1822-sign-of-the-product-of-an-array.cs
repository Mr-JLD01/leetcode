public class Solution {
    public int ArraySign(int[] nums) {
        int numNeg = 0;
        
        foreach(int e in nums){
            if(e == 0)
                return 0;
            if(e < 0)
                numNeg++;
        }
        
        if(numNeg % 2 == 0)
            return 1;
        else
            return -1;
    }
}