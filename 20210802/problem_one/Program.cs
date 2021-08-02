using System;

namespace problem_one
{
    class Program
    {
        static int LongestCommonSubsequences(string shorter, string longer)
        {
            for(int i = 0; i < shorter.Length; i++)
            {
                for(int j = shorter.Length; j > i; j--)
                {
                    string subStr = shorter.Substring(i, j);
                    if(longer.Contains(subStr))
                        return j - i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string first, second;
            int length;
            Console.Write("Enter first string: ");
            first = Console.ReadLine();
            Console.Write("Enter second string: ");
            second = Console.ReadLine();
            if(first.Length > second.Length)
                length = LongestCommonSubsequences(second, first);
            else
                length = LongestCommonSubsequences(first, second);
            if(length == -1)
                Console.WriteLine("Could not find any matching subsequences.");
            else
                Console.WriteLine($"The length of the longest common subsequence is {length}");
        }
    }
}
