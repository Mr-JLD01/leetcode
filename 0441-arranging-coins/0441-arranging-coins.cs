public class Solution {
    public int ArrangeCoins(int n) {
        int row = 1;
        int complete = 0;
        
        while(n >= row){
            n -= row++;
            complete++;
        }
        
        return complete;
    }
}