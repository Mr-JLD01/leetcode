/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int low = 1;
        int high = n;

        while(low<=high){
            int mid = low + (high-low)/2;
            int g = guess(mid);
            Console.WriteLine(mid + ";" + g);
            if(g == 0)  
                return mid;
            else if(g == 1) 
                low = mid+1;
            else 
                high = mid-1;
        }     
        return 1;
    }
}