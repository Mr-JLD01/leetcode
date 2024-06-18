class Solution {
    public char FindTheDifference(string s, string t) {
        List<char> s_prime = new List<char>(s);
        List<char> t_prime = new List<char>(t);
        
        s_prime.Sort();
        t_prime.Sort();
        
        for(int i = 0; i < s_prime.Count; i++){
            if(s_prime[i] != t_prime[i])
                return t_prime[i];
        }
        
        return t_prime[t_prime.Count -1];
    }
}