public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        HashSet<int> set = new HashSet<int>();
        foreach(int x in arr) {
            set.Add(x);
        }
        int count = 0;
        int i = 1;
        while (true) {
            if (!set.Contains(i)) {
                count++;
            }
            if (count == k) {
                return i;
            }
            i++;
        }
    }
}