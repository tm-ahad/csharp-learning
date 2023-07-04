
class TwoSum
{
    static Tuple<int, int>? solution(int[] nums, int target)
    {
        int len = nums.Length;

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return Tuple.Create(i, j);
                }
            }
        }

        return null;
    }

    static void Main(string[] args)
    {
        int[] arr = { 2, 7, 11, 15 };
        var res = solution(arr, 9);

        Console.WriteLine(res);
    }
}