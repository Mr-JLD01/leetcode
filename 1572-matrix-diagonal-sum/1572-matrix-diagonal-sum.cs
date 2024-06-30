public class Solution {
    public int DiagonalSum(int[][] mat) {
        int side = mat.Length;
        
        int sum = side % 2 == 1 ? -mat[side/2][side/2] : 0;
        
        for(int row = 0; row < side; row++){
                sum += mat[row][row];
                sum += mat[side-row-1][row];
        }
        
        return sum;
    }
}