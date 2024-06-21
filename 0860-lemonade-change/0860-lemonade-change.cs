public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0;
        int tens = 0;
        
        int changeToGive;
        
        foreach(int bill in bills){
            if(bill == 5)
                fives++;
            else if(bill == 10)
                tens++;
            
            changeToGive = bill - 5;
            
            if(5*fives + 10*tens < changeToGive)
                return false;
            
            while(changeToGive > 0){
                if(changeToGive >= 10){
                    if(tens > 0){
                        changeToGive -= 10;
                        tens--;
                    }
                    else if(fives > 0){
                        changeToGive -= 5;
                        fives--;
                    }
                }
                else if(changeToGive >= 5){
                    if(fives > 0){
                        changeToGive -= 5;
                        fives--;
                    }
                    else
                        return false;
                }
                
            }
        }
        
        return true;
        
    }
}