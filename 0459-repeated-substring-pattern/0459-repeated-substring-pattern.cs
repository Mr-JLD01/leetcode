public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int subSize = 1;
        while(subSize <= s.Length / 2){
            if(s.Length % subSize != 0){
                subSize++;
                continue;
            }
            
            bool repeated = true;
            string pattern = s.Substring(0, subSize);
            
            for(int i = subSize; i < s.Length - subSize+1; i += subSize){
                if(!s.Substring(i, subSize).Equals(pattern)){
                    repeated = false;
                    break;
                }
            }
            
            if(repeated){
                return true;
            }
            
            subSize++;
            
        }
        return false;
    }
}