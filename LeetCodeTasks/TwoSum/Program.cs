namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArr = new int[] { 2, 8, 6, 1, 4 };
            int target = 12;
            TwoSum(myArr, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = [];
            int elementsSum = default;
            bool process = true;

            for (int i = 0; i < nums.Length; i++)
            {
                if (process)
                {
                    for (int j = 1; j <= nums.Length - 1; j++)
                    {
                        if (i != j)
                        {
                            elementsSum = nums[i] + nums[j];
                        }
                        else if (i == nums.Length - 1 && j == nums.Length - 1)
                        {
                            Console.WriteLine("Array processing is completed.\nNo elements in the array add up to the target number.");
                        }
                        else
                            continue;

                        if (elementsSum == target)
                        {
                            result = [nums[i], nums[j]];
                            Console.WriteLine($"[{i}, {j}]");
                            process = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}