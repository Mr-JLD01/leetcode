public class Solution {
    public int LargestPerimeter(int[] nums) {
        List<int> sides = new List<int>(nums);
        sides.Sort();
        
        int x,y,z;
        
        for(int i = sides.Count-1; i > 1; i--){
            x = sides[i];
            y = sides[i-1];
            z = sides[i-2];
            if(IsTriangle(x,y,z))
                return x+y+z;
        }
        return 0;
    }
    
    public bool IsTriangle(int x, int y, int z){
        return x + y > z && x + z > y && y + z > x;
    }
}