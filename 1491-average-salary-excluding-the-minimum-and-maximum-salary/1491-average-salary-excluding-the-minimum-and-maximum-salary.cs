public class Solution {
    public double Average(int[] salary) {
        int min = salary[0];
        int max = salary[0];
        
        int sum = 0;
        
        for(int i = 1; i < salary.Length; i++){
            if(salary[i] < min){
                sum += min;
                min = salary[i];
            }
            else if(salary[i] > max){
                sum += max;
                max = salary[i];
            }
            else{
                sum += salary[i];
            }
        }   
    
        return (double)(sum - salary[0]) / (salary.Length - 2);
    }
}