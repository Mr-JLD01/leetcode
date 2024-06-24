public class Solution {
    public int[] PlusOne(int[] digits) {
        bool allNines = true;
        int[] plusOne;
        
        foreach(int digit in digits){
            if(digit != 9){
                allNines = false;
                break;
            }
        }
        
        if(allNines){
            plusOne = new int[digits.Length + 1];
            plusOne[0] = 1;
            return plusOne;
        }
        else{
            plusOne = new int[digits.Length];
            bool carryOver = false;
            
            for(int i = digits.Length - 1; i >= 0; i--){
                int result = carryOver || i == digits.Length - 1 ? digits[i] + 1 : digits[i];
                if(result > 9){
                    carryOver = true;
                }
                else{
                    carryOver = false;
                }
                plusOne[i] = result % 10;
            }
        }
        
        return plusOne;
    }
}