public class Solution {
    public int RomanToInt(string s) {
        int conversion = 0;
        
        for(int i = 0; i < s.Length; i++){
            switch(s[i]){
                case 'I':
                    if(i != s.Length-1 && (s[i+1] == 'V' || s[i+1] == 'X')){
                        if(s[i+1] == 'V')
                            conversion += 4;
                        else
                            conversion += 9;
                        i++;
                    }
                    else
                        conversion += 1;
                    break;
                case 'V':
                    conversion += 5;
                    break;
                case 'X':
                    if(i != s.Length-1 && (s[i+1] == 'L' || s[i+1] == 'C')){
                        if(s[i+1] == 'L')
                            conversion += 40;
                        else
                            conversion += 90;
                        i++;
                    }
                    else
                        conversion += 10;
                    break;
                case 'L':
                    conversion += 50;
                    break;
                case 'C':
                    if(i != s.Length-1 && (s[i+1] == 'D' || s[i+1] == 'M')){
                        if(s[i+1] == 'D')
                            conversion += 400;
                        else
                            conversion += 900;
                        i++;
                    }
                    else
                        conversion += 100;
                    break;
                case 'D':
                    conversion += 500;
                    break;
                case 'M':
                    conversion += 1000;
                    break;
            }
        }
        
        return conversion;
        
    }
}