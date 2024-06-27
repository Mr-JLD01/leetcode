public class Solution {
    public bool JudgeCircle(string moves) {
        int vert = 0;
        int horiz = 0;
        
        foreach(char dir in moves){
            switch(dir){
                case 'U':
                    vert++;
                    break;
                case 'D':
                    vert--;
                    break;
                case 'R':
                    horiz++;
                    break;
                case 'L':
                    horiz--;
                    break;
            }
        }
        
        return vert == 0 && horiz == 0;
        
    }
}