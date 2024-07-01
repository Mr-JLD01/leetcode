public class Solution {
    public string AddBinary(string a, string b) {
        bool carryOver = false;
        string bin = "";
        
        string smaller = a;
        string larger = b;
        
        if(smaller.Length > b.Length){
            smaller = b;
            larger = a;
        }
        
        for(int i = 0; i < smaller.Length; i++){
            if(a[a.Length-i-1] == '1' && b[b.Length-i-1] == '1'){ 
                if(carryOver){
                    bin = "1" + bin;
                }
                else{ 
                    bin = "0" + bin;
                }
                carryOver = true;
            }
            else if(a[a.Length-i-1] == '1' || b[b.Length-i-1] == '1'){
                if(carryOver){
                    bin = "0" + bin;
                    carryOver = true;
                }
                else{ 
                    bin = "1" + bin;
                    carryOver = false;
                }
            }
            else{
                if(carryOver){
                    bin = "1" + bin;
                }
                else{ 
                    bin = "0" + bin;
                }
                carryOver = false;
            }
        }
        
        for(int i = smaller.Length; i < larger.Length; i++){
            if(larger[larger.Length-i-1] == '1'){
                if(carryOver){
                    bin = "0" + bin;
                    carryOver = true;
                }
                else{ 
                    bin = "1" + bin;
                    carryOver = false;
                }
            }
            else{
                if(carryOver){
                    bin = "1" + bin;
                }
                else{ 
                    bin = "0" + bin;
                }
                carryOver = false;
            }
        }
        
        if(carryOver){
             bin = "1" + bin;
        }
        
        
        return bin;
    }
}