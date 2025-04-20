public class Solution {
    // TC => O(log n)
    // SC => O(1)
    public int Divide(int dividend, int divisor) {
        if(dividend != 0 && divisor == 0)
        {
            return Int32.MaxValue;
        }

        if(dividend == Int32.MinValue && divisor == 1){
            return Int32.MinValue;
        }

        if(dividend == Int32.MinValue && divisor == -1){
            return Int32.MaxValue;
        }

        long lDividend = Math.Abs((long)dividend);
        long lDivisor = Math.Abs((long)divisor);
        long result = 0;
        while(lDividend >= lDivisor){
            int shifts  = 0;
            while((lDivisor << shifts) <= lDividend){
                shifts++;
            }
            shifts--;
            result = result + (1 << shifts);
            lDividend = lDividend - (lDivisor << shifts);
        }

        if(dividend < 0 && divisor > 0) return -(int)result;
        if(dividend > 0 && divisor < 0) return -(int)result;

        return (int)result;
    }
}