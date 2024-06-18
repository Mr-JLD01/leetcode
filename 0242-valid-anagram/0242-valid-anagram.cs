public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        List<char> s_prime = new List<char>(s);
        List<char> t_prime = new List<char>(t);
        
        s_prime.Sort();
        t_prime.Sort();
        
        
        
        for(int i = 0; i < s_prime.Count; i++){
            if(s_prime[i] != t_prime[i])
                return false;
        }
        return true;
    }
}