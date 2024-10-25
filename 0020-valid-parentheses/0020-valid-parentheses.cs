public class Solution {
    public bool IsValid(string s) {
        Stack openParentheses = new Stack();
        
        foreach(char p in s){
            if(p == '{' || p == '[' || p == '(')
                openParentheses.Push(p);
            else{
                if(openParentheses.Count == 0)
                    return false;
                
                char openP = (char)openParentheses.Pop();
                
                if(p == '}' && openP != '{')
                    return false;
                if(p == ']' && openP != '[')
                    return false;
                if(p == ')' && openP != '(')
                    return false;
            }
        }
        return openParentheses.Count == 0;
    }
}