public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int j = nums.Length - 1;
int i = j;

int[] result = new int[2];
while (j > 0)
{
    i = j - 1;
    while (i >= 0)
    {
        if (nums[i] + nums[j] == target)
        {
            result[0] = i;
            result[1] = j;
        }
            
        i--;
        
    }
    j--;
}
return result;
    }
}