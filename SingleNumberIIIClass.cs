public class Solution {
    // TC => O(n)
    // SC => O(1)
    public int[] SingleNumber(int[] nums) {
        if(nums == null || nums.Length == 0){
            return nums;
        }

        int xor = 0;
        foreach(var num in nums){
            xor ^= num;
        }

        // 2's compliment
        int temp = xor & (-xor);

        //2nd xor
        int xor2 = 0;
        foreach(var num in nums){
            if((temp & num) != 0){
                xor2 ^= num;
            }
        }

        return [xor2, xor2 ^ xor];
    }
}