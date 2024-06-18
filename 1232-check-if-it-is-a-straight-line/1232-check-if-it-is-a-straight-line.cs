public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        double prev_slope = Slope(coordinates[0][0], coordinates[1][0], coordinates[0][1], coordinates[1][1]);
        
        for(int i = 1; i < coordinates.Length-1; i++){
            double curr_slope = Slope(coordinates[i][0], coordinates[i+1][0], coordinates[i][1], coordinates[i+1][1]);
            
            if(curr_slope != prev_slope)
                return false;
            
            prev_slope = curr_slope;
        }
        return true;
    }
    
    public double Slope(int x1, int x2, int y1, int y2){
        if(x1 == x2)
            return 10000000.0; // arbitrary large slope in vert line case
        return (double)(y2-y1)/(x2-x1);
    }
}