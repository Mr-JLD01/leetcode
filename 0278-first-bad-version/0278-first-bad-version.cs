/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 0;
        int high = n;

        while(low<=high){
            int mid = low + (high-low)/2;
            if(IsBadVersion(mid) == true && IsBadVersion(mid-1) == false)   
                return mid;
            else if(IsBadVersion(mid) == false ) 
                low = mid+1;
            else 
                high = mid;
        }     
        return -1;
    }
}