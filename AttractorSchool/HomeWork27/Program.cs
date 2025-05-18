namespace HomeWork27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 4, 9, 2};
            string[] words = { "world", "apple", "hello"};

            var sortedNums = SortReverseArray<int>.Sort(nums);
            var sortedWords = SortReverseArray<string>.Sort(words);
            foreach (var x in sortedNums)
            {
                Console.WriteLine(x);
            }
            foreach (var x in sortedWords)
            {
                Console.WriteLine(x);
            }

            var sortedReversedNums = SortReverseArray<int>.Reverse(sortedNums);
            var sortedReversedWords = SortReverseArray<string>.Reverse(sortedWords);
            foreach (var x in sortedReversedNums)
            {
                Console.WriteLine(x);
            }
            foreach (var x in sortedReversedWords)
            {
                Console.WriteLine(x);
            }
        }
    }
}
