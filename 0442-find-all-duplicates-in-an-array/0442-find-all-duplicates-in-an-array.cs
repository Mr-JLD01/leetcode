public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        bool[] dupe_list = new bool[nums.Length + 1];
        IList<int> return_list = new List<int>();
        foreach(int e in nums){
            if(dupe_list[e])
                return_list.Add(e);
            else
                dupe_list[e] = true;
        }
        
        return return_list;
    }
}