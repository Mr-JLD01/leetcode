public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = word1.Length;
        int j = word2.Length;
        
        
        
        string returnString = "";
        for(int counter = 0; counter < i || counter < j; counter++){
            if(counter < i)
                returnString += word1[counter];
            if(counter < j)
                returnString += word2[counter];
        }
        
        return returnString;
    }
}