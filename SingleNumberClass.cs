public class Solution {

    // TC => O(n)
    // SC => O(1)
    public int SingleNumber(int[] nums) {
        int result = 0;

        for(int i = 0; i < nums.Length; i++){
            result ^= nums[i];
        }

        return result;
    }
}