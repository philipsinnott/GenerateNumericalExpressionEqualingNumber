using System;

namespace GenerateNumberFromRandomOperations // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int[] setOfRandomNums = GenerateSetOfRandomNumbers(10);
            //Console.WriteLine(setOfRandomNums[4]);
            foreach (int i in setOfRandomNums)
                Console.WriteLine(i);
        }

        /// Generate a specific number from a set of random numbers and a set of random operations ///
        /// Example 1 | Input: 3 + 2 * 2 - 6 | Output: 1
        /// Example 2 | Input: 7 - 9 * 6 - 3 | Output: -50
        /// Example 3 | Input: 9 - 0 + 0 * 5 | Output: 9
        /// 

        static int[] GenerateSetOfRandomNumbers(int amount)
        {
            int[] setRandomNums = new int[amount];
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                setRandomNums[i] = random.Next(0, 10);
            }
            return setRandomNums;
        }
    }
}